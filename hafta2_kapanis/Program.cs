//1 :Aşağıdaki çıktıyı yazan bir program.

//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?

Console.Write("Merhaba\r\nNasılsın ?\r\nİyiyim\r\nSen nasılsın ?\n\n");


//2 :Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

int sayi = 5;
string str = "patika";

Console.WriteLine("int : " + sayi);
Console.WriteLine("string :" + str + "\n");


//3:Rastgele bir sayı üretip , ekrana yazdırınız.
Random rnd = new Random();

Console.WriteLine("random number :" + rnd.Next(1, 100));


//4:Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Random rnd2 = new Random();
Console.WriteLine("\nrandom number modulo 3 :" + rnd2.Next(1, 100) % 3);

//5:Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
Console.Write("\nYaşınız kaç ? :");
int yas = Convert.ToInt32(Console.ReadLine());
if (yas >= 18)
    Console.WriteLine("+\n");
else if (yas < 18)
    Console.WriteLine("-\n");


//6:Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(" Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}

//7:Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
Console.Write("\nmetinsel değer 1 :");
string str1 = Console.ReadLine();
Console.Write("metinsel değer 2 :");
string str2 = Console.ReadLine();

str1 = "gülse birsel";
str2 = "demet evgar";

Console.WriteLine("metinsel değer 1 :" + str1);
Console.WriteLine("metinsel değer 2 :" + str2);


//8:Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
static void BenDegerDondurmem()
{
    Console.WriteLine("\nBen değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}

BenDegerDondurmem();


//9:İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
static int toplam(int sayi1, int sayi2)
{
    return sayi1 + sayi2;
}
//Console.WriteLine(toplam(8, 9));


//10:Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
static string to_string(bool a)
{
    return Convert.ToString(a);
}
Console.Write("\nTrue/False bir değer giriniz :");
bool tf = Convert.ToBoolean(Console.ReadLine());
Console.Write(to_string(tf));


//11:3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

Console.Write("\nyas1 :");
int yas1 = Convert.ToInt32(Console.ReadLine());
Console.Write("yas2 :");
int yas2 = Convert.ToInt32(Console.ReadLine());
Console.Write("yas3 :");
int yas3 = Convert.ToInt32(Console.ReadLine());

static int yas_en_buyuk(int y1, int y2, int y3)
{
    return Math.Max(Math.Max(y1, y2), y3);


}
Console.WriteLine("\nMax yas :" + yas_en_buyuk(yas1, yas2, yas3));



//12 :Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

static int en_buyuk_sayı_sınırsız()
{
    Console.Write("Kaç sayı girmak istiyorsunuz :");
    int adet = Convert.ToInt32(Console.ReadLine());
    Console.Write("Sayı giriniz :");
    int sayı = Convert.ToInt32(Console.ReadLine());

    int max_Sayı = sayı;

    for (int i = 1; i <= adet - 1; i++)
    {
        Console.Write("Sayı giriniz :");
        sayı = Convert.ToInt32(Console.ReadLine());

        max_Sayı = Math.Max(sayı, max_Sayı);
        
    }
    Console.WriteLine("Max sayı :" + max_Sayı);
    return max_Sayı;

}
en_buyuk_sayı_sınırsız();





//13 :Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

Console.Write("\nisim1 :");
string is1 = Console.ReadLine();
Console.Write("isim2 :");
string is2 = Console.ReadLine();
static void yer_degis(string isim1, string isim2)
{
    Console.Write(isim2 + "  " + isim1);
}

yer_degis(is1, is2);



////14: Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.


static bool tek_cift(int n1)
{
    if (n1 % 2 == 0)
        return false;


    else
        return true;
}

Console.Write("sayı giriniz :");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("sayı " + tek_cift(number1));



//15:Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

static void yol(double hız, double zaman)
{
    double yol = hız * zaman;
    Console.WriteLine("Gidilen yol :" + yol + "km");

}

Console.Write("\nHızı (km/s) giriniz :");
double hız1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Zamanı (s) giriniz :");
double zaman1 = Convert.ToDouble(Console.ReadLine());


yol(hız1, zaman1);

////16:Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
static void alan_daire(double r)
{
    double alan = Math.PI * Math.Pow(r, 2);
    Console.WriteLine("Dairenin alanı :" + alan + "cm2\n");

}
Console.Write("\nyarıçap (cm) giriniz :");
double r1 = Convert.ToDouble(Console.ReadLine());
alan_daire(r1);

////17:"Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string s1 = "Zaman bir GeRi SayIm";
Console.WriteLine(s1.ToUpper());
Console.WriteLine(s1.ToLower());

//18: "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
string s2 = "    Selamlar   ";
//Console.WriteLine(s2.Length);
s2 = s2.Trim();
Console.WriteLine(s2);
//Console.WriteLine(s2.Length);

