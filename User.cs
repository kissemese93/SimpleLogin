using System.ComponentModel.DataAnnotations;

namespace SimpleLogin
{
    public class User
    {
        //properties, key is important, unique ID
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string password { get; set; }

    }
}