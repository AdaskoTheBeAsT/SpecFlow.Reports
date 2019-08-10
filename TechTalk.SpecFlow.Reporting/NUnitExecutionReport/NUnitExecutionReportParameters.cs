using System.IO;

namespace TechTalk.SpecFlow.Reporting.NUnitExecutionReport
{
    public class NUnitExecutionReportParameters : ReportParameters
    {
        public string LabelledTestOutput { get; private set; }
        public string XmlTestResult { get; private set; }

        public NUnitExecutionReportParameters(string projectFile, string defaultNamespace, string xmlTestResult, string labelledTestOutput, string outputFile, string xsltFile)
            : base(projectFile, defaultNamespace, outputFile, xsltFile)
        {
            this.XmlTestResult = Path.GetFullPath(xmlTestResult);
            this.LabelledTestOutput = string.IsNullOrEmpty(labelledTestOutput) ? "" : Path.GetFullPath(labelledTestOutput);
        }

        public NUnitExecutionReportParameters(string projectName, string featureLanguage, string defaultNamespace, string xmlTestResult, string labelledTestOutput, string outputFile, string xsltFile)
            : base(projectName, featureLanguage, defaultNamespace, outputFile, xsltFile)
        {
            this.XmlTestResult = Path.GetFullPath(xmlTestResult);
            this.LabelledTestOutput = string.IsNullOrEmpty(labelledTestOutput) ? "" : Path.GetFullPath(labelledTestOutput);
        }
    }
}