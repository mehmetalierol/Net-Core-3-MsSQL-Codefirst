using System;
using System.ComponentModel.DataAnnotations;

namespace Net_Core_3_MsSQL_Codefirst.Base
{
    public class BaseEntity : IBaseEntity
    {
        public BaseEntity()
        {
        }

        [Key]
        public Guid ID { get; set; }

        public int? AutoID { get; set; }

        public DateTime? CreatedDate { get; set; }

        public Guid? CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public Guid? ModifiedBy { get; set; }
    }
}

