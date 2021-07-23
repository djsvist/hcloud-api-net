using Newtonsoft.Json;

namespace hcloud_api.Models.Responses.Metas
{
    public class Pagination
    {
        /// <summary>
        /// ID of the last page available. Can be null if the current page is the last one.
        /// </summary>
        [JsonProperty("last_page")]
        public int? LastPage { get; set; }

        /// <summary>
        /// ID of the next page. Can be null if the current page is the last one.
        /// </summary>
        [JsonProperty("next_page")]
        public int? NextPage { get; set; }

        /// <summary>
        /// Current page number
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Maximum number of items shown per page in the response
        /// </summary>
        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        /// <summary>
        /// ID of the previous page. Can be null if the current page is the first one.
        /// </summary>
        [JsonProperty("previous_page")]
        public int? PreviousPage { get; set; }

        /// <summary>
        /// The total number of entries that exist in the database for this query. Nullable if unknown.
        /// </summary>
        [JsonProperty("total_entries")]
        public int? TotalEntries { get; set; }
    }
}
