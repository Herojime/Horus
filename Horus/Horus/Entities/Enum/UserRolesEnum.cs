using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horus.Entities.Enum
{
    public class UserRolesEnum
    {
        public string Nombre { get; set; }
        public static UserRolesEnum root = new UserRolesEnum() { Nombre = "root" };
        public static UserRolesEnum admin = new UserRolesEnum() { Nombre = "admin" };
        public static UserRolesEnum user = new UserRolesEnum() { Nombre = "user" };
    }
}