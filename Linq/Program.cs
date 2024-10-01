using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Random random = new Random();
        // Rastgele 10 adet sayıdan oluşan liste
        List<int> numbers = Enumerable.Range(0, 10).Select(_ => random.Next(-30, 30)).ToList();

        Console.WriteLine("Rastgele Oluşan Sayılar: " + string.Join(", ", numbers));

        // Çift olan sayılar
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Çift Sayılar: " + string.Join(", ", evenNumbers));

        // Tek olan sayılar
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
        Console.WriteLine("Tek Sayılar: " + string.Join(", ", oddNumbers));

        // Negatif sayılar
        var negativeNumbers = numbers.Where(n => n < 0).ToList();
        Console.WriteLine("Negatif Sayılar: " + string.Join(", ", negativeNumbers));

        // Pozitif sayılar
        var positiveNumbers = numbers.Where(n => n > 0).ToList();
        Console.WriteLine("Pozitif Sayılar: " + string.Join(", ", positiveNumbers));

        // 15'ten büyük ve 22'den küçük sayılar
        var filteredNumbers = numbers.Where(n => n > 15 && n < 22).ToList();
        Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar: " + string.Join(", ", filteredNumbers));

        // Her bir sayının karesi
        var squares = numbers.Select(n => n * n).ToList();
        Console.WriteLine("Her Sayının Karesi: " + string.Join(", ", squares));
    }
}
