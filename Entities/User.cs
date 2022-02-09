

namespace SchoolOfDevs.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string password { get; set; }
        public TypeUser TypeUser { get; set; }

    }
}
