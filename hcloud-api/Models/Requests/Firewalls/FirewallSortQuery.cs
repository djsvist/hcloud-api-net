namespace hcloud_api.Models.Requests.Firewalls
{
    public class FirewallSortQuery
    {
        private string _value;

        private FirewallSortQuery(string value) => _value = value;

        public static FirewallSortQuery Id { get; } = new FirewallSortQuery("id");
        public static FirewallSortQuery IdAsc { get; } = new FirewallSortQuery("id:asc");
        public static FirewallSortQuery IdDesc { get; } = new FirewallSortQuery("id:desc");
        public static FirewallSortQuery Name { get; } = new FirewallSortQuery("name");
        public static FirewallSortQuery NameAsc { get; } = new FirewallSortQuery("name:asc");
        public static FirewallSortQuery NameDesc { get; } = new FirewallSortQuery("name:desc");
        public static FirewallSortQuery Created { get; } = new FirewallSortQuery("created");
        public static FirewallSortQuery CreatedAsc { get; } = new FirewallSortQuery("created:asc");
        public static FirewallSortQuery CreatedDesc { get; } = new FirewallSortQuery("created:desc");

        public override string ToString()
        {
            return _value;
        }
    }
}
