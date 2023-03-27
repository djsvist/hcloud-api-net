using System;
namespace hcloud_api.Models.Requests.SSHKeys
{
    public class SSHKeySortQuery
    {
        private string _value;

        private SSHKeySortQuery(string value) => _value = value;

        public static SSHKeySortQuery Id { get; } = new SSHKeySortQuery("id");
        public static SSHKeySortQuery IdAsc { get; } = new SSHKeySortQuery("id:asc");
        public static SSHKeySortQuery IdDesc { get; } = new SSHKeySortQuery("id:desc");
        public static SSHKeySortQuery Name { get; } = new SSHKeySortQuery("name");
        public static SSHKeySortQuery NameAsc { get; } = new SSHKeySortQuery("name:asc");
        public static SSHKeySortQuery NameDesc { get; } = new SSHKeySortQuery("name:desc");

        public override string ToString()
        {
            return _value;
        }
    }
}
