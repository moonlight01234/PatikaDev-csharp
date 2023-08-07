using System;
using System.Drawing;
using BarcodeLib;
using BarcodeStandard;
using ZXing;


namespace consoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Barkod: ");
            string barkodd = Console.ReadLine();

            writeBarcode(barkodd);
            readBarcode();
        }

        static void writeBarcode(string word)
        {
            Barcode barcode = new Barcode();

            Image img = barcode.Encode(TYPE.CODE128, word); 

            Bitmap bmp = new Bitmap(img);

            string filePath = @"C:\kullanici\barcode.png";

            bmp.Save(filePath);
        }

        static void readBarcode()
        {

            BarcodeReader barcodeReader = new BarcodeReader(); 

            barcodeReader.Options.TryHarder = true; 

            var barcodeBitMap = new Bitmap(@"C:\kullanici\barcode.png");

            if (barcodeReader.Decode(barcodeBitMap) != null) 
                Console.WriteLine("Barkod içeriği: " + barcodeReader.Decode(barcodeBitMap).Text);

            Console.ReadKey();
        }
    }
}
