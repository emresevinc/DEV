/// Author: Emre Sevinç
/// Date : 26.08.2019
Bu proje ile bir uygulama uzerinde host edilen web servis'lerin, proxy class'inin ve bu servislerin proxy class'i
uzerinden cagiriminin gosterilmesi hedeflenmektedir. Bir veritabani baglanti örnegi içermemektedir. 
Proxy generator olarak wsdl.exe kullanilmistir.
Card.Host servislerin host edildigi uygulamadir. Bu modul uzerinde musteri ile iliskilendirilmis kartlarin getirilmesi 
Customer.Host.dll kullanilarak yapilmasi hedeflenmektedir. Customer.Host farkli bir uygulama olarak dusunulebilir. 
Proje icerisinde o amacla olusturulmus fakat amac web service call islemini gostermek oldugu icin yalnizca dll'i kullanilarak
tester console uygulamasi uzerinden servis cagirimlari tetiklenmistir.