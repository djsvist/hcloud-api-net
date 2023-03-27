namespace hcloud_api.Models.Requests.Actions
{
    public class ActionSortQuery
    {
        private string _value;

        private ActionSortQuery(string value) => _value = value;

        public static ActionSortQuery Id { get; } = new ActionSortQuery("id");
        public static ActionSortQuery IdAsc { get; } = new ActionSortQuery("id:asc");
        public static ActionSortQuery IdDesc { get; } = new ActionSortQuery("id:desc");
        public static ActionSortQuery Command { get; } = new ActionSortQuery("command");
        public static ActionSortQuery CommandAsc { get; } = new ActionSortQuery("command:asc");
        public static ActionSortQuery CommandDesc { get; } = new ActionSortQuery("command:desc");
        public static ActionSortQuery Status { get; } = new ActionSortQuery("status");
        public static ActionSortQuery StatusAsc { get; } = new ActionSortQuery("status:asc");
        public static ActionSortQuery StatusDesc { get; } = new ActionSortQuery("status:desc");
        public static ActionSortQuery Progress { get; } = new ActionSortQuery("progress");
        public static ActionSortQuery ProgressAsc { get; } = new ActionSortQuery("progress:asc");
        public static ActionSortQuery ProgressDesc { get; } = new ActionSortQuery("progress:desc");
        public static ActionSortQuery Started { get; } = new ActionSortQuery("started");
        public static ActionSortQuery StartedAsc { get; } = new ActionSortQuery("started:asc");
        public static ActionSortQuery StartedDesc { get; } = new ActionSortQuery("started:desc");
        public static ActionSortQuery Finished { get; } = new ActionSortQuery("finished");
        public static ActionSortQuery FinishedAsc { get; } = new ActionSortQuery("finished:asc");
        public static ActionSortQuery FinishedDesc { get; } = new ActionSortQuery("finished:desc");

        public override string ToString()
        {
            return _value;
        }
    }
}
