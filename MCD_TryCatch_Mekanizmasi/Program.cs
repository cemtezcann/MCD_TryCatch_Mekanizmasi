using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_TryCatch_Mekanizmasi
{
    class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    int a;
            //    Console.Write("sayi gir:");
            //    a=Convert.ToInt32(Console.ReadLine( ));
            //    Console.WriteLine("Teşekkürler...");
            //}

            //catch(Exception ex)
            //{
            //    Console.WriteLine("hata oluştu.");
            //    Console.WriteLine(DateTime.Now);
            //    Console.WriteLine("Hata:"+ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Burası finally");
            //}

            //#region Try Catch Divide By Zero
            //try
            //{
            //    int bolunen = 200;
            //    int bolen = 0;
            //    int sonuc = bolunen / bolen;
            //    Console.WriteLine(sonuc);
            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine("Hata:Sıfıra bölme hatası oluştu!!!");
            //    Console.WriteLine(DateTime.Now+" "+ex.ToString());
            //}


            //#endregion

            //#region ArgumentException
            //try
            //{
            //    Dictionary<char, string> Kisiler = new Dictionary<char, string>();
            //    Kisiler.Add('k', "esra");
            //    Kisiler.Add('e', "ali mert");

            //    Kisiler.Add('k', "sena");
            //    Kisiler.Add('e', "talha");

            //    Kisiler.Add('k', "gamze");
            //    Kisiler.Add('e', "serdar");


            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.GetType().Name);

            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.GetType().Name);

            //}

            //#endregion

            try
            {
                int[] dizi = new int[] { 0, 1, 2, 3 };
                Console.WriteLine(dizi[10]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Hata");
                Console.WriteLine(DateTime.Now);
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}
