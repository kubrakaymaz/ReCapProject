using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarDeleted = "Ürün başarıyla silindi.";
        public static string CarAdded = "Ürün başarıyla eklendi.";
        public static string BrandNameOfLack = "Marka ismi 2 karakterden fazla olmalıdır.";
        public static string CheckDailyPrice = "Günlük fiyat 0'dan fazla olmalıdır.";
        public static string CarUpdated = "Ürün başarıyla güncellendi.";
        
        public static string InvalidBrandName = "Marka ismi ve numarası boş bırakılamaz.";
        public static string InvalidUserId = "Geçersiz kullanıcı numarası!";

        public static string CheckReturnDate = "Yetersiz bilgi,teslim tarihi boş bırakılamaz.";
        public static string CheckRentDate = "Yetersiz bilgi,kiralama tarihi boş bırakılamaz.";
        public static string RentalAdded = "Araba kiralama işlemi gerçekleştirildi!";
        public static string RentalUpdated = "İşlem güncellendi";
        public static string RentalDeleted = "İşlem silindi";
        public static string RentalListed = "İşlemler listelendi";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerListed = "Müşteriler listelendi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserNameIsInvalid = "Lütfen isim soyisim alanını doldurunuz.";
        public static string UserDoesNotExist = "Kullanıcı mevcut değil.";



    }
}
