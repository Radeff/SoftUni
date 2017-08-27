public abstract class Worker
{
    protected Worker(string id)
    {
        this.Id = id;
    }

    protected string Id { get; private set; }
}