using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyonu.Abstract
{
    public interface IMember
    {
        string Name { get; set; }
        string Surname { get; set; }
        string MemberNumber { get; set; }
        int BorrowableCount { get; set; }
        List<BaseBook> OwnedBooks { get; set; }
    }
}
