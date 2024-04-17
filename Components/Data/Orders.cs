namespace BlazorApp2.Components.Data
{
    public class Order
    {

        public DateTime deliverDate { get; set; }
        public string provider { get; set; }
        public string company { get; set; }
        public string cod_order { get; set; }
        public List<OrderLine>? orderLines;
        public string artKeywords { get; set; }

        public Order(DateTime deliverDate, string clientDescription, string cod_order, string company)
        {
            this.deliverDate = deliverDate;
            this.provider = clientDescription;
            this.cod_order = cod_order;
            this.company = company;
            this.orderLines = new();
            this.artKeywords = "";
        }

    }
    public class OrderLine
    {
        public decimal quantity { get; set; }
        public string desc_art { get; set; }
        public OrderLine(string desc_art, Decimal quantity)
        {
            this.desc_art = desc_art;
            this.quantity = quantity;
        }
    }
}
