using Microsoft.AspNetCore.Mvc;
using ArchitectureWebSite.Models;


namespace DenemeProje.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detay(int proje)
        {
            // Örnek proje verisi
            var projeler = new Dictionary<int, (string Resim, string Aciklama)>
{
    { 1, ("proje1.jpg",
          "Bu proje, modern ofis binalarýnýn inþa edilmesi amacýyla baþlatýlmýþtýr. Ýlk aþamada, arazi analizi ve zemin etüdü yapýlmýþtýr. Zemin etüdü sonrasýnda, yapý için uygun temeller seçilmiþtir. Temel inþaatý sýrasýnda, derin kazý iþlemleri yapýlmýþ ve betonarme temeller dökülmüþtür. Yapý betonarme karkas sistemiyle inþa edilmektedir. Çelik ve betonarme taþýyýcý sistemler kullanýlarak, her kat için güvenli bir yapý sistemi saðlanmýþtýr. Elektrik, su ve havalandýrma tesisatlarý, uzman ekipler tarafýndan dikkatle döþenmiþ ve inþaat sürecinin her aþamasýnda kalite kontrolü yapýlmýþtýr. Son aþamada, iç mekan tasarýmlarý ve dekorasyon çalýþmalarý yapýlmýþ, bina kullanýcýlarýn ihtiyacýna göre tasarlanmýþtýr. Ayrýca bina enerji verimliliði ve sürdürülebilirlik açýsýndan en son teknolojilerle donatýlmýþtýr.") },
    { 2, ("proje2.jpg",
          "Bu konut projesi, geniþ ailelerin yaþam ihtiyaçlarýný göz önünde bulundurarak tasarlanmýþtýr. Ýlk adýmda, projenin yapým süreci için mühendislik ve tasarým ekipleri ile detaylý toplantýlar gerçekleþtirilmiþ ve proje kapsamýnda kullanýlacak malzemeler seçilmiþtir. Temel inþaatý sýrasýnda, düþük yoðunluklu zemin iyileþtirmesi yapýlmýþ ve saðlam temel atma iþlemleri gerçekleþtirilmiþtir. Ýnþaatýn ilerleyen safhalarýnda, her daire için özel ses ve ýsý yalýtým sistemleri entegre edilmiþtir. Ayrýca, çevre dostu malzemeler kullanýlarak sürdürülebilirlik saðlanmýþtýr. Çatý katý da dahil olmak üzere, güneþ enerjisi panelleri ile enerji üretimi yapýlmasý planlanmýþtýr. Son olarak, bina içi peyzaj düzenlemesi yapýlmýþ, ortak alanlar modern ve kullanýþlý hale getirilmiþtir.") },
    { 3, ("proje3.jpg",
          "Bu proje, ticaret ve konut alanlarýný birleþtiren karma kullaným projelerindendir. Proje alaný seçilirken, ulaþým kolaylýðý ve çevresel faktörler dikkate alýnmýþtýr. Zemin etüdü yapýldýktan sonra, inþaat için gerekli olan tüm izinler alýnmýþ ve yerel yönetim ile uyumlu bir þekilde çalýþmalar baþlatýlmýþtýr. Ýlk aþamada, temel kazý çalýþmalarý ve yeraltý otoparký için kazýlar gerçekleþtirilmiþtir. Yapý inþaatý sýrasýnda, betonarme ve çelik yapý elemanlarý birleþtirilerek saðlam ve dayanýklý bir yapý ortaya çýkmýþtýr. Ticaret alanlarýnýn alt katlarda yer almasýyla birlikte, konut alanlarý üst katlarda yer almaktadýr. Çevre düzenlemeleri, yeþil alanlar ve sosyal yaþam alanlarý projeye dahil edilmiþtir. Son olarak, bina içi modern güvenlik sistemleri ve akýllý ev sistemleri kurulmuþtur.") },
    { 4, ("proje4.jpg",
          "Bu projede, yüksek katlý bir otel ve rezidans kompleksi inþa edilmiþtir. Yapým süreci, inþaat mühendisliði, iç mekan tasarýmý ve çevre düzenlemelerini kapsayan çok disiplinli bir yaklaþýmla gerçekleþtirilmiþtir. Temel çalýþmalarýndan sonra, yüksek hýzda asansör sistemleri, yangýn güvenliði sistemleri ve enerji verimliliði odaklý izolasyon malzemeleri kullanýlarak yapý inþa edilmiþtir. Ýnþaatýn ilerleyen aþamalarýnda, lüks iç mekan tasarýmý için özel yer döþemeleri, duvar kaplamalarý ve aydýnlatma sistemleri seçilmiþtir. Otel kýsmýnda, misafirler için fitness merkezi, spa ve restoran gibi sosyal alanlar oluþturulmuþ, rezidans kýsmýnda ise her daireye özel balkon ve geniþ pencereler eklenmiþtir. Çatý katýnda ise, þehri yüksekten görebileceðiniz bir gözlem alaný eklenmiþtir. Proje, konuklar ve sakinler için yüksek konfor seviyesini saðlayacak þekilde tasarlanmýþ ve çevre dostu malzemelerle inþa edilmiþtir. Ayrýca otel kompleksinin çatýsýna güneþ enerjisi panelleri yerleþtirilmiþ, su tasarrufu saðlamak amacýyla yaðmur suyu toplama sistemleri kurulmuþtur. Ýç mekan tasarýmýnda ise, modern ve þýk bir dekorasyon anlayýþý benimsenmiþ, otel ve rezidans alanlarýnýn her biri farklý bir konseptte tasarlanmýþtýr. Son aþamada, alanýn peyzaj düzenlemeleri yapýlmýþ ve yeþil alanlar ile çevre dostu peyzaj unsurlarý kullanýlarak sakinlerin doðal yaþamla iç içe bir ortamda yaþamalarý saðlanmýþtýr.") }
};


            // Geçerli proje var mý kontrol edelim
            if (projeler.ContainsKey(proje))
            {
                ViewBag.Resim = projeler[proje].Resim;
                ViewBag.Aciklama = projeler[proje].Aciklama;
            }
            else
            {
                ViewBag.Resim = "default.jpg"; // Varsayýlan resim
                ViewBag.Aciklama = "Proje bulunamadý.";
            }

            return View();
        }

    }
}
