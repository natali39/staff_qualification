using System.IO;
using TemplateEngine.Docx;

namespace staff_qualification_Forms
{
    public class SelfCheckReport : Report
    {
        public string ResponsiblePerson;

        public void FillSelfCheckDocument()
        {
            File.Delete("selfCheckDocument.docx");
            File.Copy("selfCheckTemplate.docx", "selfCheckDocument.docx");

            File.Delete("selfCheckDocument.docx");
            File.Copy("selfCheckTemplate.docx", "selfCheckDocument.docx");

            var valuesToFill = new Content(
                new FieldContent("ModelDescription", ModelDescription),
                new FieldContent("Operation", Operation),
                new FieldContent("ResponsiblePerson", ResponsiblePerson),
                new FieldContent("Date", Date.ToString("d")),
                new FieldContent("StaffName", StaffName));

            using (var outputDocument = new TemplateProcessor("selfCheckDocument.docx")
                .SetRemoveContentControls(true))
            {
                outputDocument.FillContent(valuesToFill);
                outputDocument.SaveChanges();
            }
            System.Diagnostics.Process.Start("selfCheckDocument.docx");
        }
    }
}
