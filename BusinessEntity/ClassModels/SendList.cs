﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessEntity.ClassModels
{
    public  class SendList
    {
        public int SendListID { get; set; } 
        public string Name { get; set; }
        public Employee Employee { get; set; }  
        public ICollection<Alumnus> Alumni { get; set; }


    }
}
