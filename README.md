# 📖 Telefon Rehberi CRUD Uygulaması (C# Windows Forms)

Bu proje, C# Windows Forms ve Entity Framework kullanılarak geliştirilmiş, temel veritabanı işlemlerini (CRUD) ve dinamik arama özelliklerini barındıran bir masaüstü uygulamasıdır. Kullanıcıların kişi eklemesini, güncellemesini, silmesini ve mevcut kişiler arasında gerçek zamanlı arama yapmasını sağlar.

---

## ✨ Özellikler

* **Listeleme (Read):** Veritabanındaki tüm kayıtlar açılışta `DataGridView` üzerinde listelenir.
* **Yeni Kayıt Ekleme (Create):** İsim, soyisim ve telefon numarası girilerek yeni kişi eklenebilir. Format hatalarına karşı `try-catch` blokları ile basit hata yönetimi yapılmıştır.
* **Kayıt Güncelleme (Update):** Tablodan seçilen bir kişinin bilgileri anlık olarak TextBox'lara aktarılır ve güncellenebilir.
* **Kayıt Silme (Delete):** Seçilen kişi veritabanından kalıcı olarak silinir.
* **Dinamik Arama (Search):** LINQ teknolojisi kullanılarak harf girildikçe anlık filtreleme yapılır:
  * İsme göre arama (`Contains` metodu ile büyük/küçük harf duyarsız)
  * Soyisme göre arama
  * Telefon numarasına göre arama

---

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C#
* **Arayüz:** Windows Forms (.NET)
* **ORM (Veri Erişim):** Entity Framework (Code First Yaklaşımı)
* **Veritabanı İşlemleri:** LINQ (Language Integrated Query)
* **Veritabanı:** SQL Server (Varsayılan Entity Framework sağlayıcısı üzerinden)

---

## 📂 Proje Mimarisi

Proje, veri erişim katmanı ile arayüzün birbirinden ayrıldığı basit bir mimari üzerine kurulmuştur:

* **`ProductDal.cs` (Data Access Layer):** Veritabanı bağlantılarını (`PhoneContext`) ve Entity Framework durum yönetimini (`EntityState.Added`, `Modified`, `Deleted`) barındıran sınıftır. Veri çekme ve manipülasyon işlemleri burada gerçekleşir.
* **`Form1.cs` (UI Layer):** Kullanıcı etkileşimlerinin yakalandığı, arama algoritmalarının tetiklendiği ve form elemanlarının yönetildiği sınıftır.
* **`PhoneContext` & `product`:** Veritabanı tablolarının sınıflara (Entity) modellendiği Code-First yapısıdır.

---

## 🚀 Kurulum ve Çalıştırma

1. Projeyi bilgisayarınıza klonlayın veya `.zip` olarak indirin.
2. Visual Studio'yu açın ve çözüm (`.sln`) dosyasını yükleyin.
3. Projede **Entity Framework** kullanıldığı için, Package Manager Console üzerinden gerekli paketlerin yüklü olduğundan emin olun:
   ```bash
   Install-Package EntityFramework
Veritabanı bağlantı cümlenizin (Connection String) App.config veya Web.config dosyasında doğru yapılandırıldığından emin olun. Eğer Code-First kullanıyorsanız, SQL Server üzerinde PhoneContext isminde bir veritabanı otomatik oluşacaktır.

F5 tuşuna basarak projeyi derleyin ve çalıştırın.

💡 Kullanım İpuçları
Tablodan herhangi bir hücreye tıkladığınızda (CellClick eventi), o satırdaki veriler otomatik olarak "Güncelleme" paneline aktarılır.

Arama kutularına metin girerken büyük/küçük harfe dikkat etmenize gerek yoktur; sistem ToLower() metodu ile arka planda metinleri eşleştirir.

Arama kutusunu tamamen temizlediğinizde tablo otomatik olarak orijinal haline (tüm kayıtlar) geri döner.
