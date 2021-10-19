using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelRequestManagerNew
{
    public class Users
    {
        public static List<Users> userList = new List<Users>();
        public int userID { get; set; }
        public string userGUID { get; set; }
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userBirthDate { get; set; }
        public string registerDate { get; set; }
        public string userEmail { get; set; }
        public string userTele { get; set; }
        public bool admin { get; set; }
        public bool available { get; set; }
    }
}
