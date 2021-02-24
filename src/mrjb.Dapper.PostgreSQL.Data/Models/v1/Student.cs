using System.Collections.Generic;

namespace mrjb.Dapper.PostgreSQL.Data.Models
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? SchoolId { get; set; }

        public School School { get; set; }

        public List<SchoolClass> Classes { get; set; }
    }
}
