using System;

namespace UserEnvironment.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Person Person { get; set; }
    }
}