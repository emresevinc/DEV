///	Author: Emre Sevin�
///	25.08.2019 
Bu proje ile operasyon siniflarinin icerisinde tanimili olan metotlar�n yap�sal olarak bir register g�revi g�ren singleton instance �zerinde 
tutularak ihtiyac duyuldugu durumlarda bu singleton instance uzerinden kullanmayi gostermeyi hedeflemektedir.
Uygulama aya�a kalkarken farkli moduller icerisinde tanimli olan operasyon siniflarinin birer instance'i olusturularak, register edilir.
Bu yapi ile operasyon siniflarinin icerisindeki metotlar ilgili singleton instance uzerinde adreslenmis oldugu icin kod icerisindeki
karmasikliklarin ve bagimliliklarin azaltilmasi saglanabilir.
