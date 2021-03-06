﻿using TemplateEngine.Docx;
using System.IO;
using System;

namespace staff_qualification_Forms
{
    public class TrainingReport : Report
    {
        public string Trainer;
        public DateTime EndDate;

        public void FillTrainingDocument()
        {
            File.Delete("trainingDocument.docx");
            File.Copy("trainingTemplate.docx", "trainingDocument.docx");

            File.Delete("trainingDocument.docx");
            File.Copy("trainingTemplate.docx", "trainingDocument.docx");

            var valuesToFill = new Content(
                new FieldContent("modelDescription", ModelDescription),
                new FieldContent("operationDescription", Operation),
                new FieldContent("trainer", Trainer),
                new FieldContent("startDate", Date.ToString("d")),
                new FieldContent("endDate", EndDate.ToString("d")),
                new FieldContent("staffID", StaffID),
                new FieldContent("staffName", StaffName));

            using (var outputDocument = new TemplateProcessor("trainingDocument.docx")
                .SetRemoveContentControls(true))
            {
                outputDocument.FillContent(valuesToFill);
                outputDocument.SaveChanges();
            }
            System.Diagnostics.Process.Start("trainingDocument.docx");
        }
    }
}
