using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
	public static class Libraries
	{
		//Find in the csc.rsp file.

		//# This file contains command-line options that the C#
		//# command line compiler (CSC) will process as part
		//# of every compilation, unless the "/noconfig" option
		//# is specified. 

		//# Reference the common Framework libraries
		public static string[] CommonFrameworkLibraries = new string[]
		{
			"Accessibility.dll",
			"Microsoft.CSharp.dll",
			"System.Configuration.dll",
			"System.Configuration.Install.dll",
			"System.Core.dll",
			"System.Data.dll",
			"System.Data.DataSetExtensions.dll",
			"System.Data.Linq.dll",
			"System.Data.OracleClient.dll",
			"System.Deployment.dll",
			"System.Design.dll",
			"System.DirectoryServices.dll",
			"System.dll",
			"System.Drawing.Design.dll",
			"System.Drawing.dll",
			"System.EnterpriseServices.dll",
			"System.Management.dll",
			"System.Messaging.dll",
			"System.Runtime.Remoting.dll",
			"System.Runtime.Serialization.dll",
			"System.Runtime.Serialization.Formatters.Soap.dll",
			"System.Security.dll",
			"System.ServiceModel.dll",
			"System.ServiceModel.Web.dll",
			"System.ServiceProcess.dll",
			"System.Transactions.dll",
			"System.Web.dll",
			"System.Web.Extensions.Design.dll",
			"System.Web.Extensions.dll",
			"System.Web.Mobile.dll",
			"System.Web.RegularExpressions.dll",
			"System.Web.Services.dll",
			"System.Windows.Forms.Dll",
			"System.Workflow.Activities.dll",
			"System.Workflow.ComponentModel.dll",
			"System.Workflow.Runtime.dll",
			"System.Xml.dll",
			"System.Xml.Linq.dll"
		};
	}
}
