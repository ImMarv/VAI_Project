using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAI_Project_Assignment
{
    public class ProductSession
    {
        // another section that 2227823 helped me out with, lets me get all the data I'd need for the notifications to work. 
        public int ProductID { get; set; }
        public string SoftwareName { get; set; }
        public string SoftwareType { get; set; }
        public string SoftwareDescription { get; set; }
        public string BusinessAreas { get; set; }
        public string Modules { get; set; }
        public string ClientTypes { get; set; }
        public string Cloud { get; set; }
        public string AdditionalInfo { get; set; }
        public string NumberOfLikes { get; set; }
}
}
