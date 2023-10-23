using System;
using System.IO;

namespace LeituraDeInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\dnlus\OneDrive\Documentos\Numeros.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    int contador = 0;
                    int sum = 0;
                    while (!sr.EndOfStream)
                    {
                        var num = int.Parse(sr.ReadLine());
                        sum += num;
                        contador++;

                    }

                    var average = sum / contador;
                    Console.WriteLine("A média é: " + average);

                }
            }catch (IOException ex) 
            {
                Console.WriteLine("Erro ao tentar abrir o arquivo");
                Console.WriteLine(ex.Message);
            }

        }
    }
}