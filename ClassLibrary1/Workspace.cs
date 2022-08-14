namespace Lib;
public class Workspace
{
    public Guid Id { get; private set; }
    public string Name { get; private set; }

    public Workspace(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
        Validate();
    }

    private void Validate()
    {
        if(string.IsNullOrWhiteSpace(Name))
            throw new ArgumentNullException("Name");
    }
}
