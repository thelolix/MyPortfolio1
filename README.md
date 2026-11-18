<div align="center">

# 🚀 ASP.NET Core MVC & MS SQL Server Portfolio Project

<img src="https://img.shields.io/badge/C%23-.NET-239120?style=for-the-badge&logo=csharp&logoColor=white" />
<img src="https://img.shields.io/badge/ASP.NET%20Core-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
<img src="https://img.shields.io/badge/MS%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" />
<img src="https://img.shields.io/badge/Bootstrap%205-7952B3?style=for-the-badge&logo=bootstrap&logoColor=white" />
<img src="https://img.shields.io/badge/Architecture-Clean%20%26%20Layered-blue?style=for-the-badge" />

*Modern web teknolojileri ve ilişkisel veritabanı mimarileriyle geliştirilmiş, uçtan uca dinamik kişisel portfolyo ve yönetim paneli.*

</div>

---

## 📌 Proje Hakkında

Bu proje; yazılım geliştirme sürecinde edinilen teorik bilgileri gerçek dünya projelerine dönüştürmek, katmanlı mimari prensiplerini uygulamak ve profesyonel bir dijital kimlik sergilemek amacıyla **ASP.NET Core MVC** katmanı üzerinde geliştirilmiştir. Projede hiçbir statik (hardcoded) veri bulunmamakta; tüm içerikler **MS SQL Server** veritabanından dinamik olarak çekilmektedir.

---

## 📸 Proje Ekran Görüntüleri

### 🌐 Ana Sayfa & Portfolyo Arayüzü
Ziyaretçileri karşılayan modern, duyarlı (responsive) ve dinamik arayüz tasarımı.
<p align="center">
  <img src="https://github.com/user-attachments/assets/d373402c-90a9-4354-84b0-11fd3a2dc76e" alt="AnaSayfa" width="100%">
</p>

### 👤 Hakkımda Bölümü
<p align="center">
  <img src="https://github.com/user-attachments/assets/8b42fbf7-226c-4bb2-b9cc-07fbcd333330" alt="Hakkımda" width="100%">
</p>

### 💼 Deneyimler & Profesyonel Yolculuk
<p align="center">
  <img src="https://github.com/user-attachments/assets/0c76ac92-f9e2-40b4-a130-a81db6500864" alt="Deneyimler" width="100%">
</p>

### 📬 İletişim Formu Arayüzü
<p align="center">
  <img src="https://github.com/user-attachments/assets/0634dca1-8cbe-4f0c-9100-3617fbce39a0" alt="İletişim" width="100%">
</p>

---

### ⚙️ Yönetim Paneli (Admin Dashboard)
Tüm portfolyo verilerinin anlık istatistikler, grafikler ve kart yapılarıyla yönetildiği ana kontrol merkezi.
<p align="center">
  <img src="https://github.com/user-attachments/assets/7e6c8c26-8bde-4289-a798-12d31de65b1d" alt="Dashboard" width="100%">
</p>

### 📚 Eğitim Yönetim Tablosu (CRUD)
<p align="center">
  <img src="https://github.com/user-attachments/assets/ce422f37-6253-42ec-a23a-3dd7cb162572" alt="Egitim" width="100%">
</p>

### 💬 Gelen Mesajlar Listesi
<p align="center">
  <img src="https://github.com/user-attachments/assets/953cd821-ff4e-43cc-95b8-6a03709982f9" alt="Msj" width="100%">
</p>

### 🔍 Mesaj Detay Modal Görünümü
<p align="center">
  <img src="https://github.com/user-attachments/assets/19c31a24-44bf-4e41-bbbf-48c83614663e" alt="Msj_Detay" width="100%">
</p>

---

## 🛠️ Kullanılan Teknolojiler & Altyapı

* **Backend:** C#, ASP.NET Core MVC, LINQ, ViewComponents
* **Veritabanı & ORM:** MS SQL Server, T-SQL, Entity Framework Core (Code First / DbContext)
* **Mimari & Tasarım:** Katmanlı Mimari (Layered Architecture), OOP Prensipleri
* **Frontend:** HTML5, CSS3, Bootstrap 5, JavaScript (ES6+), Bootstrap Icons
* **Sürüm Kontrolü:** Git & GitHub

---

## ✨ Öne Çıkan Özellikler

* **Dinamik İçerik Mimarisi:** `ViewComponent` yapıları sayesinde veritabanındaki verilerin ana sayfaya modüler ve performanslı bir şekilde yansıtılması.
* **Kapsamlı Admin Paneli:** Projelerin, sertifikaların ve yetkinliklerin dışarıdan müdahaleye gerek kalmadan yönetilebilmesi.
* **İnteraktif İletişim Sistemi:** Ziyaretçi mesajlarının anlık olarak sisteme düşmesi, okunmadı/okundu statülerinin admin panelinden yönetilmesi.
* **Modern UI/UX Deneyimi:** Özel kart tasarımları, animasyonlu yazı geçişleri ve şık renk paleti.

---

## 📂 Proje Katman Yapısı

```text
MYAcedemy_Portfolio_Project/
│
├── Controllers/       # MVC Controller sınıfları (Admin ve Default rotaları)
├── Context/           # Entity Framework Core DbContext sınıfı
├── Entites/           # Veritabanı tablolarına karşılık gelen modeller
├── ViewComponents/    # Sayfa parçacıklarını dinamik yöneten bileşenler
└── Views/             # Razor (.cshtml) arayüz görünümleri
