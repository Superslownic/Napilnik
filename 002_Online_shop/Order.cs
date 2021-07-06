namespace NapilnikTask_Online_shop
{
    public struct Order
    {
        public Order(string paylink)
        {
            Paylink = paylink;
        }

        public string Paylink { get; private set; }
    }
}
