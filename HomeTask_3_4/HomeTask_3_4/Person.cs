using System.Collections.Generic;

namespace HomeTask_3_4
{
    public class Person
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IEnumerable<int> AddressList { get; set; }
    }
}
