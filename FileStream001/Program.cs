using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileStream001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Pasta = @"C:\Curso C\Arquivo01.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                //fs = new FileStream(Pasta,FileMode.Open);
                
                sr = File.OpenText(Pasta);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);

                }
              
            }
            catch (IOException e) {
                Console.WriteLine("Um erro ocorreu!!" + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                  //  if(fs !=null) fs.Close();
                }
            }
        }
    }

