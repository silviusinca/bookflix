using Bookflix.Data;
using Bookflix.Models;

namespace Bookflix.Helpers.Seeders
{
    public class BookSeeder
    {
        public readonly BookflixContext _context;

        public BookSeeder(BookflixContext context)
        {
            _context = context;
        }

        public void SeedInitialBooks()
        {
            if (!_context.Books.Any()) {
                var tbp = new Book
                {
                    AuthorName = "Cixin Liu",
                    Title = "The Three-Body Problem",
                    Description = "Set against the backdrop of China's Cultural Revolution, " +
                    "a secret military project sends signals into space to establish contact " +
                    "with aliens. An alien civilization on the brink of destruction captures the " +
                    "signal and plans to invade Earth. Meanwhile, on Earth, different camps start " +
                    "forming, planning to either welcome the superior beings and help them take over " +
                    "a world seen as corrupt, or to fight against the invasion. The result is a " +
                    "science fiction masterpiece of enormous scope and vision.",
                    DatePublished = new DateTime(2006, 8, 12)
                };
                var tdf = new Book
                {
                    AuthorName = "Cixin Liu",
                    Title = "The Dark Forest",
                    Description = "In The Dark Forest, Earth is reeling from the revelation of a " +
                    "coming alien invasion-in just four centuries' time. The aliens' human " +
                    "collaborators may have been defeated, but the presence of the sophons, " +
                    "the subatomic particles that allow Trisolaris instant access to all human " +
                    "information, means that Earth's defense plans are totally exposed to the" +
                    " enemy. Only the human mind remains a secret. This is the motivation for " +
                    "the Wallfacer Project, a daring plan that grants four men enormous resources " +
                    "to design secret strategies, hidden through deceit and misdirection from Earth " +
                    "and Trisolaris alike. Three of the Wallfacers are influential statesmen and " +
                    "scientists, but the fourth is a total unknown. Luo Ji, an unambitious Chinese" +
                    " astronomer and sociologist, is baffled by his new status. All he knows is that" +
                    " he's the one Wallfacer that Trisolaris wants dead.",
                    DatePublished = new DateTime(2006, 5, 1)
                };
                var de = new Book
                {
                    AuthorName = "Cixin Liu",
                    Title = "Death's End",
                    Description = "Half a century after the Doomsday Battle, the uneasy balance of " +
                    "Dark Forest Deterrence keeps the Trisolaran invaders at bay. Earth enjoys " +
                    "unprecedented prosperity due to the infusion of Trisolaran knowledge. With " +
                    "human science advancing daily and the Trisolarans adopting Earth culture, " +
                    "it seems that the two civilizations will soon be able to co-exist peacefully" +
                    " as equals without the terrible threat of mutually assured annihilation. But " +
                    "the peace has also made humanity complacent. Cheng Xin, an aerospace engineer" +
                    " from the early twenty-first century, awakens from hibernation in this new " +
                    "age. She brings with her knowledge of a long-forgotten program dating from " +
                    "the beginning of the Trisolar Crisis, and her very presence may upset the" +
                    " delicate balance between two worlds. Will humanity reach for the stars or " +
                    "die in its cradle?",
                    DatePublished = new DateTime(2010, 11, 10)
                };

                _context.Add(tbp);
                _context.Add(tdf);
                _context.Add(de);

                _context.SaveChanges();
            }
        }

    }
}
