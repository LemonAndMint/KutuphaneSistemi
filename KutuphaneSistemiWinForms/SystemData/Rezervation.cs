using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneSistemi.SystemData.Member;

namespace KutuphaneSistemi.SystemData
{
    public class Rezervation : Data
    {
        [Key]
        public int rezervationID { get; set; }
        public NormalMember member { get; set; }
        public Book book { get; set; }

        public DateTime rezervationTime { get; set; }

    }
}
