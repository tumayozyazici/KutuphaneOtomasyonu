using KutuphaneOtomasyonu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Concrete
{
    public class BookScientific : BaseBook
    {
        public override void GetBorrowable()
        {
            Count += 1;
        }

        public override void SetBorrowable()
        {
            if (Count > 5)
            {
                IsBorrowable = true;
                Count -= 1;
            }
            else
            {
                IsBorrowable = false;
                throw new Exception("Bilimsel kitap için maksimum ödünç verilecek sayıya ulaşıldı.");
            }
        }
    }
}
