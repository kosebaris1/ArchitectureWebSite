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
            // �rnek proje verisi
            var projeler = new Dictionary<int, (string Resim, string Aciklama)>
{
    { 1, ("proje1.jpg",
          "Bu proje, modern ofis binalar�n�n in�a edilmesi amac�yla ba�lat�lm��t�r. �lk a�amada, arazi analizi ve zemin et�d� yap�lm��t�r. Zemin et�d� sonras�nda, yap� i�in uygun temeller se�ilmi�tir. Temel in�aat� s�ras�nda, derin kaz� i�lemleri yap�lm�� ve betonarme temeller d�k�lm��t�r. Yap� betonarme karkas sistemiyle in�a edilmektedir. �elik ve betonarme ta��y�c� sistemler kullan�larak, her kat i�in g�venli bir yap� sistemi sa�lanm��t�r. Elektrik, su ve havaland�rma tesisatlar�, uzman ekipler taraf�ndan dikkatle d��enmi� ve in�aat s�recinin her a�amas�nda kalite kontrol� yap�lm��t�r. Son a�amada, i� mekan tasar�mlar� ve dekorasyon �al��malar� yap�lm��, bina kullan�c�lar�n ihtiyac�na g�re tasarlanm��t�r. Ayr�ca bina enerji verimlili�i ve s�rd�r�lebilirlik a��s�ndan en son teknolojilerle donat�lm��t�r.") },
    { 2, ("proje2.jpg",
          "Bu konut projesi, geni� ailelerin ya�am ihtiya�lar�n� g�z �n�nde bulundurarak tasarlanm��t�r. �lk ad�mda, projenin yap�m s�reci i�in m�hendislik ve tasar�m ekipleri ile detayl� toplant�lar ger�ekle�tirilmi� ve proje kapsam�nda kullan�lacak malzemeler se�ilmi�tir. Temel in�aat� s�ras�nda, d���k yo�unluklu zemin iyile�tirmesi yap�lm�� ve sa�lam temel atma i�lemleri ger�ekle�tirilmi�tir. �n�aat�n ilerleyen safhalar�nda, her daire i�in �zel ses ve �s� yal�t�m sistemleri entegre edilmi�tir. Ayr�ca, �evre dostu malzemeler kullan�larak s�rd�r�lebilirlik sa�lanm��t�r. �at� kat� da dahil olmak �zere, g�ne� enerjisi panelleri ile enerji �retimi yap�lmas� planlanm��t�r. Son olarak, bina i�i peyzaj d�zenlemesi yap�lm��, ortak alanlar modern ve kullan��l� hale getirilmi�tir.") },
    { 3, ("proje3.jpg",
          "Bu proje, ticaret ve konut alanlar�n� birle�tiren karma kullan�m projelerindendir. Proje alan� se�ilirken, ula��m kolayl��� ve �evresel fakt�rler dikkate al�nm��t�r. Zemin et�d� yap�ld�ktan sonra, in�aat i�in gerekli olan t�m izinler al�nm�� ve yerel y�netim ile uyumlu bir �ekilde �al��malar ba�lat�lm��t�r. �lk a�amada, temel kaz� �al��malar� ve yeralt� otopark� i�in kaz�lar ger�ekle�tirilmi�tir. Yap� in�aat� s�ras�nda, betonarme ve �elik yap� elemanlar� birle�tirilerek sa�lam ve dayan�kl� bir yap� ortaya ��km��t�r. Ticaret alanlar�n�n alt katlarda yer almas�yla birlikte, konut alanlar� �st katlarda yer almaktad�r. �evre d�zenlemeleri, ye�il alanlar ve sosyal ya�am alanlar� projeye dahil edilmi�tir. Son olarak, bina i�i modern g�venlik sistemleri ve ak�ll� ev sistemleri kurulmu�tur.") },
    { 4, ("proje4.jpg",
          "Bu projede, y�ksek katl� bir otel ve rezidans kompleksi in�a edilmi�tir. Yap�m s�reci, in�aat m�hendisli�i, i� mekan tasar�m� ve �evre d�zenlemelerini kapsayan �ok disiplinli bir yakla��mla ger�ekle�tirilmi�tir. Temel �al��malar�ndan sonra, y�ksek h�zda asans�r sistemleri, yang�n g�venli�i sistemleri ve enerji verimlili�i odakl� izolasyon malzemeleri kullan�larak yap� in�a edilmi�tir. �n�aat�n ilerleyen a�amalar�nda, l�ks i� mekan tasar�m� i�in �zel yer d��emeleri, duvar kaplamalar� ve ayd�nlatma sistemleri se�ilmi�tir. Otel k�sm�nda, misafirler i�in fitness merkezi, spa ve restoran gibi sosyal alanlar olu�turulmu�, rezidans k�sm�nda ise her daireye �zel balkon ve geni� pencereler eklenmi�tir. �at� kat�nda ise, �ehri y�ksekten g�rebilece�iniz bir g�zlem alan� eklenmi�tir. Proje, konuklar ve sakinler i�in y�ksek konfor seviyesini sa�layacak �ekilde tasarlanm�� ve �evre dostu malzemelerle in�a edilmi�tir. Ayr�ca otel kompleksinin �at�s�na g�ne� enerjisi panelleri yerle�tirilmi�, su tasarrufu sa�lamak amac�yla ya�mur suyu toplama sistemleri kurulmu�tur. �� mekan tasar�m�nda ise, modern ve ��k bir dekorasyon anlay��� benimsenmi�, otel ve rezidans alanlar�n�n her biri farkl� bir konseptte tasarlanm��t�r. Son a�amada, alan�n peyzaj d�zenlemeleri yap�lm�� ve ye�il alanlar ile �evre dostu peyzaj unsurlar� kullan�larak sakinlerin do�al ya�amla i� i�e bir ortamda ya�amalar� sa�lanm��t�r.") }
};


            // Ge�erli proje var m� kontrol edelim
            if (projeler.ContainsKey(proje))
            {
                ViewBag.Resim = projeler[proje].Resim;
                ViewBag.Aciklama = projeler[proje].Aciklama;
            }
            else
            {
                ViewBag.Resim = "default.jpg"; // Varsay�lan resim
                ViewBag.Aciklama = "Proje bulunamad�.";
            }

            return View();
        }

    }
}
