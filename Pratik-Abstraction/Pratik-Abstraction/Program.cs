// Çalışanlardan birkaç örnek nesne oluşturulması
using Pratik_Abstraction;

YazilimGelistirici yazilimci = new YazilimGelistirici { Ad = "Ali", Soyad = "Yılmaz", Departman = "Yazılım" };
ProjeYoneticisi projeYoneticisi = new ProjeYoneticisi { Ad = "Hasan", Soyad = "Çıldırmış", Departman = "Proje Yönetimi" };
SatisTemsilcisi satisci = new SatisTemsilcisi { Ad = "Ayşe", Soyad = "Kara", Departman = "Satış" };

// Her çalışanın görevini çağırma
yazilimci.Gorev();
projeYoneticisi.Gorev();
satisci.Gorev();