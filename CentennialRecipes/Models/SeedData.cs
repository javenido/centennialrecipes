using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentennialRecipes.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

            context.Database.Migrate();

            // add chefs
            EnsureChefsAdded(context);

            // add recipes
            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange
                (
                    new Recipe
                    {
                        Name = "Rhubarb Crumble",
                        User = "avenido",
                        Description = "Rhubarb is a quintessentially Canadian ingredient. It’s popular in sweet dishes, since its tangy, slightly bitter flavour helps to round out and balance sweeter flavours. It’s hearty and grows both easily and quickly. I know at least a few people who’ve found wild rhubarb patches. Did you know that some people say you can actually hear it grow?",
                        Chef = context.Chefs.First(c => c.ToString() == "Gordon Ramsay"),
                        PreparationTime = "25 minutes",
                        Ingredients = "4 stalks rhubarb, cut into 2 cm pieces 400 g;" +
                            "3/4 cup rolled oats 80 g;" +
                            "1 1/4 cup white flour (all purpose) 150 g;" +
                            "2/3 cup butter, unsalted 150 g;" +
                            "1/2 cup sugar 110 g;" +
                            "2/3 cup brown sugar 140 g;" +
                            "3 tbsp lemon juice, freshly squeezed 1 lemon;" +
                            "8 scoops vanilla ice cream [optional] 500 mL",
                        Reviews = new List<RecipeReview>
                        {
                            new RecipeReview
                            {
                                User = "Admin",
                                Content = "https://www.soscuisine.com/recipe/rhubarb-crumble",
                                DateAdded = DateTime.Now
                            }
                        }
                    },

                    new Recipe
                    {
                        Name = "Split Pea Soup",
                        User = "pacleb",
                        Description = "Quebec-style split pea soup really is quite different than the varieties most areas might be familiar with. For one thing, it uses yellow peas. For another, it’s much heartier than a typical pea soup, since it’s made with lard and chunks of pork belly. Our version is much lighter, but every bit as delicious!",
                        Chef = context.Chefs.First(c => c.ToString() == "Heston Blumenthal"),
                        PreparationTime = "15 minutes",
                        Ingredients = "1 1/2 cup green split peas (dried), rinsed and drained 300 g;" +
                            "1 onions, finely chopped 200 g;" +
                            "1	leeks, finely chopped 300 g;" +
                            "1	carrots, finely chopped 100 g;" +
                            "1 stalk celery, finely chopped 70 g;" +
                            "2 cloves garlic, minced or pressed;" +
                            "2 tbsp	olive oil 30 mL;" +
                            "1 tsp	dried savory 1 g;" +
                            "2 bay leaf 0.4 g;" +
                            "4 cups	chicken broth 1 L;" +
                            "2 cups	water 500 mL;" +
                            "1 pinch salt [optional] 0.2 g;" +
                            "ground pepper to taste [optional]",
                        Reviews = new List<RecipeReview>
                        {
                            new RecipeReview
                            {
                                User = "Admin",
                                Content = "https://www.soscuisine.com/recipe/split-pea-soup",
                                DateAdded = DateTime.Now
                            }
                        }
                    },

                    new Recipe
                    {
                        Name = "Slow Cooker Ham",
                        User = "torceno",
                        Description = "Ham is an all-the-time food here in Canada, though it’s especially a feature of holiday meals. Generally glazed in something sweet, our version is extra Canadian, with maple syrup and beer. Every Canadian pretty much loves those two things. All that’s missing from this dish is a hockey game to watch on TV.",
                        Chef = context.Chefs.First(c => c.ToString() == "Thomas Keller"),
                        PreparationTime = "10 minutes",
                        Ingredients = "1.4 kg smoked ham (whole), toupie or picnic type, rind removed;" +
                            "1 tbsp	mustard powder 7 g;" +
                            "1 1/3 cup beer, lager 330 mL;" +
                            "1/2 cup maple syrup 125 mL;" +
                            "ground pepper to taste [optional]",
                        Reviews = new List<RecipeReview>
                        {
                            new RecipeReview
                            {
                                User = "Admin",
                                Content = "https://www.soscuisine.com/recipe/ham-beer-maple-syrup-slow-cooker",
                                DateAdded = DateTime.Now
                            },
                            new RecipeReview
                            {
                                User = "avenido",
                                Content = "Perfect for Thanksgiving! Thanks for sharing :)",
                                DateAdded = DateTime.Now
                            }
                        }
                    },

                    new Recipe
                    {
                        Name = "Lobster Roll",
                        User = "pacleb",
                        Description = "While lobster rolls are usually associated more with New England, they’re also popular in the maritime provinces. Newfoundland, PEI, New Brunswick, and Nova Scotia all have very interesting cuisines and unique dishes not found in other parts of Canada. Figgy duff and boiled dinners are also really popular. But, it’s Canada’s birthday! Why not indulge with a little lobster?",
                        Chef = context.Chefs.First(c => c.ToString() == "Alain Ducasse"),
                        PreparationTime = "10 minutes",
                        Ingredients = "2 lobsters, or cooked 1 kg;" +
                            "4 tsp lemon juice, freshly squeezed 1/2 lemon;" +
                            "4 tsp mayonnaise 18 g;" +
                            "2 tsp ketchup 10 g;" +
                            "1/2 stalk	celery, thinly sliced 35 g;" +
                            "1 radishes, thinly sliced 16 g;" +
                            "2 panino rolls, ciabatta type 200 g;" +
                            "1/4 cup mixed greens 7 g;" +
                            "1 pinch salt [optional] 0.2 g;" +
                            "ground pepper to taste [optional]",
                        Reviews = new List<RecipeReview>
                        {
                            new RecipeReview
                            {
                                User = "Admin",
                                Content = "https://www.soscuisine.com/recipe/lobster-roll",
                                DateAdded = DateTime.Now
                            }
                        }
                    },

                    new Recipe
                    {
                        Name = "Apple Pie",
                        User = "torceno",
                        Description = "As Canadian as apple pie! That’s what the saying ought to be. If you’ve ever met a Canadian, you know that we’re always very proud of our nation. We’re even prouder when we can take credit for something that our friends south of border seem to think they came up with (Thanksgiving, basketball…). Apple pie is just such a dish, that actually has its origins in the great white North!",
                        Chef = context.Chefs.First(c => c.ToString() == "Jamie Oliver"),
                        PreparationTime = "30 minutes",
                        Ingredients = "2 batches of my one minute homemade pie crust (or 1 if you roll it out very thinly!);" +
                            "7-8 small granny smith apples, peeled, sliced, and cored;" +
                            "1 stick butter;" +
                            "3 tbsp all-purpose flour;" +
                            "1/4 cup water;" +
                            "1/2 cup white sugar;" +
                            "1/2 cup brown sugar;" +
                            "1 heaping tsp cinnamon;" +
                            "1/4 tsp nutmeg;" +
                            "1 tsp vanilla",
                        Reviews = new List<RecipeReview>
                        {
                            new RecipeReview
                            {
                                User = "Admin",
                                Content = "https://audreysapron.wordpress.com/2013/12/20/the-best-apple-pie-ever/",
                                DateAdded = DateTime.Now
                            },
                            new RecipeReview
                            {
                                User = "avenido",
                                Content = "Decent dish. 6/10",
                                DateAdded = DateTime.Now
                            }
                        }
                    },

                    new Recipe
                    {
                        Name = "Philippine Adobo",
                        User = "pacleb",
                        Description = "Philippine Adobo (from Spanish adobar: \"marinade,\" \"sauce\" or \"seasoning\") is a popular Filipino dish and cooking process in Philippine cuisine that involves meat, seafood, or vegetables marinated in vinegar, soy sauce, garlic, and black peppercorns, which is browned in oil, and simmered in the marinade. It has occasionally been considered the unofficial national dish in the Philippines.",
                        Chef = context.Chefs.First(c => c.ToString() == "Boy Logro"),
                        PreparationTime = "10 minutes",
                        Ingredients = "1 cup white vinegar;" +
                            "1/4 cup soy sauce;" +
                            "1 whole garlic bulb, smashed and peeled;" +
                            "2 teaspoons kosher salt;" +
                            "1 teaspoon coarsely ground pepper;" +
                            "1 bay leaf;" +
                            "2 pounds bone-in chicken thighs or drumsticks;" +
                            "1 tablespoon canola oil;" +
                            "1 cup water;"
                    },

                    new Recipe
                    {
                        Name = "Banana Fritters",
                        User = "torceno",
                        Description = "These Banana Fritters are perfect for when you need to satisfy a sweet craving. Golden brown and completely delicious, they’re yummy to the very last bite!",
                        Chef = context.Chefs.First(c => c.ToString() == "Boy Logro"),
                        PreparationTime = "10 minutes",
                        Ingredients = "½ cup milk;" +
                            "2 medium (7\" to 7 - 7 / 8\" long)s bananas, mashed;" +
                            "2 cups all-purpose flour;" +
                            "½ teaspoon salt;" +
                            "3 teaspoons baking powder;" +
                            "2 large eggs eggs, beaten;" +
                            "1 tablespoon margarine, melted;" +
                            "1 quart vegetable oil for frying;" +
                            "½ cup confectioners' sugar;",
                        Reviews = new List<RecipeReview> {
                            new RecipeReview {
                                User = "avenido",
                                Content = "These great little fritters are a breakfast favourite.",
                                DateAdded = DateTime.Now
                            }
                        }
                    },

                    new Recipe
                    {
                        Name = "Beef Bulalo",
                        User = "pacleb",
                        Description = "Bulalô is a beef dish from the Philippines. It is a light colored soup that is made by cooking beef shanks and bone marrow until the collagen and fat has melted into the clear broth. It typically includes leafy vegetables (like pechay or cabbage), corn on the cob, scallions, onions, garlic, ginger, and fish sauce. Potatoes, carrots, or taro can also be added. It is commonly eaten on rice with soy sauce and calamansi on the side. Bulalo is native to the Southern Luzon region of the Philippines, particularly in the provinces of Batangas and Cavite.",
                        Chef = context.Chefs.First(c => c.ToString() == "Boy Logro"),
                        PreparationTime = "10 minutes",
                        Ingredients = "2 lbs beef shank;" +
                            "½ pc small cabbage whole leaf individually detached;" +
                            "1 small bundle Pechay;" +
                            "3 pcs Corn each cut into 3 parts;" +
                            "2 tbsp Whole pepper corn;" +
                            "1/2 cup Green onions;" +
                            "1 medium sized onion;" +
                            "34 ounces water;" +
                            "2 tbsp fish sauce optional;",
                        Reviews = new List<RecipeReview> {
                            new RecipeReview {
                                User = "torceno",
                                Content = "I like to have bulalo during cold days. Sipping the soup alone makes me feel comfortable. This bulalo recipe that we have here is my favorite because it is the simplest yet it produces an excellent dish.",
                                DateAdded = DateTime.Now
                            }
                        }
                    },

                    new Recipe
                    {
                        Name = "Lumpiang Sariwa",
                        User = "avenido",
                        Description = "Have you tried making your own Lumpiang Sariwa with Fresh Lumpia Wrapper from scratch? If not, chances are that you got intimidated with the procedure, or you have limited information on how to make one. If you are one of those who are trying to learn how to make this dish and need more in-depth information, this post and the detailed video below should be able to help.",
                        Chef = context.Chefs.First(c => c.ToString() == "Boy Logro"),
                        PreparationTime = "30 minutes",
                        Ingredients = "6 to 8 pieces Romaine lettuce;" +
                            "1/2 cup crushed peanuts;" +
                            "1/4 cup chopped parsley;" +
                            "10 ounces extra firm tofu fried and cubed;" +
                            "1/2 cup small shrimp shell removed;" +
                            "1 piece Knorr Shrimp Cube;" +
                            "1/2 head cabbage chopped;" +
                            "3/4 cup green beans sliced crosswise;" +
                            "1 piece medium carrot julienne;" +
                            "1 cup sweet potato cubed;" +
                            "3 tablespoons parsley chopped;" +
                            "1 piece white onion chopped;" +
                            "2 cloves garlic minced;" +
                            "2 tablespoons fish sauce;" +
                            "1/2 cup water;" +
                            "1/8 teaspoon ground black pepper;" +
                            "3 tablespoons cooking oil;" +
                            "1 cup all-purpose flour;" +
                            "2 pieces eggs;" +
                            "2 tablespoons canola oil;" +
                            "1 1/2 cups water;" +
                            "1/4 cup cooking oil or cooking oil spray;" +
                            "6 tablespoons brown sugar;" +
                            "1 1/2 tablespoons soy sauce;" +
                            "1 1/2 cups water;" +
                            "1 tablespoon garlic minced;" +
                            "1 tablespoon cornstarch;"
                    }
                );
            }

            // save changes
            if (context.ChangeTracker.HasChanges())
                context.SaveChanges();
        }

        private static void EnsureChefsAdded(ApplicationDbContext context)
        {
            if (!context.Chefs.Any())
            {
                context.Chefs.Add(new Chef { FirstName = "unknown", LastName = "", Description = "" });
            }

            if (!context.Chefs.Any(c => c.ToString() == "Gordon Ramsay"))
            {
                context.Chefs.Add(new Chef
                {
                    FirstName = "Gordon",
                    LastName = "Ramsay",
                    Description = "Internationally renowned, multi-Michelin starred chef Gordon Ramsay has opened a string of successful restaurants across the globe, from the UK and France to Singapore and Hong Kong, to the United States. Gordon has also become a star of the small screen both in the UK and internationally, with shows such as Kitchen Nightmares, Hell’s Kitchen, Hotel Hell and MasterChef US.",
                    Specialty = Cuisine.British,
                    Website = "https://www.gordonramsay.com/",
                    Restaurant = "Restaurant Gordon Ramsay"
                });
            }

            if (!context.Chefs.Any(c => c.ToString() == "Heston Blumenthal"))
            {
                context.Chefs.Add(new Chef
                {
                    FirstName = "Heston",
                    LastName = "Blumenthal",
                    Description = "Heston Marc Blumenthal is a British celebrity chef. He is the proprietor of The Fat Duck in Bray, Berkshire, one of five restaurants in Great Britain to have three Michelin stars; it was voted No. 1 in The World's 50 Best Restaurants in 2005.",
                    Specialty = Cuisine.British,
                    Website = "http://thefatduck.co.uk/",
                    Restaurant = "The Fat Duck Restaurant"
                });
            }

            if (!context.Chefs.Any(c => c.ToString() == "Thomas Keller"))
            {
                context.Chefs.Add(new Chef
                {
                    FirstName = "Thomas",
                    LastName = "Keller",
                    Description = "Thomas Keller is an American chef, restaurateur, and cookbook writer. He and his landmark Napa Valley restaurant, The French Laundry in Yountville, California, have won multiple awards from the James Beard Foundation, notably the Best California Chef in 1996, and the Best Chef in America in 1997. The restaurant is a perennial winner in the annual Restaurant Magazine list of the Top 50 Restaurants of the World.",
                    Specialty = Cuisine.American,
                    Website = "https://www.thomaskeller.com/",
                    Restaurant = "The French Laundry"
                });
            }

            if (!context.Chefs.Any(c => c.ToString() == "Alain Ducasse"))
            {
                context.Chefs.Add(new Chef
                {
                    FirstName = "Alain",
                    LastName = "Ducasse",
                    Description = "Alain Ducasse is a French-born Monégasque chef. He operates a number of restaurants including Alain Ducasse at The Dorchester which holds three stars (the top ranking) in the Michelin Guide.",
                    Specialty = Cuisine.French,
                    Website = "http://www.alain-ducasse.com/",
                    Restaurant = "DUCASSE Restaurant"
                });
            }

            if (!context.Chefs.Any(c => c.ToString() == "Jamie Oliver"))
            {
                context.Chefs.Add(new Chef
                {
                    FirstName = "Jamie",
                    LastName = "Oliver",
                    Description = "Jamie Trevor Oliver is a British chef and restaurateur. He is known for his approachable cuisine, which has led him to front numerous television shows and open many restaurants.",
                    Specialty = Cuisine.British,
                    Website = "https://www.jamieoliver.com",
                    Restaurant = ""
                });
            }

            if (!context.Chefs.Any(c => c.ToString() == "Boy Logro"))
            {
                context.Chefs.Add(new Chef
                {
                    FirstName = "Boy",
                    LastName = "Logro",
                    Description = "Pablo Logro, also known as Boy Logro or Chef Boy, is a Filipino celebrity chef known for his cooking shows, Idol sa Kusina and Chef Boy Logro: Kusina Master.",
                    Specialty = Cuisine.Filipino,
                    Website = "https://www.kusinamasterrecipes.com/tag/chef-boy-logro-recipes/",
                    Restaurant = "Paluto Restaurant"
                });
            }

            if (!context.Chefs.Any(c => c.ToString() == "Mark McEwan"))
            {
                context.Chefs.Add(new Chef
                {
                    FirstName = "Mark",
                    LastName = "McEwan",
                    Description = "Mark McEwan is a Canadian celebrity chef based in Toronto. He had his own television show on Food Network Canada entitled The Heat, which followed his catering team from North 44 Caters as they served the influential and elite. He was also head judge on Food Network Canada's Top Chef Canada.",
                    Specialty = Cuisine.Canadian,
                    Website = "https://mcewangroup.ca",
                    Restaurant = "Fabbrica Don Mills"
                });
            }

            if (!context.Chefs.Any(c => c.ToString() == "Michel Roux Jr."))
            {
                context.Chefs.Add(new Chef
                {
                    FirstName = "Michel",
                    LastName = "Roux Jr.",
                    Description = "Michel Albert Roux, known as Michel Roux Jr., is an English two-star Michelin chef at the London restaurant Le Gavroche. Roux was born at Pembury maternity hospital in Kent, whilst his father Albert Roux was working for the horse race trainer Major Peter Cazalet.",
                    Specialty = Cuisine.British,
                    Website = "http://www.michelroux.co.uk/",
                    Restaurant = "Le Gavroche"
                });
            }

            if (context.ChangeTracker.HasChanges())
                context.SaveChanges();
        }
    }
}