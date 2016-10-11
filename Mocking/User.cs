using System;

namespace Mocking
{
    public enum Rights
    {
        Full,
        None,
    };
    public class User 
    {

        public User()
        {
        }

        public string Password { get; set; }
        public Rights Rights { get; internal set; }
        public string UserName { get; set; }

        
   
        public string ViewAllEmployees()
        {
            return "Here is the list";
        }
    }
}