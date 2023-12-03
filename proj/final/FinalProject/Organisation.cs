// Abstract class representing an educational organization
public abstract class EducationalOrganization
{
    public string Name { get; set; }
    public List<string> Type { get; set; }
    public string Introduction { get; set; }
    public string Year { get; set; }

    public abstract void DisplayDetails();
}
