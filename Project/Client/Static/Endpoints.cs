namespace Project.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string RecommendationsEndpoint = $"{Prefix}/recommendations";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string BooksEndpoint = $"{Prefix}/books";
        public static readonly string PublishersEndpoint = $"{Prefix}/publishers";
    }
}
