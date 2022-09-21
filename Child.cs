using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{


    [Table("Child")]
    public class Child
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }

        [Column("LastName")]
        public string LastName { get; set; }
        [Column("BirthDate")]
        public long BirthDate { get; set; }
     
        [Column("Gender")]
        public Gender Gender { get; set; }
    }
}
