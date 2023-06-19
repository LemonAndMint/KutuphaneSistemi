using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneSistemiWinForms.SystemData.Member;

namespace KutuphaneSistemiWinForms.SystemData
{
    public class Rezervation : Data
    {
        [Key]
        public int rezervationID { get; set; }
        public int memberID { get; set; }
        public int bookID { get; set; }
        public DateTime startTime { get; set; }
        public int rezOver { get; set; }

    }
}
