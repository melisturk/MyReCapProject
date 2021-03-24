using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        internal static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Arabalar Listelendi";
        public static string CarDeleted = "Araba Silindi ";
        public static string CarUpdated = "Araba Güncellendi";


        public static string BrandAdded ="Marka Eklendi";
        public static string BrandDeleted = "Marka Silindi";
        public static string BrandUpdated = "Marka Güncellendi";
        public static string BrandListed = "Markalar Listelendi";


        public static string ColorAdded = "Renk Eklendi";
        public static string ColorDeleted ="Renk Silindi";
        public static string ColorUpdated = "Renk Güncellendi";
        public static string ColorListed = "Renkler Listelendi";


        public static string UserAdded = "Kullanıcı Eklendi";
        public static string UserDeleted = "Kullanıcı Silindi";
        public static string UserUpdated = "Kullanıcı Güncellendi";
        public static string UserListed = "Kullanıcı Listelendi";


        public static string CustomerAdded = "Müşteri Eklendi";
        public static string CustomerDeleted = "Müşteri Silindi";
        public static string CustomerUpdated = "Müşteri Güncellendi";
        public static string CustomerListed = "Müşteri Listelendi";


        public static string RentalAdded = " Kiralama Bilgisi Eklendi";
        public static string RentalDeleted = "Kiralama Bilgisi Silindi";
        public static string RentalUpdated = "Kiralama Bilgisi Güncellendi";
        public static string RentalListed = "Kiralama Bilgisi Listelendi";
        public static string CarAlreadyRented = "Araba Kullanımda";
        public static string RentalCreated = "Kiralama İşlemi Gerçekleşti";
        
        public static string NotExist = "Böyle bir resim yok";
        public static string InvalidFileExtension = "Geçersiz dosya ";
        public static string ImageNumberLimitExceeded = "Bu araba için resim kapasitesi dolmuştur, daha fazla resim yükleyemezsiniz.";
        public static string AddSingular = "eklendi";
        public static string UpdateSingular = "güncellendi";
        public static string DeleteSingular = "silindi";
        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = " Kullanıcı kayıtlı";
        public static string UserNotFound = " Kullanıcı bulunamadı";
        public static string PasswordError= "Hatalı şifre!";
        public static string SuccessfulLogin="Başarılı giriş" ;
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated="Token oluşturuldu";
    }
}
