﻿using System;
using Aspose.Words.Reporting;

namespace Aspose.Words.Examples.CSharp.LINQ
{
    class SetTextBackgroundColorDynamically
    {
        public static void Run()
        {
            // ExStart:SetTextBackgroundColorDynamically
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_LINQ();
            string fileName = "BackgroundColor.doc";
            // Load the template document.
            Document doc = new Document(dataDir + fileName);

            // Create a Reporting Engine.
            ReportingEngine engine = new ReportingEngine();

            // Execute the build report.
            engine.BuildReport(doc, Common.GetClients(), "ColoredItem");
            dataDir = dataDir + RunExamples.GetOutputFilePath(fileName);
            // Save the finished document to disk.
            doc.Save(dataDir);
            // ExEnd:SetTextBackgroundColorDynamically
            Console.WriteLine("\nFile saved at " + dataDir);
        }
    }
}