# eFatura Generator
Windows Forms c# .net framework ile e-Fatura basımını kolaylaştırmak için yazılmış programdır
## Arayüz Tasarımı ve Açıklamaları
<img src = "https://github.com/mustafayakin/eFatura-Generator/blob/main/readme%20Görselleri/1.PNG" width=1200px height=600px> 
Arayüz tasarımımız böyle. 
Firma bilgileri ve müşteri bilgileri girildikten sonra ürünler sol alttan seçiliyor. Datagridview ile ürün ekleyebilir, daha sonra bu ürünleri SEÇ butonu ile seçebilirsiniz. Aynı ürünü seçtikçe adet sayısını arttırabilir ya da seçilen ürünler datagridview'ini kullanarak adet sayısında oynama yapabilirsiniz.  Eğer fiyatı hesaplamak istiyorsanız sol üstteki kısımdan hesaplama yapabilir iskonto ve kdv oranlarında değişiklik yapabilirsiniz.

Eklenilen Özellikler:

 - Adet sayısı 0 olarak seçilirse seçilen ürünler kısmından ürün siliniyor.
 - Adet sayısı kısmı boş bırakılırsa ***boş bırakılamaz!*** uyarısı veriliyor.
 - Eğer hiçbir ürün seçilmeden fiyat hesaplama tuşuna basılırsa **uyarı** veriliyor.
 - Firma logosu ekleme kısmından firmanın logosu eklenebiliyor.
 - KDV ve İskonto oranları belirlenebiliyor.
 - PDF olarak gösterme ve istenildiği takdirde yazdırma butonları aktif olarak çalışıyor.
 - Ürünler datasının altına yeni ürünler eklenebiliyor (eklenen ürünler test amaçlı koyulmuştur)
 
## Ürünler Eklendikten Sonra Görsel
<img src = "https://github.com/mustafayakin/eFatura-Generator/blob/main/readme%20Görselleri/2.PNG" width=1200px height=600px> 
 Seçilen ürünler kısmında fiyat ve isim kısmını onlyRead yaptım ki ürünlerin adlarını burada değiştirip hata oluşmasının önüne geçmek gerekiyor.
 
## Tutar Hesaplama Kısmı
<img src = "https://github.com/mustafayakin/eFatura-Generator/blob/main/readme%20Görselleri/3.PNG" width=1200px height=600px> 
Eğer iskonto ve KDV verilmez ise bunları 0 olarak kabul ediyorum, ve buna göre hesaplama yapıyorum. Fakat değerleri verilirse, Seçilen ürünlerin hepsini foreach ile dönüp adet sayısı ve birim fiyatı ile çarpıp kdv'sini hesaplayıp en son iskontosunu çıkarıyorum. 

## PDF Olarak Kaydet Butonu
<img src = "https://github.com/mustafayakin/eFatura-Generator/blob/main/readme%20Görselleri/4.PNG" width=1200px height=600px> 
bu butona basıldığında görsel böyle oluyor. Sol üstteki yazıcı simgesine basarak bilgisayarınıza bu PDF'yi kaydedebilirsiniz.

## PDF Görseli 
<img src = "https://github.com/mustafayakin/eFatura-Generator/blob/main/readme%20Görselleri/5.PNG" width=667px height=724px> 
PDF birebir Türkiye Cumhuriyeti Gelir İdaresi Başkanlığının formatında hazırlanmıştır. Tüm kısımları doğrudur. Sağ üstteki tabloda faturanın oluşturulma tarihi ve oluşturulma zamanı görülebilmektedir. Bir altındaki ana tabloda ürünler miktarları ve birim fiyatları görülebilir. Onun altındaki kısımda irsaliye yerine geçer ve toplam ödenmesi gereken tutarın yazılışını görebilirsiniz. Bunların hepsi dinamik biçimde oluşur. Onun bir altında da banka hesabı ekleyebileceğiniz kısımı görebilirsiniz.

***Oluşturulan faturanın bir örneğini burada görebilirsiniz:*** <a href src= "https://github.com/mustafayakin/eFatura-Generator/blob/main/readme%20Görselleri/ornekFatura.pdf">link</a>
