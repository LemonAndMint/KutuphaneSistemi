using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneSistemi.SystemData
{
    public class SystemHistory: Data
    {
        [Key]
        public int historyID { get; set; }
    }
}
