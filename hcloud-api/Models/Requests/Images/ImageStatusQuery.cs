namespace hcloud_api.Models.Requests.Images
{
    public class ImageStatusQuery
    {
        private string _value;

        private ImageStatusQuery(string value) => _value = value;

        public static ImageStatusQuery Available { get; } = new ImageStatusQuery("available");
        public static ImageStatusQuery Creating { get; } = new ImageStatusQuery("creating");

        public override string ToString()
        {
            return _value;
        }
    }
}
