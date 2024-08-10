using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaWeek4PracticeClosure
{
    // Creating a base class
    public abstract class BaseMakine
    {
        // Defining fields 
        private DateTime _productionDate;
        private int _serialNumber;
        private string _name;
        private string _description;
        private string _operatingSystem;

        // Defining properties and encapsulation
        public DateTime ProductionDate { get; set; }

        public int SerialNumber { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string OperatingSystem { get; set; }

        // Method that display common informations
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Üretim Tarihi --> {ProductionDate}");
            Console.WriteLine($"Seri Numarası --> {SerialNumber}");
            Console.WriteLine($"Adı --> {Name}");
            Console.WriteLine($"Açıklama --> {Description}");
            Console.WriteLine($"İşletim Sistemi --> {OperatingSystem}");
        }

        // An abstract method 
        public abstract void UrunAdıGetir();
     
    }

    // Creating a new class that inherits from base class
    public class Telefon : BaseMakine
    {
        
        private bool _validTrLicense; // Checking Tr licence

        public bool ValidTrLicence { get; set; } 

        public Telefon()
        {
            ProductionDate = DateTime.Now; // Whenever this constructor is run, time will be registered at that moment
        }

        public override void UrunAdıGetir() // Overriding the abstract method coming from base class
        {
            Console.WriteLine($"Telefonunuzun Adı --> {Name}");
        }

        public override void BilgileriYazdir() // Overriding this method for adding new properties
        {
            base.BilgileriYazdir();
            Console.WriteLine(ValidTrLicence ? "TR Lisansı Var" : "TR Lisansı Yok");

        }
    }

    // Creating a new class that inherits from base class
    public class Bilgisayar : BaseMakine 
    {
        private int _usbPortCount; 

        private bool _validBluetooth; // Checking Bluetooth feature

        public int UsbPortCount 
        {
            get
            {
                return _usbPortCount;
            }
            set
            {
                if (value == 2 || value == 4) // Checking USB port number
                {
                    _usbPortCount = value;
                }
                else
                {
                    Console.WriteLine("USB Port sayısı sadece 2 veya 4 olabilir, başka seçenekler mevcut değildir.");
                    _usbPortCount = -1; // If it is not 2 or 4 adding -1
                }
            }
        }

        public bool ValidBluetooth { get; set; }

        public Bilgisayar()
        {
            ProductionDate = DateTime.Now; // // Whenever this constructor is run, time will be registered at that moment
        }

        public override void UrunAdıGetir() // Overriding the abstract method coming from base class
        {
            Console.WriteLine($"Bilgisayarınızın adı --> {Name}");
        }

        public override void BilgileriYazdir() // Overriding and adding computer properties.
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Port Sayısı --> {UsbPortCount}");
            Console.WriteLine(ValidBluetooth ? "Bluetooth Özelliği Var" : "Bluetooth Özelliği Yok");
        }
    }
}
