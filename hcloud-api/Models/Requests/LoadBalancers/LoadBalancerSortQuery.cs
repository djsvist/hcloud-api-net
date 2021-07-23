namespace hcloud_api.Models.Requests.LoadBalancers
{
    public class LoadBalancerSortQuery
    {
        private string _value;

        private LoadBalancerSortQuery(string value) => _value = value;

        public static LoadBalancerSortQuery Id { get; } = new LoadBalancerSortQuery("id");
        public static LoadBalancerSortQuery IdAsc { get; } = new LoadBalancerSortQuery("id:asc");
        public static LoadBalancerSortQuery IdDesc { get; } = new LoadBalancerSortQuery("id:desc");
        public static LoadBalancerSortQuery Name { get; } = new LoadBalancerSortQuery("name");
        public static LoadBalancerSortQuery NameAsc { get; } = new LoadBalancerSortQuery("name:asc");
        public static LoadBalancerSortQuery NameDesc { get; } = new LoadBalancerSortQuery("name:desc");
        public static LoadBalancerSortQuery Created { get; } = new LoadBalancerSortQuery("created");
        public static LoadBalancerSortQuery CreatedAsc { get; } = new LoadBalancerSortQuery("created:asc");
        public static LoadBalancerSortQuery CreatedDesc { get; } = new LoadBalancerSortQuery("created:desc");

        public override string ToString()
        {
            return _value;
        }
    }
}
