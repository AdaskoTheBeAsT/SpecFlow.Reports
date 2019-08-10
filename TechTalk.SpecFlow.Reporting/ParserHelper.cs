using System.Collections.Generic;
using System.Globalization;
using System.IO;
using TechTalk.SpecFlow.Generator.Project;
using TechTalk.SpecFlow.Parser;

namespace TechTalk.SpecFlow.Reporting
{
    static class ParserHelper
    {
        public static List<SpecFlowDocument> GetParsedFeatures(SpecFlowProject specFlowProject)
        {
            
            return GetParsedFeatures(
                Directory.EnumerateFiles(
                    specFlowProject.ProjectSettings.ProjectFolder,
                    "*.feature",
                    SearchOption.AllDirectories),
                specFlowProject.Configuration.SpecFlowConfiguration.FeatureLanguage);
        }

        public static List<SpecFlowDocument> GetParsedFeatures(IEnumerable<string> featureFiles, CultureInfo featureLanguage)
        {
            List<SpecFlowDocument> parsedSpecFlowDocument = new List<SpecFlowDocument>();
            foreach (var featureFile in featureFiles)
            {
                SpecFlowGherkinParser parser = new SpecFlowGherkinParser(featureLanguage);
                using (var reader = new StreamReader(featureFile))
                {
                    var specFlowFeature = parser.Parse(reader, featureFile);
                    parsedSpecFlowDocument.Add(specFlowFeature);
                }
            }
            return parsedSpecFlowDocument;
        }
    }
}
