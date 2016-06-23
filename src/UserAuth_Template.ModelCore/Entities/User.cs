using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAuth_Template.ModelCore.Entities
{
    [Table("Users")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
    }
}
