using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tuntiharjoitus 1.
            float numberOne = 4;
            float numberTwo = 3;

            float div = numberOne / numberTwo;
            float mul = numberOne * numberTwo;
            float sub = numberOne - numberTwo;
            float sum = numberOne + numberTwo;

            Console.WriteLine("Jakolasku : " + div);
            Console.WriteLine("Kertolasku : " + mul);
            Console.WriteLine("Vähennyslasku : " + sub);
            Console.WriteLine("Yhteenlasku : " + sum);

            // Tuntiharjoitus 2.
            float a = 3;
            float b = 4;
            float c = (float)Math.Sqrt(Math.Pow(a,2f)+Math.Pow(b,2f));

            Console.WriteLine("Hypotenuusan pituus : " + c);

            // Tuntiharjoitus 3.

            Console.WriteLine("Syötä Etunimesi ja Sukunimesi");
            string fullName = Console.ReadLine();
            String[] nameSplit = fullName.Split(' ');
            Console.WriteLine("Etunimesi : " + nameSplit[0]);
            Console.WriteLine("Sukunimesi : " + nameSplit[1]);

            // Tuntiharjoitus 4.
            Console.WriteLine("aaHypotenuusan pituus : " + Pythagora(3,4));

            // Tuntiharjoitus 5.
            Console.WriteLine("Vastaus : " + MultiplyTen());

            // Tuntiharjoitus 6.
            Console.WriteLine("Syötä Etunimesi ja Sukunimesi");
            fullName = Console.ReadLine();
            nameSplit = fullName.Split(' ');

            if(nameSplit.Length < 2){
                Console.WriteLine("Syötä etu ja sukunimesi");
            } else if (nameSplit.Length > 2){
                Console.WriteLine("Syötä pelkästään etu ja sukunimesi");
            }else{
                Console.WriteLine("Etunimesi : " + nameSplit[0]);
                Console.WriteLine("Sukunimesi : " + nameSplit[1]);
            }
            


        }


        static float Pythagora(float a, float b){

            return (float)Math.Sqrt(Math.Pow(a,2f)+Math.Pow(b,2f));
        }

        static int MultiplyTen(){

            Console.WriteLine("Minka luvun haluat kertoa kymmenellä");
            int number = int.Parse(Console.ReadLine());
            return number * 10;
        }
    }
}
