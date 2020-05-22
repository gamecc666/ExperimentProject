namespace TodoApi.Models
{
    public class TodoItem
    {
        //数据库中的主键
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
