# 🎯 4 Haneli Sayı Tahmin Oyunu <br>
Bu proje, C# Windows Forms kullanılarak geliştirilen basit ama eğlenceli bir sayı tahmin oyunudur. <br>
Oyuncu, bilgisayarın rastgele oluşturduğu 4 haneli sayıyı 15 deneme hakkı bitmeden tahmin etmeye çalışır.
<br>

# 🧩 Özellikler 
🔢 4 haneli rastgele sayı oluşturma <br>
🧠 Doğru ve yanlış haneler için geri bildirim sistemi <br>
⏳ 15 tahmin hakkı (hak bitince oyun sonlanır) <br>
💬 Kullanıcı dostu arayüz ve uyarı mesajları <br>
🧾 Geçmiş tahminlerin listelenmesi (geri bildirimle birlikte) <br>
🌈 Placeholder (örnek yazı) efektli giriş kutusu <br>
<br>

# ⚙️ Kullanılan Teknolojiler <br>
• C# (Windows Forms Application)<br>
• .NET Framework<br>
• Random sınıfı ile rastgele sayı üretimi<br>
• Basit UI/UX uygulamaları (renk değişimi, focus olayları, mesaj kutuları)<br>
<br>
# 🎮 Nasıl Oynanır?
•"Başlat/Yeniden Başlat" butonuna tıklayın. <br>
•Program rastgele bir 4 haneli sayı oluşturur.<br>
•Tahmin kutusuna sayınızı girin ve "Tahmin Et" butonuna basın.<br>
•Her tahmin sonrası aşağıdaki formatta "Tahminler" kısmında geri bildirim alırsınız:<br>
Örneğin;<br>
• 2+ | 1- <br>
`+` → Doğru yerdeki rakam <br>
`-` → Farklı yerde bulunan doğru rakam <br>
<p>15 hakkınız bitmeden doğru sayıyı bulmaya çalışın! 🎯</p> <br>

# 🖼️ Oyun İçi Görüntüler
🟢<b> Başlat Ekranı</b> <br>
Bu ekran oyunu başlatmadan önceki ana menüyü gösterir. Kullanıcı "Başlat" butonuna basarak oyunu başlatır.
<div align="center">
  <img src="assets/başlangıç ekranı.png" width="300" alt="Ekran Görüntüsü" />
</div>

---
 🎯 <b>Tahmin Ekranı</b> <br>
Kullanıcı tahminini bu ekrana girer ve "Tahmin Et" butonuna basar. Girdi doğrulaması yapılır ve geri bildirim listelenir.<br> Geri bildirim: `+` doğru yerdeki rakam, `-` doğru ama yanlış yerdeki rakam.
<div align="center">
  <img src="assets/tahmin.png" width="300" alt="Tahmin Ekranı" />
</div>

---

⚠️ <b>Yanlış Giriş Ekranı</b> <br>
Kullanıcı 0 ile başlayan, 4 haneli olmayan veya sayı dışında bir karakter girerse bu ekran görünür.MessageBox ile uyarı gösterilir ve tahmin hakkı azaltılmaz. Uyarıyı kullanıcı kapattıktan sonra oyun, mevcut durumda devam eder; sıfırlanmaz.
<div align="center">
  <img src="assets/hata mesajı.png" width="300" alt="Hata Mesajı Ekranı" />
</div>

---
❌ <b>Yanlış Tahmin Ekranı</b> <br>
Kullanıcının tahmini doğru sayı ile eşleşmediğinde görünür.  

<div align="center">
  <img src="assets/hak bitti.png" width="300" alt="hak bitti Ekranı" />
</div>

---
🏆 <b>Kazanma Ekranı</b><br>
Kullanıcı doğru sayıyı tahmin ettiğinde görünür. Doğru sayı ve tebrik mesajı gösterilir, tahmin kutusu devre dışı bırakılır. Oyun Biter. 
<div align="center">
  <img src="assets/doğru tahmin.png" width="300" alt="doğru tahmin Ekranı" />
</div>
<p align="center">🎉 Tebrikler! Doğru sayıyı buldunuz 🎉</p>

<br>

# 🧠 Koddan Bazı Detaylar
• HesaplaFeedback() metodu, tahmin ile doğru sayı arasındaki benzerlikleri analiz eder.<br>
• btnBaslat_Click() yeni oyunu başlatır ve tüm alanları sıfırlar.<br>
• txtTahmin.GotFocus / LostFocus olayları ile placeholder efekti uygulanmıştır.<br>
• Kullanıcı geçersiz giriş yaptığında MessageBox ile hata bildirimi gösterilir.<br>

# Bilgi
• Bu küçük oyun, Görsel Programlama - 2 Dersi için bir ödev olarak hazırlandı<br>
• Hem algoritma pratiği yapmak hem de Windows Forms deneyimi kazanmak için tasarlandı.<br>
<div align="center">
  Buraya kadar okuduğunuz için teşekkür ederim :) <br>
  <img src="https://media.giphy.com/media/MDJ9IbxxvDUQM/giphy.gif" width="400" alt="Cute cat hugs GIF" />
</div>

