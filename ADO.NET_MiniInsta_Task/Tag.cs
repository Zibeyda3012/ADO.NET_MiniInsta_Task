namespace ADO.NET_MiniInsta_Task
{
    public class Tag
    {
        public int Id { get; set; }

        public string _tag { get; set; }

        public List<Post> _Posts { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
