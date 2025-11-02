# 🎯 4 Haneli Sayı Tahmin Oyunu <br>
Bu proje, C# Windows Forms kullanılarak geliştirilen basit ama eğlenceli bir sayı tahmin oyunudur. <br>
Oyuncu, bilgisayarın rastgele oluşturduğu 4 haneli sayıyı sınırlı deneme hakkı içinde tahmin etmeye çalışır.
<br>

# 🧩 Özellikler 
🔢 4 haneli rastgele sayı oluşturma <br>
🧠 Doğru ve yanlış haneler için geri bildirim sistemi <br>
⏳ 15 tahmin hakkı (hak bitince oyun sonlanır) <br>
💬 Kullanıcı dostu arayüz ve uyarı mesajları <br>
🧾 Geçmiş tahminlerin listelenmesi (geri bildirimle birlikte) <br>
🌈 Placeholder (örnek yazı) efektli giriş kutusu <br>

---

# ⚙️ Kullanılan Teknolojiler <br>
• C# (Windows Forms Application)<br>
• .NET Framework<br>
• Random sınıfı ile rastgele sayı üretimi<br>
• Basit UI/UX uygulamaları (renk değişimi, focus olayları, mesaj kutuları)<br>

# 🎮 Nasıl Oynanır?
•"Başlat" butonuna tıklayın. <br>
•Program rastgele bir 4 haneli sayı oluşturur.<br>
•Tahmin kutusuna sayınızı girin ve "Tahmin Et" butonuna basın.<br>
•Her tahmin sonrası aşağıdaki formatta geri bildirim alırsınız:<br>
• 2+ | 1- <br>
• +   → Doğru yerdeki rakam <br>
• -   → Farklı yerde bulunan doğru rakam <br>
• 15 hakkınız bitmeden doğru sayıyı bulmaya çalışın! 🎯 <br>

# 🖼️ 


# 🧠 Koddan Bazı Detaylar
• HesaplaFeedback() metodu, tahmin ile doğru sayı arasındaki benzerlikleri analiz eder.<br>
• btnBaslat_Click() yeni oyunu başlatır ve tüm alanları sıfırlar.<br>
• txtTahmin.GotFocus / LostFocus olayları ile placeholder efekti uygulanmıştır.<br>
• Kullanıcı geçersiz giriş yaptığında MessageBox ile hata bildirimi gösterilir.<br>

# 🚀 Geliştirici Notu
• “Her denemede biraz daha fazlasını öğrenmeye devam ediyorum.”<br>
• Bu küçük oyun, hem algoritma pratiği hem de Windows Forms deneyimi kazanmak için tasarlandı.<br>
