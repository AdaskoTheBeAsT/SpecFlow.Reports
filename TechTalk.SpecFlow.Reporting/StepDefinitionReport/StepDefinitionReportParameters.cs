namespace TechTalk.SpecFlow.Reporting.StepDefinitionReport
{
    public class StepDefinitionReportParameters : ReportParameters
    {
        public string BinFolder { get; private set; }
        public bool ShowBindingsWithoutInsance { get; private set; }

        public StepDefinitionReportParameters(string projectFile, string defaultNamespace, string outputFile, string xsltFile, string binFolder, bool showBindingsWithoutInsance) 
            : base(projectFile, defaultNamespace, outputFile, xsltFile)
        {
            BinFolder = binFolder;
            ShowBindingsWithoutInsance = showBindingsWithoutInsance;
        }
    }
}
