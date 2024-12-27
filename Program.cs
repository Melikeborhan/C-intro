//1- Kullanıcıdan başlangıç, bitiş ve artış miktarı alınarak aralıktaki tüm sayıları ekrana yazdırınız.     

            //  Console.Write("başlangıç: ");
            //  int baslangic = int.Parse(Console.ReadLine());

            //  Console.Write("bitiş: ");
            //  int bitis = int.Parse(Console.ReadLine());

            //  Console.Write("artış miktarı: ");
            //  int artis = int.Parse(Console.ReadLine());

            //  int sayac = 0;
            //  int toplam=0;
            //  for (int i = baslangic; i <= bitis; i=i+artis)
            //  {
            //      sayac++;
            //      toplam+=i;
            //      Console.WriteLine($"{sayac}.sayı: {i}");
            //  }
            //  Console.WriteLine("toplam: "+toplam);


// 2-aşağıdaki sayilar dizisindeki hangi sayılar 3' ün katıdır?
//int[] sayilar = {1,3,5,6,7,23,67,90,120};

    // for (int i = 0; i < sayilar.Length; i++)
    // {
    //     if(sayilar[i]%3==0){
    //         Console.WriteLine($"3e bölünen sayilar:{sayilar[i]}");
        
    //     }
    // }


// 3- sayilar dizisindeki sayıların toplamı kaçtır?
// int[] sayilar = {1,3,5,6,7,23,67,90,120};

// int toplam = 0;
// for (int i = 0; i < sayilar.Length; i++){
//   toplam += sayilar[i];
// }
//   Console.WriteLine($"toplam değer:{toplam}"); 



// 4- sayilar dizindeki tek sayıların karesini ekrana yazdırınız. 
// int[] sayilar = {1,3,5,6,7,23,67,90,120};

// for (int i = 0; i < sayilar.Length; i++)
// {
//     if(sayilar[i]%2==1){
//         Console.WriteLine($"Tek sayilar:{sayilar[i]*sayilar[i]}");
//     }
// }

string[] arabalar = {"Opel","Mazda","Toyota","Bmw","Merdedes"};
// 5- arabalar dizisindeki en az 5 karakterli araç isimlerini yazdırın.

for (int i = 0; i < arabalar.Length; i++)
{
    if(arabalar[i].Length <= 5){
        Console.WriteLine($"En az 5 harften olusan arabalar:{arabalar[i]}");
    }
}