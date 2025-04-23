using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proect_7.Model
{
    public class User
    {
        [Key]
        public  int  UserID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public virtual Role Role{ get; set; }
    }
}
