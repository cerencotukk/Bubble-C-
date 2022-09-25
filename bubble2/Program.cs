using System;

namespace bubble2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] sayilar = new int[] { 34, 87, 3, 87, 40, 65, 13, 74, 90, 81, 5, 99 };
           
            foreach (var item in sayilar)
            {
                Console.WriteLine(item + " ");

            }


            for (int i =0; i<sayilar.Length; i++)

            {
                for (int j=0; j<sayilar.Length; j++)
                {
                    if (sayilar[i] < sayilar[j])

                    {
                        int temp;

                        temp = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = temp;
                    }
                }
            }

            Console.Write("Sayıların sıralanmış halleri: ");
            Console.WriteLine("\n");
            foreach (var item in sayilar)
            {
                Console.Write(item + " ");

            }
            Console.ReadKey();
        }

    }
}
