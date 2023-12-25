using KutuphaneOtomasyonu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Concrete
{
    public class BookGeneral : BaseBook
    {
        public override void GetBorrowable()
        {
            Count += 1;
        }

        public override void SetBorrowable()
        {
            Count -= 1;
        }
    }
}
