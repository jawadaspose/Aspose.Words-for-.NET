' For complete examples and data files, please go to https://github.com/asposewords/Aspose_Words_NET
Dim doc As New Document()
Dim builder As New DocumentBuilder(doc)

Dim table As Table = builder.StartTable()
' Make the header row.
builder.InsertCell()

' Set the left indent for the table. Table wide formatting must be applied after 
' at least one row is present in the table.
table.LeftIndent = 20.0

' Set height and define the height rule for the header row.
builder.RowFormat.Height = 40.0
builder.RowFormat.HeightRule = HeightRule.AtLeast

' Some special features for the header row.
builder.CellFormat.Shading.BackgroundPatternColor = Color.FromArgb(198, 217, 241)
builder.ParagraphFormat.Alignment = ParagraphAlignment.Center
builder.Font.Size = 16
builder.Font.Name = "Arial"
builder.Font.Bold = True

builder.CellFormat.Width = 100.0
builder.Write("Header Row," & vbLf & " Cell 1")

' We don't need to specify the width of this cell because it's inherited from the previous cell.
builder.InsertCell()
builder.Write("Header Row," & vbLf & " Cell 2")

builder.InsertCell()
builder.CellFormat.Width = 200.0
builder.Write("Header Row," & vbLf & " Cell 3")
builder.EndRow()

' Set features for the other rows and cells.
builder.CellFormat.Shading.BackgroundPatternColor = Color.White
builder.CellFormat.Width = 100.0
builder.CellFormat.VerticalAlignment = CellVerticalAlignment.Center

' Reset height and define a different height rule for table body
builder.RowFormat.Height = 30.0
builder.RowFormat.HeightRule = HeightRule.Auto
builder.InsertCell()
' Reset font formatting.
builder.Font.Size = 12
builder.Font.Bold = False

' Build the other cells.
builder.Write("Row 1, Cell 1 Content")
builder.InsertCell()
builder.Write("Row 1, Cell 2 Content")

builder.InsertCell()
builder.CellFormat.Width = 200.0
builder.Write("Row 1, Cell 3 Content")
builder.EndRow()

builder.InsertCell()
builder.CellFormat.Width = 100.0
builder.Write("Row 2, Cell 1 Content")

builder.InsertCell()
builder.Write("Row 2, Cell 2 Content")

builder.InsertCell()
builder.CellFormat.Width = 200.0
builder.Write("Row 2, Cell 3 Content.")
builder.EndRow()
builder.EndTable()

dataDir = dataDir & Convert.ToString("DocumentBuilder.CreateFormattedTable_out_.doc")
' Save the document to disk.
doc.Save(dataDir)
