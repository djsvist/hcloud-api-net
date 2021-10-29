namespace hcloud_api.Models.Requests.Certificates
{
    public class CertificateSortQuery
    {
        private string _value;

        private CertificateSortQuery(string value) => _value = value;

        public static CertificateSortQuery Id { get; } = new CertificateSortQuery("id");
        public static CertificateSortQuery IdAsc { get; } = new CertificateSortQuery("id:asc");
        public static CertificateSortQuery IdDesc { get; } = new CertificateSortQuery("id:desc");
        public static CertificateSortQuery Name { get; } = new CertificateSortQuery("name");
        public static CertificateSortQuery NameAsc { get; } = new CertificateSortQuery("name:asc");
        public static CertificateSortQuery NameDesc { get; } = new CertificateSortQuery("name:desc");
        public static CertificateSortQuery Created { get; } = new CertificateSortQuery("created");
        public static CertificateSortQuery CreatedAsc { get; } = new CertificateSortQuery("created:asc");
        public static CertificateSortQuery CreatedDesc { get; } = new CertificateSortQuery("created:desc");

        public override string ToString()
        {
            return _value;
        }
    }
}
