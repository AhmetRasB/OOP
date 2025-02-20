## Nesnenin Anatomisi
***
#### Obje

- En kucuk esas parca nesne/obje/object dir.
- Nesneler içerisinde verir tutabilecekleri alanlar barındırırlar, bu alanlara field diyeceğiz.
- Fielddeki değerleri işleyebilmesi için fonksiyonlar mevcuttur.
- Bu fonksiyonlar ileride operasyonlara tabi tutabiliyoruz. Metotlar, properirtyler.
- Tüm nesneler esasında bir sınıf modellemesinin öğreneğidir.
- Nesne sadece Classın ürünüdür.
- 1 Classtan istediğimiz kadar nesne oluşturabiliriz.
*** 
#### Nesne

- Nesne, nesnellik felsefesine dayanan bir kavramdır. Kainattaki her bir şeyi nesne olarak görmek ve o şekilde yorumlamak fikrine dayanır.
- Nesne, gerçek hayatta elle tutulur, gözle görülür objelerdir. Dolayısıyla programlamada da nesnelerimiz gündelik nesnelerin muadilidir.
- Gerçek hayattaki herhangi bir olguyu nesneyi objeyi programlama dünyasında tarif ederkende onu bir nesne olarak tarif edecek ve o şekilde modelleyeceğiz.
*** 
#### Nesne Modellemesi

-  Nesnelerin oluşturulabilmesi için öncelikle modellenmesi gerekmektedir.
- Nesne modeli class ile gerçekleştirilir.

****

![[Pasted image 20250211221032.png]]
Bu araba sınıfından istediğimiz araba nesnesini üretebiliriz;

![[Pasted image 20250211221114.png]]

- Hepsi 4 tekerdir ve classta bu sabittir
- Hepsinin rengi vardır ve nesne üzerinde değişir
- Hepsinin modeli vardır ve nesne üzerinde değişir
- Hepsinin beygir gücü vardır ve nesne üzerinde değişir
***

![[Pasted image 20250211221431.png]]

Nesne modelinden farklı nesneler üretilmiş.

*** 
#### Nesneler Hangi Türdendir?

- Nesneler referans türlü değerlerdir.
*** 
#### Referans türü nedir?
-  Referans türlü değişkenler, Heap’te saklanan nesnelere işaret eden Stack üzerindeki referanslardır.
- Kopyalandığında **sadece referans kopyalanır**, yeni bir nesne oluşturulmaz.
- Stack’te sadece **adres saklanır**, asıl veri Heap’te bulunur.
- Referans türlü değişken, **Heap bellekte saklanan** ve **Stack üzerinde adresi (referansı) tutulan değişkenlerdir**.
- Yani, **değişkenin kendisi Stack’te durur ama asıl veri Heap’te bulunur** ve Stack’te sadece Heap’teki veriye erişmek için bir **referans (adres)** tutulur.
*** 
#### Class Nedir? Neden Kullanılır?
*** 
##### Öncelikle Model içerisinde neler tutabildiğimizi hatırlayalım;
- Field
- Property
- Indexer
- Metotlar
*** 
- Object oluşturmak için muhakkkak classa ihtiyacımız var.
*** 
#### Sınıf ile Nesne arasındaki ilişki

- Classlarda nesnelerdeki ortak alan tanımları yapılır.
- Her bir objenin Ad fieldi var ama hepsinde objelerin değerleri farklı olur
#### Sınıf nerede ve nasıl oluşturulur?
```c#
class Ornekmodel  
{

}
```
- Class [isim] şeklinde oluşturulur ve {} arasına yazılır kodlar.
- Classlar bir referans türüdür.
***
##### Namespace nedir?
- İçerisinde birden fazla class struct interface gibi yapılanmaları barındıran kütüphane mantığını oluşturmanı sağlayan, genel anlamda kurmuş olduğun sistemde sınıflarını farklı namespaceler altında kategorize edip o kategorilerden çağırmanı sağlayan yapılanma.
***
- Eğerki classı namespacenin üstünde açarsan bağımsız class olur herkes erişebilir.
- Bir class tanımlamasında tanımlanan yerde (namespace/class olabilir) aynı isimde birden fazla class tanımlanamaz!
***
##### Sınıf ile nesne modeli nasıl oluşturulur?
- Önce bir sınıf oluştururuz.
- 2 tane özellik olabilir içerisinde.
- Classın içerisinde bildiğin şey varsa örnek int a,b bunlar field olur.

```c#
class Ornekmodel  
{  
    int a;  
    int b;  
  
    public void x()  
    {        Console.WriteLine(a+b);  
    }  
    public int Y()  
    {        return a*b;  
    }
}
```
***
##### Sınıf modelinden referans noktası oluşturma
- Bir class tanımlandığında o class adı bir türdür. Haliyle o türü kullanabilmek içim direkt olarak class adını kullanmamız yeterlidir.
```c#
OrnekModel w;
```
- Referans noktası alma, referans noktası ayarlama, referans alma.
- Eğerki bir referans noktasında herhangi bir nesne referans edilmiyorsa o referans noktası null değere sahiptir.
*** 
#### Class Members

##### Field Nedir?
- Nesne içerisinde veri depoladığımız, tuttuğumuz alanlardır.
- Class içerisindeki değişkenlerdir.
```c#
MyClass m1 = new MyClass();  // Nesne oluşturduk.
MyClass m2 = new MyClass(); // Nesne oluşturduk
m1.a = 5;// diyerek içerisindeki fieldlara erişebiliyoruz
m1.b = 10;
m2.a = 15;
m2.b = 20;
class MyClass  
{  
    public int a;  
	public string b;
}
```
- Class içerisinde a türünde bir  değişken bellekte tanımlanırken a nın değeri boş değer değil 0 a atanacaktır. Sayısal türlerin varsayılan değeri 0 dır.
*** 
##### Property Nedir?
-  Nesne içerisinde özellik-property sağlar.
- Property esasında özünde bir metottur. Yeni programatik-algoritmik kodlarımızı inşa ettiğimiz bir metot.
*** 
#### Bağımsız: Metot Nedir? Ne İşe Yarar?
-  Yöntem, yordam, functions.
-  Fiili olarak gerçekleştirdiğimiz tüm operasyonlar bir metottur.
- Metot prosedürel programlamanın temel elemanıdır.
- Bir iş fiiliyat operasyon yapan en küçük program parçacıklarıdır.
- Metotlar içerisine yazılan kodun tekrarlı bir şekilde kullanılmasını sağlarlar ve bunu yaparken kaynak kodun tekrar etmesini de engellemiş olur. Böylece ideal kodlamaya erişmiş oluruz.
***
##### Metot Anatomisi Nasıldır?
- Metot içerisinde metot tanımlanamaz* Şimdilik.
- İlk erişim belirleyicisi tanımlanır.
- Sonra geri dönüş değeri.
- En son metodun adı verilir.
- () açıp kapatılır
***
###### Erişim belirleyici
- Erişim belirleyicileri ileride göreceğimiz Access Modifier yapılarıdır.
- Oluşturulmuş olan bir yapının dışarıdan erişip erişilemeyeceğimizi sağlayan konulardır.
- Dışarıdan erişilmesini istiyorsan public.
- Sadece ben diyorsan private.
***
###### Geri dönüş değeri
- Metotlar yaptıkları operasyonlar-algoritmalar-işlemler neticesinde geriye değerler dönebilmektedirler.
- Bu değer kodun içerisinde yakalanabilir ve programatik olarak işlemlere tabii tutulabilir.
- Geri dönüş değerini ekran çıktısıyla karıştırmamak gerekir.
*** 
###### Metodun adı
- Metodun adını verir.
*** 
###### ()
- Metod dediğimiz bu yapılanmalar dış dünyadan parametreler alabilmekte ve bu parametrelerdeki değerler üzerinde işlemler gerçekleştirebilmektedir... İşte bu parametreleri parantez içerisinden alabilmekteyiz.
- Almak zorunda değildir.
- (int sayi1) (int sayi1, int sayi2)
***
{}
- Metodun gerçekleştireceği operasyonu faaliyeti algoritmayı oluşturduğumuz alandır
*** 
() varsa o metoddur net olarak.

##### İşlevine Göre Metod Türleri Nelerdir?

- 4 Farklı türde oluşturabilirsiniz.
***

1. Geri değer döndürmeyen, parametre almayan
```c#
private void Metot1()
{
    Console.WriteLine("Metot1");
}
```
***
1. Geri değer döndürmeyen, parametre alan
```c#
public void Metot2(int a)
{

}
public void Metot3(int a,string b,char c)
{

}
```
***
1. Geri değer döndüren, parametre almayan
```c#
 public string Metot4()
 {
     return "selam";
 }
```
- Eğerki bir metot geriye herhangi bir türde değer döndüreceğini ifade ediyorsa kesinlikle o tipte etmelidir.
***
4. Geri değer döndüren, parametre alan
```c#
 public int Metot5(int a)
 {
     return a;
 }
```
***
- Hepsinde erişim belirleyici vardır.
- Hepsinde geri dönüş türü vardır.
- Hepsinde metod adı vardır.
- Bir metod geriye değer döndürmüyorsa, void ile belirtilmesi zorunludur. Başka bir tür olursa onu geriye döndürür.
*** 
##### Metodun geriye değer döndürmesi ne demektir?

- Metodun geriye değer döndürmesi demek, metodun yaptığı işlem neticesinde uüretilen değeri ekrana consola veritabanına herhangi bir log ekranına çıktı vermesi demek değildir!!!
- Metodun geriye döndürdüğü değer, programatik olarak yakalanıp algoritmanın akışında farklı yönlendirmelere sebebiyet verebilen değerdir!!!
- Metodun geriye döndürdüğü değer algoritmanın akışında kullanılabilir değerdir!!!
***
##### Metotlarda Opsiyonel Parametreler
- Parametreli bir metot kullanırken çağırırken tetiklerken parametrelerine türlerine uygun değerler gönderilmek zorunludur, eğerki bir metodun parametrelerine zorunlu bir şekilde değer göndermek istemiyorsak, parametreye değeri isteğimize göre opsiyonel olarak göndermek istiyorsak o parametrenin bu durumu karşılayacak bir özellikle olması gerekmektedir. İşte bu özelliğede opsiyonel parametreler denmektedir.

```c#
class Program  
{  
    static void Main(string[] args)  
    {        
	    X(5,10);  
    }  
    static public void X(int a, int b)  
    {            
    
    }  
}
```

- Bir parametrenin opsiyonel olabilmesi demek o parametrenin varsayılan default değeri olması demektir.
- Bu şekilde yaparsak zorunlu olarak a da b ye de değer verilmelidir. Opsiyonel yapmak için;

```c#
static public void X(int a, int b = 0)
```

- Metot parametrelerine = (assign) operatörü ile bir değer atanırsa eğer o parametreye varsayılan değeri atanmış olur. Bu şekilde opsiyonel parametre haline getirilmiş olur.
- Tüm parametreler opsiyonel olabilir.
- Birden fazla parametre içerisinde bir kısmı opsiyonel olabilirmi?
- - Birden fazla parametre durumunda opsiyonel olanlar sağ tarafta **Tanımlanmalıdır.
****
##### Tanımlandığı sınıf içerisindeki metotlar tarafından kullanımı
- Bir metot tanımlandığı sınıf içerisindeki farklı bir metot içerisinden çağırılacaksa eğer tek yapılması gereken sadece isminin çağırılmasıdır tetiklenmesidir veya çalıştırılmasıdır.
***
##### Başka Sınıfta Tanımlanmış Metotların Erişimi-Referans ve Nesne İlişkisi (Temel Düzey)
***
###### Class
-  Yeryüzündeki herhangi bir olguyu modellememizi sağlayan yapılanma. İçerisinde ilgili olguya dair verileri tutacak alanları(field) barındıran ve bu alanlar üzerinde işlem yapmamızı sağlayacak olan metotları barındıran bir yapı!
- Class bir modelse, nesne classın verisidir.
###### Nesne
- Classtan üretilen değer-veri.
###### Referans
- Classtan üretilen değeri kullanmamızı sağlayan yapı.
***
![[Pasted image 20250215124921.png]]
***

- Eğerki bir nesne oluşturduğunda başka yerden o nesneye rahat erişim göstermek istiyorsan;
```c#
Random r = new Random();
```

- Aynı türde bir değişkenle işaretlemen gerekiyor.
***
**Örnek**
```c#
class Program  {  
        static void Main(string[] args)  
        {            
	        Matematik mat = new Matematik();  
            int sonuc = mat.Cikar(5, 2);  
            Console.WriteLine(sonuc);  
         }  
    }  
class Matematik  {  
        public int Topla(int sayi1, int sayi2)  
        {            
	        return sayi1 + sayi2;  
        }  
        public int Cikar(int sayi1, int sayi2)  
        {            
	        return sayi1 - sayi2;  
        }  
        public int Carp(int sayi1, int sayi2)  
        {            
	        return sayi1 * sayi2;  
        }  
        public int Bol(int sayi1, int sayi2)  
        {            
	        return sayi1 / sayi2;  
        }    
    }
```

- Dışarıdan erişilebilmesi için **Public** işaretlenmesi önemlidir
***
##### Non Trailing Named Arguments
- Hangi parametreye hangi değerlerin gönderildiğini direkt görebilmek için bu özelliği kullanırız.
- Çok parametreli fonskiyonlarda hedef parametrelere değer göndermemizi sağlayan bir özelliktir.
```c#
X(a:2,b:3,c:"selam");
X(b:3,c:"selam",a:10);

static void X(int a,int b,string c){

}
```
***
##### Metotlarda In Parametreleri
- Parametrenin değerini metodun içerisinde herhangi bir yerde çağırıp kullanabiliriz.
- Metot içerisinde üretilen herhangi bir değeri tutacak değişken oluşturmaktansa parametre üzerinde bu değeri tutabiliriz. Yeni parametrenin değerini değiştirebiliriz. (Çünkü parametreler özünde bir değişkendir.)
- In komutu sayesinde parametreye verilen değeri sabit tutabilmekteyiz.
- In komutu metodun parametresiin readonly(Sadece okunabilir) hale getirir.
- In komutunun kullanıldığı parametrelerde eğerki metot içerisinde farklı bir assign durumu söz konusu olursa derleyici hatası verecektir.
***
##### Local Functions(Metot İçerisinde Tanımlanabilir Yerel Metotlar)
- Bir metot içerisinde tanımlanmış olan metotlardır!
- C# ta metotlar sade ve sadece class içerisinde tanımlanırlar, Halbuki oop de göreceğimiz struct, aabstract class, interface, record yapılanmalarında da metotlar tanımlanmaktaddır. Metotlar bu saydıklarımızın dışında kesinlikle başka bir yerde tanımlanamaz!!
- Metotlar kesinlikle metotların içerisinde tanımlanamaz demiştik, c# 7 da gelen local function özelliği sayesinde metot içerisinde metot tanımlanabilmektedir.
- Tanımlanmış metodun tanımlandığı sınıf dışından erişilip erişilmemesi durumunu belirleyen ifade erişim belirleyicisidir.
- Local functionslarda erişim belirleyicileri yoktur, direkt geri dönüş değerinden başlanır.
- Local function sadece tanımlandığı metodun içerisinde erişilebilir olacaktır.
- Local function olarak tanımlanan fonksiyon adı tanımlandığı fonksiyonun adınadna farklı olmalıdır! Aksi taktirde derleyici hatası vermez!!
- Local functionun tanımlandığı metod içerisinde her yerden erişilebilir(ister metodun üstünde ister altında).
- Bir metot sadece tek bir metotta tekrarlı bir şekilde kullanılacak bir algoritmayı kod parçacığını işlemi o metoda özel bir şekilde tek seferlik tanımlamamızı ve kullanmamızı sağlamaktadır.
- Anonim, Delegate, Func gibi ileri düzey programlamada bulunan muadilleri vardır.
***
##### Static Local Functions(Metot İçerisinde Tanımlanabilir Statik Yerel Metotlar)

##### Metotlarda Overloading (Çoklu Yükleme)
- Bir class içerisinde aynı isimde birden fazla metot tanımlanamaz!
- Bir sınıfın içerisinde aynı isimde birden fazla metot tanımlanamaz, belirli kurallar içerisinde.
- Bir classta aynı isimde birden fazla metot tanımlanmışsa eğer o isime overloading yapılmıştır.
- Bir class içerisinde belirli kurallar çerevesinde aynı isimde birden fazla metot oluşturmaya Method overloading denir.
***
**Bir sınıf içerisinde birden fazla aynı isimde metot tanımlayabilmek için şu kurallara dikkat edilmesi gerekmektedir;**
1. Bu fark bizzat metot imzalarında olmalıdır.
2. Metot overloading işlemini yapabilmek için metotların isimleri aynı olmalıdır.
3. Metotlar arasında farkı yaratırken erişim belirleyicileri ve geri dönüş değerleri aktif rol oynamaktadır.
4. Parametrelerin sayıları yada türleri farklı olmak zorundadır.
5. Overloading işlemine tabi tutulmuş metotlardan istediğimizi kullanabilmek için o metodun imzasına uygun parametreleri tetiklememiz yeterli olacaktır.
##### Recursive fonksiyonlar
- Kendi içerisinde kendisini çağıran tetikleyen fonksiyonlardır.
- Bu bir yaklaşımdır!
- Anlaşılması, kullanması ve anlatılması zordur.
###### Ne amaçla kullanılmaktadır?
- Öngörülemeyen, derinliği tahmin edilemeyen sonu bilinmeyen durumlarda tercih edilebilir.
##### Ref Keywordü Nedir? Ne Amaçla Kullanılmaktadır?
-  Ref Keywordü referanstan gelmektedir.
- Referans OOP kavramıdır.
- OOP de nesneler (object) Ramde heap bölgesinde tutulmaktadır.
- OOP de referanslar = operatörü ile iletişime geçebilmektedirler. Bir referans işaretlediği herhangi bir nesneyi = operatörü sayesinde farklı bir referansa işaretletebilir.
- Yani referanslar da = operatörü neticesinde herhangi bir verisel-nesnesel türeme söz konusu olmamakla, işaretlenmiş nesne diğer referans tarafından işaretlenmektedir.
- Ref keywordü değer türlü değişkenlerde referans operasyonları yapmamıız sağlayan bir keyworddür.
- Ref Keywordü değer türlü değişkenlerin referanslarını çağırmamızı kullanmamızı sağlayan bir keyworddür.
- Değer türlü değişkenlerde referans çalışması yapmak istiyorsak eğer ref keywordü kullanılır!
- Ref keywordü değer türlü değişkenlerin referans türlü değişkenler gibi çalışmasını sağlayan komuttur.
- Değer türlü değişkenlerde shallow copy yapmamızı sağlayan bir keyworddür.

```c#
int a = 5;  
ref int b = ref a;  
Console.WriteLine(a);  
Console.WriteLine(b);
```

Burda assign değil, b ile a aynı değeri görecek şekilde ayarlandı.
***
Örnek:
```c#
int a = 5;  
ref int b = ref a;  
Console.WriteLine(a);  
Console.WriteLine(b);  
  
a *=5;  
Console.WriteLine(b);  
b -=10;  
Console.WriteLine(a);  
Console.WriteLine(b);
```

***
Çıktı:
5
5
25
15
15
***

Örnek 2:

```c#
int y = 10;  
X(ref y);  
Console.WriteLine(y);  
  
void X(ref int a)  
{  
    a = 25;  
}

```
***
Çıktı:
25
***
```c#
int y = 10;  
X( y);  
Console.WriteLine(y);  
  
void X( int a)  
{  
    a = 25;  
}
```
***
Çıktı:
10
***
##### Ref keywordunde return değeri
- Sadece metotlarda geçerlidir.
- Metotlar geriye değer döndürebilen yapılardır. Ayrıca metotlarda geriye nesnelerde döndürebilmekteyiz. Ayrıca ref returns özelliği sayesinde değer türlü değişkenlerin referanslarınıda geriye döndürebilmekteyiz.
##### Out Keywordü Nedir? Ne Amaçla Kullanılmaktadır?
- Bir sistem düşünelim (şirket, teşkilat, metot). Dış dünyadan herhangi bir veri geliyorsa input diyoruz, dışarı çıkan veriye output diyoruz.
- Out keywordü metotların Parametreleri üzerinden dışarıya eddğer göndermemizi sağlayan bir keyworddür.
- Bir metodun parametreleri varsayılan olarak Inputtur, hliyle metotlarda tanımlanmış parametreler direkt olarak içeriye değer almaya odaklanır.
- Bir metodun parametresi dışarıya değer çıkaracaksa o parametrenin out keywordüyle işaretlenmesi gerekmektedir.
- Output parametrelerine muhakkak değer verilmelidir.
- Bir metot out parametreleri barındırıyorsa o pararmetrelere kendi içerisinde değer ataması gerekmektedir. Aksi takdirde derleyici hatası alacaktır! 

