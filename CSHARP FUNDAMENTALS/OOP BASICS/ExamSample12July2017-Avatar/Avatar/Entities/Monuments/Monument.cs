public abstract class Monument : Entity
{
    protected Monument(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }

    public override string ToString()
    {
        var typeName = this.GetType().Name;
        var type = this.GetType().Name.Remove(typeName.Length - Constants.MonumentStringLength);

        return $"###{type} {nameof(Monument)}: {this.Name}, {type} {nameof(this.Affinity)}: {this.Affinity}";
    }
}
