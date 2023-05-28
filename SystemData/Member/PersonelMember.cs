using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemi.SystemData.Member
{
    public class PersonelMember : NormalMember
    {
        public Image PersonelPicture { get; set; }
        public string PersonelTitle { get; set; }
    }
}
