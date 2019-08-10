using System.IO;

namespace TechTalk.SpecFlow.Reporting
{
    public abstract class ReportParameters
    {
        public string XsltFile { get; private set; }
        public string OutputFile { get; private set; }
        public string ProjectFile { get; private set; }
        public string ProjectName { get; set; }
        public string FeatureLanguage { get; set; }

        public string DefaultNamespace { get; set; }

        protected ReportParameters(string projectFile, string defaultNamespace, string outputFile, string xsltFile)
        {
            this.ProjectFile = projectFile;
            DefaultNamespace = defaultNamespace;
            this.OutputFile = Path.GetFullPath(outputFile);
            this.XsltFile = string.IsNullOrEmpty(xsltFile) ? "" : Path.GetFullPath(xsltFile);
        }

        protected ReportParameters(string projectName, string featureLanguage, string defaultNamespace, string outputFile, string xsltFile)
        {
            this.ProjectName = projectName;
            this.FeatureLanguage = featureLanguage;
            DefaultNamespace = defaultNamespace;
            this.OutputFile = Path.GetFullPath(outputFile);
            this.XsltFile = string.IsNullOrEmpty(xsltFile) ? "" : Path.GetFullPath(xsltFile);
        }
    }
}
