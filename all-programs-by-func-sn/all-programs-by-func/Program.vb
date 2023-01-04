Imports System
Imports System.Runtime.Intrinsics.X86

Module Program
    Sub Main(args As String())

        Dim go_out As Integer

        Do


            Dim z_in As String
            Console.WriteLine("choose from the following options:")
            Console.WriteLine("taking average of 3 numbers type avg")
            Console.WriteLine("to use the calculator type calc")
            Console.WriteLine("to have the tree type tree")
            Console.WriteLine("to see our menu type menu")
            Console.WriteLine("to have the words of the numbers type num")
            Console.WriteLine("to have the phoone book type book")
            z_in = Console.ReadLine()
            Select Case z_in
                Case "avg"

                    Dim number1 As Integer
                    Dim number2 As Integer
                    Dim number3 As Integer
                    Dim total As Integer
                    Dim Avg As Integer

                    Console.Write("enter the first number:")
                    number1 = Convert.ToInt32(Console.ReadLine())
                    Console.Write("enter the second number:")
                    number2 = Convert.ToInt32(Console.ReadLine())
                    Console.Write("enter the third number:")
                    number3 = Convert.ToInt32(Console.ReadLine())

                    If IsNumeric(number1 And number2 And number3) Then


                        Avg = Findavg(number1, number2, number3)
                        Console.WriteLine("the Avg is:" & Avg)


                    Else
                        Console.WriteLine("the invalid input")

                    End If


                    If IsNumeric(number1 And number2 And number3) Then


                        total = Findtotal(number1, number2, number3)
                        Console.WriteLine("the total is:" & total)

                    Else
                        Console.WriteLine("the invalid input")

                    End If










                Case "calc"

                    Dim firstnum, secondnum, answer As Integer
                    Dim ops As String
                    Dim EX As Integer



                    Do

                        Console.WriteLine("Enter first number" + vbNewLine)
                        firstnum = Console.ReadLine()
                        If IsNumeric(firstnum) = True Then

                            Console.WriteLine("Enter second number" + vbNewLine)
                            secondnum = Console.ReadLine()


                            If IsNumeric(secondnum) = True Then


                                Console.WriteLine("select an operator:" + vbNewLine)
                                Console.WriteLine("A stands for addition" + vbNewLine)
                                Console.WriteLine("S stands for Substraction" + vbNewLine)
                                Console.WriteLine("M stands for Multiplication" + vbNewLine)
                                Console.WriteLine("MOD stands for Modulo" + vbNewLine)
                                Console.WriteLine("D stands for Division" + vbNewLine)
                                Console.WriteLine("p stands for power" + vbNewLine)
                                ops = Console.ReadLine()




                                If (ops = "A") Then
                                    answer = calc_add(firstnum, secondnum)
                                ElseIf (ops = "S") Then
                                    answer = calc_sub(firstnum, secondnum)
                                ElseIf (ops = "M") Then
                                    answer = calc_mult(firstnum, secondnum)
                                ElseIf (ops = "POW") Then
                                    answer = calc_pow(firstnum, secondnum)
                                ElseIf (ops = "MOD") Then
                                    answer = calc_mod(firstnum, secondnum)
                                ElseIf (ops = "D") Then
                                    answer = calc_div(firstnum, secondnum)


                                Else
                                    Console.WriteLine("NOT A VALID OPERATOR" + vbNewLine)
                                    Console.ReadKey()

                                End If
                                Console.Write("The answer is:" & firstnum & " " & ops & " " & secondnum & "=" & answer)
                                Console.ReadLine()
                            Else
                                Console.WriteLine("NOT A VALID entry" + vbNewLine)
                                Console.ReadKey()
                            End If
                        Else
                            Console.WriteLine("NOT A VALID entry" + vbNewLine)
                            Console.ReadKey()
                        End If





                        Console.WriteLine("IF YOU SELECT 0 YOU CAN EXIT BUT IF 1 you can do your calculation" + vbNewLine)
                        EX = Console.ReadLine()

                    Loop While EX = 1

                    Console.WriteLine("GOODBYE" + vbNewLine)
                    Console.ReadLine()




                Case "tree"

                    Dim your_num As Integer
                    Console.Write("enter the  number:")
                    your_num = Console.ReadLine()

                    Tree(your_num)


                Case "menu"

                    Dim EX As Integer

                    Do
                        Dim answer As String
                        Console.WriteLine("do you want to add new item: if yes type yes and if no type no")
                        answer = Console.ReadLine()




                        If answer = "yes" Then
                            menu2d()

                        ElseIf answer = "no" Then

                            Console.WriteLine("thank you")
                            Console.ReadKey()

                        End If



                        Console.WriteLine("IF YOU SELECT 0 YOU CAN EXIT BUT IF 1 you can ADD to the menu")
                        EX = Console.ReadLine()

                    Loop While EX = 1




                Case "num"

                    Dim number_in As Integer
                    Console.WriteLine("enter a number between 0 and 1000:")
                    number_in = Console.ReadLine()

                    num2word(number_in)



                Case "book"

                    Console.WriteLine("**************welcome to phone book********************")

                    Dim opt As Integer = 1
                    Dim ex_1 As Integer
                    Dim ex_2 As Integer
                    Dim ex_3 As Integer
                    Dim inp As String











                    Do



                        Console.WriteLine("if you want to add new contact type add")
                        Console.WriteLine("if you want to delete a contact type delete")
                        Console.WriteLine("if  you want to update a contact type update ")
                        Console.WriteLine("if you want to display contacts type display ")
                        Console.WriteLine("if you want to exit type exit")
                        inp = Console.ReadLine()


                        Select Case inp

                            Case "add"


                                Do

                                    add_phone()

                                    Console.WriteLine("do you want to add new contact? if yes type 1 if no type 0")
                                    ex_1 = Console.ReadLine()

                                Loop While ex_1 = 1


                            Case "delete"

                                Do


                                    delete_phone()

                                    Console.WriteLine("do you want to delete another contact? if yes type 1 if no type 0")
                                    ex_2 = Console.ReadLine()

                                Loop While ex_2 = 1


                            Case "update"

                                Do




                                    Console.WriteLine("do you want to update another contact? if yes type 1 if no type 0")
                                    ex_3 = Console.ReadLine()

                                Loop While ex_3 = 1





                            Case "display"

                                display_phone()



                            Case "exit"

                                Console.WriteLine("do you want to exit? if yes type 1 if no type 0")
                                opt = Console.ReadLine()

                        End Select



                    Loop While opt = 1










                Case Else
                    Console.WriteLine("invalid option, try again later")
                    Console.Read()



            End Select





            Console.WriteLine("do you want to RETURN  to the MAIN MENU? if yes type 1 else 0")
            go_out = Console.ReadLine()

        Loop While go_out = 1

        Console.WriteLine("*********GOODBYE*********")

    End Sub


    Function Findavg(ByVal num1 As Integer, ByVal num2 As Integer, ByVal num3 As Integer) As Integer
        ' local variable declaration */
        Dim result As Integer
        result = (num1 + num2 + num3) / 3
        Findavg = result
    End Function

    Function Findtotal(ByVal num1 As Integer, ByVal num2 As Integer, ByVal num3 As Integer) As Integer
        ' local variable declaration */
        Dim result_total As Integer
        result_total = (num1 + num2 + num3)
        Findtotal = result_total
    End Function


    Function calc_add(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        ' local variable declaration */
        Dim result As Integer

        result = num1 + num2
        calc_add = result
    End Function

    Function calc_sub(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        ' local variable declaration */
        Dim result As Integer

        result = num1 - num2
        calc_sub = result
    End Function

    Function calc_div(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        ' local variable declaration */
        Dim result As Integer

        result = num1 / num2
        calc_div = result
    End Function
    Function calc_mult(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        ' local variable declaration */
        Dim result As Integer

        result = num1 * num2
        calc_mult = result
    End Function
    Function calc_mod(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        ' local variable declaration */
        Dim result As Integer

        result = num1 Mod num2
        calc_mod = result
    End Function
    Function calc_pow(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        ' local variable declaration */
        Dim result As Integer

        result = num1 ^ num2
        calc_pow = result
    End Function

    Sub Tree(ByVal z As Integer)
        'local variable declaration
        Dim i, j, m As Integer



        For i = 0 To z / 2
            Console.Write(Space(z / 2 - i))

            For j = 0 To (i)
                Console.Write("*")
                m = m + 1
                If m = z Then
                    Exit For
                End If

            Next j
            Console.WriteLine()
            If m = z Then
                Exit For
            End If
        Next i
        Console.ReadLine()

    End Sub

    Sub menu2d()

        Dim menu As New ArrayList
        Dim NEW_OPTION As String
        menu.Add(" kebab    9.99  5")
        menu.Add(" beef    6.99   7")
        menu.Add(" chiken    4.65  9")
        menu.Add(" beer    0.99   10")




        Console.WriteLine("enter the new item:")
        NEW_OPTION = Console.ReadLine()
        menu.Add(NEW_OPTION)



        Dim menu_array() As Object = menu.ToArray()

        For i As Integer = 0 To 4

            Console.WriteLine("item{0} = {1}", i, menu_array(i))

        Next
    End Sub
    Sub num2word(ByVal input_in As Integer)




        Dim mod_result As Integer
        Dim div_result As Integer
        Dim mod_result_1 As Integer
        Dim div_result_1 As Integer
        Dim array_index As Integer
        Dim array_index_1 As Integer
        Dim array_index_2 As Integer


        Dim output_array = New String() {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thertheen", "fourtheen", "sixtheen", "seventeen", "eighteen", "nineteen"}


        Dim output_array_digit(1000) As String
        output_array_digit(20) = "twenty"
        output_array_digit(30) = "thirty"
        output_array_digit(40) = "fourty"
        output_array_digit(50) = "fifty"
        output_array_digit(60) = "sixty"
        output_array_digit(70) = "seventy"
        output_array_digit(80) = "eighty"
        output_array_digit(90) = "ninty"
        output_array_digit(100) = "one hundred"
        output_array_digit(200) = "two hundred"
        output_array_digit(300) = "three hundred"
        output_array_digit(400) = "four hundred"
        output_array_digit(500) = "five hundred"
        output_array_digit(600) = "six hundred"
        output_array_digit(700) = "seven hundred"
        output_array_digit(800) = "eight hundred"
        output_array_digit(900) = "nine hundred"





        Select Case input_in
            Case 100 To 1000
                div_result_1 = input_in \ 100
                array_index = div_result_1 * 100

                mod_result_1 = input_in Mod 100
                array_index_1 = mod_result_1 \ 10
                array_index_2 = mod_result_1 Mod 10

                Console.WriteLine("the converted number is: " & output_array_digit(array_index) & " " & output_array_digit(array_index_1 * 10) & " " & output_array(array_index_2))
                Console.ReadKey()
            Case 30

                Console.WriteLine("the converted number is: thirty")
                Console.ReadKey()

            Case 40

                Console.WriteLine("the converted number is: fourty")
                Console.ReadKey()


            Case 50
                Console.WriteLine("the converted number is: fifty")
                Console.ReadKey()

            Case 60
                Console.WriteLine("the converted number is: sixty")
                Console.ReadKey()


            Case 70
                Console.WriteLine("the converted number is: seventy")
                Console.ReadKey()


            Case 80
                Console.WriteLine("the converted number is: eitghy")
                Console.ReadKey()


            Case 90
                Console.WriteLine("the converted number is:ninty")
                Console.ReadKey()


            Case 100
                Console.WriteLine("the converted number is: one hundred")
                Console.ReadKey()


            Case 200
                Console.WriteLine("the converted number is: two hundred")
                Console.ReadKey()

            Case 300
                Console.WriteLine("the converted number is: three hundred")
                Console.ReadKey()


            Case 400
                Console.WriteLine("the converted number is: four hundred")
                Console.ReadKey()


            Case 500
                Console.WriteLine("the converted number is: five hundred")
                Console.ReadKey()


            Case 600
                Console.WriteLine("the converted number is: six hundred")
                Console.ReadKey()


            Case 700
                Console.WriteLine("the converted number is: seven hundred")
                Console.ReadKey()


            Case 800
                Console.WriteLine("the converted number is: eight hundred")
                Console.ReadKey()



            Case 900
                Console.WriteLine("the converted number is: nine hundred")
                Console.ReadKey()


                Console.WriteLine("the converted number is: one thousand")
                Console.ReadKey()


            Case 0 To 19
                Select Case input_in
                    Case 0

                        Console.WriteLine("the converted number is: zero")
                        Console.ReadKey()
                    Case 1

                        Console.WriteLine("the converted number is: one")
                        Console.ReadKey()


                    Case 2

                        Console.WriteLine("the converted number is: two")
                        Console.ReadKey()

                    Case 3

                        Console.WriteLine("the converted number is: three")
                        Console.ReadKey()
                    Case 4

                        Console.WriteLine("the converted number is: four")
                        Console.ReadKey()
                    Case 5


                        Console.WriteLine("the converted number is: five")
                        Console.ReadKey()
                    Case 6

                        Console.WriteLine("the converted number is: six")
                        Console.ReadKey()
                    Case 7

                        Console.WriteLine("the converted number is: seven")
                        Console.ReadKey()
                    Case 8

                        Console.WriteLine("the converted number is: eight")
                        Console.ReadKey()
                    Case 9

                        Console.WriteLine("the converted number is: nine")
                        Console.ReadKey()
                    Case 10

                        Console.WriteLine("the converted number is: ten")
                        Console.ReadKey()

                    Case 11
                        Console.WriteLine("the converted number is: eleven")
                        Console.ReadKey()
                    Case 12
                        Console.WriteLine("the converted number is: twleve")
                        Console.ReadKey()
                    Case 13
                        Console.WriteLine("the converted number is: thirteen")
                        Console.ReadKey()
                    Case 14
                        Console.WriteLine("the converted number is:fourteen")
                        Console.ReadKey()
                    Case 15
                        Console.WriteLine("the converted number is: fifteen")
                        Console.ReadKey()
                    Case 16
                        Console.WriteLine("the converted number is: sixteen")
                        Console.ReadKey()
                    Case 17
                        Console.WriteLine("the converted number is: seventeen")
                        Console.ReadKey()
                    Case 18
                        Console.WriteLine("the converted number is: eighteen")
                        Console.ReadKey()
                    Case 19
                        Console.WriteLine("the converted number is: nineteen")
                        Console.ReadKey()


                End Select



            Case 21 To 29

                div_result = input_in \ 10
                mod_result = input_in Mod 10

                Console.WriteLine("the converted number is: " & output_array_digit(div_result * 10) & " " & output_array(mod_result))
                Console.ReadKey()


            Case 31 To 39
                div_result = input_in \ 10
                mod_result = input_in Mod 10

                Console.WriteLine("the converted number is: " & output_array_digit(div_result * 10) & " " & output_array(mod_result))
                Console.ReadKey()



            Case 41 To 49
                div_result = input_in \ 10
                mod_result = input_in Mod 10

                Console.WriteLine("the converted number is: " & output_array_digit(div_result * 10) & " " & output_array(mod_result))
                Console.ReadKey()



            Case 51 To 59
                div_result = input_in \ 10
                mod_result = input_in Mod 10

                Console.WriteLine("the converted number is: " & output_array_digit(div_result * 10) & " " & output_array(mod_result))
                Console.ReadKey()



            Case 61 To 69
                div_result = input_in \ 10
                mod_result = input_in Mod 10

                Console.WriteLine("the converted number is: " & output_array_digit(div_result * 10) & " " & output_array(mod_result))
                Console.ReadKey()



            Case 71 To 79
                div_result = input_in \ 10
                mod_result = input_in Mod 10

                Console.WriteLine("the converted number is: " & output_array_digit(div_result * 10) & " " & output_array(mod_result))
                Console.ReadKey()



            Case 81 To 89
                div_result = input_in \ 10
                mod_result = input_in Mod 10

                Console.WriteLine("the converted number is: " & output_array_digit(div_result * 10) & " " & output_array(mod_result))
                Console.ReadKey()



            Case 91 To 99
                div_result = input_in \ 10
                mod_result = input_in Mod 10

                Console.WriteLine("the converted number is: " & output_array_digit(div_result * 10) & " " & output_array(mod_result))
                Console.ReadKey()
        End Select
    End Sub

    Sub add_phone()
        Dim menu As ArrayList = New ArrayList()
        menu.Add("0) mary lavine, 5143789843")
        menu.Add("1) sarah mrcdi, 5143786543")
        menu.Add("2) shan lavine, 5143789843")
        menu.Add("3) mehr shokri, 5143789225")

        Dim add_in As String
        Console.WriteLine("enter the first_name  last_name,phone_number")
        add_in = Console.ReadLine()
        menu.Add(add_in)
        Console.WriteLine("how many contact number you have?: {0}", menu.Count)

        For Each i As String In menu
            Console.WriteLine("{0} ", i)
        Next i
        Console.WriteLine()
        Console.ReadKey()

    End Sub


    Sub delete_phone()
        Dim menu As ArrayList = New ArrayList()
        menu.Add("0) mary lavine, 5143789843")
        menu.Add("1) sarah mrcdi, 5143786543")
        menu.Add("2) shan lavine, 5143789843")
        menu.Add("3) mehr shokri, 5143789225")
        Dim input_delete As Integer
        Console.WriteLine("which contact do you want to remove: type its number")
        input_delete = Console.ReadLine()
        Console.WriteLine(menu(input_delete))
        menu.RemoveAt(input_delete)


        Console.WriteLine("how many contact number you have?: {0}", menu.Count)

        For Each i As String In menu
            Console.WriteLine("{0} ", i)
        Next i
        Console.WriteLine()
        Console.ReadKey()

    End Sub

    Sub update_phone()
        Dim menu As ArrayList = New ArrayList()
        menu.Add("0) mary lavine, 5143789843")
        menu.Add("1) sarah mrcdi, 5143786543")
        menu.Add("2) shan lavine, 5143789843")
        menu.Add("3) mehr shokri, 5143789225")
        Dim new_input As String
        Dim input_update As String
        Console.WriteLine("how many contact number you have?: {0}", menu.Count)

        For Each i As String In menu
            Console.WriteLine("{0} ", i)
        Next i
        Console.WriteLine()
        Console.ReadKey()




        'Dim array() As Object = menu.ToArray()


        Console.WriteLine("which contact do you want to update: type its number")
        input_update = Console.ReadLine()


        Console.WriteLine("enter   the new first name and last name and number")
        new_input = Console.ReadLine()

        menu.Insert(input_update, new_input)
        menu.RemoveAt(input_update + 1)
    End Sub


    Sub display_phone()
        Dim menu As ArrayList = New ArrayList()
        menu.Add("0) mary lavine, 5143789843")
        menu.Add("1) sarah mrcdi, 5143786543")
        menu.Add("2) shan lavine, 5143789843")
        menu.Add("3) mehr shokri, 5143789225")


        Console.WriteLine("*********contact list********")

        For Each i As String In menu
            Console.WriteLine(i)
        Next i

        Console.ReadLine()

    End Sub








End Module
