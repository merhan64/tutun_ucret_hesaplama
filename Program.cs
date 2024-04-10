using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tütünde_günlük_çalışma_ücreti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("**** çalışan kimlik bilgileri ****");
            Console.WriteLine();

            string ad, soyad, yer, yas;
            Console.Write("isminiz: ");
            ad = Console.ReadLine();
            Console.Write("soyisminiz: ");
            soyad = Console.ReadLine();
            Console.Write("yaşadığınız yer: ");
            yer = Console.ReadLine();
            Console.Write("yaşınız: ");
            yas = Console.ReadLine();
            Console.WriteLine();

            double tarla, fiyMazot;
            Console.Write("toplam kaç dönüm tütün tarlanız var: ");
            tarla = Convert.ToDouble(Console.ReadLine());
            Console.Write("hesaplamalarda kullanılacak olan mazotun birim fiyatı:");
            fiyMazot = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine();

            // tarla sürmek - hazırlamak
            Console.WriteLine("**** aşağıdaki değerleri tarla hazırlama zamanına göre cevaplayınız! ****");

            double gün1, calısan1, kira, emek1, gider1, gidmazot1;

           

            Console.Write("çalışılan gün sayısı: ");
            gün1 =Convert.ToDouble(Console.ReadLine());

            Console.Write("çalışan kişi sayısı: ");
            calısan1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("dönüm başına kaç litre mazot kullandınız: ");
            gidmazot1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("dönüm başına kaç defa sürme işlemi yapıldı: ");
            double sefer1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("kiraya tarla alındıysa toplam ücreti yazınız: ");
            kira = Convert.ToDouble(Console.ReadLine());


            emek1 = (gün1 * calısan1);
            gider1 = (gidmazot1 * fiyMazot * sefer1 * tarla) + kira;
            Console.Write("bu bölümde masrafınız {0}TL.", gider1);



            Console.WriteLine();
            Console.WriteLine();

            // ocak depmek
            Console.WriteLine("**** aşağıdaki değerleri ocak depimi zamanına göre cevaplayın! ****");

            double gün2, calısan2, emek2, gider2, su, tlSu, gubre, fiyGubre, masNAYLON, masIlac, gidmazot2, paraOcak;

            Console.Write("çalışılan gün sayısı: ");
            gün2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("çalışan kişi sayısı: ");
            calısan2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("kullanılan su miktarı kaç ton: ");
            su = Convert.ToDouble(Console.ReadLine());

            Console.Write("suyun birim fiyatı: ");
            tlSu = Convert.ToDouble(Console.ReadLine());

            Console.Write("kullanılan gübre miktarı: ");
            gubre = Convert.ToDouble(Console.ReadLine());

            Console.Write("gübrenin birim fiyatı: ");
            fiyGubre = Convert.ToDouble(Console.ReadLine());

            Console.Write("naylona yapılan toplam masraf: ");
            masNAYLON = Convert.ToDouble(Console.ReadLine());

            Console.Write("ilaca yapılan toplam masraf: ");
            masIlac = Convert.ToDouble(Console.ReadLine());

            Console.Write("kaç litre mazot kullandınız: ");
            gidmazot2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("fidan ocaklarını sattıysanız, toplam alınan para miktarı: ");
            paraOcak = Convert.ToDouble(Console.ReadLine());

            emek2 = (gün2 * calısan2);
            gider2 = (su * tlSu) + (gubre * fiyGubre) + masNAYLON + masIlac + (gidmazot2 * fiyMazot) - paraOcak;
            Console.Write("bu bölümde toplam masrafınız {0}TL", gider2);

            Console.WriteLine();
            Console.WriteLine();

            // tütün dikimi
            Console.WriteLine("**** aşağıdaki değerleri tütün dikimi zamanına göre cevaplayın! ****");
            double gün3, calısan3, emek3, gider3, gidMazot3, isci, gündelikIsci, su1;


            Console.Write("çalışılan gün sayısı: ");
            gün3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("çalışan kişi sayısı: ");
            calısan3 = Convert.ToDouble(Console.ReadLine());


            Console.Write("dönüm başına kaç litre mazot kullandınız: ");
            gidMazot3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("tarlada su kullandıysanız, toplam kullanılan su miktarı kaç ton: ");
            su1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("dikimde gündelikle kullanılan işçi sayısı: ");
            isci = Convert.ToDouble(Console.ReadLine());

            Console.Write("işçilerin gündelik ücret birim fiyatı: ");
            gündelikIsci = Convert.ToDouble(Console.ReadLine());

            emek3 = (gün3 * calısan3);
            gider3 = (gidMazot3 * fiyMazot * tarla) + (su1 * tlSu) + (isci * gündelikIsci);
            Console.Write("bu bölümde toplam masrafınız {0}TL", gider3);

            Console.WriteLine();
            Console.WriteLine();

            // ilaçlama - çapalama
            Console.WriteLine("**** aşağıdaki değerleri tütün ilaçlama-çapalama zamanına göre cevaplayın! ****");
            double gün4, calısan4, emek4, gider4, masZehir, gidMazot4;

            Console.Write("çalışılan gün sayısı: ");
            gün4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("çalışan kişi sayısı: ");
            calısan4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("dönüm başına kaç litre mazot kullandınız: ");
            gidMazot4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("toplam yapılan zehir, ilaç vs masrafları: ");
            masZehir = Convert.ToDouble(Console.ReadLine());

            emek4 = (gün4 * calısan4);
            gider4 = (gidMazot4 * tarla * fiyMazot) + masZehir;
            Console.Write("bu bölümde toplam masrafınız {0}TL", gider4);


            Console.WriteLine();
            Console.WriteLine();

            // tütün kırımı
            Console.WriteLine("**** aşağıdaki değerleri tütün kırma zamanına göre cevaplayın! ****");
            double gün5, calısan5, emek5, gider5, gidmazot5, isci1, gundelikIsci1;


            Console.Write("çalışılan gün sayısı: ");
            gün5 = Convert.ToDouble(Console.ReadLine());

            Console.Write("çalışan kişi sayısı: ");
            calısan5 = Convert.ToDouble(Console.ReadLine());

            Console.Write("toplam harcanan mazot yaklaşık kaç litre: ");
            gidmazot5 = Convert.ToDouble(Console.ReadLine());

            Console.Write("eğer işçi kullanıldıysa kaç gündelik işçi çalıştırıldı:  ");
            isci1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("çalışan işçilerin gündelik ücreti: ");
            gundelikIsci1 = Convert.ToDouble(Console.ReadLine());

            emek5 = calısan5 * gün5;
            gider5 = (gidmazot5 * fiyMazot) + (isci1 * gundelikIsci1);
            Console.Write("bu bölümde toplam masrafınız {0}TL", gider5);


            Console.WriteLine();
            Console.WriteLine();

            // tütün paketleme
            Console.WriteLine("**** aşağıdaki değerleri tütün paketleme zamanına göre cevaplayın! ****");
            double gün6, calısan6, emek6, gider6;

            Console.Write("çalışılan gün sayısı: ");
            gün6 = Convert.ToDouble(Console.ReadLine());

            Console.Write("çalışan kişi sayısı: ");
            calısan6 = Convert.ToDouble(Console.ReadLine());

            Console.Write("yapılan herhangi bir masraf varsa, kaç TL: ");
            gider6 = Convert.ToDouble(Console.ReadLine());


            emek6 = gün6 * calısan6;
            Console.Write("bu bölümde toplam masrafınız {0}TL", gider6);


            Console.WriteLine();
            Console.WriteLine();

            //sigorta
            Console.Write("ailede tütün işinde genel olarak çalışan kaç kişi var: ");
            double topCalısan, topAY, sigorta, gidSigorta;

            topCalısan = Convert.ToDouble(Console.ReadLine());
            topAY = (gün1 + gün2 + gün3 + gün4 + gün5 + gün6) / 30;
            Console.Write("sigorta giderlerini hesaplamak için aylık bağkur primini yazınız: ");
            sigorta = Convert.ToDouble(Console.ReadLine());
            gidSigorta = (topAY * topCalısan * sigorta);

            Console.Write("ailenin toplam sigorta gideri {0}TL!", gidSigorta);


            Console.WriteLine();
            Console.WriteLine();

            // gelir - gider
            double fiyatkg, tütünkg, topGelir, topGider, kalan, gunKarsılıgı;

            Console.Write("toplam işlenilen tütün kaç kg: ");
            tütünkg = Convert.ToDouble(Console.ReadLine());
            Console.Write("satacağınız tütünün kg fiyatı: ");
            fiyatkg= Convert.ToDouble(Console.ReadLine());
            topGelir = (tütünkg * fiyatkg);
            topGider = (gider1 + gider2 + gider3 + gider3 + gider4 + gider5 + gider6 + gidSigorta);
            kalan = topGelir - topGider;
            gunKarsılıgı = kalan / (emek1 + emek2 + emek3 + emek4 + emek5 + emek6);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("**** SONUÇ EKRANI ****");

           Console.WriteLine("Sayın {0} {1} ({2}) ({3}) ", ad, soyad, yas, yer);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("{0} kg tütünden elde edilen toplam geliriniz {1}TL.", tütünkg, topGelir);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Bu süreçte yapılan toplam masraf {0}", topGider);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Tütün işinde 1 yılda size kalan net para {0}TL.", kalan);


            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ailenizde 1 kişinin 1 günde çalışmasının karşılığı {0}TL.", gunKarsılıgı);


            Console.WriteLine();
            Console.WriteLine();

            Console.Read();
        }
    }
}
