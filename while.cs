// Sınırsız sayıda ürün ismini bir dizi içinde saklayın.
// Ürün adetini kullanıcı belirlesin.
// Eklenen ürünler listelensin.

Console.Write("adet: ");
int adet = int.Parse(Console.ReadLine());  
//burada kodun normalde calısması gereklı fakat TryParse kullnamadıgımız için hata verdi.


string[] urunler =  new string[adet] ;

int i = 0;
do
{
    Console.Write("adet: ");
    urunler[i] = Console.ReadLine();
    i++;

}while(adet !=i);

Console.Write("urunler yükleniyor..");

for (int a = 0; a < urunler.Length; a++)
{
    Console.WriteLine($"{a+1}. ürün adi:{urunler[a]}");
}

