namespace hcloud_api.Models.Requests.Servers
{
    public class ServerStatusQuery
    {
        private string _value;

        private ServerStatusQuery(string value) => _value = value;

        public static ServerStatusQuery Initializing { get; } = new ServerStatusQuery("initializing");
        public static ServerStatusQuery Starting { get; } = new ServerStatusQuery("starting");
        public static ServerStatusQuery Running { get; } = new ServerStatusQuery("running");
        public static ServerStatusQuery Stopping { get; } = new ServerStatusQuery("stopping");
        public static ServerStatusQuery Off { get; } = new ServerStatusQuery("off");
        public static ServerStatusQuery Deleting { get; } = new ServerStatusQuery("deleting");
        public static ServerStatusQuery Rebuilding { get; } = new ServerStatusQuery("rebuilding");
        public static ServerStatusQuery Migrating { get; } = new ServerStatusQuery("migrating");
        public static ServerStatusQuery Unknown { get; } = new ServerStatusQuery("unknown");

        public override string ToString()
        {
            return _value;
        }
    }
}
