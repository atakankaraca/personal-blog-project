using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Model.DTO
{
    public class ArticleVM
    {
        //public int ID { get; set; }
        //public string Title { get; set; }
        //public int Author_ID { get; set; }
        //public DateTime Created_Date { get; set; }
        //public string Tags { get; set; }
        //public bool Is_Deleted { get; set; }
        //public string Post_Content { get; set; }
        //public int Category_ID { get; set; }
        //public int ViewCount { get; set; }

        public int ID { get; set; }
        public string Title { get; set; }
        public Nullable<int> Author_ID { get; set; }
        public Nullable<System.DateTime> Created_Date { get; set; }
        public string Tags { get; set; }
        public Nullable<bool> Is_Deleted { get; set; }
        public string Post_Content { get; set; }
        public Nullable<int> Category_ID { get; set; }
        public Nullable<int> ViewCount { get; set; }

        public virtual CategoryVM Category { get; set; }
        public virtual UserVM User { get; set; }
    }
}
