// See https://aka.ms/new-console-template for more information
using AbstractVEInterface;

Console.WriteLine("Hello, World!");

WordDocument wordDocument = new WordDocument();
ExcelDocument excelDocument = new ExcelDocument();
PDFDocument pdfDocument = new PDFDocument();    

DocumentPrinter printer =  new DocumentPrinter();
printer.Print(wordDocument);
printer.Print(excelDocument);
//printer.Print(pdfDocument);
