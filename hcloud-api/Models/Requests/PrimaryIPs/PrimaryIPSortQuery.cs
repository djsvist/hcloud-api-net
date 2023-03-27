namespace hcloud_api.Models.Requests.PrimaryIPs
{
    public class PrimaryIPSortQuery
    {
        private string _value;

        private PrimaryIPSortQuery(string value) => _value = value;

        public static PrimaryIPSortQuery Id { get; } = new PrimaryIPSortQuery("id");
        public static PrimaryIPSortQuery IdAsc { get; } = new PrimaryIPSortQuery("id:asc");
        public static PrimaryIPSortQuery IdDesc { get; } = new PrimaryIPSortQuery("id:desc");
        public static PrimaryIPSortQuery Created { get; } = new PrimaryIPSortQuery("created");
        public static PrimaryIPSortQuery CreatedAsc { get; } = new PrimaryIPSortQuery("created:asc");
        public static PrimaryIPSortQuery CreatedDesc { get; } = new PrimaryIPSortQuery("created:desc");

        public override string ToString()
        {
            return _value;
        }
    }
}
