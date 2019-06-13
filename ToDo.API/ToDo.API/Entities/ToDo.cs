using System.ComponentModel.DataAnnotations;

namespace ToDo.API.Entities
{
    public class ToDo
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
