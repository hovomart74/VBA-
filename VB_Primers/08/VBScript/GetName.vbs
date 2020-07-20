' GetName.vbs
' VBScript to validate username input.
' Author Mike McGrath http://www.ineasysteps.com
' Version 1.0 - September 2015
' -----------------------------------------------'

Option Explicit 

Dim name, regX

Private Function GetName()

name = InputBox( "Как тебя зовут?", "Вопрос" )

' Is Cancel pressed?
If VarType( name ) = vbEmpty Then 
Exit Function

' Is empty input?
Elseif name = "" Then
MsgBox "Ты же ничего не написал:(", vbInformation, "Ошибка"
Call GetName

' Is input invalid?
Elseif Invalid() Then
MsgBox "Приветствуются только русские буквы и пробелы!", vbCritical, "Ошибка"
Call GetName

' Is accepted.
Else
MsgBox "Привет, " & name & "!", vbExclamation, "Сообщение"
End If

End Function

Private Function Invalid()
Set regX = New RegExp 
regX.Pattern = "[^А-Я а-я]"
Invalid = regX.Test( Name ) 
End Function

Call GetName