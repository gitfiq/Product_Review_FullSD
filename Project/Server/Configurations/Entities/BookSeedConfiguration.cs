using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Shared.Domain;

namespace Project.Server.Configuration.Entities
{
    public class BookSeedConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData
            (
                new Book
                {
                    Id = 1,
                    Title = "Harry Potter",
                    Description = "The Dursleys were so mean and hideous that summer that all Harry Potter wanted was to get back to the Hogwarts School for Witchcraft and Wizardry. But just as he's packing his bags, Harry receives a warning from a strange, impish creature named Dobby who says that if Harry Potter returns to Hogwarts, disaster will strike.And strike it does. For in Harry's second year at Hogwarts, fresh torments and horrors arise, including an outrageously stuck-up new professor, Gilderoy Lockhart, a spirit named Moaning Myrtle who haunts the girls' bathroom, and the unwanted attentions of Ron Weasley's younger sister, Ginny.But each of these seem minor annoyances when the real trouble begins, and someone -- or something -- starts turning Hogwarts students to stone. Could it be Draco Malfoy, a more poisonous rival than ever? Could it possibly be Hagrid, whose mysterious past is finally told? Or could it be the one everyone at Hogwarts most suspects... Harry Potter himself?",
                    BookRating = 5,
                    PublishYear = 2014,
                    Edition = "1",
                    Subject = "English",
                    SchoolLevel = "Primary 5",
                    NumberOfPages = 200,
                    PublisherID = 1
                },
                new Book
                {
                    Id = 2,
                    Title = "Lord Of The Rings",
                    Description = "One Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkness bind them.\r\n\r\nIn ancient times the Rings of Power were crafted by the Elven-smiths, and Sauron, the Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others. But the One Ring was taken from him, and though he sought it throughout Middle-earth, it remained lost to him. After many ages it fell by chance into the hands of the hobbit Bilbo Baggins.\r\n\r\nFrom Sauron's fastness in the Dark Tower of Mordor, his power spread far and wide. Sauron gathered all the Great Rings to him, but always he searched for the One Ring that would complete his dominion.\r\n\r\nWhen Bilbo reached his eleventy-first birthday he disappeared, bequeathing to his young cousin Frodo the Ruling Ring and a perilous quest: to journey across Middle-earth, deep into the shadow of the Dark Lord, and destroy the Ring by casting it into the Cracks of Doom.",
                    BookRating = 5.0,
                    PublishYear = 2015,
                    Edition = "1",
                    Subject = "English",
                    SchoolLevel = "Secondary 1",
                    NumberOfPages = 250,
                    PublisherID = 1
                },
                new Book
                {
                    Id = 3,
                    Title = "A Dog's Purpose: A Novel for Humans",
                    Description = "The family film told from the dog’s perspective also stars Britt Robertson, KJ Apa, John Ortiz, Peggy Lipton, Juliet Rylance, Luke Kirby, Pooch Hall and Dennis Quaid. A Dog’s Purpose is produced by Gavin Polone (Zombieland, TV’s Gilmore Girls). The film from Amblin Entertainment and Walden Media will be distributed by Universal Pictures. Screenplay by W. Bruce Cameron & Cathryn Michon and Audrey Wells and Maya Forbes & Wally Wolodarsky.\r\n\r\nHeartwarming, insightful, and often laugh-out-loud funny, A Dog's Purpose is not only the emotional and hilarious story of a dog's many lives, but also a dog's-eye commentary on human relationships and the unbreakable bonds between man and man's best friend. This moving and beautifully crafted story teaches us that love never dies, that our true friends are always with us, and that every creature on earth is born with a purpose.",
                    BookRating = 4.0,
                    PublishYear = 2015,
                    Edition = "1",
                    Subject = "English",
                    SchoolLevel = "Secondary 1",
                    NumberOfPages = 336,
                    PublisherID = 1
                },
                new Book
                {
                    Id = 4,
                    Title = "The Book That Wouldn't Burn",
                    Description = "The boy has lived his whole life trapped within a book-choked chamber older than empires and larger than cities.\r\n\r\nThe girl has been plucked from the outskirts of civilization to be trained as a librarian, studying the mysteries of the great library at the heart of her kingdom.They were never supposed to meet. But in the library, they did.\r\n\r\nTheir stories spiral around each other, across worlds and time. This is a tale of truth and lies and hearts, and the blurring of one into another. A journey on which knowledge erodes certainty and on which, though the pen may be mightier than the sword, blood will be spilled and cities burned.",
                    BookRating = 3.0,
                    PublishYear = 2015,
                    Edition = "1",
                    Subject = "English",
                    SchoolLevel = "Secondary 1",
                    NumberOfPages = 421,
                    PublisherID = 1
                },
                new Book
                {
                    Id = 5,
                    Title = "Harry Potter and the Prisoner of Azkaban ",
                    Description = "The third book in the Harry Potter series, illustrated in brilliant full color by MinaLima and featuring eight exclusive interactive elements, including the Marauder’s Map and more!Return to Hogwarts in this stunning edition of Harry Potter and the Prisoner of Azkaban. J.K. Rowling’s complete and unabridged text is accompanied by full-color illustrations on nearly every page and eight paper-engineered interactive elements: Readers will explore the Knight Bus, reveal the Grim in a teacup, spin the Time-Turner, and more.\r\n\r\nDesigned and illustrated by MinaLima ― the award-winning studio behind the graphic style of the Harry Potter films ― this keepsake edition is the perfect gift for Harry Potter fans of all ages, a beautiful addition to any collector’s bookshelf, and an enchanting way to share this beloved series with a new generation of readers.",
                    BookRating = 3.0,
                    PublishYear = 2015,
                    Edition = "1",
                    Subject = "English",
                    SchoolLevel = "Secondary 1",
                    NumberOfPages = 421,
                    PublisherID = 1
                },
                new Book
                {
                    Id = 6,
                    Title = "The Science of Interstellar",
                    Description = "Interstellar, from acclaimed filmmaker Christopher Nolan, takes us on a fantastic voyage far beyond our solar system. Yet in The Science of Interstellar, Kip Thorne, the Nobel prize-winning physicist who assisted Nolan on the scientific aspects of Interstellar, shows us that the movie’s jaw-dropping events and stunning, never-before-attempted visuals are grounded in real science. Thorne shares his experiences working as the science adviser on the film and then moves on to the science itself. In chapters on wormholes, black holes, interstellar travel, and much more, Thorne’s scientific insights―many of them triggered during the actual scripting and shooting of Interstellar―describe the physical laws that govern our universe and the truly astounding phenomena that those laws make possible.",
                    BookRating = 3.0,
                    PublishYear = 2015,
                    Edition = "1",
                    Subject = "English",
                    SchoolLevel = "Secondary 1",
                    NumberOfPages = 421,
                    PublisherID = 1
                },
                new Book
                {
                    Id = 7,
                    Title = "Iron Flame (The Empyrean Book 2) ",
                    Description = "Everyone expected Violet Sorrengail to die during her first year at Basgiath War College—Violet included. But Threshing was only the first impossible test meant to weed out the weak-willed, the unworthy, and the unlucky.\r\n\r\nNow the real training begins, and Violet’s already wondering how she’ll get through. It’s not just that it’s grueling and maliciously brutal, or even that it’s designed to stretch the riders’ capacity for pain beyond endurance. It’s the new vice commandant, who’s made it his personal mission to teach Violet exactly how powerless she is–unless she betrays the man she loves.\r\n\r\nAlthough Violet’s body might be weaker and frailer than everyone else’s, she still has her wits—and a will of iron. And leadership is forgetting the most important lesson Basgiath has taught her: Dragon riders make their own rules.\r\n\r\nBut a determination to survive won’t be enough this year.\r\n\r\nBecause Violet knows the real secret hidden for centuries at Basgiath War College—and nothing, not even dragon fire, may be enough to save them in the end.\r\n\r\nThe Empyrean series is best enjoyed in order.\r\nReading Order:\r\nBook #1 Fourth Wing\r\nBook #2 Iron Flame",
                    BookRating = 3.0,
                    PublishYear = 2015,
                    Edition = "1",
                    Subject = "English",
                    SchoolLevel = "Secondary 1",
                    NumberOfPages = 421,
                    PublisherID = 1
                }
            );
        }
    }
}