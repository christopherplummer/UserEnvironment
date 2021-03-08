using System;

namespace UserEnvironment.Models
{
    public class User
    {
        public User()
        {
            UserName = "Not valid";
            Password = "Not valid";
            Person = new Person();
        }
        
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
            Person = new Person();
        }
        
        public User(string userName, string password, Person person)
        {
            UserName = userName;
            Password = password;
            Person = person;
        }
        
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public Person Person { get; private set; }

        private void EncryptPassword()
        {
            
        }
    }
}