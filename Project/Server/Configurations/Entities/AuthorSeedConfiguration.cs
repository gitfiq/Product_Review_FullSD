using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Shared.Domain;

namespace Project.Server.Configuration.Entities
{
    public class AuthorSeedConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData
            (
                new Author
                {
                    Id = 1,
                    EmailAddress = "roalddahl@bookmail.com",
                    Biography = "Roald Dahl (1916-1990) was a prolific British author renowned for his captivating and whimsical children's literature. Born in Wales, Dahl's diverse career began as a fighter pilot in World War II before he found success as a writer. His imaginative tales, such as \"Charlie and the Chocolate Factory,\" \"Matilda,\" and \"James and the Giant Peach,\" have become timeless classics, celebrated for their dark humor and memorable characters. Dahl's unique storytelling and vivid imagination earned him widespread acclaim, making him one of the most beloved and influential children's authors of the 20th century. His legacy endures, enchanting readers of all ages.",
                    ContactInfo = "22446688",
                    FirstName = "Roald",
                    LastName = "Dahl",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Author
                {
                    Id = 2,
                    EmailAddress = "georgeorwell@bookmail.com",
                    Biography = "George Orwell (1903-1950), born Eric Arthur Blair in India, was a British writer and journalist renowned for his penetrating social and political critiques. Best known for dystopian classics \"Nineteen Eighty-Four\" and \"Animal Farm,\" Orwell delved into the perils of totalitarianism and the abuse of power. A committed democratic socialist, his experiences during the Spanish Civil War and reflections on totalitarian regimes fueled his compelling narratives. Orwell's non-fiction works, including \"Homage to Catalonia\" and \"Down and Out in Paris and London,\" displayed a keen eye for societal injustice. His incisive prose and commitment to truth make Orwell a literary giant whose influence persists globally.",
                    ContactInfo = "11335577",
                    FirstName = "George",
                    LastName = "Orwell",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Author
                {
                    Id = 3,
                    EmailAddress = "jrrtolkien@bookmail.com",
                    Biography = "J.R.R. Tolkien (born January 3, 1892, Bloemfontein, South Africa—died September 2, 1973, Bournemouth, Hampshire, England) English writer and scholar who achieved fame with his children's book The Hobbit (1937) and his richly inventive epic fantasy The Lord of the Rings ",
                    ContactInfo = "48591526",
                    FirstName = "J.R.R",
                    LastName = "Tolkien",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Author
                {
                    Id = 4,
                    EmailAddress = "jkrowling@bookmail.com",
                    Biography = "J.K. Rowling, born Joanne Rowling on July 31, 1965, in Yate, Gloucestershire, England, is a British author best known for creating the immensely popular \"Harry Potter\" series. Rowling's journey to literary fame began with the idea for the series during a train journey in 1990. Over the next several years, she meticulously outlined the seven-book saga, which follows the magical adventures of the young wizard Harry Potter and his friends.",
                    ContactInfo = "35246857",
                    FirstName = "J.K",
                    LastName = "Rowling",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
