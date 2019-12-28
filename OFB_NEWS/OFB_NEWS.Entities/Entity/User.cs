using System.Collections.Generic;

namespace OFB_NEWS.Entities.Entity
{
    public class User
    {
        public User()
        {
            News = new HashSet<News>();
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public ICollection<News> News { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}