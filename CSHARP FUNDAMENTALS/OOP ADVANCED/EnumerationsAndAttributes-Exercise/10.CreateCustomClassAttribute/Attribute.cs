namespace _10.CreateCustomClassAttribute
{
    public class KurAttribute : System.Attribute
    {
        public KurAttribute(string author, int revision, string description, string[] reviewers)
        {
            this.Author = author;
            this.Revision = revision;
            this.Description = description;
            this.Reviewers = reviewers;
        }

        public string[] Reviewers { get; set; }

        public string Description { get; set; }

        public int Revision { get; set; }

        public string Author { get; set; }
    }
}