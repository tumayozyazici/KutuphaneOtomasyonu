using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Abstract
{
    public abstract class BaseBook
    {
        private int _count;

        public string ISBN { get; set; } = Guid.NewGuid().ToString().Substring(0, 4);
        public string Title { get; set; }
        public string Author { get; set; }
        public int? PublicationYear { get; set; }
        public bool IsBorrowable { get; set; } = true;
        public int Count
        {
            get { return _count; }
            set
            {
                if (value > 0)
                {
                    _count = value;
                    IsBorrowable = true;
                }
                else if (value == 0)
                {
                    _count = 0;
                    IsBorrowable = false;
                }
                else
                {
                    IsBorrowable=false;
                    throw new Exception("Adet sıfırın altında olamaz.");
                }
            }
        }               //Kitap sayısı sıfır olduğunda IsBorrowable false olacak. Kitap müsait mi kontrolü...

        public abstract void SetBorrowable();
        public abstract void GetBorrowable();
    }
}
