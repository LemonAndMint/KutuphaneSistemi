using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemi.SystemData.Member
{
    public class Member : Data
    {
        public string MemberName { get; set; }
        public string MemberTelNo { get; set; }
        public string MemberMail { get; set; }
        public string MemberAdress { get; set; }
        public string MemberNick { get; set; }
        public string MemberPassword { get; set; }
    }
}
