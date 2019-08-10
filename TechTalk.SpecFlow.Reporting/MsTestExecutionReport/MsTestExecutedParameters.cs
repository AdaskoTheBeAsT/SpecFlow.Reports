using System.IO;

namespace TechTalk.SpecFlow.Reporting.MsTestExecutionReport
{
    public class MsTestExecutionReportParameters : ReportParameters
    {
        public string XmlTestResult { get; private set; }

        public MsTestExecutionReportParameters(string projectFile, string defaultNamespace, string xmlTestResult, string outputFile, string xsltFile)
            : base(projectFile, defaultNamespace, outputFile, xsltFile)
        {
            this.XmlTestResult = Path.GetFullPath(xmlTestResult);
        }

        public MsTestExecutionReportParameters(string projectName, string featureLanguage, string defaultNamespace, string xmlTestResult, string outputFile, string xsltFile)
            : base(projectName, featureLanguage, defaultNamespace, outputFile, xsltFile)
        {
            this.XmlTestResult = Path.GetFullPath(xmlTestResult);
        }
    }
}
