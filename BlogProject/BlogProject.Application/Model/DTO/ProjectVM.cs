using BlogTemp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Model.DTO
{
    public class ProjectVM
    {
        public int ID { get; set; }
        public int User_ID { get; set; }
        public string Project_Name { get; set; }
        public string Project_Description { get; set; }
        public string Project_Link { get; set; }
        
    }
}
