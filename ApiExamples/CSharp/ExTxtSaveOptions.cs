// Copyright (c) 2001-2016 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Words. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using Aspose.Words;
using Aspose.Words.Saving;
using NUnit.Framework;

namespace ApiExamples
{
    [TestFixture]
    public class ExTxtSaveOptions : ApiExampleBase
    {
        [Test]
        public void PageBreaks()
        {
            Document doc = new Document();

            TxtSaveOptions saveOptions = new TxtSaveOptions();
            saveOptions.ForcePageBreaks = true;
            doc.Save(MyDir + "123.docx", saveOptions);
        }
    }
}