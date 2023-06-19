using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemiWinForms.SystemData.Member
{
    public class NormalMember : Data
    {
        [Key]
        public int MemberID { get; set; }
        public string? MemberName { get; set; }
        public string? MemberTelNo { get; set; }
        public string? MemberMail { get; set; }
        public string? MemberAdress { get; set; }
        public string MemberNick { get; set; }
        public string MemberPassword { get; set; }
        public string? PersonelTitle { get; set; }
        public int isPersonel { get; set; }
        public int isAdmin { get; set; }


    }
}
