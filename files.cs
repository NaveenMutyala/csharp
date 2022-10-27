using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bd = new byte[200];
            char[] dat = new char[200];
            FileStream fs = new FileStream("C:/Users/exam2/Downloads/data.txt",FileMode.Create);
            dat = "A file is created using a fileStream class".ToCharArray();
            Encoder e = Encoding.UTF8.GetEncoder();
            e.GetBytes(dat, 0, dat.Length, bd, 0, true);
            fs.Seek(0, SeekOrigin.Begin);
            fs.Write(bd, 0, bd.Length);
            fs.Close();
           // Console.WriteLine("Hello There");
           //Reading 
            byte[] bd1 = new byte[200];
            char[] dat1 = new char[200];
            FileStream fs1 = new FileStream("C:/Users/exam2/Downloads/data.txt", FileMode.Open);
            fs1.Seek(0, SeekOrigin.Begin);
            fs1.Read(bd1, 0, 200);
            Decoder d = Encoding.UTF8.GetDecoder();
            d.GetChars(bd1, 0, bd1.Length, dat1, 0);
            Console.WriteLine(dat1);


            Console.ReadKey();

            
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace fileRead
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            FileStream fs = new FileStream("C:/Users/exam2/Downloads/data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line+"This is a line");
                line = sr.ReadLine();
            }
            sr.Close();
            Console.ReadKey();

        }
    }
}
