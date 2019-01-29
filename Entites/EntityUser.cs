using Net_Core_3_MsSQL_Codefirst.Base;
using Net_Core_3_MsSQL_Codefirst.Entites.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net_Core_3_MsSQL_Codefirst.Entites
{
    [Table("Users")]
    public class EntityUser : BaseEntity, IEntityUser
    {
        public EntityUser()
        {
        }

        public int? Age { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string SurName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Address { get; set; }
        [Required]
        public string Password { get; set; }
        public string Title { get; set; }
    }
}
