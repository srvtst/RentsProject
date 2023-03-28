using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Contants
{
    public static class Message
    {
        public static string CarAdded = "Araba Başarılı Olarak Sisteme Eklenmiştir";
        public static string CarNameInvalid = "Araba İsmi Geçersiz Karakter İçermektedir";
        public static string CarListed = "Arabalar Listelenmiştir";
        public static string ColorAdded = "Renk Başarılı Olarak Sisteme Eklenmiştir";
        public static string BrandAdded = "Marka Başarılı Olarak Sisteme Eklenmiştir";
        public static string CarUpdated = "Araba Başarılı Olarak Güncellenmiştir";
        public static string BrandUpdated = "Marka Başarılı Olarak Güncellenmiştir";
        public static string ColorUpdated = "Renk Başarılı Olarak Güncellenmiştir";
        public static string CarDeleted = "Araba Başarılı Olarak Sistemden Silinmiştir";
        public static string BrandDeleted = "Marka Başarılı Olarak Sistemden Silinmiştir";
        public static string ColorDeleted = "Renk Başarılı Olarak Sistemden Silinmiştir";
        public static string BrandListed = "Markalar Listelenmiştir";
        public static string CustomerListed = "Müşteriler Listelenmiştir";
        public static string CustomerAdded = "Müşteri Başarılı Olarak Sisteme Eklenmiştir";
        public static string CustomerUpdated = "Müşteri Başarılı Olarak Güncellenmiştir";
        public static string CustomerDeleted = "Müşteri Başarılı Olarak Sistemden Silinmiştir";
        public static string UserAdded = "Kullanıcı Başarılı Olarak Sisteme Eklenmiştir";
        public static string UserUpdated = "Kullanıcı Başarılı Olarak Güncellenmiştir";
        public static string UserDeleted = "Kullanıcı Başarılı Olarak Sistemden Silinmiştir";
        public static string UserNotFound = "Kullanıcı sistemde bulunmamaktadır.";
        public static string CategoryAdded = "Kategori Başarılı Olarak Sisteme Eklenmiştir";
        public static string CategoryUpdated = "Kategori Başarılı Olarak Güncellenmiştir";
        public static string CategoryDeleted = "Kategori Başarılı Olarak Sistemden Silinmiştir";
        public static string CategoryNameInvalid = "Kategori İsmi Geçersiz Karakter İçermektedir";
        internal static string AuthorizationDenied = "Yetkiniz yok";
    }
}
