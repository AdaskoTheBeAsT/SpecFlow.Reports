using System.Collections.Generic;
using System.Xml.Serialization;

namespace TechTalk.SpecFlow.Reporting.StepDefinitionReport.ReportElements
{
    [XmlType(Namespace = StepDefinitionReport.XmlNamespace)]
    
    public class TableArgument : ReportStepArgument
    {
        public TableArgument()
        {
            
        }

        public TableArgument(List<ReportTableRow> rows)
        {
            Rows = rows;
        }

        public List<ReportTableRow> Rows { get; private set; }
    }
}
