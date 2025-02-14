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
- 

