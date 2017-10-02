using System.ComponentModel.DataAnnotations;

namespace WebServiceTest.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
