namespace Net_Core_3_MsSQL_Codefirst.Entites.Interfaces
{
    public interface IEntityUser
    {
        int? Age { get; set; }
        string Name { get; set; }
        string SurName { get; set; }
        string Email { get; set; }
        string Address { get; set; }
        string Password { get; set; }
        string Title { get; set; }
    }
}
