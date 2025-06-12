# 👨‍💼 Personel Kayıt Sistemi

Bu proje, bir şirketin personel bilgilerini yönetmek amacıyla geliştirilmiş bir masaüstü uygulamasıdır. Uygulama, kullanıcı dostu bir arayüzle personel kayıtlarının güvenli ve düzenli bir şekilde tutulmasını sağlar. Proje, **C# (Windows Forms)** ile geliştirilmiş olup, veriler **Microsoft SQL Server** üzerinde saklanmaktadır.

---

## 🎯 Proje Amacı

- Yeni personel kaydı ekleme
- Mevcut kayıtları güncelleme
- Personel silme işlemleri
- Personel listesini görüntüleme
- Temel istatistik bilgilerini sunma
- Şehirlere ve mesleklere göre grafiksel analiz yapma
- Veritabanı işlemlerini **Stored Procedure**, **Function** ve **Trigger** kullanarak yönetme

---

## 🧱 Kullanılan Teknolojiler

- 💻 C# (Windows Forms - .NET Framework)
- 🗃️ Microsoft SQL Server
- 🧠 T-SQL (Stored Procedure, Function, Trigger)
- 📊 Chart bileşeni ile grafiksel analiz

---

## 🗃️ Veritabanı Yapısı

### Tablolar:
- `Tbl_Personel`: Personel bilgilerini tutar
- `Tbl_Yonetici`: Giriş yapan kullanıcı bilgileri
- `Tbl_Log`: Veritabanı işlemlerinin kayıt altına alındığı log tablosu

### Ana Özellikler:
- `sp_PersonelEkle`, `sp_PersonelGuncelle`, `sp_PersonelSil`, `sp_YoneticiGirisKontrol`, `sp_IstatistikGetir` gibi birçok stored procedure
- `fn_SehirdekiPersonelSayisi`: Verilen şehirdeki personel sayısını döndüren fonksiyon
- `trg_PersonelEklendiLog`, `trg_PersonelSilmeKontrol`: Kayıt ekleme ve silme işlemlerine özel triggerlar

---

## 🧩 Uygulama Özellikleri

- 👤 Giriş ekranı (Yönetici kontrolü)
- 📋 Personel listesi ve işlemler
- 📈 İstatistik formu (toplam/ortalama maaş, medeni durum analizi)
- 🧭 Grafik formu (şehir ve meslek bazlı analiz)

---

## 🔐 Güvenlik ve Kontrol

- Trigger kullanımı ile maaşı 1000 TL altında olan personelin silinmesi engellenmiştir.
- Yeni kayıtlar loglanarak veritabanı hareketleri kayıt altına alınır.

---

## 🖼️ Ekran Görüntüleri

- Giriş Formu
- Ana Form (Listeleme & İşlemler)
- İstatistik Ekranı
- Grafik Ekranı

---

## 🎥 Proje Tanıtım Videosu

📺 [YouTube Video Linki][(https://youtu.be/3nO8b8Anw1g)

---



Bu proje, veri tabanı işlemlerinde **performans**, **güvenlik** ve **kullanıcı dostu arayüz** prensiplerini temel alarak geliştirilmiştir.
