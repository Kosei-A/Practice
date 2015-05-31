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

        ' Keep the console window open in debug mode. 
        Console.WriteLine("Press any key to exit.")
        Console.ReadKey()

    End Sub

End Module
