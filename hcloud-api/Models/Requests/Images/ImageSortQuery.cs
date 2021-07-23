namespace hcloud_api.Models.Requests.Images
{
    public class ImageSortQuery
    {
        private string _value;

        private ImageSortQuery(string value) => _value = value;

        public static ImageSortQuery Id { get; } = new ImageSortQuery("id");
        public static ImageSortQuery IdAsc { get; } = new ImageSortQuery("id:asc");
        public static ImageSortQuery IdDesc { get; } = new ImageSortQuery("id:desc");
        public static ImageSortQuery Name { get; } = new ImageSortQuery("name");
        public static ImageSortQuery NameAsc { get; } = new ImageSortQuery("name:asc");
        public static ImageSortQuery NameDesc { get; } = new ImageSortQuery("name:desc");
        public static ImageSortQuery Created { get; } = new ImageSortQuery("created");
        public static ImageSortQuery CreatedAsc { get; } = new ImageSortQuery("created:asc");
        public static ImageSortQuery CreatedDesc { get; } = new ImageSortQuery("created:desc");

        public override string ToString()
        {
            return _value;
        }
    }
}
