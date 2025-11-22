using MauiPlanets.Models;


namespace MauiPlanets.Services
{
    internal class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest " +
                "in the Solar System. In English, it is named after the ancient Roman god " +
                "Mercurius (Mercury), god of commerce and communication, and the messenger " +
                "of the gods. Mercury is classified as a terrestrial planet, with roughly " +
                "the same surface gravity as Mars. The surface of Mercury is heavily " +
                "cratered, as a result of countless impact events that have accumulated " +
                "over billions of years.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/75_mercury_carousel_1.jpg"
                }
            },

            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is a terrestrial " +
                "planet and is the closest in mass and size to its orbital neighbour" +
                " Earth. Venus has by far the densest atmosphere of the terrestrial " +
                "planets, composed mostly of carbon dioxide with a thick, global " +
                "sulfuric acid cloud cover. At the surface it has a mean temperature " +
                "of 737 K (464 °C; 867 °F) and a pressure 92 times that of Earth's " +
                "at sea level.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },

            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life " +
                "exists. Almost 1.5 million species of animals and plants have been " +
                "discovered so far, and many more have yet to be found. While " +
                "other planets may have small amounts of ice or steam, the Earth " +
                "is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },

            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },

            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined, and slightly less than one-thousandth the mass of the " +
                "Sun. Its diameter is eleven times that of Earth, and a tenth " +
                "that of the Sun. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },

            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },

            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                            "It is named after Greek sky deity Uranus (Caelus), who in " +
                            "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                            "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                            "has the third-largest planetary radius and fourth-largest " +
                            "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },

            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                            "the farthest known planet in the Solar System. It is the " +
                            "fourth-largest planet in the Solar System by diameter, the " +
                            "third-most-massive planet, and the densest giant planet. " +
                            "It is 17 times the mass of Earth, and slightly more " +
                            "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },

            new()
            {
                Name = "Pluto",
                Subtitle ="Former Dwarf Planet",
                HeroImage = "pluto.png",
                Description = "Pluto is a dwarf planet in the Kuiper belt, a " +
                            "ring of bodies beyond Neptune. It was the first Kuiper " +
                            "belt object to be discovered and is the largest known " +
                            "plutino (objects in a 2:3 resonance with Neptune). " +
                            "Pluto was discovered by Clyde Tombaugh in 1930 and was " +
                            "considered the ninth planet from the Sun until 2006, " +
                            "when it was reclassified as a dwarf planet by the " +
                            "International Astronomical Union.",
                AccentColorStart = Color.FromArgb("#4e4e4e"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://www.pngmart.com/files/22/Pluto-Planet-PNG-Pic.png",
                    "https://www.pngmart.com/files/22/Pluto-Planet-PNG.png",
                },

            },

            new()
                {
                    Name = "Ceres",
                    Subtitle = "The largest asteroid",
                    HeroImage = "ceres.png",
                    Description = "Ceres is the largest object in the asteroid belt " +
                                "between Mars and Jupiter. With a diameter of about 940 km, " +
                                "it is the only dwarf planet located in the inner solar system. " +
                                "Ceres is composed of a mixture of water ice and various hydrated " +
                                "minerals such as carbonates and clay. It contains approximately " +
                                "25% water by mass, much more than any other asteroid.",
                    AccentColorStart = Color.FromArgb("#7a7a7a"),
                    AccentColorEnd = Color.FromArgb("#b0b0b0"),
                    Images = new()
                    {
                        "https://images.newscientist.com/wp-content/uploads/2020/08/10143522/10-aug_ceres-ocean.jpg?width=837",
                        "https://news.berkeley.edu/wp-content/uploads/2020/08/Ceres_Occator_final-750px.jpg",
                    }
            },

            new()
            {
                Name = "Haumea",
                Subtitle = "The fast rotator",
                HeroImage = "haumea.png",
                Description = "Haumea is a dwarf planet located beyond Neptune's orbit. " +
                            "It was discovered in 2004 by a team at the Sierra Nevada Observatory " +
                            "in Spain, and its name comes from the Hawaiian goddess of fertility " +
                            "and childbirth. Haumea is one of the fastest rotating large objects " +
                            "in the solar system, completing a full rotation in just under four hours.",
                AccentColorStart = Color.FromArgb("#7a7a7a"),
                AccentColorEnd = Color.FromArgb("#b0b0b0"),
                Images = new()
                {
                    "https://media.istockphoto.com/id/953189348/photo/haumea-dwarf-planet.jpg?s=1024x1024&w=is&k=20&c=J_bi6JuFVuQDryR__Kvdi3JBaDwIo-lLaZT7DL_bA9c=",
                    "https://media.istockphoto.com/id/1178503587/photo/dwarf-planet-haumea.jpg?s=1024x1024&w=is&k=20&c=KzFUY6ISpdlTCJnlBuPIUj85iiZBETZ43FCQQCfh8AQ=",
                }
            },

            new()
            {
                Name = "Makemake",
                Subtitle = "The bright one",
                HeroImage = "makemake.png",
                Description = "Makemake is a dwarf planet located in the Kuiper belt, " +
                            "a region of the solar system beyond Neptune that is populated by " +
                            "small icy bodies. It was discovered in 2005 by a team led by " +
                            "Michael E. Brown at the Palomar Observatory in California. " +
                            "Makemake is named after the creator deity of the Rapa Nui people " +
                            "of Easter Island.",
                AccentColorStart = Color.FromArgb("#7a7a7a"),
                AccentColorEnd = Color.FromArgb("#b0b0b0"),
                Images = new()
                {
                    "https://astronz.nz/cdn/shop/articles/makemake.png?v=1682129134",
                    "https://cdn.eso.org/images/newsfeature/eso1246a.jpg",
                }

            },

            new()
            {
                Name = "Eris",
                Subtitle = "The scattered disc object",
                HeroImage = "eris.png",
                Description = "Eris is a dwarf planet located in the scattered disc, " +
                            "a distant region of the solar system that is populated by small icy bodies. " +
                            "It was discovered in 2005 by a team led by Michael E. Brown at the Palomar " +
                            "Observatory in California. Eris is named after the Greek goddess of strife and discord.",
                AccentColorStart = Color.FromArgb("#7a7a7a"),
                AccentColorEnd = Color.FromArgb("#b0b0b0"),
                Images = new()
                {
                    "https://media.istockphoto.com/id/1044815536/photo/eris-dwarf-planet-rotating-in-its-own-orbit-in-the-outer-space-3d-rendering.jpg?s=1024x1024&w=is&k=20&c=o79le10-Hnaqcj4KeFoIf3GkUQG0SMdYRDx9aiEeDOQ=",
                    "https://images-assets.nasa.gov/image/PIA03034/PIA03034~orig.jpg?w=603&h=200&fit=crop&crop=faces%2Cfocalpoint",
                }
            },
        };


        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
