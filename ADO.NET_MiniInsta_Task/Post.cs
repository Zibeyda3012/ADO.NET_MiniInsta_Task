namespace ADO.NET_MiniInsta_Task
{
    public class Post
    {
        public int Id { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        public string ImagePath { get; set; }

        public string Text { get; set; }

        public List<Tag> Tags { get; set; }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
