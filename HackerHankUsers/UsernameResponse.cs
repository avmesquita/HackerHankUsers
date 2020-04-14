using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerHankUsers
{
    public class UsernameResponse
    {
        public string id { get; set; }
        public string username { get; set; }
        public string about { get; set; }
        public string submitted { get; set; }
        public string updated_at { get; set; }
        public string submission_count { get; set; }
        public string comment_count { get; set; }
        public string created_at { get; set; }
    }
}
