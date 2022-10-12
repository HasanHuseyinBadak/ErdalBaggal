using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ErdalBaggal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Erdal Baggal ÜRÜN ve SİPARİŞ TAKİP
            #region MENU TABLOSU
            ErdalBaggal[] erdalBakkal = new ErdalBaggal[10];

            erdalBakkal[0] = new ErdalBaggal();
            erdalBakkal[0].secim = 1;
            erdalBakkal[0].menu = "Patates";
            erdalBakkal[0].fiyat = 11.75;
            erdalBakkal[0].birim = "KG";
            erdalBakkal[0].stok = 100;
            erdalBakkal[0].miktar = 1;

            erdalBakkal[1] = new ErdalBaggal();
            erdalBakkal[1].secim = 2;
            erdalBakkal[1].menu = "Domates";
            erdalBakkal[1].fiyat = 16.50;
            erdalBakkal[1].birim = "KG";
            erdalBakkal[1].stok = 200;
            erdalBakkal[1].miktar = 1;

            erdalBakkal[2] = new ErdalBaggal();
            erdalBakkal[2].secim = 3;
            erdalBakkal[2].menu = "Biber";
            erdalBakkal[2].fiyat = 15;
            erdalBakkal[2].birim = "KG";
            erdalBakkal[2].stok = 50;
            erdalBakkal[2].miktar = 1;

            erdalBakkal[3] = new ErdalBaggal();
            erdalBakkal[3].secim = 4;
            erdalBakkal[3].menu = "Kola";
            erdalBakkal[3].fiyat = 17.75;
            erdalBakkal[3].birim = "LT";
            erdalBakkal[3].stok = 350;
            erdalBakkal[3].miktar = 1;

            erdalBakkal[4] = new ErdalBaggal();
            erdalBakkal[4].secim = 5;
            erdalBakkal[4].menu = "Yumurta";
            erdalBakkal[4].fiyat = 3;
            erdalBakkal[4].birim = "Adet";
            erdalBakkal[4].stok = 120;
            erdalBakkal[4].miktar = 1;

            erdalBakkal[5] = new ErdalBaggal();
            erdalBakkal[5].secim = 6;
            erdalBakkal[5].menu = "Ice Tea";
            erdalBakkal[5].fiyat = 16;
            erdalBakkal[5].birim = "LT";
            erdalBakkal[5].stok = 280;
            erdalBakkal[5].miktar = 1;

            erdalBakkal[6] = new ErdalBaggal();
            erdalBakkal[6].secim = 7;
            erdalBakkal[6].menu = "Sigara";
            erdalBakkal[6].fiyat = 38;
            erdalBakkal[6].birim = "PAKET";
            erdalBakkal[6].stok = 1520;
            erdalBakkal[6].miktar = 1;

            erdalBakkal[7] = new ErdalBaggal();
            erdalBakkal[7].secim = 8;
            erdalBakkal[7].menu = "Süt  ";
            erdalBakkal[7].fiyat = 7;
            erdalBakkal[7].birim = "LT";
            erdalBakkal[7].stok = 25;
            erdalBakkal[7].miktar = 1;

            erdalBakkal[8] = new ErdalBaggal();
            erdalBakkal[8].secim = 9;
            erdalBakkal[8].menu = "Cips";
            erdalBakkal[8].fiyat = 15;
            erdalBakkal[8].birim = "PAKET";
            erdalBakkal[8].stok = 628;
            erdalBakkal[8].miktar = 1;

            erdalBakkal[9] = new ErdalBaggal();
            erdalBakkal[9].secim = 10;
            erdalBakkal[9].menu = "Su  ";
            erdalBakkal[9].fiyat = 2;
            erdalBakkal[9].birim = "LT";
            erdalBakkal[9].stok = 400;
            erdalBakkal[9].miktar = 1;

            int adet = 0;
            double toplam = 0;
            string urunler = "";
            string tercih = "e";
            int[] urunNo = new int[10];

            for (int i = 0; i < erdalBakkal.Length; i++)
            {

                Console.WriteLine($"{erdalBakkal[i].secim}-) {erdalBakkal[i].menu}\t : {erdalBakkal[i].fiyat} TL            Kalan STOK = {erdalBakkal[i].stok}");
            }




            #endregion

            #region SİPARİŞ GİRİŞİ ve FİYATLANDIRMA


            Console.WriteLine("         *-* HOŞGELDİNİZ *-* ");
            while (tercih == "e")
            {


                for (int i = 0; i < erdalBakkal.Length; i++)
                {



                    Console.WriteLine("Almak İstediğiniz Ürünü Tuşlayınız");
                    erdalBakkal[i].secim = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Kaç {erdalBakkal[erdalBakkal[i].secim - 1].birim} {erdalBakkal[erdalBakkal[i].secim - 1].menu} Almak İstersiniz");
                    adet = Convert.ToInt32(Console.ReadLine());
                    int kalan = 0;

                    if (kalan >= 0)
                    {


                        Console.WriteLine($"{adet} {erdalBakkal[erdalBakkal[i].secim - 1].birim} {erdalBakkal[erdalBakkal[i].secim - 1].menu} SEPETİNİZE EKLENDİ. ");
                        Console.WriteLine();
                        Console.WriteLine($"{erdalBakkal[erdalBakkal[i].secim - 1].menu} Ürünümüzün Kalan Stok Sayısı {(erdalBakkal[erdalBakkal[i].secim - 1].stok - 1) - (adet - 1)}");
                        kalan = ((erdalBakkal[erdalBakkal[i].secim - 1].stok - 1) - adet) - kalan;
                        urunler = ($"{adet} {erdalBakkal[erdalBakkal[i].secim - 1].birim} ") + (erdalBakkal[erdalBakkal[i].secim - 1].menu) + ", " + urunler;
                        toplam = (erdalBakkal[erdalBakkal[i].secim - 1].fiyat * adet) + toplam;


                    }

                    else
                    {
                        Console.WriteLine($"Seçtiğiniz {erdalBakkal[erdalBakkal[i].secim - 1].menu} Stokta Olmadığından İşleme Devam Edilemiyor..");
                    }
                    



                    break;
                }
                Console.WriteLine("Başka Ürün Almak İster misiniz? e/h ");
                tercih = Console.ReadLine();
            }
            Console.Clear();
            Console.WriteLine($"        Aldığınız Ürünler;");
            Console.WriteLine();
            Console.WriteLine($"{urunler}");
            Console.WriteLine();
            Console.WriteLine($"Toplam = {toplam} TL");
            Console.WriteLine();
            Console.WriteLine("Bizi Tercih Ettiğiniz İçin TEŞEKKÜR EDERİZ:)");


            #endregion


            #endregion
            
        }
    }
}
