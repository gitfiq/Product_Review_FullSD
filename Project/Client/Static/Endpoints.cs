namespace Project.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string AuthorsEndpoint = $"{Prefix}/authors";
        public static readonly string ReviewsEndpoint = $"{Prefix}/reviews";
        public static readonly string BookAuthorDetailsEndpoint = $"{Prefix}/bookAuthorDetails";
        public static readonly string AppUsersEndpoint = $"{Prefix}/appUsers";
        public static readonly string RecommendationsEndpoint = $"{Prefix}/recommendations";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string BooksEndpoint = $"{Prefix}/books";
        public static readonly string PublishersEndpoint = $"{Prefix}/publishers";
        public static readonly string ProductsEndpoint = $"{Prefix}/products";
    }
}