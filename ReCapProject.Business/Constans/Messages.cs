using ReCapProject.Entities.DTO.CarImagesDto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject.Business.Constans
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string DescriptionInvalid = "Açıklama geçersiz";
        public static string DailyPriceInvalid = "Günlük kiralama ücreti girmediniz";
        internal static string MaintemanceTime = "Arabalar Listelemeye Kapalı";
        internal static string CarListed = "Arabalar Listelendi";
        public static string CarDelete = "Araba sistemden silindi";
        public static string CarGetById = "Arabalar ID numaralarına göre listelenmistir.";
        public static string CarUpdate = "Seçili araba güncellenmiştir";

        public static string UserAdd = "Kullanıcı eklendi";
        public static string RentalInvalid = "Araç suan başka bir müsterinin kullanımındadır.";

        public static string BrandAdd = "Marka eklenmiştir";
        public static string BrandInValid = "Marka eklenememiştir";
        public static string BrandDelete = "Marka silinmiştir";
        public static string BrandNotDelete = "Marka silinemedi";
        public static string BrandUpdate = "Marka güncellenmesi gerçekleşmiştir";
        public static string BrandNotUpdate = "Marka güncellenemedi";
        public static string MultipleCarImageErrors = "Beşden fazla araç görseli eklemeyiniz";

        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
    }
}