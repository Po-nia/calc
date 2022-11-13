using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //info dla użytkownika
            Console.WriteLine("Co chcesz zrobić?");
            Console.WriteLine("dodawanie - naciśnij 1");
            Console.WriteLine("odejmowanie - naciśnij 2");
            Console.WriteLine("mnożenie - naciśnij 3");
            Console.WriteLine("dzielenie - naciśnij 4");
            int action = Convert.ToInt32(Console.ReadLine());

            if (action > 4)
            {
                Console.WriteLine("Wybrałeś złą cyfrę, game over");
            }
            else
            {

                //pobranie liczb od użytkownika
                Console.WriteLine("Podaj pierwszą liczbę");
                float input1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Podaj drugą liczbę");
                float input2 = float.Parse(Console.ReadLine());

                float result = 0;

                if (action == 4 && input2 == 0)
                {
                    Console.WriteLine("Nie dziel przez zero, tak nie wolno");
                }


                switch (action)
                {
                    case 1:
                        {
                            result = Dodawanie(input1, input2);
                            break;
                        }

                    case 2:
                        {
                            result = Odejmowanie(input1, input2);
                            break;
                        }

                    case 3:
                        {
                            result = Mnozenie(input1, input2);
                            break;
                        }

                    case 4:
                        {
                            result = Dzielenie(input1, input2);
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Błąd, spróbuj ponownie");
                            break;
                        }
                }

                Console.WriteLine("Wynik to {0}", result);
                Console.ReadKey();
            }


            //Dodawanie
            static float Dodawanie(float input_1, float input_2)
            {
                float result = input_1 + input_2;
                return result;

            }

            //Odejmowanie
            static float Odejmowanie(float input_1, float input_2)
            {
                float result = input_1 - input_2;
                return result;
            }

            //Mnozenie  
            static float Mnozenie(float input_1, float input_2)
            {
                float result = input_1 * input_2;
                return result;
            }

            //Dzielenie 
            static float Dzielenie(float input_1, float input_2)
            {
                float result = input_1 / input_2;
                return result;
            }
        }
        }
    }
