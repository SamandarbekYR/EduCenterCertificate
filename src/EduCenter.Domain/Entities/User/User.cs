namespace EduCenter.Domain.Entities.User;

public class User:BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string PasswordHash {  get; set; } = string.Empty;
    public string PaswordSalt {  get; set; } = string.Empty;
}
