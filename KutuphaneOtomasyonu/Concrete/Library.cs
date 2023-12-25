using KutuphaneOtomasyonu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Concrete
{
    public class Library : ILibrary
    {
        private static List<BaseBook> _books;
        private static List<IMember> _members;
        public Library()
        {
            _members = new List<IMember>();
            _books = new List<BaseBook>();
        }

        public void AddBook(BaseBook book)
        {
            _books.Add(book);
        }

        public void BarrowBook(BaseBook book, IMember member)
        {
            if (book.IsBorrowable)
            {
                member.OwnedBooks.Add(book);
                member.BorrowableCount++;
                book.SetBorrowable();
            }
            else
            {
                throw new Exception("Kitap ödünç verilemedi.");
            }
        }

        public List<BaseBook> Books()
        {
            return _books; 
        }

        public List<IMember> Members()
        {
            return _members;
        }

        public void RegisterMember(IMember member)
        {
            _members.Add(member);
        }

        public void ReturnBook(BaseBook book, IMember member)
        {
            member.OwnedBooks.Remove(book);
            member.BorrowableCount--;
            book.GetBorrowable();
        }
    }
}
