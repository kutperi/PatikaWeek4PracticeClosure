# Ürün Üretim Sistemi

Bu proje, kullanıcıların telefon veya bilgisayar üretmesini sağlayan basit bir konsol uygulamasıdır. Kullanıcı, ürün türünü seçtikten sonra ürün özelliklerini belirleyebilir ve bu bilgileri görüntüleyebilir.

## İçindekiler
- [Kullanım](#kullanım)
- [Kod Yapısı](#kod-yapısı)
- [Özellikler](#özellikler)

## Kullanım

1. Uygulamayı başlattığınızda, sizi bir karşılama mesajı karşılayacak.
2. Ardından, telefon veya bilgisayar üretmek isteyip istemediğiniz sorulacak. 1 veya 2 tuşlayarak seçiminizi yapın.
3. Seçtiğiniz ürüne bağlı olarak, çeşitli bilgileri girmeniz istenecek (ad, seri numarası, işletim sistemi vb.).
4. Ürün oluşturulduktan sonra, ürünün özellikleri ekranda görüntülenecek.
5. Yeni bir ürün oluşturmak isteyip istemediğiniz sorulacak. Evet derseniz süreç başa döner, hayır derseniz program sonlanır.

## Kod Yapısı

### 1. Ana Program Dosyası
- **Main.cs**
  - Bu dosya, kullanıcı etkileşimlerini yönetir ve `Telefon` veya `Bilgisayar` sınıflarını kullanarak ürün oluşturur.
  - Kullanıcıdan gelen verileri alır ve ilgili sınıfların özelliklerini ayarlar.
  - Kullanıcıdan yeni bir ürün isteyip istemediği tekrar sorulur ve döngü bu şekilde devam eder.

### 2. Sınıflar ve Miras Yapısı
- **BaseMakine.cs**
  - `BaseMakine` sınıfı, telefon ve bilgisayar gibi ürünlerin ortak özelliklerini ve yöntemlerini tanımlar. 
  - `BilgileriYazdir` ve `UrunAdıGetir` gibi metodlar bu sınıfta tanımlıdır.
  
- **Telefon.cs**
  - `Telefon` sınıfı, `BaseMakine` sınıfından miras alır ve telefon ürünlerine özgü özellikleri ekler. Örneğin, TR lisansını kontrol eder.
  
- **Bilgisayar.cs**
  - `Bilgisayar` sınıfı, `BaseMakine` sınıfından miras alır ve bilgisayar ürünlerine özgü özellikleri ekler. Örneğin, USB port sayısını ve Bluetooth özelliğini kontrol eder.

## Özellikler

- **Telefon** ve **Bilgisayar** üretimi yapılabilir.
- Ürünler için **ad**, **seri numarası**, **işletim sistemi** gibi özellikler girilebilir.
- Telefon için **TR Lisansı** ve bilgisayar için **USB port sayısı** ile **Bluetooth** özellikleri kontrol edilebilir.
- Kullanıcı, yeni bir ürün oluşturmak isteyip istemediğini belirleyebilir.
