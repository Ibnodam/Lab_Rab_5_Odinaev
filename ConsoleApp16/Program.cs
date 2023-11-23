


    try

    {

        Console.Write("Введите текст: ");

        string S = Console.ReadLine();

        int a = 0;

        int counter = 0;

        Digits(S);

        int Digits(string S)

        {



            if (a >= S.Length)

            {

                Console.WriteLine($"Количество цифр в вашем тесте равно {counter}.");

                return counter;

            }

            dig(S);

            void dig(string S)

            {

                if (S[a] == '0' || S[a] == '1' || S[a] == '2' || S[a] == '3' || S[a] == '4' || S[a] == '5' || S[a] == '6' || S[a] == '7' || S[a] == '8' || S[a] == '9')

                {

                    a++;

                    counter++;

                }

                else a++;

            }

            return Digits(S);



        }

    }



    catch (Exception ex)

    { Console.WriteLine(ex.Message); }




