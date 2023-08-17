
Console.WriteLine("Bu eğitimin ilk günüdür." + (1 + 10));// bu aslında bir metottur ekrana çıktı basmamızı sağlar.
// çift tırnak açılıp kapanması aslında ben buraya metinsel bir ifade yazıcam demek. 
//debug olarak çalıştırmak performans açısından daha iyidir.

//DEĞİŞKENLER ikiye ayrılır 1. değer tip 2. si referans tipler.
//değer tipler bizim en temelde kullandığımız değer tipleri dir. ilkel tiplerdir. 
//değer tipler: boolean, integar,float, double. 
//syntax ı => değişken değişken ismi = değer;

// integer tam sayı tanımlama
int sayi1 = 10;
Console.WriteLine(sayi1);

//boolean true false tanımlama
bool dogruluk= false;
bool dogruluk1 = true;
Console.WriteLine(dogruluk);
Console.WriteLine(dogruluk1);

// DEĞER TİPLERİN ÖZELLİKLERİ: Hafızanın stack kısmında tutulur.
// stackte veriler sıralı şekilde tutulur ve çalışma sırasında değil derleme sırasında tutulur.
// null değerler alamazlar.

// soru işareti koyarsak derleyiciye deriz ki bnm değişkenim null değer alabilir.
int? sayi2= null;
Console.WriteLine(sayi2);

// REFERANS TİPLER: hafızanın heap kısmında tutulur. string, array, hashmap, list, classlar, interfaceler.
//Referans tipler null değer alabilir.
//referans tipler kendisiyle beraber metotları getirebilir.

string metin = "ilk eğitim örneği";
Console.WriteLine(metin);

//crtl+k+c ile yorum satırına alabilirsiniz. geri almak istersekte ctrl+k+u
//jetBrains Rider başka bir editör.


// İki sayıyı toplayıp ekrana yazdırma 
int a = 30;
int b = 67;
Console.WriteLine("a ve b nin toplamı:" +(a+b));
//ikinci yol.
int sonuc = a + b;
Console.WriteLine(sonuc);
//3. yol string interpolation: bunu kullanmak için başa dolar işareti koymalıyız.
//En çok bu kullanılır bunun ne olduğunu araştır bebek.
Console.WriteLine($"iki sayının toplamı: {a}+{b}={sonuc}");
string metin1 = "metin1 ";
string metin2 = "metin2";
string birlestirilmisMetin= metin1+ metin2;
Console.WriteLine(birlestirilmisMetin);
Console.WriteLine("iki sayının toplamı" + a+b);

string example = "Küçük Büyük veya String örneği";
// ToUpper bir metottor ve tüm karakterleri büyük harfe çevirir. noktadan sonra parantezli bir şey varsa eğer
// o zaman bunun metot olduğunu anlarız.
Console.WriteLine(example.ToUpper()); 

// ToLower stringin içindeki tüm harfleri küçük harfle yazar.
Console.WriteLine(example.ToLower());

// StarsWith ile true değer döndürür çünkü metinsel ifadenin k harfiyle başladığı için ve doğru olduğu için true döndü
// ama eğer küçük k ile yazsaydık false döndürürdü çünkü küçük büyük harfe duyarlıdır. BUnun nedeni ASCII tablosundaki
// k ve K nın değerleri farklıdır.
Console.WriteLine(example.StartsWith("K"));


// metnin ilk dört harfini ekrana bastırsın.
Console.WriteLine(example[0..4]); // burada 0. index ile 4. index arasındaki değerleri alır.
// sıfır yazmayıp [..4] olarak da yazarsak baştan alıp 4 e kdr alır.


// metnin ilk dört hanesinden sonraki karakterleri getirir.
Console.WriteLine(example[3..]);// 4 den sonraki tüm karakterleri alır. 


char aa = 'A';

//String değeri int değere çevirme 
Console.WriteLine((int)aa); // bunun adı costumer ve burda a harfinin integer değerini ASCII tablosundaki int değerini bastırır.

//EndsWith ile şu harf ile bitip bitmediğini sorgularız. true ya da false değer döndürür.
Console.WriteLine(example.EndsWith("O"));
// O harfiyle bitiyor mu? false döndürür.



// kod satırları sırasıyla toplama çıkarma bölme ve çarpma işlemleri yapsın. 
// iki sayının çarpımı... gibi

int c = 300;
int d = 60;
// iki sayının toplamı
int top= c+d;
//iki sayının eksiği
int cık = c - d;
//iki sayının çarpımı
int carp = c * d;
//iki sayının bölümü
int bol = c / d;
Console.WriteLine($"iki sayının toplamı: {c}+{d}={top}");
Console.WriteLine($"iki sayının çıkarma: {c}-{d}={cık}");
Console.WriteLine($"iki sayının çarpımı: {c}*{d}={carp}");
Console.WriteLine($"iki sayının bölümü: {c}/{d}={bol}");


//VÜCUT KİTLE ENDEKSİ HESAPLAMA 
//FORMÜL: VKİ, bireyin vücut ağırlığının (kg), boy uzunluğunun
//(m cinsinden) karesine (BKI=kg/m2) bölünmesiyle elde edilen bir değerdir.

double kg = 67; // double veri tipi kullanma nedenimiz ondalık sayılarla sonuç verebilir o yüzden double alırsak daha rahat olur.
double m = 1.78;
double vki = kg / (m * m); // burada da vki ye kg'ı boyun yani metrenin karesine böldük
Console.WriteLine($"Kişinin vücut kitle endeksi : {vki} "); //buradada sonucu ekrana bastırdık.

//DAİRENİN ÇEVRESİ VE ALANINI HESAPLAYAN UYGULAMA 
// FORMÜL: ALAN= pi*r^2  ÇEVRE= 2*pi*r

double pi = 3.14; 
double r = 4;
double alan = pi * (r * r);
double cevre = 2 * pi * r;
Console.WriteLine($"Dairenin Alanı: {alan}");
Console.WriteLine($"Dairenin Çevresi: {cevre}");

//MATH KÜTÜPHANESİYLE YAPIMI:
double yaricap = 10.0;
double pii= Math.PI;// math kütüphanesi bize pi değerini getirecek.
double alann= pii * Math.Pow(yaricap,2); //Math.pow üst alma işlemidir. pow power dan gelir. yaricapin karesini aldık burada.
double cevree = 2 * pii * yaricap;
Console.WriteLine($"yarıçapı: {yaricap} olan dairenin alanı: {alann}");
Console.WriteLine($"yarıçapı: {yaricap} olan dairenin çevresi: {cevree}");









