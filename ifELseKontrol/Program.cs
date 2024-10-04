// See https://aka.ms/new-console-template for more information
Console.Write("Lütfen bir sayı giriniz :  ");

int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi > 10) //sayının 10'dan büyük olduğunu kontrol eder.
{
    Console.WriteLine(" Girilen sayı 10'dan büyüktür. ");
    if (sayi % 2 == 0) //sayının çift olup olmadığına bakar.
    {
        Console.WriteLine(" Sayı çifttir. ");
    }
    else
    {
        Console.WriteLine(" Sayı tektir. ");
    }

}

if (sayi < 10) //sayının 10'dan küçük olduğuna bakar
{
    Console.WriteLine(" Girilen sayı 10'dan küçüktür. ");
    if (sayi % 2 == 0) // sayı 10'dan küçük ise çift olup olmadığını kontrol eder.
    {
        Console.WriteLine(" Sayı çifttir. ");

    }
    else
    {
        Console.WriteLine(" Sayı tektir. ");
    }


}


else
{
    Console.WriteLine(" Sayı 10'a eşittir."); //sayı 10'a eşit ise bu kısmı çalıştırır.
}