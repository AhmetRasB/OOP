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
- Parametre almaz metot gibi, içerisinde get; ve set; adında 2 metot bulundurur.
- Propertyin işlevsel açıdan metottan farkı yoktur lakin davranışsal olarak nesne üzerinde bir değer okuma ve değer atama işlemlerinde kullanılır.

![[Pasted image 20250220150156.png]]
- Property nin değeri çağırıldığında (get) tetiklenir ve değeri return eder.
- Property nin bir  değeri  atandığında (set) e yakalanır.
*** 
##### Kapsülleme (Encapsulation Nedir?)
- Kapsülleme bir nesne içerisindeki dataların(fieldlardaki verilerin) dışarıya kontrollü bir şekilde açılası ve koontrollü bir şekilde veri almasıdır.

![[Pasted image 20250220185550.png]]

![[Pasted image 20250220210417.png]]

- Field hangi türden bir fieldi temsil ediyorsa o türden olmalıdır.
- Temsil edecekleri fieldin baş harfi büyük başlar. (orn: field = adi, property = Adi)
- Get property üzerinden değer talep edildiğinde tetiklenir, yani bu değer gönderilir.
- Property üzerinden değer gönderilecekse set bloğu ile gönderilir.
##### PROP
- Bir property her ne kadar encapsulation yapsada temsilettiği fieldda ki dataya hiç müdahale etmeden erişilmesini ve veri atanmasını sağlıyorsa böyle bir durumda kullanılan propery imzasıdır.

![[Pasted image 20250221100240.png]]
- Hayır fieldda ki değere müdahale olsun olmasın direkt erişim yapılmasını istemiyoruz. Bu alışkanlığımız olsun. Haliyle böylebir durumda yine property kullanacağız. Sadece get ve setblokları aşağıdaki gibi tanımlanması yeterli olacaktır.

![[Pasted image 20250221100349.png]]
- Prop propertyler compie edildiklerinde arka planda kendi fieldlarını oluştururlar. Dolayısıyla bir field tanımlamaya gerek yoktur.
- Prop imzalarda ilgili property read only olabilir lakin write only olamaz.

##### Auto Property Initializers 
- Bir propertynin ilk değerini nesne ayağa kaldırır kaldırmaz aşağıdaki gibi verebiliriz;

![[Pasted image 20250221101608.png]]

- Auto property initializers özelliği sayesinde read only olan proplara hızlıca değer atanabilmektedir.

##### Ref Readonly Returns

![[Pasted image 20250221102918.png]]

- ref readonly returns, bir sınıf içerisindeki field referansıyla döndürmemizi sağlayan ve bir yandan da bu değişkenin değerini readonly yapan özelliktir.

##### Computed Property 
- İçerisinde türetilmiş bir bağıntı taşıyan propertylerdir. 
- Aritmetik hesaplama varsa kullanılır.

##### Expression-Bodied Property
- Tanımlanan property de Lambda Expression kullanmamızı sağlayan söz dizimidir.

![[Pasted image 20250221150226.png]]

- Sadece readonly larda kullanılır!
- Kısmi olarak Auto Property Initializersin akrabasıdır diyebiliriz.

##### Inıt-Only Properties - Init Accessor
- Nesnenin sadece ilk yaratılış anında propertylerine değer atamaktadır.
- Böylece iş kuralı gereği runtimeda değeri değişmemesi gereken nesneler için bir önlem alınmaktadır.
- Developer açısından süreç esnasında değiştirilmemesi gereken property değerlerinin "yanlışlıkla" değiştirilmemesinin önüne geçmekte ve böylece olası hata ve buglardan yazılımı arındırmaktadır.

![[Pasted image 20250221150536.png]]

##### Indexer
- Nesneye indexer özelliği kazandıran fıtrat olarak property ile birebir aynı olan elemandır.

![[Pasted image 20250221152521.png]]

##### Class Elemanlarına Açıklama Satırı Nasıl Eklenir?

![[Pasted image 20250222130206.png]]

-  Bizim kendi adımıza yazmış olduğumuz kodu daha sonraki süreçlerde geriye döndüğümüzde daha iyi kavramamıza yarar.
![[Pasted image 20250222130314.png]]

##### This keywordü
- This keywordü ilgili class yapılanmasının o anki nesnesine karşılık gelir.
- This kullanmak zorunda değiliz.
### Nesne Nedir?

- Nesneler complex değerlerdir. (int,string,bool vb. değil)
- Nesneleri modellememizi sağlayan classlar ise complex typelardır 
- İçerisinde bir veya birden fazla değer barındırabilen anlamlı bir organizmadır.
- O verilerin üzerinde işlem yapıp değerler üretebilir.
- Nesne oluşturmak için **Sadece class**.
##### new Operatörü ile nesne üretimi
- Nesne üretimi için new operatörü kullanılmaktadır.

![[Pasted image 20250222165651.png]]

##### Target-Typed New Expressions 
- Nesne oluşum sürecinde oluşturulacak olan nesne eğerki direkt bir referansa atılıyorsa eğer burada hangi nesnenin oluşturulduğu referans sayesinde bilinmektedir.

![[Pasted image 20250222171327.png]]

##### Referans Nedir?
- Ramin Stack bölgesinde tanımlanan ve Heap bölgesindeki nesneleri işaretleyen-referans eden eğişkenlerdir-noktalardır.

![[Pasted image 20250222185045.png]]

- Referanslar illa bir nesne referans etmek zorunda değiller.
- Eğerki bir referans herhangi bir nesne işaretlemiyorsa null değerini alır.

##### Stack - Heap İlişkisi
- Nesneler neden referansla işaretleniyor? Neden referans kullanıyoruz? 
- Referans üzerinden nesneye nasıl erişilebilir?
##### Referanssız Nesneler
- Bir nesne oluşturulduğu an herhangi bir referansla işaretlenmezse eğer Heap'e yerleştirilir.
- Lakin bu nesneye tarafımızca birdaha erişemeyiz. Haliyle ilgili nesneyle aramızdaki tek diyalog oluşturma anıdır.
- Eğerki bir nesne referanssızsa bunu oluşturabiliriz. lakin bu nesne sistemde memory de lüzumsuz yer kaplayacağından dolayı belli bir süre sonra garbage collector dediğimiz cop toplayıcısı tarafından temizlenecektir.
- GC: heapde referanssız olan nesneleri imha etmekten temizlemekten sorumllu bir yapılanmadır.
##### Shallow Copy 
- Var olan bir nesnenin, değerin, referansının kopyalanmasıdır. Shallow copy neticesinde eldeki değer çoğaltılmaz. Sadece birden fazla referansla işaretlenmiş olur.
- Nesne tek işaretleyen birden fazla.
- Referans türlü değişkenlerin default davranışı shallow copydir.
##### Deep Copy 
- Var olan bir nesne deep copy ile kopyalanıyorsa eğer ilgili nesne miktarı çoğalır. Aynı özelliklere ve değerlere sahip olan bellekte frklı bir nesne oluşur
- Değer türlü değişkenlerde default davranış deep copydir.