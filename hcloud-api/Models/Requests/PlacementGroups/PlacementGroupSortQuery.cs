namespace hcloud_api.Models.Requests.PlacementGroups
{
    public class PlacementGroupSortQuery
    {
        private string _value;

        private PlacementGroupSortQuery(string value) => _value = value;

        public static PlacementGroupSortQuery Id { get; } = new PlacementGroupSortQuery("id");
        public static PlacementGroupSortQuery IdAsc { get; } = new PlacementGroupSortQuery("id:asc");
        public static PlacementGroupSortQuery IdDesc { get; } = new PlacementGroupSortQuery("id:desc");
        public static PlacementGroupSortQuery Name { get; } = new PlacementGroupSortQuery("name");
        public static PlacementGroupSortQuery NameAsc { get; } = new PlacementGroupSortQuery("name:asc");
        public static PlacementGroupSortQuery NameDesc { get; } = new PlacementGroupSortQuery("name:desc");
        public static PlacementGroupSortQuery Created { get; } = new PlacementGroupSortQuery("created");
        public static PlacementGroupSortQuery CreatedAsc { get; } = new PlacementGroupSortQuery("created:asc");
        public static PlacementGroupSortQuery CreatedDesc { get; } = new PlacementGroupSortQuery("created:desc");

        public override string ToString()
        {
            return _value;
        }
    }
}
