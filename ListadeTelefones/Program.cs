using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ListadeTelefones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] arquivos = Directory.GetFiles($"{AppDomain.CurrentDomain.BaseDirectory}Arquivos", "*.txt", SearchOption.AllDirectories);

                Console.WriteLine("Arquivos que possuem numeros de telefone nos formatos (41) 9999-9999 ou (41) 99999-9999 ou (41)99999-9999 ou (41)9999-9999:");
                foreach (string arq in arquivos)
                {
                    List<string> listTelefones = File.ReadAllLines(arq).ToList();

                    var t = listTelefones.Where(x => Regex.IsMatch(x,@"\(\d{2}\)(\s{1}|)\d{4,5}-\d{4}"));

                    if (t.Any())
                    {
                        Console.WriteLine($"Caminho Arquivos: {arq}");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
