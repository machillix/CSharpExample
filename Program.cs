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
            
            // Tuntiharjoitus 7.
            Console.WriteLine("Anna Pituusesi");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("Anna Painosi");
            float weight = float.Parse(Console.ReadLine());

            float bmi = weight/(height*height);
            string desc = "";
            if(bmi < 19){
                desc = "alipainoinen";
            } else if (bmi < 25){
                desc = "normaalipainoinen";
            }else{
                desc = "ylipainoinen";
            }

            Console.WriteLine("Paino Indeksi on : " + bmi + " Olet " + desc);

            // Harjoitus 8.
            Console.WriteLine("5 "+IsDivTwoAndSeven(5));
            Console.WriteLine("14 "+IsDivTwoAndSeven(14));

            // Harjoitus 9.

            Console.WriteLine("Anna viikonpäivä numerona");
            int dayNumber = int.Parse(Console.ReadLine());
            
            switch(dayNumber){
                case 1:{
                    Console.WriteLine("Maanantai");
                    break;
                }
                case 2:{
                    Console.WriteLine("Tiistai");
                    break;
                }
                case 3:{
                    Console.WriteLine("Keskiviikko");
                    break;
                }
                case 4:{
                    Console.WriteLine("Torstai");
                    break;
                }
                case 5:{
                    Console.WriteLine("Perjantai");
                    break;
                }
                case 6:{
                    Console.WriteLine("Lauantai");
                    break;
                }
                case 7:{
                    Console.WriteLine("Sunnuntai");
                    break;
                }
                default:{
                    Console.WriteLine("Ei viikonpäivä");
                    break;
                }
            }

            // Harjoitus 10.

            char ascii = (char)0;

            while(ascii != (char)118){
                Console.WriteLine(ascii);
                ascii++;
            }

            // Harjoitus 11.
            string[] days = {"Ma","Ti","Ke","To","Pe","La","Su"};

            for(int i = 0; i < days.Length;i++){
                Console.WriteLine(days[i]);

            }
            // Harjoitus 12.
            foreach(String day in days){
                Console.WriteLine(day);
            } 


        }

        static string IsDivTwoAndSeven(int number){

            string answer = "on ei ole jaollinen 2:lla ja 7:lla";
            if(number % 2 == 0 && number % 7 == 0){
                answer = "on on jaollinen 2:lla ja 7:lla";
            }
            return answer;
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
