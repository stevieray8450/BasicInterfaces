using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{
    interface IStorable
    {
        void Save();
        void Load();
    }

    interface IPrintable
    {
        void Print();
    }

    class Document : IStorable, IPrintable
    {
        public void Save()
        {
            Console.WriteLine("Document saved");
        }
        public void Load()
        {
            Console.WriteLine("Document loaded");
        }
        public void Print()
        {
            Console.WriteLine("Document printing");
        }
    }

    class Image : Document
    {
        public void Print()
        {
            Console.WriteLine("Image printed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document();
            d.Save();
            d.Load();
            d.Print();

            Console.WriteLine("*********************");

            Image i = new Image();
            i.Save();
            i.Load();
            i.Print();
        }
    }
}
