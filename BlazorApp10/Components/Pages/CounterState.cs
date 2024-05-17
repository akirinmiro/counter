namespace BlazorApp10.Components.Pages
{
    public class CustomCounterState
    {
        public List<ItemModel> Items { get; set; } = new List<ItemModel>();
        public string InputValue { get; set; }
    }

    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime TimeAdded { get; set; }
    }
}
