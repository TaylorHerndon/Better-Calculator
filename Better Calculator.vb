Option Explicit On
Option Strict On
Imports System.Threading

'Taylor Herndon
'RCET0265
'Spring 2021
'Better Calculator with multithreading
'https://github.com/TaylorHerndon/Better-Calculator

Module Module1

    'Declaring a function to be able to get the currently pressed key.
    'This is needed to not interfere with the normal console interaction.
    'ie. Console.Readkey.key could not be used because it would overide the normal user inputs.

    Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Integer) As Boolean

    Sub Main()

        'Initalizing multithreading to be able to abort the program at ANY point.

        Dim thread1 As Thread = New Thread(AddressOf Calculator)
        Dim thread2 As Thread = New Thread(AddressOf Abort)

        'Starting both the calculator and abort processes
        thread1.Start()
        thread2.Start()

    End Sub

    'Calculator routine
    Sub Calculator()

        Dim Number1 As Double = Nothing
        Dim Number2 As Double = Nothing
        Dim Operation As String = "~"
        Dim Result As Double = Nothing
        Dim UserSelect As Integer = Nothing

        'Intro lines
        Console.WriteLine("Hello, welcome to the better calculator!")
        System.Threading.Thread.Sleep(1000)
        Console.WriteLine("Here at BetterCalculator Incorperated we pride ourselves on having better calculators than SimpleCalculator Corp.")
        System.Threading.Thread.Sleep(2000)
        Console.WriteLine("[Q]: To exit the program at any time.")
        System.Threading.Thread.Sleep(2000)
        Console.WriteLine("Press any key to start computing...")
        Console.ReadKey()

        'Main calculator process
        Do

            'Get Number 1
            Do While Number1 = Nothing

                MyActions.PasteTitle(Number1, Number2, Operation, Result)
                Console.WriteLine(vbNewLine & "Please enter your first number...")

                Try

                    Number1 = Convert.ToDouble(Console.ReadLine())

                Catch

                    Number1 = Nothing

                End Try

            Loop

            'Get Number 2
            Do While Number2 = Nothing

                MyActions.PasteTitle(Number1, Number2, Operation, Result)
                Console.WriteLine(vbNewLine & "Please enter your second number...")

                Try

                    Number2 = Convert.ToDouble(Console.ReadLine())

                Catch

                    Number2 = Nothing

                End Try

            Loop

            'Get desired operation
            Do Until Operation <> "~"

                MyActions.PasteTitle(Number1, Number2, Operation, Result)

                Console.WriteLine("Now... what do you want for your operation?")
                Console.WriteLine("1. Addition [+]" & vbNewLine & "2. Subtraction [-]" & vbNewLine & "3. Multiplication [x]" & vbNewLine & "4. Division [÷]")

                Do Until UserSelect <> Nothing

                    UserSelect = CInt(MyActions.ConsoleKeyToNumber())

                Loop

                Select Case UserSelect

                    Case 1

                        Operation = "+"
                        Result = Number1 + Number2

                    Case 2

                        Operation = "-"
                        Result = Number1 - Number2

                    Case 3

                        Operation = "x"
                        Result = Number1 * Number2

                    Case 4

                        Operation = "÷"
                        Result = Number1 / Number2

                    Case Else

                        Operation = "~"

                End Select

            Loop

            'Ask if the user wants to run the calculator process again
            MyActions.PasteTitle(Number1, Number2, Operation, Result)
            Console.WriteLine("Your result should be in the header.")
            System.Threading.Thread.Sleep(2000)
            Console.WriteLine("Do you want to compute again?")
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Y - N")

            Do Until Operation = "~"

                Select Case Console.ReadKey.Key

                    Case ConsoleKey.Y

                        Number1 = Nothing
                        Number2 = Nothing
                        Operation = "~"
                        Result = Nothing

                    Case ConsoleKey.N

                        MyActions.PasteTitle(Number1, Number2, Operation, Result)
                        Console.WriteLine("Thank you for choosing BetterCalculator Incorperated!")
                        System.Threading.Thread.Sleep(2000)
                        Console.WriteLine("Remember to keep on hating SimpleCalculator Corp!")
                        System.Threading.Thread.Sleep(2000)
                        End

                End Select

            Loop

        Loop

    End Sub

    Sub Abort()

        'Sleep thread every 100ms until key 81 (Q) is pressed
        Do Until GetAsyncKeyState(81)
            Thread.Sleep(100)
        Loop

        'Once Q is pressed, the entire program is ended.
        End

    End Sub

End Module
