namespace hcloud_api.Models.Requests.Volumes
{
    public class VolumeStatusQuery
    {
        private string _value;

        private VolumeStatusQuery(string value) => _value = value;

        public static VolumeStatusQuery Creating { get; } = new VolumeStatusQuery("creating");
        public static VolumeStatusQuery Available { get; } = new VolumeStatusQuery("available");

        public override string ToString()
        {
            return _value;
        }
    }
}
