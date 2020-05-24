using System;
using System.Collections.Generic;

namespace ExamenRest.Models
{
    public partial class Users
    {
        public int IdUser { get; set; }
        public string NombreUser { get; set; }
        public string EmailUser { get; set; }
        public string PassUser { get; set; }
        public string FachaSistemaUser { get; set; }
        public string PrivilegioUser { get; set; }
        public string NombreCompletoUser { get; set; }
    }
    public class RequestLogin {
        public string username { get; set; }
        public string password { get; set; }

    }
    public class ResponseLogin {
        public string id { get; set; }
        public string user { get; set; }
        public string role { get; set; }
    }
}
