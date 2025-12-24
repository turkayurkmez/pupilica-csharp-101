using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractVEInterface
{

    public interface IPrintable
    {
        void Print();
    }
    public abstract class Document
    {
        public void Copy(string from, string to)
        {
            Console.WriteLine("Dosya kopyalandı");
        }

        public void Move(string from, string to)
        {
            Console.WriteLine("Dosya taşındı");
        }

        public abstract void Load();
        public abstract void Save();

       // public abstract void Print();
      
    }
    public class ExcelDocument : Document, IPrintable
    {
        public override void Load()
        {
            Console.WriteLine("Excel açılıyor");
        }

        public void Print()
        {
            Console.WriteLine("Excel çıktısı alınıyor");

        }

        public override void Save()
        {
            Console.WriteLine("Excel kaydediliyor");

        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Load()
        {
            Console.WriteLine("Word açılıyor");
        }

        public  void Print()
        {
            Console.WriteLine("Word çıktısı alınıyor");

        }

        public override void Save()
        {
            Console.WriteLine("Word kaydediliyor");

        }
    }

    public class PDFDocument : Document
    {
        public override void Load()
        {
            Console.WriteLine("PDF açılıyor");
        }

        //public override void Print()
        //{
        //    Console.WriteLine("PDF çıktısı alınıyor");

        //}

        public override void Save()
        {
            Console.WriteLine("PDF kaydediliyor");

        }

    }

    public class DocumentPrinter
    {
        public void Print(IPrintable document)
        {
            document.Print();
        }
    }
}
