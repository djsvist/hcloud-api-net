namespace hcloud_api.Models.Requests.FloatingIPs
{
    public class FloatingIPSortQuery
    {
        private string _value;

        private FloatingIPSortQuery(string value) => _value = value;

        public static FloatingIPSortQuery Id { get; } = new FloatingIPSortQuery("id");
        public static FloatingIPSortQuery IdAsc { get; } = new FloatingIPSortQuery("id:asc");
        public static FloatingIPSortQuery IdDesc { get; } = new FloatingIPSortQuery("id:desc");
        public static FloatingIPSortQuery Created { get; } = new FloatingIPSortQuery("created");
        public static FloatingIPSortQuery CreatedAsc { get; } = new FloatingIPSortQuery("created:asc");
        public static FloatingIPSortQuery CreatedDesc { get; } = new FloatingIPSortQuery("created:desc");

        public override string ToString()
        {
            return _value;
        }
    }
}
