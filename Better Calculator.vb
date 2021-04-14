Option Explicit On
Option Strict On
Imports System.Threading

'Taylor Herndon
'RCET0265
'Spring 2021
'Better Calculator with multithreading
'https://github.com/TaylorHerndon/Better-Calculator

Module BetterCalculator

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

        Dim number1 As Double = Nothing
        Dim number2 As Double = Nothing
        Dim operation As String = "~"
        Dim result As Double = Nothing
        Dim userSelect As Integer = Nothing

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
            Do While number1 = Nothing

                MyActions.PasteTitle(number1, number2, operation, result)
                Console.WriteLine(vbNewLine & "Please enter your first number...")

                Try
                    number1 = Convert.ToDouble(Console.ReadLine())
                Catch
                    number1 = Nothing
                End Try

            Loop

            'Get Number 2
            Do While number2 = Nothing

                MyActions.PasteTitle(number1, number2, operation, result)
                Console.WriteLine(vbNewLine & "Please enter your second number...")

                Try
                    number2 = Convert.ToDouble(Console.ReadLine())
                Catch
                    number2 = Nothing
                End Try

            Loop

            'Get desired operation
            Do Until operation <> "~"

                MyActions.PasteTitle(number1, number2, operation, result)

                Console.WriteLine("Now... what do you want for your operation?")
                Console.WriteLine("1. Addition [+]" & vbNewLine & "2. Subtraction [-]" & vbNewLine & "3. Multiplication [x]" & vbNewLine & "4. Division [÷]")

                Do Until userSelect <> Nothing
                    userSelect = CInt(MyActions.ConsoleKeyToNumber())
                Loop

                Select Case userSelect

                    Case 1
                        operation = "+"
                        result = number1 + number2
                    Case 2
                        operation = "-"
                        result = number1 - number2
                    Case 3
                        operation = "x"
                        result = number1 * number2
                    Case 4
                        operation = "÷"
                        result = number1 / number2
                    Case Else
                        operation = "~"

                End Select

            Loop

            'Ask if the user wants to run the calculator process again
            MyActions.PasteTitle(number1, number2, operation, result)
            Console.WriteLine("Your result should be in the header.")
            System.Threading.Thread.Sleep(2000)
            Console.WriteLine("Do you want to compute again?")
            System.Threading.Thread.Sleep(1000)
            Console.WriteLine("Y - N")

            Do Until operation = "~"

                Select Case Console.ReadKey.Key

                    Case ConsoleKey.Y
                        number1 = Nothing
                        number2 = Nothing
                        operation = "~"
                        result = Nothing

                    Case ConsoleKey.N
                        MyActions.PasteTitle(number1, number2, operation, result)
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
