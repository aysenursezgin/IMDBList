using System;
using System.Collections.Generic;

class Film
{
    public string Isim { get; set; }
    public double ImdbPuani { get; set; }

    public Film(string isim, double imdbPuani)
    {
        Isim = isim;
        ImdbPuani = imdbPuani;
    }
}

class Program
{
    static void Main()
    {
        List<Film> filmListesi = new List<Film>();
        string devamEt;

        do
        {
            // Kullanıcıdan film ismi ve IMDb puanı alma
            Console.Write("Film İsmi: ");
            string isim = Console.ReadLine();

            Console.Write("IMDb Puanı (0-10): ");
            double imdbPuani;
            while (!double.TryParse(Console.ReadLine(), out imdbPuani) || imdbPuani < 0 || imdbPuani > 10)
            {
                Console.Write("Geçersiz puan. Lütfen 0 ile 10 arasında bir IMDb puanı girin: ");
            }

            // Film nesnesi oluşturma ve listeye ekleme
            filmListesi.Add(new Film(isim, imdbPuani));

            // Kullanıcıya devam edip etmeyeceğini sorma
            Console.Write("Başka bir film eklemek ister misiniz? (Evet için 'e' girin, hayır için 'h'): ");
            devamEt = Console.ReadLine().ToLower();

        } while (devamEt == "e");

        // Uygulamanın sonunda çıktılar
        Console.WriteLine("\nBütün Filmler:");
        foreach (var film in filmListesi)
        {
            Console.WriteLine($"İsim: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
        }

        // IMDb puanı 4 ile 9 arasında olan filmler
        Console.WriteLine("\nIMDb Puanı 4 ile 9 Arasında Olan Filmler:");
        foreach (var film in filmListesi)
        {
            if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
            {
                Console.WriteLine($"İsim: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
            }
        }

        // İsmi 'A' ile başlayan filmler
        Console.WriteLine("\nİsmi 'A' ile Başlayan Filmler:");
        foreach (var film in filmListesi)
        {
            if (film.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"İsim: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
            }
        }
    }
}
