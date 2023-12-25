using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Abstract
{
    public interface ILibrary
    {
        List<BaseBook> Books();
        List<IMember> Members();

        void AddBook(BaseBook book);
        void RegisterMember(IMember member);
        void BarrowBook(BaseBook book, IMember member);                 //Her defasında bir kitap alabilir...
        //void BarrowBook(List<BaseBook> book, IMember member);         Bir defada birden fazla kitap alabildiği senaryo...
        void ReturnBook(BaseBook book, IMember member);
        //void ReturnBook(List<BaseBook> book, IMember member); 
        

    }
}
