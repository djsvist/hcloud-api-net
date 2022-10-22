namespace hcloud_api.Models.Requests.Servers
{
    public class ServerSortQuery
    {
        private string _value;

        private ServerSortQuery(string value) => _value = value;

        public static ServerSortQuery Id { get; } = new ServerSortQuery("id");
        public static ServerSortQuery IdAsc { get; } = new ServerSortQuery("id:asc");
        public static ServerSortQuery IdDesc { get; } = new ServerSortQuery("id:desc");
        public static ServerSortQuery Name { get; } = new ServerSortQuery("name");
        public static ServerSortQuery NameAsc { get; } = new ServerSortQuery("name:asc");
        public static ServerSortQuery NameDesc { get; } = new ServerSortQuery("name:desc");
        public static ServerSortQuery Created { get; } = new ServerSortQuery("created");
        public static ServerSortQuery CreatedAsc { get; } = new ServerSortQuery("created:asc");
        public static ServerSortQuery CreatedDesc { get; } = new ServerSortQuery("created:desc");

        public override string ToString()
        {
            return _value;
        }
    }
}
