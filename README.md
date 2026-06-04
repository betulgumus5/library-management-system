 Kütüphane Otomasyon Sistemi (Library Management System)

Bu proje, kütüphane yönetim süreçlerini dijitalleştirmek; kitap kayıtlarını, üye işlemlerini ve ödünç alma/iade süreçlerini kolayca yönetmek amacıyla geliştirilmiş bir masaüstü uygulamasıdır.
Ayşe Betül Gümüş
360125016
Bilgisayar Programcılığı
Görsel Programlama & Veri Tabanı
 
 Kullanılan Teknolojiler & Araçlar
Geliştirme Ortamı: Visual Studio
Programlama Dili: C# (Windows Forms)
Veritabanı:MSSQL Server 2022 Express
Tasarım & Sunum: Canva

 Proje Klasör Yapısı
Proje deposu (repository) aşağıdaki gibi organize edilmiştir:
VisualStudio: Projenin tüm C# kaynak kodlarını ve form tasarımlarını içerir.
Database.sql: Veritabanı tablolarını ve şemasını oluşturan SQL script dosyasını barındırır.
Documents: Projeye ait Görsel Programlama ve Veri Tabanı ders sunumlarının PDF dosyalarını içerir.

Kurulum ve Çalıştırma Talimatları
1.Veritabanını Hazırlama: `Database.sql` klasöründeki `.sql` dosyasını SQL Server Management Studio (SSMS) üzerinde açarak `Execute` edin.
2. Projeyi Açma:`VisualStudio` klasörünün içindeki `.sln` (Solution) dosyasına çift tıklayarak projeyi Visual Studio ile açın.
3. Bağlantı Cümlesi Ayarı:Kod içerisindeki `SqlConnection` adresinin kendi local `.\SQLEXPRESS` server adınızla uyuştuğundan emin olun.
4. Çalıştırma:Visual Studio üzerinden `Start` butonuna basarak uygulamayı çalıştırabilirsiniz.
