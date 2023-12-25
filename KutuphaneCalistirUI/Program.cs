using KutuphaneOtomasyonu.Abstract;
using KutuphaneOtomasyonu.Concrete;

namespace KutuphaneCalistirUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kütüphane başladı
            Library library = new Library();
            //Kitaplar oluşturuldu
            BookGeneral book1 = new BookGeneral() { Title = "Suç ve Ceza", Author = "Dostoyevski", PublicationYear = 1925, Count = 10 };
            BookGeneral book2 = new BookGeneral() { Title = "Savaş ve Barış", Author = "Tolstoy", PublicationYear = 1925, Count = 8 };
            BookGeneral book3 = new BookGeneral() { Title = "Genel Kitap", Author = "Mehmet", PublicationYear = 1925, Count = 7 };

            BookHistorical book4 = new BookHistorical() { Title = "Türklerin Tarihi", Author = "İlber Ortaylı", PublicationYear = 2004, Count = 12 };
            BookHistorical book5 = new BookHistorical() { Title = "İstanbul'un Fethi", Author = "Halil İnancık", PublicationYear = 2004, Count = 5 };

            BookScientific book6 = new BookScientific() { Title = "coding 101", Author = "Fatih Alkan", PublicationYear = 2012, Count = 8 };
            BookScientific book7 = new BookScientific() { Title = "C# Hızlı Öğren", Author = "Fatih Alkan", PublicationYear = 2016, Count = 10 };

            //Kütüphaneye Kitap Ekle
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);
            library.AddBook(book7);

            //Üye Oluştur
            Member member1 = new Member() { Name = "Fatih", Surname = "Alkan", MemberNumber = "1" };
            Member member2 = new Member() { Name = "Hasan", Surname = "Özdemir", MemberNumber = "2" };

            //Üyeleri Kaydet
            library.RegisterMember(member1);
            library.RegisterMember(member2);

            Console.WriteLine("*************Kitap Listesi*************");
            foreach (var item in library.Books())
            {
                Console.WriteLine(item.Title + " Adet: " + item.Count);
            }

            library.BarrowBook(book1, member1);
            library.BarrowBook(book1, member2);

            Console.WriteLine("*************Kitap Listesi*************");
            foreach (var item in library.Books())
            {
                Console.WriteLine(item.Title + " Adet: " + item.Count);
            }

            Console.WriteLine("*************Üyemdeki Kitaplar*************");
            foreach (var item in library.Members())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("\tKitapları");
                foreach (var odunc in item.OwnedBooks)
                {
                    Console.WriteLine(odunc.Title);
                }
            }
            library.ReturnBook(book1,member2);

            Console.WriteLine("*************Kitap Listesi*************");
            foreach (var item in library.Books())
            {
                Console.WriteLine(item.Title + " Adet: " + item.Count);
            }

            Console.WriteLine("*************Üyemdeki Kitaplar*************");
            foreach (var item in library.Members())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("\tKitapları");
                foreach (var odunc in item.OwnedBooks)
                {
                    Console.WriteLine(odunc.Title);
                }
            }

            Console.ReadLine();
        }
    }
}
