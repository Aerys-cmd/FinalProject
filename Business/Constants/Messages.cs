using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım Zamanı";
        public static string ProductsListed = "Ürünler Listelendi.";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductUpdated="Ürün Güncellendi.";
        public static string ProductNameAlreadyExists="Bu ürün adı daha önceden alınmış";
        public static string CategoryLimitExceeded="Kategori limiti aşıldı.";
        public static string CategorysListed="Kategoriler listelendi.";
        public static string AuthorizationDenied="Doğrulama reddedildi.";
        internal static string UserRegistered="Kullanıcı kaydedildi.";
        internal static string UserNotFound="Kullanıcı bulunamadı";
        internal static string PasswordError ="Şifre yanlış";
        internal static string SuccessfulLogin="Giriş başarıyla sağlandı.";
        internal static string UserAlreadyExists="Kullanıcı zaten mevcut";
        internal static string AccessTokenCreated="Giriş Tokeni oluşturuldu.";
    }
}
