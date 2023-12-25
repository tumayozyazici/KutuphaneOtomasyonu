using KutuphaneOtomasyonu.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Concrete
{
    public class Member : IMember
    {
        private int _barrowableCount = 0;
        public Member()
        {
            OwnedBooks = new List<BaseBook>();
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MemberNumber { get; set; }
        public int BorrowableCount
        {
            get { return _barrowableCount; }
            set { _barrowableCount = value; }
        }
        public List<BaseBook> OwnedBooks { get; set; }
    }
}
