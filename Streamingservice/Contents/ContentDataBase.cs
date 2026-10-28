namespace Streamingservice.Contents
{
    public static class ContentDataBase
    {
        public static List<Content> ContentList { get; set; } = new List<Content>
        {
            new Movie
            {
                Id = 1,
                Title = "Sagan om Felix - Plånbokens återkomst",
                Description = "A tale about a square and Felix",
                Genre = Genre.Fantasy,
                IsExclusive = false,
                PlayTime = 240
            },
            new Movie
            {
                Id = 2,
                Title = "Ida-Gun",
                Description = "Will she be the first ever woman in the most elite airstrike team in USA, Ida-Gun.",
                Genre = Genre.Action,
                IsExclusive = false,
                PlayTime = 118
            },
            new Series 
            {
                Id = 3,
                Title = "Wiklundton",
                Description = "A Series about family drama in the town of Märsta",
                Genre = Genre.Drama,
                IsExclusive = true,
                Seasons = new List<Season>
                {
                    new Season
                    {
                        SeasonNumber = 1,
                        Episodes = new List<Episode>
                        {
                            new Episode { EpisodeNumber = 1, EpisodeTitle = "Pilot", PlayTime = 45 },
                            new Episode { EpisodeNumber = 2, EpisodeTitle = "The series has landed", PlayTime = 45 },
                            new Episode { EpisodeNumber = 3, EpisodeTitle = "Märsta is not Stockholm", PlayTime = 45 },
                            new Episode { EpisodeNumber = 4, EpisodeTitle = "Who took the last mazarin?!?", PlayTime = 45 }
                        }
                    },

                    new Season
                    {
                        SeasonNumber = 2,
                        Episodes = new List<Episode>
                        {
                            new Episode { EpisodeNumber = 1, EpisodeTitle = "Märsta is the new Stockholm", PlayTime = 45 },
                            new Episode { EpisodeNumber = 2, EpisodeTitle = "Elvis lives", PlayTime = 45 },
                            new Episode { EpisodeNumber = 3, EpisodeTitle = "Elvis is missing", PlayTime = 45 },
                            new Episode { EpisodeNumber = 4, EpisodeTitle = "Märsta by night", PlayTime = 45 },
                            new Episode { EpisodeNumber = 5, EpisodeTitle = "We all love Märsta", PlayTime = 45 }
                        }
                    }
                }
            },
            new Movie
            {
                Id = 4,
                Title = "Harry Minna och De Vises HP",
                Description = "Harry Minna goes on a hunt for the philosophers HP, a very wonderful and magical laptop.",
                Genre = Genre.Fantasy,
                IsExclusive = false,
                PlayTime = 98
            },
            new Movie
            {
                Id = 5,
                Title = "How to lose Felix in 10 day",
                Description = "A lovely romance story about a small-town romance",
                Genre = Genre.Romance,
                IsExclusive = false,
                PlayTime = 92
            },
            new Movie
            {
                Id = 6,
                Title = "Terminida",
                Description = "The Terminida is threatening the world, will she be stopped in time?",
                Genre = Genre.Thriller,
                IsExclusive = false,
                PlayTime = 134
            },
            new Series
            {
                Id = 7,
                Title = "The Tråd",
                Description = "A Series about societys different problems",
                Genre = Genre.Drama,
                IsExclusive = true,
                Seasons = new List<Season>
                {
                    new Season
                    {
                        SeasonNumber = 1,
                        Episodes = new List<Episode>
                        {
                            new Episode { EpisodeNumber = 1, EpisodeTitle = "The thread", PlayTime = 45 },
                            new Episode { EpisodeNumber = 2, EpisodeTitle = "Threading", PlayTime = 45 },
                            new Episode { EpisodeNumber = 3, EpisodeTitle = "Polyester", PlayTime = 45 },
                            new Episode { EpisodeNumber = 4, EpisodeTitle = "Sewing machine", PlayTime = 45 }
                        }
                    }
                }
            },
            new Movie
            {
                Id = 8,
                Title = "Dennis på taket",
                Description = "Dennis is running around on the roof. Everyone is wondering why.",
                Genre = Genre.Comedy,
                IsExclusive = false,
                PlayTime = 87
            },
            new Movie
            {
                Id = 9,
                Title = "Jonas: Homecoming",
                Description = "Jonas returns to Borlänge after a long journey",
                Genre = Genre.Action,
                IsExclusive = false,
                PlayTime = 98
            },
            new Movie
            {
                Id = 10,
                Title = "Jonas: Far From Home",
                Description = "Jonas is once again out on a big adventure",
                Genre = Genre.Action,
                IsExclusive = false,
                PlayTime = 98
            },
            new Movie
            {
                Id = 11,
                Title = "Jonas: No Way Home",
                Description = "How will he find his way back from Ica Domnarvet",
                Genre = Genre.Action,
                IsExclusive = false,
                PlayTime = 98
            },
            new Movie
            {
                Id = 12,
                Title = "Jonas: Brand New Day",
                Description = "Jonas wakes up",
                Genre = Genre.Action,
                IsExclusive = false,
                PlayTime = 98
            },
            new Movie
            {
                Id = 13,
                Title = "101 Minna",
                Description = "An evil, old woman wants to skin all the Minnas to make a nice fur (skin?) coat.",
                Genre = Genre.Horror,
                IsExclusive = false,
                PlayTime = 113
            },
            new Movie
            {
                Id = 14,
                Title = "Ida wears Prada",
                Description = "A girl with expensive taste, zero money, and enough attitude to get banned from every fashion show in Paris. ",
                Genre = Genre.Drama,
                IsExclusive = true,
                PlayTime = 98
            },
            new Movie
            {
                Id = 15,
                Title = "Jonas till farsa",
                Description = "The journey of being a father",
                Genre = Genre.Documentary,
                IsExclusive = false,
                PlayTime = 120
            },
            new Movie
            {
                Id = 16,
                Title = "Ida and Prejudice",
                Description = "A romantic story about how Ida finds her true love in a very dramatic and rainy world.",
                Genre = Genre.Romance,
                IsExclusive = true,
                PlayTime = 122
            },
            new Series
            {
                Id = 17,
                Title = "Varma fakta",
                Description = "A documentary series that avoids important issues and investigates absolutely nothing. No facts, no evidence, just vibes. ",
                Genre = Genre.Documentary,
                IsExclusive = true,
                Seasons = new List<Season>
                {
                    new Season
                    {
                        SeasonNumber = 1,
                        Episodes = new List<Episode>
                        {
                            new Episode { EpisodeNumber = 1, EpisodeTitle = "Ocean -  The big blue", PlayTime = 45 },
                            new Episode { EpisodeNumber = 2, EpisodeTitle = "Rain forest - The rustling", PlayTime = 45 },
                        }
                    },

                    new Season
                    {
                        SeasonNumber = 2,
                        Episodes = new List<Episode>
                        {
                            new Episode { EpisodeNumber = 1, EpisodeTitle = "Afternoon tea", PlayTime = 45 },
                            new Episode { EpisodeNumber = 2, EpisodeTitle = "Droplets of rain", PlayTime = 45 }
                        }
                    },
                    new Season
                    {
                        SeasonNumber = 3,
                        Episodes = new List<Episode>
                        {
                            new Episode { EpisodeNumber = 1, EpisodeTitle = "Campfire by night", PlayTime = 45 },
                            new Episode { EpisodeNumber = 2, EpisodeTitle = "Campfire tales", PlayTime = 45 }
                        }
                    },
                    new Season
                    {
                        SeasonNumber = 4,
                        Episodes = new List<Episode>
                        {
                            new Episode { EpisodeNumber = 1, EpisodeTitle = "Soft fluffy cats", PlayTime = 45 },
                            new Episode { EpisodeNumber = 2, EpisodeTitle = "Hurricane tortilla", PlayTime = 45 }
                        }
                    }
                }
            },
            new Movie
            {
                Id = 18,
                Title = "Project Hail Minna",
                Description = "When the world is in danger, Minna is humanity’s last hope. Unfortunately, she has no idea what’s going on and didn’t sign up for this.",
                Genre = Genre.ScienceFiction,
                IsExclusive = false,
                PlayTime = 98
            },
            new Series
            {
                Id = 19,
                Title = "Breaking Ida",
                Description = "Driven by a sudden crisis, rule-following Ida steps over the line—and plunges into the city's criminal underworld. A fast-paced drama about breaking free.",
                Genre = Genre.Drama,
                IsExclusive = false,
                Seasons = new List<Season>
                {
                    new Season
                    {
                        SeasonNumber = 1,
                        Episodes = new List<Episode>
                        {
                            new Episode { EpisodeNumber = 1, EpisodeTitle = "Ida breaks a ...", PlayTime = 45 },
                            new Episode { EpisodeNumber = 2, EpisodeTitle = "Ida breaks a window", PlayTime = 45 },
                            new Episode { EpisodeNumber = 3, EpisodeTitle = "Ida breaks a rule", PlayTime = 45 },
                            new Episode { EpisodeNumber = 4, EpisodeTitle = "Ida breaks a promise", PlayTime = 45 }
                        }
                    },

                    new Season
                    {
                        SeasonNumber = 2,
                        Episodes = new List<Episode>
                        {
                            new Episode { EpisodeNumber = 1, EpisodeTitle = "Ida breaks a code", PlayTime = 45 },
                            new Episode { EpisodeNumber = 2, EpisodeTitle = "Ida breaks a law", PlayTime = 45 },
                            new Episode { EpisodeNumber = 3, EpisodeTitle = "Ida breaks a leg or two", PlayTime = 45 },
                            new Episode { EpisodeNumber = 4, EpisodeTitle = "Ida breaks a heart", PlayTime = 45 },
                            new Episode { EpisodeNumber = 5, EpisodeTitle = "Ida goes home to Nås", PlayTime = 45 }
                        }
                    }
                }
                
            },
            new Movie
            {
                Id = 20,
                Title = "Wiklund Wars",
                Description = "In a world where greed meets family betrayal, the ultimate battle for an empire begins.",
                Genre = Genre.ScienceFiction,
                IsExclusive = true,
                PlayTime = 190
            },
            new Movie
            {
                Id = 21,
                Title = "I-T",
                Description = " A terrifying horror movie where a group of teenagers faces their worst nightmare: the Wi-Fi stops working, and the IT support guy says, “Have you tried turning it off and on again?”",
                Genre = Genre.Horror,
                IsExclusive = false,
                PlayTime = 113
            },
            new Movie
            {
                Id = 22,
                Title = "Dennis & Dennisare",
                Description = "Two hopelessly clueless friends, both named Dennis, try to fix a tiny mistake, only to trigger a chaotic chain of absurd disasters across the city.",
                Genre = Genre.Comedy,
                IsExclusive = true,
                PlayTime = 104
            }
        };
    }
}