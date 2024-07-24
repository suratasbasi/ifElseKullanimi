// See https://aka.ms/new-console-template for more information
Console.Write("Lütfen bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi >= 10)  // Kullanıcının girdiği sayının 10'a eşit veya 10'dan büyük anlamak için öncelikle if kontrol yapısıyla büyük ve eşit operatörlerini kullanıyorum.
{
    if (sayi == 10)
    {
        Console.WriteLine("Girilen sayı 10'a eşittir."); // Girilen sayının 10'a eşit olup olmadığı anlaşılır. Eşitse iç içe if konrtol yapısı atanır.
    }

    else if (sayi > 10)
    {
        Console.WriteLine("Girilen sayı 10'dan büyüktür.");  // Girilen sayının 10'dan büyük olup olmadığı anlaşılır. Büyükse iç içe else if kontrol yapısı atanır.
    }
}

else
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");  // Girilen sayı yukarıdaki koşulları sağlamıyorsa else kontrol yapısı atanır. Yani girilen sayının 10'dan küçük olduğu bilgisi yazar.
}



if (sayi % 2 == 0)  // Girilen sayının tek veya çift olduğunu anlamak için 2'ye bölümünden kalanın 0 olup olmadığına bakılır. Bunun için 'modül' operatörü ve ardından 'eşit mi' operatörü kullanılır.
{
    Console.WriteLine("Girilen sayı çifttir.");  // Girilen sayının 2'ye bölümünden kalan 0'a eşitse if kontrol yapısı atanır.
}

else
{
    Console.WriteLine("Girilen sayı tektir.");  // Yukarıdaki koşul sağlanmıyorsa yani 2'ye bölümünden kalan 0'a eşit değilse else kontrol yapısı atanır.
}
