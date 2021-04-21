using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineErpApi.Domain
{
    public class LoginModel
    {
        [Required]
        public string userName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}
