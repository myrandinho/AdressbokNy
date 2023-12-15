namespace Adressbok.Interfaces
{
    public interface IContact
    {
        string Adress { get; set; }
        string Email { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        string phoneNumber { get; set; }
    }
}