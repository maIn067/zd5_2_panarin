namespace zd4.Models
{
    public class ListItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public override string ToString() => Title;
    }
}
