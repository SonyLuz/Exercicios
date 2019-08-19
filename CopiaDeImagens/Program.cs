using System;
using System.Collections.Generic;
using System.IO;

namespace CopiaDeImagens
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Imagens";
            
            if(!DiretorioExiste(path))
            {
                if (CriarDiretorio(path))
                {
                    if (CopiarImagens(path))
                    {
                        Console.WriteLine("Copia realizada");
                    }
                }
            }
            else
            {
                Console.WriteLine("Diretório já existe, será iniciado a cópia das imagens.");
                if (CopiarImagens(path))
                {
                    Console.WriteLine("Copia realizada");
                }
            }

            Console.ReadKey();
        }

        public static bool DiretorioExiste(string path)
        {
            try
            {
                if(!string.IsNullOrEmpty(path))
                {
                    return Directory.Exists(path);
                }

                return false;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                return false;
            }
        }

        public static bool CriarDiretorio(string path)
        {
            try
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine($"Diretório criado em {path}");
                return true;             
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
            
        }

        public static bool CopiarImagens(string path)
        {
            try
            {
                string[] imagens = Directory.GetFiles($"{AppDomain.CurrentDomain.BaseDirectory}Arquivos", "*.jpg", SearchOption.AllDirectories);
                foreach(var i in imagens)
                {
                    string nameFile = Path.GetFileName(i);
                    File.Copy(i, $"{path}/{nameFile}", true);
                }                
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return false;
            }
        }
    }
}
