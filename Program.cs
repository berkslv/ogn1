﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_basarisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ders başarısı hesaplama uygulamasına hoş geldiniz ");

            Console.WriteLine("Dersten minimum geçer not nedir ? ");
            string gecernot = Console.ReadLine();

            int gecerlinot = Convert.ToInt32(gecernot);

            Console.WriteLine("Dersin finali ortalamayı yüzde kaç etkiliyor ? ");
            string finaletkisi = Console.ReadLine();
            int finalinetkisi = Convert.ToInt32(finaletkisi);



            Console.WriteLine("Dersin vizesi ortalamayı yüzde kaç etkiliyor ? ");
            string vizeetkisi = Console.ReadLine();
            int vizeninetkisi = Convert.ToInt32(vizeetkisi);


            Console.WriteLine("Dersin ödevleri ve yoklaması ortalamayı yüzde kaç etkiliyor ? ");
            string ödevetkisi = Console.ReadLine();
            int ödevinetkisi = Convert.ToInt32(ödevetkisi);



            Console.WriteLine("Vize notunuzu giriniz ? ");
            string vizenot = Console.ReadLine();

            Console.WriteLine("Final notunuzu giriniz ? ");
            string finalnot = Console.ReadLine();

            Console.WriteLine("Ödev notunuzu giriniz ? ( ödev etkilemiyorsa 0 giriniz ) ");
            string ödevnot = Console.ReadLine();

            int finalinnotu = Convert.ToInt32(finalnot);
            int vizeninnotu = Convert.ToInt32(vizenot);
            int ödevinnotu = Convert.ToInt32(ödevnot);

            int finalsonuc = finalinnotu * finalinetkisi / 100;
            int vizesonuc = vizeninnotu * vizeninetkisi / 100;
            int ödevsonuc = ödevinnotu * ödevinetkisi / 100;

            int ortalama = finalsonuc + vizesonuc + ödevsonuc;
            Console.WriteLine("Ortalamanız: " + ortalama);

            Console.WriteLine("ortalama, finalsonuc, vizesonuc, ödevsonuc: {0} {1} {2} {3}",ortalama, finalsonuc, vizesonuc, ödevsonuc);
            if (ortalama >= 100 && ortalama <= 0)
            {
                Console.WriteLine("Girdiğiniz değerleri gözden geçiriniz değerler 0 ile 100 aralığında olmalı");
            }
            else if (ortalama >= gecerlinot)
            {
                Console.WriteLine(" Tebrikler dersten geçerli not almışsınız ortalamanız : " + ortalama);
            }
            else
            {
                Console.WriteLine("Maalesef dersten geçerli not alamadınız ortalamanız : " + ortalama);
            }

            Console.WriteLine("Uygulamamızı tercih ettiğiniz için teşekkürler ");
        }
    }
}
