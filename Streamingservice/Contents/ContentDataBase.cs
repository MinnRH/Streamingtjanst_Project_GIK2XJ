namespace Streamingservice.Contents
{
    public static class ContentDataBase
    {
        // Listan är statisk för att den ska vara tillgänglig över hela applikationen och inte behöva instansieras varje gång.
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
            },
            new Movie
            {
                Id = 23,
                Title = "Dennis Protocol",
                Description = "In a rain-slicked metropolis ruled by algorithms, a rogue rogue hacker uncovers a memory chip containing the consciousness of the city's founder.",
                Genre = Genre.ScienceFiction,
                IsExclusive = true,
                PlayTime = 129
            },
            new Movie
            {
                Id = 24,
                Title = "Love at Zero Felix",
                Description = "A chronically motion-sick travel blogger and an eccentric wilderness instructor get stranded together at a remote mountain cabin.",
                Genre = Genre.Romance,
                IsExclusive = false,
                PlayTime = 104
            },
            new Movie
            {
                Id = 25,
                Title = "The Static Between Idas",
                Description = "After moving into an isolated seaside radio tower, a late-night broadcaster begins hearing broadcasts from an alternative reality—and something is listening back.",
                Genre = Genre.Horror,
                IsExclusive = true,
                PlayTime = 112
            },
            new Movie
            {
                Id = 26,
                Title = "Jonas syndicate",
                Description = "A retired master locksmith is dragged into one final job: breaching an impenetrable vault beneath a high-stakes Casino in Monaco.",
                Genre = Genre.Thriller,
                IsExclusive = false,
                PlayTime = 141
            },
            new Movie
            {
                Id = 27,
                Title = "Ash & Minna",
                Description = "Decades after the sun was obscured by volcanic haze, a lone scavenger protects a young girl who holds the coordinates to the last sunlit valley.",
                Genre = Genre.ScienceFiction,
                IsExclusive = false,
                PlayTime = 135
            },
            new Movie
            {
                Id = 28,
                Title = "The Silent Dennis",
                Description = "Investigating a series of strange disappearances in a secluded mountain town, a local detective uncovers an ancient entity that feeds on secrets.",
                Genre = Genre.Horror,
                IsExclusive = true,
                PlayTime = 105
            },
            new Movie
            {
                Id = 29,
                Title = "Accidental Heist",
                Description = "Two hopelessly incompetent moving guys mistakenly drive off with a museum's priceless artifact, sparking a chaotic state-wide police chase.",
                Genre = Genre.Comedy,
                IsExclusive = false,
                PlayTime = 98
            },
            new Movie
            {
                Id = 30,
                Title = "Vanguard: Final Jonas",
                Description = "A disgraced operative is forced out of hiding to intercept a stolen orbital weapon before a rogue syndicate triggers global devastation.",
                Genre = Genre.Action,
                IsExclusive = false,
                PlayTime = 132
            },
            new Movie
            {
                Id = 31,
                Title = "Echoes of Ida",
                Description = "When a deep-space communications officer receives a SOS from an unmapped planet, she discovers a forgotten Ida-colony harboring a lethal cosmic secret.",
                Genre = Genre.ScienceFiction,
                IsExclusive = true,
                PlayTime = 124
            },
            new Movie
            {
                Id = 32,
                Title = "Dennis & Jonas: Professional Amateurs",
                Description = "Tasked with house-sitting a billionaire's mansion, Dennis and Jonas accidentally launch the security system's auto-destruct protocol while trying to fix the toaster.",
                Genre = Genre.Comedy,
                IsExclusive = false,
                PlayTime = 96
            },
            new Movie
            {
                Id = 33,
                Title = "Felix and the Quantum Glitch",
                Description = "Felix tries to debug a simple homework script, but accidentally tears a hole in spacetime, trapping himself in a dimension made entirely of uncompiled C# code.",
                Genre = Genre.ScienceFiction,
                IsExclusive = true,
                PlayTime = 115
            },
            new Movie
            {
                Id = 34,
                Title = "Minna's Missing Mug",
                Description = "When Minna's favorite coffee mug vanishes from the office breakroom, she turns into a hard-boiled detective launching an aggressive, city-wide manhunt.",
                Genre = Genre.Drama,
                IsExclusive = false,
                PlayTime = 102
            },
            new Movie
            {
                Id = 35,
                Title = "Ida's Ultimatum",
                Description = "Running on three energy drinks and sheer willpower, Ida takes on an entire corporate board of directors in a high-stakes negotiation battle to save the world's last Wi-Fi router.",
                Genre = Genre.Action,
                IsExclusive = true,
                PlayTime = 120
            },
            new Movie
            {
                Id = 36,
                Title = "The Roadtrip Disaster",
                Description = "Dennis, Jonas, Felix, Minna and Ida pile into a tiny hatchback for a weekend getaway, only to take a 'shortcut' that leads them straight into a secret military testing zone.",
                Genre = Genre.Comedy,
                IsExclusive = false,
                PlayTime = 110
            },
            new Movie
            {
                Id = 37,
                Title = "The Morning After Borlänge",
                Description = "After a wild celebration, Jonas, Felix, Minna, and Ida wake up in a wrecked hotel room with no memory of the night, a loose alpaca in the bathroom, and Dennis completely missing.",
                Genre = Genre.Comedy,
                IsExclusive = true,
                PlayTime = 108
            },
            new Movie
            {
                Id = 38,
                Title = "Jonas & Dennis: Master Chefs",
                Description = "Determined to win a Michelin star, Jonas and Dennis open a underground gourmet restaurant, serving raw instant noodles and calling it 'deconstructed fusion'.",
                Genre = Genre.Comedy,
                IsExclusive = false,
                PlayTime = 92
            },
            new Movie
            {
                Id = 39,
                Title = "Felix & Ida: Syntax Error",
                Description = "When an AI server room locks Felix and Ida inside on a Friday night, they must hack their way through ten levels of digital traps before the automated laser grid resets.",
                Genre = Genre.Action,
                IsExclusive = true,
                PlayTime = 114
            },
            new Movie
            {
                Id = 40,
                Title = "Minna vs. The Haunted Printer",
                Description = "When Minna buys a second-hand office printer that only prints cryptical warnings at 3 AM, she and Felix team up to perform an exorcism with an ethernet cable.",
                Genre = Genre.Horror,
                IsExclusive = false,
                PlayTime = 101
            },
            new Movie
            {
                Id = 41,
                Title = "The Great Exam Heist",
                Description = "Faced with an impossible final test, Dennis, Jonas, Felix, Minna, and Ida execute an overly complex, Mission Impossible-style heist just to extend the deadline by 24 hours.",
                Genre = Genre.Action,
                IsExclusive = false,
                PlayTime = 125
            },
            new Movie
            {
                Id = 42,
                Title = "The Sword of Dennis",
                Description = "When Dennis accidentally pulls an ancient glowing sword from a park bench, he and Jonas are thrust into a magical realm where Dennis is mistakingly crowned the High King.",
                Genre = Genre.Fantasy,
                IsExclusive = true,
                PlayTime = 138
            },
            new Movie
            {
                Id = 43,
                Title = "Minna & The Whispering Woods",
                Description = "Deep inside an enchanted forest, Minna discovers a hidden sanctuary of mythical creatures—and must teach them modern project management to save their realm from destruction.",
                Genre = Genre.Fantasy,
                IsExclusive = false,
                PlayTime = 126
            },
            new Movie
            {
                Id = 44,
                Title = "Ida, Felix & The Mana Core",
                Description = "In a floating city powered by magic, sorcerer Ida and alchemist Felix team up to stop a rogue guild from draining the city's power grid during finals week.",
                Genre = Genre.Fantasy,
                IsExclusive = false,
                PlayTime = 119
            },
            new Movie
            {
                Id = 45,
                Title = "Coffee, Code & Jonas",
                Description = "Jonas falls head over heels for a mysterious developer who keeps leaving flirty comments in his GitHub pull requests, leading to a hunt across the city to find her.",
                Genre = Genre.Romance,
                IsExclusive = false,
                PlayTime = 105
            },
            new Movie
            {
                Id = 46,
                Title = "Ida's Matchmaking Mishap",
                Description = "Self-proclaimed romance expert Ida tries to set up Dennis with his dream date, but her elaborate and chaotic schemes constantly pull Felix into the middle of the drama.",
                Genre = Genre.Romance,
                IsExclusive = true,
                PlayTime = 98
            },
            new Movie
            {
                Id = 47,
                Title = "Love in the Midnight Library",
                Description = "Trapped in the university library after hours during a heavy snowstorm, Minna and Jonas start off as rival study partners and end up discovering something much deeper.",
                Genre = Genre.Romance,
                IsExclusive = false,
                PlayTime = 112
            },
            new Movie
            {
                Id = 48,
                Title = "The Borlänge Identity",
                Description = "Waking up on a train with a bag full of cash and no memory, Felix must rely on frantic encrypted phone calls from Minna to outsmart a shadowy cartel following his every move.",
                Genre = Genre.Thriller,
                IsExclusive = true,
                PlayTime = 130
            },
            new Movie
            {
                Id = 49,
                Title = "Dennis Undercover",
                Description = "Mistaken for an infamous international art thief, Dennis gets recruited by intelligence agents, forcing Jonas and Ida to act as his handlers before his cover gets blown.",
                Genre = Genre.Thriller,
                IsExclusive = false,
                PlayTime = 122
            },
            new Movie
            {
                Id = 50,
                Title = "Zero Day Protocol",
                Description = "When Minna and Felix stumble upon a backdoor vulnerability in a mega-corporation's firewall, they trigger a deadly race against time to expose the conspiracy before they are erased.",
                Genre = Genre.Thriller,
                IsExclusive = true,
                PlayTime = 117
            }
        };
    }
}