using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace final018.Config
{
    public class AuthResult
    {
        public string token { get; set; }
        public string refreshtoken { get; set; }
        public bool success { get; set; }
        public List<string> errors { get; set; }
    }
}
