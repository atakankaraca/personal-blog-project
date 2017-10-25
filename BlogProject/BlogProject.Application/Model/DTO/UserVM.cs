using BlogTemp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Application.Model.DTO
{
    public class UserVM
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mail { get; set; }
        public string CoverImage { get; set; }
        public string ProfileImage { get; set; }
        public string TwitterLink { get; set; }
        public string GitHubLink { get; set; }
        public string LinkedinLink { get; set; }

    }
}
