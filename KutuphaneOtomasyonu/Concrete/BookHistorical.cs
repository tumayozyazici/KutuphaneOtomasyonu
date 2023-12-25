using KutuphaneOtomasyonu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Concrete
{
    public class BookHistorical : BaseBook
    {
        public override void GetBorrowable()
        {
            Count += 1;
        }

        public override void SetBorrowable()
        {
            if (Count > 3)
            {
                IsBorrowable = true;
                Count -= 1;
            }
            else
            {
                IsBorrowable = false;
                throw new Exception("Tarihsel kitap için maksimum ödünç verilecek sayıya ulaşıldı.");
            }
        }
    }
}
