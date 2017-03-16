using System;
using Aspose.Words.Reporting;

namespace Aspose.Words.Examples.CSharp.LINQ
{
    class UseVariableInTemplate
    {
        public static void Run()
        {
            // ExStart:UseVariableInTemplate
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LINQ();
            string fileName = "Variables.docx";

            // Load the template document.
            Document doc = new Document(dataDir + fileName);

            // Create a Reporting Engine.
            ReportingEngine engine = new ReportingEngine();

            // Execute the build report.
            engine.BuildReport(doc, engine);
            dataDir = dataDir + RunExamples.GetOutputFilePath(fileName);
            // Save the finished document to disk.
            doc.Save(dataDir);
            // ExEnd:UseVariableInTemplate
            Console.WriteLine("\nFile saved at " + dataDir);
        }
    }
}