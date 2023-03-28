using Core.Utilities.Helpers.GuidHelper;
using Core.Utilities.Results;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public class FileHelperManager
    {
        private static string _currentDirectory = @"C:\Users\servetsoysal\source\repos\MyCarProject\WebAPI\Images\CarImage";

        public static IResult Upload(IFormFile file)
        {
            var fileExists = CheckFileExists(file);
            //dosya mevcut değilse hata dönecektir. Dönen bir hata varsa o hata mesajını yansıtıyoruz.
            if (fileExists.Message != null)
            {
                return new ErrorResult(fileExists.Message);
            }
            //FileName -- dosya adını alma işlemi yapıyor.
            //file.FileName -- file dosyasının adını almaktadır.
            //GetExtension -- dosyanın uzantısını döndürüyor.
            var type = Path.GetExtension(file.FileName);
            //dosya türü yani type geçerli mi değil mi kontrol ediliyor.
            var typeValid = CheckFileTypeValid(type);
            //guidi kullanarak benzersiz isim veriyorum.
            var randomName = GuidHelperManager.CreateGuid();

            //dosya türü geçersiz ise hatayı yansıtacaktır.
            if (typeValid.Message != null)
            {
                return new ErrorResult(typeValid.Message);
            }
            //dizini _currentDirectory + _folderName olarak oluşturuyor. Yani \\wwwroot\\images olarak dizin oluşturacak.
            CheckDirectoryExists(_currentDirectory);
            //image dosyasını dizin + isim + tip olarak oluştur.
            CreateImageFile(_currentDirectory + randomName + type, file);
            return new SuccessResult((randomName + type).Replace("\\", "/"));
        }
        public static IResult Update(IFormFile file, string imagepath)
        {
            //dosya mevcut mu? 
            var fileExists = CheckFileExists(file);
            //dosya mevcut mesaj vermedi. Mesaj boş mu değil mi kontrol ediyor. boş ise atlıyor değilse hata veriyor.
            if (fileExists.Message != null)
            {
                return new ErrorResult(fileExists.Message);
            }
            var type = Path.GetExtension(file.FileName);
            var typeValid = CheckFileTypeValid(type);
            var randomName = GuidHelperManager.CreateGuid();

            if (typeValid.Message != null)
            {
                return new ErrorResult(typeValid.Message);
            }

            DeleteOldImageFile((_currentDirectory + imagepath).Replace("/", "\\"));
            CheckDirectoryExists((_currentDirectory));
            CreateImageFile(_currentDirectory + randomName + type, file);
            return new SuccessResult((randomName + type).Replace("/", "\\"));
        }
        public static IResult Delete(string path)
        {
            //_currentDirectort + path = directory varsa sil.
            DeleteOldImageFile((_currentDirectory + path).Replace("/", "\\"));
            return new SuccessResult();
        }
        //directory -- wwwroot\\images dizinininde varsa sil.
        private static void DeleteOldImageFile(string directory)
        {
            if (File.Exists(directory.Replace("/", "\\")))
            {
                File.Delete(directory.Replace("/", "\\"));
            }
        }
        //dosyanın mevcut olup/olmadığını kontrol ediyoruz.
        private static IResult CheckFileExists(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                return new SuccessResult();
            }
            return new ErrorResult("File doesnt exists");
        }
        //type verisinin türünü kontrol ediyorum.
        private static IResult CheckFileTypeValid(string type)
        {
            //png , jpg veya jpeg değilse hata ver. Ben bu türden veri istiyorum.
            if (type != ".jpeg" && type != ".png" && type != ".jpg")
            {
                return new ErrorResult("Wrong file type");
            }
            return new SuccessResult();
        }
        //dizin var mı yok mu kontrol ediyor. Yoksa dizini oluşturuyor.
        //directory -- dizin demek.
        private static void CheckDirectoryExists(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
        //bir tane dizin ve dosya alıyorum.
        //IFromFile HttpRequest ile gönderilen bir dosyayı temsil eder.
        private static void CreateImageFile(string directory, IFormFile file)
        {
            //dizinde bir tane dosya oluşturuyorum.
            using (FileStream fs = File.Create(directory))
            {
                //mevcut olan bir dosyayı kopyalıyor ve üzerine yazmaya izin vermiyor.
                file.CopyTo(fs);
                //ara belleği temizliyor ve arabelleğe verilerin dosyaya yazılmasına neden olur.
                fs.Flush();
            }
        }
    }
}