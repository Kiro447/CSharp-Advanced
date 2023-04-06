namespace ClassCode.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public List<Order> Orders { get; set; }
        //= new List<Order>(); ili tuka ili u constructor

        public User(int id, string username, string address)
        {
            Id = id;
            Username = username;
            Address = address;
            Orders = new List<Order>();
        }
        public void PrintOrders()
        {
            for (int i = 1; i < Orders.Count; i++)
            {
                Console.WriteLine($"{i}) {Orders[i-1].Print()}");
            }
        }
    }
}
