using LibApp.Models;

namespace LibApp.ViewModels
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public MembershipType MembershipType { get; set; }

        public Customer()
        {
        }
    }
}
