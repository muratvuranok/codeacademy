--select * into Urunler from Products 
--select * into Kategoriler from Categories
--select * into Kargolar from Shippers


insert into Kategoriler (CategoryName, Description) values('Kategori Adı','Açıklama Alanı')

insert into Kargolar values('Kargo Şirket Adı','Telefon No')
insert into Kargolar (Phone, CompanyName) values('Telefon No', 'Company Adı')

insert into Customers (CustomerID,CompanyName) values ('CADMY','Code Academy')



update Kargolar set Phone = 'Tel No Olacak'

select * into Personeller from Employees


select* from Personeller

update Personeller set FirstName = 'Murat' where EmployeeID = 6


update Personeller set FirstName = 'Murat' where TitleOfCourtesy = 'Mr.'

-- Delete from Personeller -- Tablo içerisinde yer alan kayıtları siler
-- drop table Personeller  -- Tablonun kendisini siler


delete from Personeller where EmployeeId = 1

-- Trigger


 
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER TRIGGER   -- CREATE -> Oluşturma, ALTER -> Düzenleme
LowerCaseCompany  --> Trigger Name
ON  Shippers      --> which table
   AFTER INSERT   --> when
AS 
BEGIN
  --  inserted
  --  deleted
  declare @CompanyName nvarchar(100), @ShipperID int

     select @CompanyName = CompanyName, @ShipperID = ShipperID from inserted

	 update Shippers set CompanyName = LOWER(@CompanyName) where  ShipperID= @ShipperID

END
GO

-- inserted            deleted
--    +                   -          -> Insert
--    -                   +          -> Delete
--    +                   +          -> Update



insert into Shippers values('Yeni Kayıt','123')

select * from Shippers
delete from Kargolar
truncate table Kargolar
select * from Kargolar
insert into Kargolar values('test','123')


--drop Table Personeller

select EmployeeID, FirstName, LastName into Personeller from Employees
 

 alter Trigger Changestatus on Personeller
 instead of delete
 as
 begin

      

	  update Personeller set [Status] = 0 where EmployeeID =(select EmployeeID from deleted)
 end

 delete from Personeller where EmployeeID = 1
 select * from Personeller

 /*
 
 Telefon Numarası Formatlayan bir Function yazınız

 +905323521245
  905321234578
   05321234578
    5327894512 -> min değeri karşılamıyorsa hata mesajı veriniz

	min değer karşılanıyorsa kullanıcın girdiği telefon numarasını +90 (532) 123 12 12
 
 */
  select  Phone  from Shippers
 select dbo.PhoneFormat(Phone) from Shippers

 -- Shippers tablosu için trigger oluşturunuz, (instead of insert) bu trigger içerisinde gelen datayı yakalayıp yazdığınız telefon formatlama function'ını kullanarak db'ye formatlı bir telefon kaydı eklettiriniz (update olmayacak)



 -- Tüm açıklamalar mevcut

-- Tablo Adı = " Country ", Parametreler = Id, CountryName,Code
-- Tablo Adı = " City",     Parametreler = Id, CityName, CountryId,Code
-- Tablo Adı = " District", Parametreler = Id, DistrictName, CountryId, CityId,Code
-- Tablo Adı = " Town",     Parametreler = Id, TownName, CountryId, CityId, DistrictId,code

/*
   Procedure Ödevi
  NOT : Yeni bir veri tabanı kod ile oluşturulacak :)
  1) Yukarıdaki tablolar Code ile oluşturulacak ve kod ile ılişkilendirilecektir.
  2) Bir adet StoreProcedure yazılacak ve bu procedure içerisine parametre olarak, Ülke Adı, şehir Adı, ılçe Adı ve Mahalle Adı alacak.
  3) Ülkeler tablosunda parametrede gönderilen ülke var mı yok mu kontrol edilecek. 
    3.1) Eğer Ülke Yok ise Eklenecek. Var ise kullanıcıya mesaj ile bildirilecek
  4) şehirler tablosunda parametrede gönderilen Ülke Kontol edilecek ve Bu ülkeye ait Bölyle bir şejir olup olmadığı kontrol edilecek. 
    4.1) Eğer şehir yok ise eklenecek. Var ise O ülkenin Id paramtresi yakalanacak ve o Id paramteresine göre şehirler tablosuna kayıt eklenecek.
  5) ılçeler tablosunda parametrede gönderilen Ülke o ülkeye bağlı şehir ve o şehire bağlı ılçe varmı yok mu kontrol edilecek.
    5.1) Eğer Ülke Yok ise, Ülke eklenecek. Sonra eklenen ülkenin Id parametresine göre ıl eklenecek. Sonrasında ise, ülke Id ve ıl Id parametreleri yakalanıp ilçe eklenecek.
    5.2) Eğer Ülke var şehir yok ise, parametrede gönderilen ülke Id yakalanıp şehir eklenecek ve Ulke Id ile şehir Id parametrelerini kullanarak ılçeyi Eklenecek.
  6) Mahalle tablosunda parametrede gönderilen Ülke, o ülkeye bağlı şehir, o şehire bağlı ilçe varmı yok mu kontrol edilecek.
    6.1) Eğer Ülke yok ise; Önce Ülke eklenecek ve o ülkenin Id parametresine göre ıl, Ülke ve ıl Id parametrelerine göre ilçe, Ulke ıl ve ılçe Id parametrelerine göre de Mahalle eklenecek.
    6.2) Eğer ülke var ise ve şehir yok  ise O ülke Id parametresine göre şehir,, Ülke ve şehir Id parametresine göre ılçe, Ülke  şehir ilçe Id parametrelerine göre Mahalle eklenecek.
    6.3) Eğer ülke ıl var ama ilçe yok ise, Ülke şehir Id parametreleri yakalanacak ve ılçe eklenecek. Sonrasında Ülke şehir ve ılçe Id parametreleri yakalnarak Mahalle Eklenecek
    6.4) Eğer ülke il ilçe var ama mahalle yok ise, Ülke ıl ılçe Id parametreleri kullanılarak Mahalle eklenecektir.
	NOT : ıl ve şehir Aynı Anlama Gelir :) artı (+) her blok içerisinde mesaj verilecek
*/
 -- ('Türkiye','istanbul','Beşiktaş','cihannüma')