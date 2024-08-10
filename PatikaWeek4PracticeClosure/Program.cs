/* 
Program akışı:

1- Konsol ekranından kullanıcıya telefon üretmek için 1 bilgisayar üretmek için 2'ye basması gerektiğini söyleyiniz.

2- Kullanıcının seçimine göre ilgili classtan nesne üreterek özelliklerini konsol ekranından yani kullanıcıdan alınız.

3- Bütün bilgiler girildiğinde ürünün başarıyla üretildiğini bir mesaj ile bildirip başka bir ürün üretmek isteyip istemediğini sorunuz.

4- Kullanıcı evet cevabını verirse 1. aşamaya geri dönünüz, hayır cevabını verirse iyi günler dileyerek uygulamayı sonlandırınız.
*/


using PatikaWeek4PracticeClosure;
using System.ComponentModel.Design;

string lastChoice = ""; // Defining a null string

do // Using do-while loop
{

    Console.WriteLine("Merhaba At Mavalı Üretsin Yalanı Tesisine Hoşgeldiniz!");

FirstQuestion: // If user enters data other than 1 or 2, it will be asked again here.

    Console.Write("Telefon ve Bilgisayar arasından üretmek istediğinizi seçiniz( 1 veya 2 tuşlayın): ");
    string firstChoice = Console.ReadLine().ToLower();

    if (firstChoice == "1") // Asking phone features to the user and setting properties
    {
        Console.WriteLine("Telefon üretmeyi seçtiniz.");
        Telefon telefon1 = new Telefon();

        Console.Write("Lütfen telefonunuz için bir ad giriniz: ");
        telefon1.Name = Console.ReadLine();

        Console.Write("Lütfen telefonunuz için bir seri numarası giriniz: ");
        telefon1.SerialNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Lütfen telefonunuzda olmasını istediğiniz işletim sistemini giriniz: ");
        telefon1.OperatingSystem = Console.ReadLine();

        Console.Write("Telefonunuzun TR lisansı olmasını ister misiniz? (Evet ya da Hayır olarak cevap verin lütfen): ");
        string trLicenceChoice = Console.ReadLine().ToLower();

        if (trLicenceChoice == "evet") // Checking Tr Licence
        {
            telefon1.ValidTrLicence = true;
        }
        else
        {
            telefon1.ValidTrLicence = false;
        }

        Console.WriteLine("Telefonunuz başarıyla oluşturuldu. İşte detayları...");

        // Calling methods to display informations
        telefon1.UrunAdıGetir();

        telefon1.BilgileriYazdir();

    }

    else if (firstChoice == "2") // Asking computer features to the user and setting properties
    {
        Console.WriteLine("Bilgisayar üretmeyi seçtiniz.");
        Bilgisayar bilgisayar1 = new Bilgisayar();

        Console.Write("Lütfen bilgisayarınız için bir ad giriniz: ");
        bilgisayar1.Name = Console.ReadLine();

        Console.Write("Lütfen bilgisayarınız için bir seri numarası giriniz: ");
        bilgisayar1.SerialNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Lütfen bilgisayarınızda olmasını istediğiniz işletim sistemini giriniz: ");
        bilgisayar1.OperatingSystem = Console.ReadLine();

        Console.Write("Lütfen bilgisayarınızda kaç adet USB Port girişi istediğinizi yazınız(2 veya 4 seçeneklerimiz mevcuttur): ");
        bilgisayar1.UsbPortCount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Bilgisayarınızda Bluetooth özelliği olsun ister misiniz (Evet ya da Hayır yazınız): ");
        string bluetoothChoice = Console.ReadLine().ToLower();

        if (bluetoothChoice == "evet") // Checking bluetooth features
            bilgisayar1.ValidBluetooth = true;
        else
            bilgisayar1.ValidBluetooth = false;

        Console.WriteLine("Bilgisayarınız başarıyla oluşturuldu. İşte detayları...");

        // Calling methods to display informations
        bilgisayar1.UrunAdıGetir();

        bilgisayar1.BilgileriYazdir();

    }

    else // If user enters data other than 1 or 2, this condition will triggered
    {
        Console.WriteLine("Hatalı tuşlama yaptınız, lütfen 1 veya 2'yi tuşlayınız.");

        goto FirstQuestion; 
    }

    // The user is asked whether he/she wants to create another new product again.
    Console.WriteLine("Yeni bir ürün daha yapmak ister misiniz?");
    lastChoice = Console.ReadLine().ToLower();

    if (lastChoice == "evet")
    {
        Console.WriteLine("O zaman sizi başa yolluyorum\nHoopppp gittiniz.");
    }
    else if (lastChoice == "hayır")
    {
        Console.WriteLine("Peki iyi günler, ne zaman isterseniz buradayız tekrar bekleriz.");
    }
    else
    {
        Console.WriteLine("İyi günler programı sonlandırıyorum.");
    }

} while (lastChoice == "evet");