using Net_Core_3_MsSQL_Codefirst.Base;
using Net_Core_3_MsSQL_Codefirst.Entites.Interfaces;

namespace Net_Core_3_MsSQL_Codefirst.Entites
{
    public class EntityRole : BaseEntity, IEntityRole
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
