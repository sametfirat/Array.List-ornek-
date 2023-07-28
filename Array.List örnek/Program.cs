using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.List_örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList degerler = new ArrayList();
            bool exit = true;

            do
            {

                Console.WriteLine("Değer ekle :1");
                Console.WriteLine("Değer Listele :2");
                Console.WriteLine("Değer ara :3");
                Console.WriteLine("Değer Düzenle :4");
                Console.WriteLine("Değer Sil :5");
                Console.WriteLine("Cıkış:6");
                Console.Write("Yapmak istediğiniz işlemi seciniz:");
                string secim = (Console.ReadLine());
                
                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Eklemek istediğiniz değeri giriniz :");
                        degerler.Add(Console.ReadLine());
                        
                        break;
                        
                    case "2": 
                           //for (int i=0;i<degerler.Count;i++)
                           // Console.WriteLine(degerler[i]);
                           object[] dizi = degerler.ToArray();
                        for (int i = 0; i < dizi.Length; i++)
                        Console.WriteLine(dizi[i]);
                        System.Threading.Thread.Sleep(1000);
                        break;

                    case "3":
                        Console.WriteLine("Aramak istediğiniz değeri giriniz :");
                        object ara = Console.ReadLine();

                        if (degerler.Contains(ara)) 
                        {
                            int a = degerler.IndexOf(ara);
                            Console.WriteLine("Aradığınız değkenin indeksi :"+ a);
                            System.Threading.Thread.Sleep(1000);
                        }
                        else
                        {
                            Console.WriteLine("aradığınız değer bulunmamaktadır");
                            System.Threading.Thread.Sleep(1000);
                        }
                        break;

                    case "4":

                        degerler.Reverse();
                        Console.WriteLine("değerler tersine cevirildi");
                        System.Threading.Thread.Sleep(1000);
                        break;

                     case "5":
                        Console.WriteLine("Silmek istediğiniz değeri girin: ");
                        ara = Console.ReadLine();
                        if (degerler.Contains(ara))
                        {
                            int a = degerler.IndexOf(ara);
                            degerler.RemoveAt(a);
                            Console.WriteLine(a +"'inci değişken silinmiştir ");

                        }
                        else
                            Console.WriteLine( "silmek istediğiniz değer bulunmamaktadır" );
                        System.Threading.Thread.Sleep(1000);
                        break;

                     case "6":
                         exit = false;
                        break;

                     default:
                        Console.WriteLine("Hatalı bir secim yaptınız ");
                        System.Threading.Thread.Sleep(1000) ;
                        break;
                } 
               Console.Clear();
            }
            while (exit);
        }
    }
}
