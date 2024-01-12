using System;

namespace integer_ikililerin_toplami
{
    public static class DiziIslemleri
    {
        public static int[,] IkiliSayiDizisiOlustur(int ikiliSayiAdedi)
        {
            
            int[,] ikiliSayiDizisi = new int[ikiliSayiAdedi,2];

            for (int i = 0; i < ikiliSayiDizisi.GetLength(0); i++)
            {
                for (int j = 0; j < ikiliSayiDizisi.GetLength(1); j++)
                {
                    Console.Write($"{i + 1}. sayı ikilisinin {j + 1}. değerini giriniz : ");
                    ikiliSayiDizisi[i,j] = int.Parse(Console.ReadLine());
                }
            }

            return ikiliSayiDizisi;
        }

        public static int[] IkiliSayiDizisiTopla(int[,] dizi)
        {
            int[] yeniDizi = new int[dizi.GetLength(0)];
            for (int i = 0; i < yeniDizi.Length; i++)
            {
                if(dizi[i,0] == dizi[i,1])
                    yeniDizi[i] = ToplamininKaresi(dizi[i,0], dizi[i,1]);
                else
                    yeniDizi[i] = Toplami(dizi[i,0], dizi[i,1]);
            }

            return yeniDizi;
        }

        public static void DiziYazdir(int[] dizi)
        {
            Console.Write("Çıktı : ");
            foreach (int sayi in dizi)
            {
                Console.Write(sayi + " ");
            }
        }
        private static int Toplami(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        private static int ToplamininKaresi(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam * toplam;
        }
    }
}