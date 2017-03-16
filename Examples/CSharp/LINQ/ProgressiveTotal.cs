using Aspose.Words.Reporting;
using System;

namespace Aspose.Words.Examples.CSharp.LINQ
{
    class ProgressiveTotal
    {
        public static void Run()
        {
            // ExStart:ProgressiveTotal
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LINQ();
            string fileName = "ProgressiveTotal.doc";

            // Load the template document.
            Document doc = new Document(dataDir + fileName);

            // Create a Reporting Engine.
            ReportingEngine engine = new ReportingEngine();

            // Execute the build report.
            engine.BuildReport(doc, Common.GetContracts(), "contracts");
            dataDir = dataDir + RunExamples.GetOutputFilePath(fileName);
            // Save the finished document to disk.
            doc.Save(dataDir);
            // ExEnd:ProgressiveTotal
            Console.WriteLine("\nFile saved at " + dataDir);
        }
    }
}