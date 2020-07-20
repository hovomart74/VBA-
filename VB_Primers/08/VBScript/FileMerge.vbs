' FileMerge.vbs
' VBScript to read text from a parent directory.
' Author Mike McGrath http://www.ineasysteps.com
' Version 1.0 - September 2015
' -----------------------------------------------'

Option Explicit

Dim fso, folder, textOut, file, textIn
 
Set fso = CreateObject( "Scripting.FileSystemObject" )
Set folder = fso.GetFolder( ".\Textfiles" ).Files
Set textOut = fso.CreateTextFile( "Merged.txt" ) 

For Each file In folder

    Set textIn = fso.OpenTextFile( file, 1 ) 
        textOut.WriteLine "Файл: " & file.Name
        textOut.WriteLine textIn.ReadAll
        textOut.WriteLine vbCr
    textIn.Close

Next 
 
textOut.Close