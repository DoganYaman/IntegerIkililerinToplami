using System;

namespace integer_ikililerin_toplami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen sayı ikililerin adedini giriniz : ");
            int ikiliSayiAdedi = int.Parse(Console.ReadLine());
            int[,] ikiliSayiDizisi = DiziIslemleri.IkiliSayiDizisiOlustur(ikiliSayiAdedi);
            int[] yeniDizi = DiziIslemleri.IkiliSayiDizisiTopla(ikiliSayiDizisi);
            DiziIslemleri.DiziYazdir(yeniDizi);
        }
        
    }
}
