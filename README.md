# Afet Çantam Hazır mı?

## Proje Hakkında

Afet Çantam Hazır mı?, Unity ve C# kullanılarak geliştirilmiş eğitici bir 3D oyun projesidir. Oyun, çocuklara afet öncesinde ve sonrasında ihtiyaç duyabilecekleri temel ekipmanları eğlenceli bir şekilde öğretmeyi amaçlamaktadır.

Oyuncu farklı afet senaryolarında (deprem, sel, heyelan ve yangın) doğru malzemeleri toplayarak afet çantasını hazırlamaya çalışır. Oyunlaştırma (Gamification) yaklaşımı kullanılarak afet farkındalığının artırılması hedeflenmiştir.

## Özellikler

- 3D Unity oyun ortamı
- Deprem, Sel, Heyelan ve Yangın sahneleri
- Bilge Dede sesli bilgilendirme sistemi
- Puanlama sistemi
- Liderlik tablosu (Scoreboard)
- Oyuncu adı kaydetme
- Sahne geçişleri
- Eğitsel içerik ve afet farkındalığı

## Kullanılan Teknolojiler

- Unity
- C#
- TextMeshPro
- PlayerPrefs
- SceneManager
- AudioSource
- Visual Studio

 ## Oyun Senaryosu

Oyuncu afet bölgelerinde ilerlerken karşısına çıkan nesneler arasından doğru ekipmanları toplar. Her afet türü için gerekli ekipmanlar farklıdır. Doğru seçimler oyuncuya puan kazandırırken yanlış seçimler puan kaybına neden olur.

Oyunun sonunda oyuncunun puanı hesaplanır ve sıralama ekranında gösterilir.

## Proje Amacı

Bu proje, çocukların afetlere hazırlıklı olma konusunda bilinçlenmelerini sağlamak ve afet çantasında bulunması gereken temel ekipmanları öğretmek amacıyla geliştirilmiştir.

## Oyundan Görseller

### Menü Ekranı 

Oyunda karşılaşılan ilk sahnedir.

<img width="1206" height="611" alt="Ekran görüntüsü 2026-06-23 070006" src="https://github.com/user-attachments/assets/5b43a176-0e44-40d6-a51f-c66309bb3e02" />


### Deprem Sahnesi 

Erişimin olduğu tek sahnedir. Oyuncu bu sahneyi geçtiğinde kilitli olan sel sahnesine erişim sağlayabilir.

<img width="1208" height="612" alt="Ekran görüntüsü 2026-06-23 070021" src="https://github.com/user-attachments/assets/a08c989e-4ae4-4531-b7cb-a460a5e919e1" />


### Sel Sahnesi

Oyuncu bu sahneyi geçtikten sonra heyelan sahnesini aktif hale getirebilir.

<img width="1210" height="615" alt="Ekran görüntüsü 2026-06-23 070053" src="https://github.com/user-attachments/assets/9fdea73f-3006-4a68-8733-d9a125c0e586" />


### Heyelan Sahnesi

Oyuncu bu sahneyide başarıyla tamamladıktan sonra oyunun son sahnesi olan yangın sahnesine erişim sağlayabilir

<img width="1207" height="612" alt="Ekran görüntüsü 2026-06-23 070037" src="https://github.com/user-attachments/assets/711a6cce-e309-456e-aa88-e51185b60e47" />


### Yangın Sahnesi 

Oyuncunun karşılaştığı son afete hazırlık sahnesidir.

<img width="1205" height="620" alt="Ekran görüntüsü 2026-06-23 070106" src="https://github.com/user-attachments/assets/2112ef7b-400b-46b8-9275-f74b15a8dd2d" />

### ScoreTable Sahnesi

Oyuncu bu sahneye her oyun sonunda erişerek isim yazıp gelen score tablesinde kendisini görebilir.
112 Bilgilendirme butonuna bastığında rehber karakter olan Bilge Dede tarafından "112 ne zaman aranmalı,neden aranmalı?" konusuna açıklık getirmek için sesli bilgilendirme metnini dinler. Butona  ikinci kez basıldığında ise bilgilendirme sonlandırılır. Sol üsteki kapat butonuna basılarak ana menüye dönüş yapılır

<img width="801" height="407" alt="Ekran görüntüsü 2026-06-23 071637" src="https://github.com/user-attachments/assets/5ce71d27-c6f9-42d8-b09e-ccbdcfedd5d7" />

### Bilge Dede Geri Dönütleri

Bilge Dede oyuncu can sayısı ve ya süresi bittiğinde , güvenli alana başarıyla ulaştığında ancak yeterli puanala ulaşamadığında ve son olarak güvenli alana yeterli puanla birlikte başarıyla ulaştığında farklı yazılı ve sözlü geri dönütlerde bulunur. Bunlar:

<img width="786" height="370" alt="Ekran görüntüsü 2026-06-23 071657" src="https://github.com/user-attachments/assets/cbe5e4a3-51fc-48ad-a333-27701530c98d" />

<img width="801" height="410" alt="Ekran görüntüsü 2026-06-23 071608" src="https://github.com/user-attachments/assets/4b179d36-3548-4f85-ac5c-81d56bf4eef9" />

<img width="800" height="410" alt="Ekran görüntüsü 2026-06-23 071541" src="https://github.com/user-attachments/assets/cd858645-e84c-4a3d-84bf-96849e27b1d0" /> 

### Sahnelerdeki Hediye Sandıklar

Her afet sahnesinde içerisinde ilgili afetle ilgili soruların oluğu 3 hediye sandık vardır. Oyuncu bu sandıklara dokuntuğunda açılan paneldeki soruyu cevaplar. Her doğru puan oyuncuya 5 puan kazandırırken oyuncu yanlış bir cevap verdiğinde herhangi bir yaptırım uygulanmaz.
Aşağıdaki görsel deprem sahnesinden örnektir.

<img width="800" height="411" alt="Ekran görüntüsü 2026-06-23 071515" src="https://github.com/user-attachments/assets/071f0a00-9e1a-4034-8a3a-07280fd5fa9e" />

## YouTube Linki

Aşağıdaki linke tıklayarak daha detaylı anlatım yaptığım proje videoma ulaşabilirsiniz.

https://www.youtube.com/watch?v=XTPcudQw8FY

## İndirilebilir Oyun

Oyunun çalıştırılabilir sürümü GitHub Releases bölümünde bulunmaktadır.

## Geliştirici

Tuğba Ünal

Uludağ Üniversitesi
Yönetim Bilişim Sistemleri

## İletişim

tugbaunal670@gmail.com





