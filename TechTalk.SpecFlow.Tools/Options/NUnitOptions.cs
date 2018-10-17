using CommandLine;

namespace TechTalk.SpecFlow.Tools.Options
{
    [Verb("NUnitExecutionReport", HelpText = "Formats an NUnit execution report to SpecFlow style.")]
    public class NUnitOptions : BaseReportOptions
    {
        [Option('t', "xmlTestResult",
            Default = "TestResult.xml",
            HelpText = "Xml Test Result file generated by NUnit. Defaults to TestResult.xml.")]
        public string XmlTestResult { get; set; }

        [Option('o', "testOutput",
            Default = "TestResult.txt",
            HelpText = "The labeled test output file generated by nunit-console. Defaults to TestResult.txt.")]
        public string TestOutput { get; set; }
    }
}