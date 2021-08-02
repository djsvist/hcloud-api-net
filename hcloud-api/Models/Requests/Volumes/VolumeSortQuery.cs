namespace hcloud_api.Models.Requests.Volumes
{
    public class VolumeSortQuery
    {
        private string _value;

        private VolumeSortQuery(string value) => _value = value;

        public static VolumeSortQuery Id { get; } = new VolumeSortQuery("id");
        public static VolumeSortQuery IdAsc { get; } = new VolumeSortQuery("id:asc");
        public static VolumeSortQuery IdDesc { get; } = new VolumeSortQuery("id:desc");
        public static VolumeSortQuery Name { get; } = new VolumeSortQuery("name");
        public static VolumeSortQuery NameAsc { get; } = new VolumeSortQuery("name:asc");
        public static VolumeSortQuery NameDesc { get; } = new VolumeSortQuery("name:desc");
        public static VolumeSortQuery Created { get; } = new VolumeSortQuery("created");
        public static VolumeSortQuery CreatedAsc { get; } = new VolumeSortQuery("created:asc");
        public static VolumeSortQuery CreatedDesc { get; } = new VolumeSortQuery("created:desc");

        public override string ToString()
        {
            return _value;
        }
    }
}
