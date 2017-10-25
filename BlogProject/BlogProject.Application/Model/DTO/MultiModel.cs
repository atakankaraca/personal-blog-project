using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Model.DTO
{
    public class MultiModel
    {
        public IEnumerable<ArticleVM> Articles { get; set; }
        public IEnumerable<BioVM> Bios { get; set; }
        public IEnumerable<CategoryVM> Categories { get; set; }
        public IEnumerable<UserVM> Users { get; set; }
        public IEnumerable<ProjectVM> Projects { get; set; }

        public ArticleVM Article { get; set; }
        public BioVM Bio { get; set; }
        public CategoryVM Category { get; set; }
        public UserVM User { get; set; }
        public ProjectVM Project { get; set; }
    }
}
