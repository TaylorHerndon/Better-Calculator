﻿Imports Microsoft.VisualBasic
Imports System
Module MyActions

    Sub PasteTitle(Number1 As Double, Number2 As Double, Operation As String, Result As Double)

        Console.Clear()
        Console.WriteLine("[--[Welcome to BetterCalculator Incorperated's better calculator TI-X99SRX Titanium Platinum Express]--]")
        Console.WriteLine("[}===================================================================================================={]")
        Console.WriteLine("[" & Number1 & "] " & Operation & " [" & Number2 & "] = [" & Result & "]")
        Console.WriteLine("[}===================================================================================================={]")


    End Sub

    Function ConsoleKeyToString()

        Dim ConvertedString As String = ""

        Select Case Console.ReadKey.Key
            Case ConsoleKey.Enter
                ConvertedString = "Enter"
            Case ConsoleKey.D1
                ConvertedString = "1"
            Case ConsoleKey.D2
                ConvertedString = "2"
            Case ConsoleKey.D3
                ConvertedString = "3"
            Case ConsoleKey.D4
                ConvertedString = "4"
            Case ConsoleKey.D5
                ConvertedString = "5"
            Case ConsoleKey.D6
                ConvertedString = "6"
            Case ConsoleKey.D7
                ConvertedString = "7"
            Case ConsoleKey.D8
                ConvertedString = "8"
            Case ConsoleKey.D9
                ConvertedString = "9"
            Case ConsoleKey.D0
                ConvertedString = "0"
            Case ConsoleKey.NumPad1
                ConvertedString = "1"
            Case ConsoleKey.NumPad2
                ConvertedString = "2"
            Case ConsoleKey.NumPad3
                ConvertedString = "3"
            Case ConsoleKey.NumPad4
                ConvertedString = "4"
            Case ConsoleKey.NumPad5
                ConvertedString = "5"
            Case ConsoleKey.NumPad6
                ConvertedString = "6"
            Case ConsoleKey.NumPad7
                ConvertedString = "7"
            Case ConsoleKey.NumPad8
                ConvertedString = "8"
            Case ConsoleKey.NumPad9
                ConvertedString = "9"
            Case ConsoleKey.NumPad0
                ConvertedString = "0"
            Case ConsoleKey.A
                ConvertedString = "A"
            Case ConsoleKey.B
                ConvertedString = "B"
            Case ConsoleKey.C
                ConvertedString = "C"
            Case ConsoleKey.D
                ConvertedString = "D"
            Case ConsoleKey.E
                ConvertedString = "E"
            Case ConsoleKey.F
                ConvertedString = "F"
            Case ConsoleKey.G
                ConvertedString = "G"
            Case ConsoleKey.H
                ConvertedString = "H"
            Case ConsoleKey.I
                ConvertedString = "I"
            Case ConsoleKey.J
                ConvertedString = "J"
            Case ConsoleKey.K
                ConvertedString = "K"
            Case ConsoleKey.L
                ConvertedString = "L"
            Case ConsoleKey.M
                ConvertedString = "M"
            Case ConsoleKey.N
                ConvertedString = "N"
            Case ConsoleKey.O
                ConvertedString = "O"
            Case ConsoleKey.P
                ConvertedString = "P"
            Case ConsoleKey.Q
                ConvertedString = "Q"
            Case ConsoleKey.R
                ConvertedString = "R"
            Case ConsoleKey.S
                ConvertedString = "S"
            Case ConsoleKey.T
                ConvertedString = "T"
            Case ConsoleKey.U
                ConvertedString = "U"
            Case ConsoleKey.V
                ConvertedString = "V"
            Case ConsoleKey.W
                ConvertedString = "W"
            Case ConsoleKey.X
                ConvertedString = "X"
            Case ConsoleKey.Y
                ConvertedString = "Y"
            Case ConsoleKey.Z
                ConvertedString = "Z"
            Case ConsoleKey.Spacebar
                ConvertedString = " "
            Case Else
                ConvertedString = ""
        End Select

        Return ConvertedString

    End Function

    Function ConsoleKeyToNumber()

        Dim ConvertedString As Integer = Nothing

        Select Case Console.ReadKey.Key
            Case ConsoleKey.D1
                ConvertedString = 1
            Case ConsoleKey.D2
                ConvertedString = 2
            Case ConsoleKey.D3
                ConvertedString = 3
            Case ConsoleKey.D4
                ConvertedString = 4
            Case ConsoleKey.D5
                ConvertedString = 5
            Case ConsoleKey.D6
                ConvertedString = 6
            Case ConsoleKey.D7
                ConvertedString = 7
            Case ConsoleKey.D8
                ConvertedString = 8
            Case ConsoleKey.D9
                ConvertedString = 9
            Case ConsoleKey.D0
                ConvertedString = 0
            Case ConsoleKey.NumPad1
                ConvertedString = 1
            Case ConsoleKey.NumPad2
                ConvertedString = 2
            Case ConsoleKey.NumPad3
                ConvertedString = 3
            Case ConsoleKey.NumPad4
                ConvertedString = 4
            Case ConsoleKey.NumPad5
                ConvertedString = 5
            Case ConsoleKey.NumPad6
                ConvertedString = 6
            Case ConsoleKey.NumPad7
                ConvertedString = 7
            Case ConsoleKey.NumPad8
                ConvertedString = 8
            Case ConsoleKey.NumPad9
                ConvertedString = 9
            Case ConsoleKey.NumPad0
                ConvertedString = 0
            Case Else
                ConvertedString = Nothing
        End Select

        Return ConvertedString

    End Function

End Module
