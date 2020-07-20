﻿Public Class Form1
    'тут обозначены общедоступные переменные 
    'чтобы не было длиннющих названий в кодах
    'переменная для TextBox1.Text
    Dim FromNum As Long
    'переменная для TextBox2.Text
    Public ToNum As Long
    'тут устанавливаем верхний предел для ToNum
    Dim VerxPredel As Long = 999999999999999
    'устанавливаем предел между остановками остановок
    Dim OsKaPredel As Integer = 10000

    'подпрограмма(ФУНКЦИЯ), которая считает по армянски
    Private Function ARM(Tiv As String)
        'создаём двухмерный массив для переводов на армянский
        Dim Znaki(2, 10) As String
        Znaki(0, 0) = "" : Znaki(0, 1) = "մեկ" : Znaki(0, 2) = "երկու" : Znaki(0, 3) = "երեք"
        Znaki(0, 4) = "չորս" : Znaki(0, 5) = "հինգ" : Znaki(0, 6) = "վեց" : Znaki(0, 7) = "յոթ"
        Znaki(0, 8) = "ութ" : Znaki(0, 9) = "ինը"
        Znaki(1, 0) = "" : Znaki(1, 1) = "տասնը" : Znaki(1, 2) = "քսան" : Znaki(1, 3) = "երեսուն"
        Znaki(1, 4) = "քարասուն" : Znaki(1, 5) = "հիսուն" : Znaki(1, 6) = "վաթսուն" : Znaki(1, 7) = "յոթանասուն"
        Znaki(1, 8) = "ութանասուն" : Znaki(1, 9) = "ինըսուն" : Znaki(1, 10) = "տաս"
        Znaki(2, 0) = "" : Znaki(2, 1) = " հարյուր "
        'Tiv нужен в формате String
        'Tiv представляем себе как массив и
        'Создаём переменную, равную максимальному индексу у элементов массива Tiv
        Dim T As Integer = Len(Tiv) - 1
        'создаём массив TivArm по количеству элементов Tiv
        Dim TivArm(T) As String
        'Создаём переменную, равную максимальному индексу у элементов массива TivArm
        Dim TA As Integer = UBound(TivArm)

        'запускаем цикл чтобы заполнить массив TivArm переводами чисел
        'формулы привязаны к разряду знака Tiv 
        For i = 0 To T
            'немножко извращяемся, чтобы заполнять массив TivArm с конца
            TivArm(TA - i) = Znaki(i, Val(Tiv(T - i)))
            'исключение для 10 => "տաս"
            If Len(Tiv) > 1 Then
                If Tiv(T - 1) = "1" And Tiv(T) = "0" Then
                    'TivArm(TA) = ""
                    TivArm(TA - 1) = Znaki(1, 10)
                End If
            End If
            'Считаем от 100
            If Len(Tiv) > 2 Then
                TivArm(TA - 2) = Znaki(0, Val(Tiv(T - 2))) & Znaki(2, 1)
                'исключение для 100 => "հարյուր"
                'чтобы вместо "հարյուր" не писать "մեկհարյուր"
                If Tiv(T - 2) = "1" Then
                    TivArm(TA - 2) = Znaki(2, 1)
                End If
                'чтобы вместо "" не писать "" & "հարյուր"
                If Tiv(T - 2) = "0" Then
                    TivArm(TA - 2) = Znaki(2, 0)
                End If
            End If
        Next
        'на основе массива TivArm создаём времменное выражение для 
        'отправки на вывод в ListBox1
        Dim VremTiv As String
        VremTiv = ""
        For v = 0 To TA
            VremTiv = VremTiv & TivArm(v)
        Next

        'Отправляем на вывод в ListBox1
        Return VremTiv
    End Function

    'разборка цифры в понятный формат для функции ARM
    Private Sub Razbor()

        'цикл поочерёдного вывода всех цифр из TextBox1 до TextBox2
        For i = FromNum To ToNum
            'i сохраняем ещё и в формате String
            Dim Tiv As String = i
            'проверяем цифру и при нехватке символов для количества кратно трём, 
            'добавляем "0" - и с переди
            Select Case Math.IEEERemainder(Len(Tiv), 3)
                Case Is = 1
                    Tiv = "00" & Tiv
                Case Is = -1
                    Tiv = "0" & Tiv
            End Select

            'максимальный индекс у вродебы массива Tiv назавём T
            Dim T As Integer = Len(Tiv) - 1

            'проверяем какой язык выбран
            Select Case ComboBox1.SelectedItem
                Case Is = "Հայերեն"
                    'если выбрали Հայերեն
                    'знаки цифры розделяем на группы по три символа
                    Dim Tret As Integer = Math.Ceiling(Len(Tiv) / 3)
                    'создаём массив ItogMassiv с количеством элементов Tret
                    Dim ItogMassiv(Tret - 1) As String
                    'максимальный индекс у массива ItogMassiv назавём iM
                    Dim iM As Integer = UBound(ItogMassiv)
                    'Запускаем цикл для заполнения ItogMassiv трёхсимволными блоками из цифры
                    For B = 0 To iM
                        ItogMassiv(iM - B) = Tiv((T - 2) - (B * 3)) &
                            Tiv((T - 1) - (B * 3)) & Tiv(T - (B * 3))
                    Next
                    'создаём массив от которого будет пользоваться цикл, заполняющий ItogArm
                    Dim Miliardi() As String = {"", " հազար ", " միլիոն ", " միլիարդ ", " տրիլիոն "}

                    'создаём переменную ItogArm, которая в итоге отправится в ListBox1
                    Dim ItogArm As String
                    ItogArm = ""

                    'создаём массив ArmMassiv по числу элементов ItogMassiv
                    'и меняем элементы аналогами Arm-перевода
                    Dim ArmMassiv(iM) As String
                    For P = 0 To iM
                        ArmMassiv(iM - P) = ARM(ItogMassiv(iM - P)) & Miliardi(P)
                    Next

                    'заполняем ItogArm при цифрах от 1000
                    If Val(Tiv) > 999 Then
                        For ZZ = 0 To iM
                            If ItogMassiv(iM - ZZ) = "000" Then
                                ArmMassiv(iM - ZZ) = ""
                            End If
                            If ItogMassiv(iM - 1) = "001" Then
                                ArmMassiv(iM - 1) = Miliardi(1)
                            End If
                        Next
                    End If
                    'заполняем ItogArm при цифрах до 1000
                    For IA = 0 To iM
                        ItogArm = ItogArm & ArmMassiv(IA)
                    Next

                    'при цифре 0
                    If iM = 0 And ItogMassiv(0) = "000" Then
                        ItogArm = "զրո"
                    End If
                    'отправляем на ПЕЧАТЬ :)
                    ListBox1.Items.Insert(0, (i & " => " & ItogArm & "   ."))

                    'дальше будем добавлять другие языки
                    'Case Is = "ДРУГОЙ ЯЗЫК"

            End Select
        Next

        If ToNum = VerxPredel And ComboBox1.SelectedItem = "Հայերեն" Then
            'сообщение по умолчанию, для слишком больших чисел
            ListBox1.Items.Insert(0, (VerxPredel & "-ից ավել դեռ հաշվել չգիտեմ ;)"))
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'очищяем ListBox1.Items
        ListBox1.Items.Clear()
        'принуждаем выбрать язык то есть, проверяем выбрали ли язык
        Select Case ComboBox1.SelectedItem
            'если не выбрали ничего,
            Case Is = ""
                'ругаем в MsgBox
                MsgBox("Ընտրի'ր լեզուն, որով հաշվելու եմ", 49, "Բարկացա'")
            Case Is = "Հայերեն"
                Startuem()
        End Select

    End Sub

    'для остановок при сверхдлинных вычислениях
    Private Sub Ostanovki()
        'розбиваем весь процесс на части стопками по OsKaPredel
        Dim Bola As Long = Math.Ceiling((ToNum - FromNum) / OsKaPredel)
        'создаём нижний предел
        Dim FromPredel As Long = FromNum
        'создаём маленький предел
        Dim ToPredel As Long = ToNum
        ToNum = FromNum + OsKaPredel
        Razbor()
        'цикл для остановок на каждой OsKaPredel
        For OsKa = 2 To (Bola + 1)
            If OsKa < (Bola + 1) Then
                'При нажатии на "Да"
                If MsgBox("Հաշվել եմ մինչև 
" & ToNum & "-ը, 
շարունակե՞մ", 36, "") = 6 Then

                    If ToNum + OsKaPredel <= ToPredel Then
                        FromNum = ToNum + 1
                        ToNum = FromPredel + (OsKaPredel * OsKa)

                        Razbor()
                    Else
                        FromNum = ToNum + 1
                        ToNum = ToPredel

                        Razbor()
                    End If

                Else
                    'При нажатии на "Нет"
                    OsKa = (Bola + 1)
                    'звуковой сигнал о завершении
                    'My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
                End If
                'My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
            End If


        Next
    End Sub



    'тут Стартует процесс обработки цифр
    Private Sub Startuem()


        'добавляем переменные, чтобы избавиться от длиннющих названий в кодах
        FromNum = Val(TextBox1.Text)
        ToNum = Val(TextBox2.Text)

        'защита от дурака
        'в случае, если хотят принудить считать в обратном порядке то
        'меняем местами FromNum и ToNum
        If FromNum > ToNum Then
            Dim vrem As Long = FromNum
            FromNum = ToNum
            ToNum = vrem
        End If

        'решаем проблему с большими числами
        'если число больше, чем готовые формулы переводов
        'устанавливаем ToNum = максимально желаемое число,
        'чтобы цикол не гонять в пустую
        If ToNum > VerxPredel Then
            ToNum = VerxPredel
        End If



        'решаем проблему с отрицательными числами
        If FromNum < 0 Then
            FromNum = 0
            'запускаем подпрограмму ругательств по поводу отрицательных чисел
            Otricateln()
        End If

        'запускаем цикл и отправяем FromNum для начала счётчика
        If ToNum - FromNum > OsKaPredel Then
            Ostanovki()
        Else
            Razbor()
        End If
    End Sub

    'при вводе отрицательных чисел
    Private Sub Otricateln()
        Select Case ComboBox1.SelectedItem
            'ответ на армянском
            Case Is = "Հայերեն"
                ListBox1.Items.Insert(0, ("Բացասական թվեր չե'մ հաշվելու,"))
                ListBox1.Items.Insert(0, ("ի'նքդ կարող ես ամեն թվից առաջ ասել <<մինուս>>"))
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'очищяем ListBox1.Items
        ListBox1.Items.Clear()
        TextBox1.Text = TextBox2.Text
        Startuem()
        TextBox2.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        AcceptButton = Button2()
    End Sub
End Class