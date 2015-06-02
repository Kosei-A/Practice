Module Module1

    '---------------------------------------------------
    ' Name:        helloworld
    ' Purpose:     Practice
    ' version :    1.0
    ' Author:      kosei.a
    '
    ' Created:     26/5/2015
    ' Copyright:   kosei.a
    ' Licence:     your licence
    '---------------------------------------------------*/

    Sub Main()
        Console.WriteLine("----- 1.1 only 1 time -----")
        Console.WriteLine("Hello World")
        Console.WriteLine("----- End -----" & vbCrLf)

        Console.WriteLine("----- 1.2 loop 5 times -----")
        For i = 1 To 5

            Console.WriteLine("Hello World")

        Next
        Console.WriteLine("----- End -----" & vbCrLf)

        Console.WriteLine("----- 1.3 print each characters -----")
        Dim str As String
        Dim c As Char
        str = "Hello World"
        For Each c In str
            Console.WriteLine(c)
        Next
        Console.WriteLine("----- End -----" & vbCrLf)

        Console.WriteLine("----- 1.4 print [l] character only -----")
        For Each c In str
            If c = "l" Then
                Console.WriteLine(c)
            End If
        Next
        Console.WriteLine("----- End -----" & vbCrLf)

        Console.WriteLine("----- 1.5 print first 4 characters -----")
        Console.WriteLine(str.Substring(0, 4))
        Console.WriteLine("----- End -----" & vbCrLf)

        Console.WriteLine("----- 1.6 print last 4 characters -----")
        Console.WriteLine(str.Substring(str.Length - 4))
        Console.WriteLine("----- End -----" & vbCrLf)

        Console.WriteLine("----- 1.7 print 4 characters from [W] -----")
        Console.WriteLine(str.Substring(str.IndexOf("W"), 4))
        Console.WriteLine("----- End -----" & vbCrLf)


        Console.WriteLine("----- 1.8 Hello 'name'! * 3 times using function -----")
        str = hello_name("Tom", 3)
        Console.WriteLine(str)
        Console.WriteLine("----- End -----" & vbCrLf)

        ' Keep the console window open in debug mode. 
        Console.WriteLine("Press any key to exit.")
        Console.ReadKey()

    End Sub

    Public Function hello_name(name As String, count As Integer) As String
        Dim hello As String = "Hello" & name & "! "
        Dim buf As New System.Text.StringBuilder(hello.Length * count)
        For i As Integer = 0 To count - 1
            buf.Append(hello)
        Next
        Return buf.ToString()
    End Function

End Module
