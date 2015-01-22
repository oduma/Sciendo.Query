namespace Sciendo.Query.Contracts.Model
{
    public class Doc
    {
        public string file_path_id { get; set; }
        public string file_path { get; set; }
        public string[] artist { get; set; }
        public string album { get; set; }
        public string title { get; set; }
        public string lyrics { get; set; }
    }
}