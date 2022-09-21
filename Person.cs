using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
namespace ClassLibrary2
{

//    Create a program which will execute the next steps:
//1) Create collection of randomly generated objects in memory by provided models, number of ofjects 10000;
//2) Serialyze it to JSON format;
//3) Write the serialization result to the current user desktop directory, the text file name should be "Persons.json";
//4) Clear the in memory collection;
//5) Read objects from file;
//6) Display in console persons count, persons credit card count, the average value of child age.

//Use POSIX format for dates.
//Use lowerCamelCase JSON notation in result file.

//    Data models:  
//class Person
//    {
//        public Int32 Id { get; set; }
//        public Guid TransportId { get; set; }
//        public String FirstName { get; set; }
//        public String LastName { get; set; }
//        public Int32 SequenceId { get; set; }
//        public String[] CreditCardNumbers { get; set; }
//        public Int32 Age { get; set; }
//        public String[] Phones { get; set; }
//        public Int64 BirthDate { get; set; }
//        public Double Salary { get; set; }
//        public Boolean IsMarred { get; set; }
//        public Gender Gender { get; set; }
//        public Child[] Children { get; set; }
//    }
//    class Child
//    {
//        public Int32 Id { get; set; }
//        public String FirstName { get; set; }
//        public String LastName { get; set; }
//        public Int64 BirthDate { get; set; }
//        public Gender Gender { get; set; }
//    }
//    enum Gender
//    {
//        Male,
//        Female
//    }



    //    --create table Person
    //--{
    //--Id int,
    //--TransportId nvarchar(MAX),
    //--FirstName nvarchar(MAX),
    //--LastName nvarchar(MAX),
    //--SequenceId int,
    //--CreditCardNumbers nvarchar(MAX),
    //--Age nvarchar(MAX),
    //--Phones nvarchar(MAX),
    //--BirthDate float
    //--Salary int,
    //--IsMarred int,
    //--Gender int,
    //--Children nvarchar(MAX)
    //--
    //--
    //--}
    //--

    //    --create table Child
    //--(
    //--Id int,
    //--FirstName nvarchar(MAX),
    //--LastName nvarchar(MAX),
    //--BirthDate float,
    //--Gender int
    //--)

    public enum Gender
    {
        Male,
        Female
    }

    [Table("Person")]
    public class Person
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("TransportId")]
        public Guid TransportId { get; set; }
        [Column("FirstName")]
        public string FirstName { get; set; }
 
        [Column("LastName")]
        public string LastName { get; set; }

        [Column("SequenceId")]
        public int SequenceId { get; set; }


        [Column("CreditCardNumbers")]
        public string CreditCardNumbers { get; set; }


        [Column("Age")]
        public int Age { get; set; }

       
        [Column("Phones")]
        public string[] Phones { get; set; }

        [Column("BirthDate")]
        public long BirthDate { get; set; }

        [Column("Salary")]
        public double Salary { get; set; }

        [Column("IsMarred")]
        public bool IsMarred { get; set; }

        [Column("Gender")]
        public Gender Gender { get; set; }

        [Column("Children")]
        public Child[] Children { get; set; }
    }
}