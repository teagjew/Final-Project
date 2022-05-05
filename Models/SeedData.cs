using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Collections.Generic;

namespace Final_Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var db = new ProductContext(serviceProvider.GetRequiredService<DbContextOptions<ProductContext>>()))
            {
                if (db.Product.Any())
                {
                    return;
                }

                db.Product.AddRange(
                    new Product
                    {
                        Name = "Double Wear Foundation",
                        Price = 46.00,
                        Type = "Foundation",
                        Brand = "Estee Lauder",
                        Reviews = new List<Review> {
                            new Review {Comment = "Great product. I wear it everyday.", 
                                            CustomerName = "Michelle Smith",
                                            Date = DateTime.Parse("2021-02-12")}
                        }
                    },

                    new Product
                    {
                        Name = "Pro Filt'r Soft Matte Longwear Liquid Foundation",
                        Price = 38.00,
                        Type = "Foundation",
                        Brand = "Fenty"
                    },

                    new Product
                    {
                        Name = "Face Tape Foundation",
                        Price = 40.00,
                        Type = "Foundation",
                        Brand = "Tarte",
                        Reviews = new List<Review> {
                            new Review {Comment = "A litte bit cakey. Super thick formula.", 
                                            CustomerName = "Denise Clark",
                                            Date = DateTime.Parse("2021-04-18")}
                        }
                    },

                    new Product
                    {
                        Name = "Good Apple Skin-Perfecting Hydrating Foundation Balm",
                        Price = 40.50,
                        Type = "Foundation",
                        Brand = "KVD Beauty",
                        Reviews = new List<Review> {
                            new Review {Comment = "Good coverage, but kind of hard to find a good color match.", 
                                            CustomerName = "Karen Cooly",
                                            Date = DateTime.Parse("2021-09-04")},
                            new Review {Comment = "My favorite foundation ever.", 
                                            CustomerName = "Amanda Trout",
                                            Date = DateTime.Parse("2021-02-28")}
                        }
                    },

                    new Product
                    {
                        Name = "Morphe 2 Hint Skin Tint",
                        Price = 18.00,
                        Type = "Foundation",
                        Brand = "Morphe",
                        Reviews = new List<Review> {
                            new Review {Comment = "Great product at a super affordable price.", 
                                            CustomerName = "Dani Mann",
                                            Date = DateTime.Parse("2021-07-09")}
                        }
                    },

                    new Product
                    {
                        Name = "On Your Collar Plumping Lip Gloss",
                        Price = 17.00,
                        Type = "Lips",
                        Brand = "R.E.M. Beauty",
                        Reviews = new List<Review> {
                            new Review {Comment = "My new favorite lip gloss!", 
                                            CustomerName = "Ariana Miller",
                                            Date = DateTime.Parse("2022-01-27")},
                            new Review {Comment = "Super tingly.", 
                                            CustomerName = "Marissa Pacheco",
                                            Date = DateTime.Parse("2021-08-21")}
                        }
                    },

                    new Product
                    {
                        Name = "Gloss Bomb Universal Lip Luminizer",
                        Price = 20.00,
                        Type = "Lips",
                        Brand = "Fenty"
                    },

                    new Product
                    {
                        Name = "Matte Liquid Lipstick",
                        Price = 17.00,
                        Type = "Lips",
                        Brand = "Kylie Cosmetics",
                        Reviews = new List<Review> {
                            new Review {Comment = "A little bit drying, but super cute.", 
                                            CustomerName = "Emily Hernandez",
                                            Date = DateTime.Parse("2022-04-27")},
                            new Review {Comment = "Very long lasting.", 
                                            CustomerName = "Valeria Collins",
                                            Date = DateTime.Parse("2021-08-01")}
                        }
                    },

                    new Product
                    {
                        Name = "Everlasting Liquid Lipstick",
                        Price = 21.00,
                        Type = "Lips",
                        Brand = "KVD Beauty"
                    },

                    new Product
                    {
                        Name = "Maracuja Juicy Lip Plump",
                        Price = 21.00,
                        Type = "Lips",
                        Brand = "Tarte",
                        Reviews = new List<Review> {
                            new Review {Comment = "Not worth the money. Wouldn't buy again.", 
                                            CustomerName = "Victoria Nunez",
                                            Date = DateTime.Parse("2020-12-07")}
                        }
                    },

                    new Product
                    {
                        Name = "Midnight Shadows Eyeshadow Palette",
                        Price = 24.00,
                        Type = "Eyes",
                        Brand = "R.E.M. Beauty",
                        Reviews = new List<Review> {
                            new Review {Comment = "Super pigmented.", 
                                            CustomerName = "Angie Garcia",
                                            Date = DateTime.Parse("2021-11-03")},
                            new Review {Comment = "Loving the neutral shades.", 
                                            CustomerName = "Brooke Scott",
                                            Date = DateTime.Parse("2021-02-14")}
                        }
                    },

                    new Product
                    {
                        Name = "Sweet Peach Eyeshadow Palette",
                        Price = 49.00,
                        Type = "Eyes",
                        Brand = "Too Faced"
                    },

                    new Product
                    {
                        Name = "Maneater Mascara",
                        Price = 24.00,
                        Type = "Eyes",
                        Brand = "Tarte",
                        Reviews = new List<Review> {
                            new Review {Comment = "Super volumizing. Gives a falsies look.", 
                                            CustomerName = "Tara Teller",
                                            Date = DateTime.Parse("2020-01-30")}
                        }
                    },

                    new Product
                    {
                        Name = "35XO Natural Flirt Artistry Palette",
                        Price = 26.00,
                        Type = "Eyes",
                        Brand = "Morphe",
                        Reviews = new List<Review> {
                            new Review {Comment = "So many different colors than other palettes for a lot cheaper.", 
                                            CustomerName = "Laura David",
                                            Date = DateTime.Parse("2021-06-21")}
                        }
                    },

                    new Product
                    {
                        Name = "Bright Fix Eye Brightner",
                        Price = 26.00,
                        Type = "Eyes",
                        Brand = "Fenty"
                    },

                    new Product
                    {
                        Name = "Tattoo Liner",
                        Price = 23.00,
                        Type = "Eyes",
                        Brand = "KVD Beauty",
                        Reviews = new List<Review> {
                            new Review {Comment = "This eyeliner stays on forever!", 
                                            CustomerName = "Jenny Marcs",
                                            Date = DateTime.Parse("2022-02-21")}
                        }
                    },

                    new Product
                    {
                        Name = "Pressed Powder Blush",
                        Price = 18.00,
                        Type = "Blush",
                        Brand = "Kylie Cosmetics",
                        Reviews = new List<Review> {
                            new Review {Comment = "Perfect blush for everyday use.", 
                                            CustomerName = "Cameron Moore",
                                            Date = DateTime.Parse("2019-12-12")}
                        }
                    },

                    new Product
                    {
                        Name = "Super Shock Blush",
                        Price = 8.00,
                        Type = "Blush",
                        Brand = "Colourpop",
                        Reviews = new List<Review> {
                            new Review {Comment = "Amazing product. Way cheaper, but same quality.", 
                                            CustomerName = "Nicole Ramone",
                                            Date = DateTime.Parse("2021-04-15")},
                            new Review {Comment = "Best blush ever!", 
                                            CustomerName = "Lindsey Becks",
                                            Date = DateTime.Parse("2020-06-25")}
                        }
                    },

                    new Product
                    {
                        Name = "Eclipse Cheek & Lip Stick",
                        Price = 18.00,
                        Type = "Blush",
                        Brand = "R.E.M. Beauty"
                    },

                    new Product
                    {
                        Name = "Cheeks Out Freestyle Cream Bronzer",
                        Price = 34.00,
                        Type = "Bronzer",
                        Brand = "Fenty",
                        Reviews = new List<Review> {
                            new Review {Comment = "Expensive, but worth it.", 
                                            CustomerName = "Robin Swisher",
                                            Date = DateTime.Parse("2020-09-10")}
                        }
                    },

                    new Product
                    {
                        Name = "Amazonian Clay Matte Waterproof Bronzer",
                        Price = 30.00,
                        Type = "Bronzer",
                        Brand = "Tarte",
                        Reviews = new List<Review> {
                            new Review {Comment = "Really is waterproof.", 
                                            CustomerName = "Megan Rogers",
                                            Date = DateTime.Parse("2021-10-11")}
                        }
                    },

                    new Product
                    {
                        Name = "Diamond Bomb All-Over Diamond Veil",
                        Price = 40.00,
                        Type = "Highlighter",
                        Brand = "Fenty",
                        Reviews = new List<Review> {
                            new Review {Comment = "Amazing! Super pigmented.", 
                                            CustomerName = "Alyssa Garrett",
                                            Date = DateTime.Parse("2021-06-27")}
                        }
                    },

                    new Product
                    {
                        Name = "Super Shock Highlighter",
                        Price = 8.00,
                        Type = "Highlighter",
                        Brand = "Colourpop",
                        Reviews = new List<Review> {
                            new Review {Comment = "Favorite highlighter of all time.", 
                                            CustomerName = "Rebecca Hall",
                                            Date = DateTime.Parse("2021-04-17")}
                        }
                    },

                    new Product
                    {
                        Name = "Interstellar Highlighter Topper",
                        Price = 22.00,
                        Type = "Highlighter",
                        Brand = "R.E.M. Beauty"
                    },

                    new Product
                    {
                        Name = "All Nighter Face Makeup Primer",
                        Price = 36.00,
                        Type = "Primer",
                        Brand = "Urban Decay",
                        Reviews = new List<Review> {
                            new Review {Comment = "Best primer there is. My makeup stays on all night.", 
                                            CustomerName = "Hannah Thomas",
                                            Date = DateTime.Parse("2021-07-04")}
                        }
                    },

                    new Product
                    {
                        Name = "Hangover Replenishing Face Primer",
                        Price = 36.00,
                        Type = "Primer",
                        Brand = "Too Faced",
                        Reviews = new List<Review> {
                            new Review {Comment = "Okay primer. I've had better.", 
                                            CustomerName = "Blair Woodard",
                                            Date = DateTime.Parse("2021-01-21")}
                        }
                    },

                    new Product
                    {
                        Name = "Pro Filt'r Hydrating Primer",
                        Price = 34.00,
                        Type = "Primer",
                        Brand = "Fenty"
                    }
                );
                db.SaveChanges();
            }
        }
    }
}