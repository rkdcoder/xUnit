
namespace Strings
{
    public class Names
    {
        public string? Initials { get; set; }
        public string MakeFullName(string firstName,  string lastName)
        {
            Initials = $"{firstName[0]}{lastName[0]}";
            return $"{firstName} {lastName}";
        }
    }
}
