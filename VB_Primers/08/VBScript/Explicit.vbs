' Explicit.vbs
' VBScript to demonstrate enforcing declarations.
' Author Mike McGrath http://www.ineasysteps.com
' Version 1.0 - September 2015
' -----------------------------------------------
Option Explicit

Dim bookTitle
bookTitle="Программирование на Visual Basic для начинающих"
MsgBox bookTitle, vbInformation, "Сообщение"

' bookTitle = "Программирование на Visual Basic для начинающих"
' MsgBox bookTitle, vbInformation, "Сообщение"