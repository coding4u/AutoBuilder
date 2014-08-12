using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Utility;

namespace AutoCompileService
{
    public class Compile
    {
        private CodeDomProvider provider;
        private string outputFolder;

        public Compile(string outputFolder)
        {
            this.outputFolder = outputFolder;
        }

        public void CompileExecutable(string csPath, string dllPath,string outFileName,string outFilePath)
        { 
            
            //var uid = csPath.GetHashCode() ^ dllPath.GetHashCode();

            List<string> csFiles = new FileHelper(csPath, "*.cs").GetAllFiles();
            List<string> csFileNames = new FileHelper(csPath, "*.cs").GetAllFileNames();
            List<string> dllFiles = new FileHelper(dllPath, "*.dll").GetAllFiles();


            provider = CodeDomProvider.CreateProvider("CSharp");
            if (provider != null)
            {
                CompilerParameters cp =
                    new CompilerParameters()
                {
                    CompilerOptions="/optimize",
                    GenerateExecutable = false,
                    GenerateInMemory = true,
                    IncludeDebugInformation = false,
                    TreatWarningsAsErrors = false,
                    OutputAssembly=Path.Combine(outFilePath,outFileName),                    
                    WarningLevel = 4
                };

                var prefix = outFileName.Remove(outFileName.IndexOf('.'), 1);

                var resName = "CSNames";

                string xmlResource =Path.Combine(Logger.ServiceLogPath,prefix+resName);

                SerializeHelper.SerializeToXML
                    (
                        Logger.ServiceLogPath,
                        new CSFiles(){CSFileNames= csFileNames},
                        prefix+resName,
                        false
                    );

                if (File.Exists(xmlResource+".xml"))
                {
                    if (provider.Supports(GeneratorSupport.Resources))
                    {
                        cp.EmbeddedResources.Add(xmlResource+".xml");
                    }
                }
                
                cp.ReferencedAssemblies.AddRange(Libraries.CommonFrameworkLibraries);

                dllFiles.ForEach(
                    a =>
                    {
                        var name = new FileInfo(a).Name;
                        if (!Libraries.CommonFrameworkLibraries.Contains(name, new CustomStrComparer()))
                            cp.ReferencedAssemblies.Add(a);

                        //The follow can do the same thing as above...
                        //if (!Array.Exists(Libraries.CommonFrameworkLibraries,s=>string.Equals(s.ToUpper(),name.ToUpper())))
                        //    cp.ReferencedAssemblies.Add(a);
                    });


                CompilerResults cr = provider.CompileAssemblyFromFile(cp, csFiles.ToArray());
                CompileResult results;
                LogModel model;

                if (cr.Errors.Count > 0)
                {

                    var errorArray = new CompilerError[cr.Errors.Count];
                    cr.Errors.CopyTo(errorArray, 0);

                    var warnings = errorArray.Where(e => e.IsWarning).ToList();
                    var errors = errorArray.Where(e => !e.IsWarning).ToList();


                    results = new CompileResult()
                    {
                        IsBuildSuccess = errors.Count > 0 ? false : true,

                        Warnings = warnings,

                        Errors = errors

                    };

                }
                else
                {
                    results = new CompileResult()
                    {
                        IsBuildSuccess = true,

                        Warnings = null,

                        Errors = null

                    };
                }

                model = new LogModel()
                {
                    CurrentFolder = csPath,
                    DllPath = dllPath,
                    CompileTime = DateTime.Now,
                    CSFileNames = csFileNames,
                    Results = results
                };

                SerializeHelper.SerializeToXML(outputFolder, model, prefix, true);

            }

        }


    }
}
