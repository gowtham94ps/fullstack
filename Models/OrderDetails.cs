namespace WebApplicationAPI.Models
{
    public class OrderDetails
    {
        public Guid Id { get; set; }
        public string Product { get; set; }
        public string Customer { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Status { get; set; }
        public string Total { get; set; }
        public string Action { get; set; }

    }
}
