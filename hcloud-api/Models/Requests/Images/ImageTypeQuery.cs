namespace hcloud_api.Models.Requests.Images
{
    public class ImageTypeQuery
    {
        private string _value;

        private ImageTypeQuery(string value) => _value = value;

        public static ImageTypeQuery System { get; } = new ImageTypeQuery("system");
        public static ImageTypeQuery Snapshot { get; } = new ImageTypeQuery("snapshot");
        public static ImageTypeQuery Backup { get; } = new ImageTypeQuery("backup");
        public static ImageTypeQuery App { get; } = new ImageTypeQuery("app");

        public override string ToString()
        {
            return _value;
        }
    }
}
