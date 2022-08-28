namespace Osho.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Title = "Sex Matters",
                Description = "Sex matters to us all. The Osho approach to sex begins with an understanding of how important love is in our lives, while at the same time acknowledges that the journey into love cannot exclude our innate biological energies. With this perspective, it becomes clear that the tendency for religions, and for society in general, to associate sex with sin and morality has been a great misfortune.",
                ImageUrl = "https://m.media-amazon.com/images/P/0312316305.01._SCLZZZZZZZ_SX500_.jpg",
                Price = 9.99m
            },
        new Product
        {
            Id = 2,
            Title = "Discovering Your Center",
            Description = "The longing to be who we really are…. Osho explains how we became alienated from our own essence, what it means to live in that disconnect, and how to rediscover our authenticity. Osho delivers a lot in one small talk!",
            ImageUrl = "https://m.media-amazon.com/images/P/B01FUUL05I.01._SCLZZZZZZZ_SX500_.jpg",
            Price = 19.99m
        },
        new Product
        {
            Id = 3,
            Title = "Earthen Lamps",
            Description = "One needs a very sympathetic ear and a very sympathetic heart to understand these beautiful parables, which are a rarity in Osho's work because they don't come from the talks that have made him so famous -- the parables are actually written by him. Mystics like Buddha and Jesus talked in parables -- and in his book Osho provides us with sixty parables, anecdotes, and stories that speak directly to us -- contemporary people of the modern age.",
            ImageUrl = "https://m.media-amazon.com/images/P/B01G12DLJW.01._SCLZZZZZZZ_SX500_.jpg",
            Price = 11.99m
        });

        }
    }
}
