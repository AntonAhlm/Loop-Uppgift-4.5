using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("skriv in ett heltal : ");
            string heltal = Console.ReadLine();
            
           
                for (int I = 0; I < heltal.Length; I++)
                {
                string talet = "";
                    string tecken = heltal[I].ToString();
                    int siffra = Convert.ToInt32(tecken);


                    if (siffra == 9)
                    {
                        int tal = 0;
                        Console.Write(tal);
                    }
                    else
                    {
                        int tal = siffra + 1;
                        Console.Write(tal);
                    }
                }
        }

    }
}
