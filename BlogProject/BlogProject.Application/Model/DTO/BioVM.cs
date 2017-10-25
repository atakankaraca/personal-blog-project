using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Model.DTO
{
    public class BioVM
    {
        //public int ID { get; set; }
        //public int User_ID { get; set; }
        //public string Bio { get; set; }

        public int ID { get; set; }
        public int User_ID { get; set; }
        public string Bio1 { get; set; }

        public virtual UserVM User { get; set; }
    }
}
