using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity.ClassModels
{
    public class Activity
    {
        public int ActivityID { get; set; }
        public string Event { get; set; }
        public string Adress { get; set; }
        public string Kategori { get; set; }
        public Employee Employee { get; set; }
    }
}
