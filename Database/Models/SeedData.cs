using Database;
using AAMRecetteAPI.Models;

namespace AAMRecetteAPI.Data;

public static class SeedData
{
    public static void Initialize(AAMRecetteAPIContext context)
    {
        context.Database.EnsureCreated();

        if (context.Categories.Any())
        {
            return;
        }
        if (context.Ingredients.Any())
        {
            return;
        }
        if (context.Recipes.Any())
        {
            return;
        }


        var pizzaCategory = new Category
        {
            Name = "Cookies",
            Photo_url = "https://www.telegraph.co.uk/content/dam/Travel/2019/January/france-food.jpg?imwidth=1400"
        };

        var mexicanCategory = new Category
        {
            Name = "Mexican Food",
            Photo_url = "https://ak1.picdn.net/shutterstock/videos/19498861/thumb/1.jpg"
        };

        var italianCategory = new Category
        {
            Name = "Italian Food",
            Photo_url = "https://images.unsplash.com/photo-1533777324565-a040eb52facd?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80"
        };

        var cookiesCategory = new Category
        {
            Name = "Cookies",
            Photo_url = "https://www.telegraph.co.uk/content/dam/Travel/2019/January/france-food.jpg?imwidth=1400"
        };

        var smoothiesCategory = new Category
        {
            Name = "Smoothies",
            Photo_url = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/still-life-of-three-fresh-smoothies-in-front-of-royalty-free-image-561093647-1544042068.jpg?crop=0.715xw:0.534xh;0.0945xw,0.451xh&resize=768:*"
        };

        context.Categories.AddRange(pizzaCategory, mexicanCategory, italianCategory, cookiesCategory, smoothiesCategory);






        var oil = new Ingredient
        {
            Name = "Oil",
            Photo_url = "https://ak7.picdn.net/shutterstock/videos/27252067/thumb/11.jpg"
        };
        var salt = new Ingredient
        {
            Name = "Salt",
            Photo_url = "https://image.freepik.com/free-photo/sea-salt-wooden-bowl-isolated-white-background_29402-416.jpg"
        };
        var russetPotatoes = new Ingredient
        {
            Name = "Russet potatoes",
            Photo_url = "http://www.valleyspuds.com/wp-content/uploads/Russet-Potatoes-cut.jpg"
        };
        var paprika = new Ingredient
        {
            Name = "Paprika",
            Photo_url = "https://image.freepik.com/free-photo/red-chilli-pepper-powder-isolated-white-background_55610-28.jpg"
        };
        var blackPepper = new Ingredient
        {
            Name = "Black Pepper",
            Photo_url = "https://ak0.picdn.net/shutterstock/videos/26741680/thumb/1.jpg"
        };
        var driedSage = new Ingredient
        {
            Name = "Dried sage",
            Photo_url = "https://d2v9y0dukr6mq2.cloudfront.net/video/thumbnail/Esxjvv7/super-slow-motion-dried-sage-falling-on-white-background_n1xg2gxzg__F0000.png"
        };
        var garlicPowder = new Ingredient
        {
            Name = "Garlic powder",
            Photo_url = "https://us.123rf.com/450wm/belchonock/belchonock1808/belchonock180818180/106007144-bowl-of-dry-garlic-powder-on-white-background.jpg?ver=6"
        };
        var groundAllspice = new Ingredient
        {
            Name = "Ground allspice",
            Photo_url = "https://www.savoryspiceshop.com/content/mercury_modules/cart/items/2/6/9/2695/allspice-berries-jamaican-ground-1.jpg"
        };
        var driedOregano = new Ingredient
        {
            Name = "Dried oregano",
            Photo_url = "https://frutascharito.es/886-large_default/oregano.jpg"
        };
        var driedBasil = new Ingredient
        {
            Name = "Dried basil",
            Photo_url = "https://www.honeychop.com/wp-content/uploads/2015/09/Dried-Mint.png"
        };
        var driedMarjoram = new Ingredient
        {
            Name = "Dried marjoram",
            Photo_url = "https://images-na.ssl-images-amazon.com/images/I/71YATIBqBYL._SX355_.jpg"
        };
        var allPurposeFlour = new Ingredient
        {
            Name = "All-purpose flour",
            Photo_url = "https://images.assetsdelivery.com/compings_v2/seregam/seregam1309/seregam130900036.jpg"
        };
        var brownSugar = new Ingredient
        {
            Name = "Brown sugar",
            Photo_url = "https://d2v9y0dukr6mq2.cloudfront.net/video/thumbnail/BALQTtekliuc6iu4u/rotating-brown-sugar-in-a-white-container-on-white-background_sis0xtbyl_thumbnail-full01.png"
        };
        var kosherSalt = new Ingredient
        {
            Name = "Kosher salt",
            Photo_url = "https://d1yn1kh78jj1rr.cloudfront.net/image/preview/r64-6MxPQjlatyfjp/storyblocks-top-view-of-ceramic-salt-cellar-with-coarse-grained-sea-salt-isolated-on-white-background_SPzKionPuV_SB_PM.jpg"
        };
        var wholeChicken = new Ingredient
        {
            Name = "Whole chicken",
            Photo_url = "https://image.shutterstock.com/image-photo/two-raw-chicken-drumsticks-isolated-260nw-632125991.jpg"
        };
        var eggs = new Ingredient
        {
            Name = "Eggs",
            Photo_url = "https://image.shutterstock.com/image-photo/egg-whites-yolk-cup-isolated-260nw-1072453787.jpg"
        };
        var quartsNeutralOil = new Ingredient
        {
            Name = "Quarts neutral oil",
            Photo_url = "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fimg1.cookinglight.Timeinc.net%2Fsites%2Fdefault%2Ffiles%2Fstyles%2F4_3_horizontal_-_1200x900%2Fpublic%2Fgettyimages-464433694_0.jpg%3Fitok%3DK42YR2GV&w=400&c=sc&poi=face&q=85"
        };
        var water = new Ingredient
        {
            Name = "Water",
            Photo_url = "https://ak1.picdn.net/shutterstock/videos/829561/thumb/11.jpg"
        };
        var onionPowder = new Ingredient
        {
            Name = "Onion Powder",
            Photo_url = "https://image.shutterstock.com/image-photo/mixed-spices-isolated-on-white-260nw-662383828.jpg"
        };
        var msg = new Ingredient
        {
            Name = "MSG",
            Photo_url = "https://img.freepik.com/free-photo/monosodium-glutamate-wood-spoon-white-background_55883-399.jpg?size=626&ext=jpg"
        };
        var chickenBreast = new Ingredient
        {
            Name = "Chicken Breast",
            Photo_url = "https://us.123rf.com/450wm/utima/utima1602/utima160200063/53405187-raw-chicken-breast-fillets.jpg?ver=6"
        };
        var onionChopped = new Ingredient
        {
            Name = "Onion chopped",
            Photo_url = "https://s3.envato.com/files/246703499/IMG_1752_5.jpg"
        };
        var celerySalt = new Ingredient
        {
            Name = "Tomato paste",
            Photo_url = "http://d3e1m60ptf1oym.cloudfront.net/45bab59a-363c-11e1-ab4e-bf4c2e0bb026/PANELA_xgaplus.jpg"
        };
        var chilliPowder = new Ingredient
        {
            Name = "Chilli Powder",
            Photo_url = "https://us.123rf.com/450wm/nuttapong/nuttapong1505/nuttapong150500009/40458002-paprika-powder-isolated-on-white-background.jpg?ver=6"
        };
        var groundBeef = new Ingredient
        {
            Name = "Ground Beef",
            Photo_url = "https://images.radio.com/kmoxam/s3fs-public/styles/nts_image_cover_tall_775x425/public/dreamsTime_s_39607998.jpg?XCM.w1UGOp9sVKkWGQZe7_JIsRddxoIK&itok=3M6KcFLH&c=73fb6497175b4c1a5c79e3ede816656a"
        };
        var kidneyBeans = new Ingredient
        {
            Name = "Can kidney beans, rinsed and drained ",
            Photo_url = "https://www.seriouseats.com/images/2014/04/20140414-pile-of-beans-primary-1500x1125.jpg"
        };
        var largeTortillas = new Ingredient
        {
            Name = "Large Tortillas",
            Photo_url = "https://upload.wikimedia.org/wikipedia/commons/5/56/NCI_flour_tortillas.jpg"
        };
        var firtos = new Ingredient
        {
            Name = "Firtos",
            Photo_url = "https://previews.123rf.com/images/ksena32/ksena321510/ksena32151000090/45863494-fried-fish-on-a-white-background.jpg"
        };
        var shreddedCheddar = new Ingredient
        {
            Name = "Shredded cheddar",
            Photo_url = "https://image.shutterstock.com/image-photo/top-view-small-bowl-filled-260nw-284460308.jpg"
        };
        var lime = new Ingredient
        {
            Name = "Lime",
            Photo_url = "https://ak8.picdn.net/shutterstock/videos/23271748/thumb/1.jpg"
        };
        var groundCumin = new Ingredient
        {
            Name = "Ground cumin",
            Photo_url = "https://image.shutterstock.com/image-photo/pile-cumin-powder-isolated-on-260nw-1193262853.jpg"
        };
        var cayennePepper = new Ingredient
        {
            Name = "Cayenne pepper",
            Photo_url = "https://ak7.picdn.net/shutterstock/videos/11461337/thumb/1.jpg"
        };
        var flakyWhiteFish = new Ingredient
        {
            Name = "Flaky white fish",
            Photo_url = "https://image.shutterstock.com/image-photo/roach-river-fish-isolated-on-260nw-277764143.jpg"
        };
        var avocado = new Ingredient
        {
            Name = "Avocado",
            Photo_url = "https://www.redwallpapers.com/public/redwallpapers-large-thumb/avocado-cut-stone-leaves-white-background-free-stock-photos-images-hd-wallpaper.jpg"
        };
        var redPepperFlakes = new Ingredient
        {
            Name = "Red Pepper Flakes",
            Photo_url = "https://as1.ftcdn.net/jpg/02/06/55/10/500_F_206551074_mVczUrAWOSMaw8kR48FQDQBqDw47jCtL.jpg"
        };
        var onions = new Ingredient
        {
            Name = "Onions",
            Photo_url = "http://www.allwhitebackground.com/images/2/2650.jpg"
        };
        var greenPepper = new Ingredient
        {
            Name = "Green Pepper",
            Photo_url = "https://ak9.picdn.net/shutterstock/videos/4055509/thumb/1.jpg"
        };
        var redPepper = new Ingredient
        {
            Name = "Red Pepper",
            Photo_url = "https://ak9.picdn.net/shutterstock/videos/10314179/thumb/1.jpg"
        };
        var pizzaDough = new Ingredient
        {
            Name = "Pizza dough",
            Photo_url = "https://image.shutterstock.com/image-photo/fresh-raw-dough-pizza-bread-260nw-518950903.jpg"
        };
        var ketchupSauce = new Ingredient
        {
            Name = "Ketchup sauce",
            Photo_url = "https://st2.depositphotos.com/5262887/11050/i/950/depositphotos_110501208-stock-photo-ketchup-bowl-isolated-on-white.jpg"
        };
        var hotSauce = new Ingredient
        {
            Name = "Hot Sauce",
            Photo_url = "https://media.istockphoto.com/photos/opened-can-of-spaghetti-sauce-on-a-white-background-picture-id497704752?k=6&m=497704752&s=612x612&w=0&h=JnL54buYu1Z3fGtd8uNdjFxiAKwlxoDluD6jbIfSaZI="
        };
        var butter = new Ingredient
        {
            Name = "Butter",
            Photo_url = "https://redrockstoffee.com/media/2016/11/AdobeStock_76417550.jpeg"
        };
        var heavyCream = new Ingredient
        {
            Name = "Heavy Cream",
            Photo_url = "https://media.istockphoto.com/photos/mayonnaise-in-bowl-isolated-on-white-background-picture-id614981116?k=6&m=614981116&s=612x612&w=0&h=LtbsI2HQXOTERYuP9YJ2PJfRF3W6DcyZ798fxMcQWC0="
        };
        var wholeMilkPlainYogurt = new Ingredient
        {
            Name = "whole-milk plain yogurt",
            Photo_url = "https://st.depositphotos.com/2757384/3317/i/950/depositphotos_33170129-stock-photo-pouring-a-glass-of-milk.jpg"
        };
        var cheese = new Ingredient
        {
            Name = "Cheese",
            Photo_url = "https://ak7.picdn.net/shutterstock/videos/3619997/thumb/1.jpg"
        };
        var mozzarella = new Ingredient
        {
            Name = "Mozzarella",
            Photo_url = "https://t3.ftcdn.net/jpg/02/06/73/98/500_F_206739841_suPu6qDPHlowFqx9qo8fLqV8sNevL2g3.jpg"
        };
        var celeryStalks = new Ingredient
        {
            Name = "Celery stalks",
            Photo_url = "https://cdn4.eyeem.com/thumb/6d1b3957c7caa9b73c3e0f820ef854b931808139-1538043742765/w/750"
        };
        var parmesanCheese = new Ingredient
        {
            Name = "Parmesan Cheese",
            Photo_url = "https://ak7.picdn.net/shutterstock/videos/3721877/thumb/1.jpg"
        };
        var pancetta = new Ingredient
        {
            Name = "pancetta",
            Photo_url = "https://previews.123rf.com/images/onlyfabrizio/onlyfabrizio1606/onlyfabrizio160600002/60198502-raw-stripes-of-pancetta-stesa-on-a-white-background.jpg"
        };
        var spaghetti = new Ingredient
        {
            Name = "Spaghetti",
            Photo_url = "https://previews.123rf.com/images/mfron/mfron1204/mfron120400098/13306773-bunch-of-spaghetti-nudeln-isoliert-auf-wei%C3%9Fem-hintergrund.jpg"
        };
        var garlic = new Ingredient
        {
            Name = "Garlic",
            Photo_url = "https://image.freepik.com/free-photo/fresh-garlic-white-background_1339-17012.jpg"
        };
        var lasagnaNoodles = new Ingredient
        {
            Name = "Lasagna noodles",
            Photo_url = "https://previews.123rf.com/images/velkol/velkol1110/velkol111000004/11083085-an-image-of-raw-lasagna-on-white-background.jpg"
        };
        var italianSauce = new Ingredient
        {
            Name = "Italian sauce",
            Photo_url = "https://previews.123rf.com/images/arinahabich/arinahabich1504/arinahabich150400858/38827029-raw-italian-sausage-on-a-white-background-.jpg"
        };
        var crushedTomatoes = new Ingredient
        {
            Name = "Crushed Tomatoes",
            Photo_url = "https://previews.123rf.com/images/merkulovnik/merkulovnik1406/merkulovnik140600100/28751626-crushed-tomato-isolated-on-white-background.jpg"
        };
        var sugar = new Ingredient
        {
            Name = "Sugar",
            Photo_url = "https://previews.123rf.com/images/sommai/sommai1411/sommai141100034/33199985-sugar-cubes-in-a-bowl-isolated-on-white-background.jpg"
        };
        var mincedFreshParsley = new Ingredient
        {
            Name = "Minced fresh parsley",
            Photo_url = "https://t4.ftcdn.net/jpg/02/15/78/05/240_F_215780551_Eid0xpP1M2fokvuEcvJj8uqhROLJkb3p.jpg"
        };
        var ricottaCheese = new Ingredient
        {
            Name = "Ricotta cheese",
            Photo_url = "https://previews.123rf.com/images/barkstudio/barkstudio1608/barkstudio160800351/61418602-ricotta-cheese-into-a-bowl-in-white-background.jpg"
        };
        var fennelSeed = new Ingredient
        {
            Name = "Fennel seed",
            Photo_url = "https://previews.123rf.com/images/pinkomelet/pinkomelet1710/pinkomelet171000227/88851299-close-up-the-fennel-seed-on-white-background.jpg"
        };
        var banana = new Ingredient
        {
            Name = "Banana",
            Photo_url = "https://www.conservationmagazine.org/wp-content/uploads/2013/04/sterile-banana.jpg"
        };
        var frozenStrawberries = new Ingredient
        {
            Name = "Frozen Strawberries",
            Photo_url = "https://www.cascadianfarm.com/wp-content/uploads/2018/12/Strawberries_Main_0218.png"
        };
        var greekYogurt = new Ingredient
        {
            Name = "Greek Yogurt",
            Photo_url = "http://images.media-allrecipes.com/userphotos/960x960/3758635.jpg"
        };

        context.Ingredients.AddRange(
          oil,
          salt,
          russetPotatoes,
          paprika,
          blackPepper,
          celerySalt,
          driedSage,
          garlicPowder,
          groundAllspice,
          driedOregano,
          driedBasil,
          driedMarjoram,
          allPurposeFlour,
          brownSugar,
          kosherSalt,
          wholeChicken,
          eggs,
          quartsNeutralOil,
          water,
          onionPowder,
          msg,
          chickenBreast,
          onionChopped,
          chilliPowder,
          groundBeef,
          kidneyBeans,
          largeTortillas,
          firtos,
          shreddedCheddar,
          lime,
          groundCumin,
          cayennePepper,
          flakyWhiteFish,
          avocado,
          redPepperFlakes,
          onions,
          greenPepper,
          redPepper,
          pizzaDough,
          ketchupSauce,
          hotSauce,
          butter,
          heavyCream,
          wholeMilkPlainYogurt,
          cheese,
          mozzarella,
          celeryStalks,
          parmesanCheese,
          pancetta,
          spaghetti,
          garlic,
          lasagnaNoodles,
          italianSauce,
          crushedTomatoes,
          sugar,
          mincedFreshParsley,
          ricottaCheese,
          fennelSeed,
          banana,
          frozenStrawberries,
          greekYogurt
        );


        var oatmealCookiesRecipe = new Recipe
        {
            Category = cookiesCategory,
            Title = "Oatmeal Cookies",
            Photo_url = "https://www.texanerin.com/content/uploads/2019/06/nobake-chocolate-cookies-1-650x975.jpg",
            PhotosArray = new List<string>
                        {
                            "https://www.texanerin.com/content/uploads/2019/06/nobake-chocolate-cookies-1-650x975.jpg",
                            "https://namelymarly.com/wp-content/uploads/2018/04/20180415_Beet_Lasagna_10.jpg",
                        },
            Time = 15,
            Description = "-- Start with cleaned and peeled russet potatoes that you have cut into 3/8-inch match sticks. Place in bowl of very cold water: keep rinsing and changing the water until the water is clear; drain thoroughly and dry with paper towels or a clean lint-free kitchen towel.\n\n -- Meanwhile, you preheat your hot oil to 350 degrees F. Place prepared taters in oil and cook about 5 minutes. They will have that blond-tone color to them. \n\n -- Note: Once you add cold potatoes to the hot oil, the temperature of your oil is going to drop - you want it to be somewhere between 330 - 325 degrees F. \n\n -- Remove from oil; drain and cool. Now - either refrigerate until ready to finish cooking, or cool completely and freeze up to 3 months. To freeze properly - place completely cooled fries in single layer on tray and place in freezer until frozen. Then bag them.\n\n -- To finish cooking - preheat your oil to 400* F. Add your cold fries (which will drop the oil temp - which is fine because you want it near the 375 degrees F. temp) and cook a few minutes until done. Lightly salt them and shake well so that the salt distributes well and they are not salty."
        };
        // ... Ajoutez d'autres recettes

        var smoothieTripleBerryRecipe = new Recipe
        {
            Category = smoothiesCategory,
            Title = "Triple Berry Smoothie",
            Photo_url = "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/delish-how-to-make-a-smoothie-horizontal-1542310071.png?crop=0.803xw:0.923xh;0.116xw,0.00510xh&resize=768:*",
            PhotosArray = new List<string>
                        {
                            "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/delish-how-to-make-a-smoothie-horizontal-1542310071.png?crop=0.803xw:0.923xh;0.116xw,0.00510xh&resize=768:*",
                            "https://www.vitamix.com/media/other/images/xVitamix-Triple-Berry-Smoothie-square-crop__1.jpg.pagespeed.ic.OgTC3ILD3R.jpg",
                            "http://images.media-allrecipes.com/userphotos/960x960/3798204.jpg",
                            "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTrzui8MM6W66I29VZwVvcjpGv99JW3O1owgupc3KwB65rhAyrZ"
                        },
            Time = 10,
            Description = "In a blender, combine all ingredients and blend until smooth. Then divide between 2 cups and top with blackberries, if desired."
        };

        var veganCookiesRecipe = new Recipe
        {
            Category = cookiesCategory,
            Title = "Vegan Cookies",
            Photo_url = "https://www.texanerin.com/content/uploads/2018/06/no-bake-lactation-cookies-1-650x975.jpg",
            PhotosArray = new List<string>
                        {
                            "https://www.texanerin.com/content/uploads/2018/06/no-bake-lactation-cookies-1-650x975.jpg",
                            "https://ichef.bbci.co.uk/news/660/cpsprodpb/B2C0/production/_106106754_vegnuggets976.jpg",
                            "https://pixel.nymag.com/imgs/daily/grub/2017/11/22/22-mcds-chicken-tenders.w330.h330.jpg",
                            "https://imagesvc.meredithcorp.io/v3/mm/image?url=https%3A%2F%2Fcdn-img.health.com%2Fsites%2Fdefault%2Ffiles%2Fstyles%2Flarge_16_9%2Fpublic%2Fstyles%2Fmain%2Fpublic%2Fgettyimages-508510211.jpg%3Fitok%3Dh-Uryi8r&w=400&c=sc&poi=face&q=85"
                        },
            Time = 30,
            Description = "-- Beat the egg and then combine it with water in a bowl. Stir. Combine the flour, salt, MSG, pepper, onion powder and garlic powder in a gallon size zip lock bag. Pound each of the breast filets until about 1/4-inch thick. Then cut into bite sized pieces. Coat each piece with the flour mixture by shaking in the zip lock bag. Remove and coat in the egg mixture. Then coat in the flour mixture again. Shake to coat. Deep fry at 375 degrees for 10-12 minutes, until browned and crispy."
        };

        var pumpkinSpiceCookiesRecipe = new Recipe
        {
            Category = cookiesCategory,
            Title = "Pumpkin Spice Cookies",
            Photo_url = "https://www.texanerin.com/content/uploads/2018/11/pumpkin-spice-cookies-4-650x975.jpg",
            PhotosArray = new List<string>
                        {
                            "https://www.texanerin.com/content/uploads/2018/11/pumpkin-spice-cookies-4-650x975.jpg",
                            "https://cdn.junglecreations.com/wp/junglecms/2018/07/4164c5bd-wide-thumbnail.jpg",
                            "https://pinchofyum.com/wp-content/uploads/Crunchwrap-Inside.jpg",
                            "https://monsonmadethis.com/wp-content/uploads/2017/10/IMG_20171015_161017_025-e1533869302263.jpg"
                        },
            Time = 45,
            Description = "-- In a medium pot over medium heat, heat 1 tablespoon oil. Add onion and cook until soft, 5 minutes. Add garlic and cook until fragrant, 1 minute more. Add tomato paste and stir to coat onion and garlic. Add ground beef and cook, breaking up meat with a wooden spoon, until no longer pink, 6 minutes. Drain fat.\n\n -- Return beef to pot and season with chili powder, paprika, salt, and pepper. Add tomato sauce and kidney beans. Bring to a boil, then reduce heat and let simmer 15 minutes. Add some chili to center of each tortilla, leaving room to fold in edges. Top with Fritos, then cheddar. Fold edges of tortillas toward the center, creating pleats. Invert Crunchwraps so pleats are on the bottom and stay together.\n\n -- In medium skillet over medium heat, heat remaining tablespoon oil. Add a Crunchwrap seam side down and cook until tortilla is golden, 3 to 5 minutes per side. Repeat with remaining Crunchwraps"
        };

        var browniesRecipe = new Recipe
        {
            Category = cookiesCategory,
            Title = "Brownies",
            Photo_url = "https://www.texanerin.com/content/uploads/2018/01/coconut-flour-brownies-1-650x975.jpg",
            PhotosArray = new List<string>
                        {
                            "https://www.texanerin.com/content/uploads/2018/01/coconut-flour-brownies-1-650x975.jpg",
                            "https://images-gmi-pmc.edge-generalmills.com/6fbc6859-e2b1-499d-b0fa-ada600c9cc3f.jpg",
                            "http://www.recipe4living.com/assets/itemimages/400/400/3/83c29ac7418067c2e74f31c8abdd5a43_477607049.jpg",
                            "https://www.franchisechatter.com/wp-content/uploads/2014/08/KFC-Photo-by-James.jpg"
                        },
            Time = 30,
            Description = "-- Preheat fryer to 350°F. Thoroughly mix together all spices. Combine spices with flour, brown sugar and salt. Dip chicken pieces in egg white to lightly coat them, then transfer to flour mixture. Turn a few Times and make sure the flour mix is really stuck to the chicken.\n\n -- Repeat with all the chicken pieces. Let chicken pieces rest for 5 minutes so crust has a chance to dry a bit. Fry chicken in batches. Breasts and wings should take 12-14 minutes, and legs and thighs will need a few more minutes. Chicken pieces are done when a meat thermometer inserted into the thickest part reads 165°F. Let chicken drain on a few paper towels when it comes out of the fryer. Serve hot."
        };

        var fishTacosRecipe = new Recipe
        {
            Category = mexicanCategory,
            Title = "Perfect Fish Tacos",
            Photo_url = "https://hips.hearstapps.com/hmg-prod/images/190307-fish-tacos-112-1553283299.jpg",
            PhotosArray = new List<string>
                        {
                            "http://d2814mmsvlryp1.cloudfront.net/wp-content/uploads/2014/04/WGC-Fish-Tacos-copy-2.jpg",
                            "https://thecozyapron.com/wp-content/uploads/2018/03/baja-fish-tacos_thecozyapron_1.jpg",
                            "https://www.simplyrecipes.com/wp-content/uploads/2017/06/2017-07-22-FishTacos-6.jpg"
                        },
            Time = 35,
            Description = "-- In a medium shallow bowl, whisk together olive oil, lime juice, paprika, chili powder, cumin, and cayenne. Add cod, tossing until evenly coated. Let marinate 15 minutes. Meanwhile, make slaw: In a large bowl, whisk together mayonnaise, lime juice, cilantro, and honey. Stir in cabbage, corn, and jalapeño. Season with salt and pepper.\n\n -- In a large nonstick skillet over medium-high heat, heat vegetable oil. Remove cod from marinade and season both sides of each filet with salt and pepper. Add fish flesh side-down. Cook until opaque and cooked through, 3 to 5 minutes per side.\n\n -- Let rest 5 minutes before flaking with a fork. Assemble tacos: Serve fish over grilled tortillas with corn slaw and avocado. Squeeze lime juice on top and garnish with sour cream."
        };

        var chickenFajitasRecipe = new Recipe
        {
            Category = mexicanCategory,
            Title = "Chicken Fajitas",
            Photo_url = "https://tmbidigitalassetsazure.blob.core.windows.net/secure/RMS/attachments/37/1200x1200/Flavorful-Chicken-Fajitas_EXPS_GHBZ18_12540_B08_15_8b.jpg",
            PhotosArray = new List<string>
                        {
                            "https://dadwithapan.com/wp-content/uploads/2015/07/Spicy-Chicken-Fajitas-22-1200x480.jpg",
                            "https://3.bp.blogspot.com/-X-dHj7ORF9Q/XH4ssgTuSZI/AAAAAAAAEig/E46HP9wCfdsvyJFcMTX30cw-ICep8lF9ACHMYCw/s1600/chicken-fajitas-mexican-food-id-149559-buzzerg.jpg",
                            "https://cdn-image.foodandwine.com/sites/default/files/styles/medium_2x/public/201403-xl-chipotle-chicken-fajitas.jpg?itok=ghVcI5SQ"
                        },
            Time = 35,
            Description = "-- In a large bowl, combine 2 tablespoons oil, lemon juice and seasonings; add the chicken. Turn to coat; cover. Refrigerate for 1-4 hours In a large skillet, saute peppers and onions in remaining oil until crisp-tender. Remove and keep warm. Drain chicken, discarding marinade. In the same skillet, cook chicken over medium-high heat for 5-6 minutes or until no longer pink.\n\n -- Return pepper mixture to pan; heat through. Spoon filling down the center of tortillas; fold in half. Serve with toppings as desired."
        };

        var buffaloPizzaRecipe = new Recipe
        {
            Category = pizzaCategory,
            Title = "Buffalo Pizza",
            Photo_url = "https://images.unsplash.com/photo-1513104890138-7c749659a591?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&w=1000&q=80",
            PhotosArray = new List<string>
                        {
                            "https://www.tablefortwoblog.com/wp-content/uploads/2019/01/buffalo-chicken-pizza-recipe-photos-tablefortwoblog-3-500x500.jpg",
                            "http://pizzachoicema.com/wp-content/uploads/2018/08/Buffalo-Chicken-Pizza.jpg",
                            "https://static1.squarespace.com/static/565bb41ae4b0509ba9fdf769/t/5b9a8e80aa4a998b0be0fcf4/1536855690622/pizza.gif"
                        },
            Time = 50,
            Description = "-- Place a rack in upper third of oven. Place a large cast-iron skillet on rack and preheat oven to 500° (or as high as your oven will go). Place pizza dough in a large bowl, pour a little oil over, and turn to coat. Cover bowl with plastic and let dough proof at room temperature while pan and oven heat up.\n\n -- Meanwhile, cook hot sauce, marinara sauce, and butter in a medium saucepan over medium heat, stirring occasionally, until butter is melted. Stir in cream, reduce heat to low, and simmer, stirring occasionally, until slightly thickened and warmed through, about 10 minutes. Heat 1 Tbsp. oil in a large skillet over medium-high. Add chicken, toss to coat, then add ¼ cup Buffalo sauce.\n\n -- Cook chicken, tossing occasionally, until heated through, about 2 minutes. Reduce heat and simmer, stirring often, until chicken is well coated and sauce is slightly thickened, about 5 minutes. Meanwhile, whisk yogurt, lemon juice, celery salt, garlic powder, ¼ cup blue cheese, ½ tsp. pepper, and 2 Tbsp. water in a small bowl, adding more water if sauce seems too thick (it should be pourable); set aside.\n\n -- Turn out dough onto a lightly floured work surface. Shape with your hands into a round that’s slightly larger than the cast-iron skillet you’re using. Take hot skillet out of oven (watch that handle!) and place on a heatproof surface. Add a little flour to pan. Lay dough in skillet, then work edges of dough up sides of skillet with your fingertips (use a rubber spatula or wooden spoon if you’re nervous about touching the hot pan). Drizzle a little oil around inside edge of pan so that it trickles behind and underneath dough, which will encourage browning and help it release.\n\n -- Spread about ⅓ cup Buffalo sauce over dough. Arrange mozzarella over, then top with remaining ¼ cup blue cheese. Arrange chicken mixture on top. Bake pizza on top rack until crust and cheese are nicely browned, 15–20 minutes. Transfer skillet to stovetop (again, watch that handle!) and let pizza rest a few minutes. Using a spatula, slide pizza onto a cutting board or platter. Arrange celery over, then top with reserved blue cheese dressing. Season with pepper, then drizzle with oil."
        };

        var classicLasagnaRecipe = new Recipe
        {
            Category = italianCategory,
            Title = "Classic Lasagna",
            Photo_url = "https://namelymarly.com/wp-content/uploads/2018/04/20180415_Beet_Lasagna_10.jpg",
            PhotosArray = new List<string>
                        {
                            "https://namelymarly.com/wp-content/uploads/2018/04/20180415_Beet_Lasagna_10.jpg",
                            "https://advancelocal-adapter-image-uploads.s3.amazonaws.com/image.al.com/home/bama-media/width600/img/news_impact/photo/burger-fijpg-57e7e5907630c2ad.jpg",
                            "https://img.thedailybeast.com/image/upload/c_crop,d_placeholder_euli9k,h_1439,w_2560,x_0,y_0/dpr_1.5/c_limit,w_1044/fl_lossy,q_auto/v1492718105/articles/2013/09/24/burger-king-s-new-french-fries-took-ten-years-to-develop/130923-gross-burger-tease_izz59e",
                            "https://aht.seriouseats.com/images/2012/02/20120221-193971-fast-food-fries-Burger-King-fries-2.jpg"
                        },
            Time = 15,
            Description = "-- Start with cleaned and peeled russet potatoes that you have cut into 3/8-inch match sticks. Place in bowl of very cold water: keep rinsing and changing the water until the water is clear; drain thoroughly and dry with paper towels or a clean lint-free kitchen towel.\n\n -- Meanwhile, you preheat your hot oil to 350 degrees F. Place prepared taters in oil and cook about 5 minutes. They will have that blond-tone color to them. \n\n -- Note: Once you add cold potatoes to the hot oil, the temperature of your oil is going to drop - you want it to be somewhere between 330 - 325 degrees F. \n\n -- Remove from oil; drain and cool. Now - either refrigerate until ready to finish cooking, or cool completely and freeze up to 3 months. To freeze properly - place completely cooled fries in single layer on tray and place in freezer until frozen. Then bag them.\n\n -- To finish cooking - preheat your oil to 400* F. Add your cold fries (which will drop the oil temp - which is fine because you want it near the 375 degrees F. temp) and cook a few minutes until done. Lightly salt them and shake well so that the salt distributes well and they are not salty."
        };

        var carbonaraRecipe = new Recipe
        {
            Category = italianCategory,
            Title = "Spaghetti Carbonara",
            Photo_url = "https://truffle-assets.imgix.net/655ce202-862-butternutsquashcarbonara-land.jpg",
            PhotosArray = new List<string>
                        {
                            "https://ak3.picdn.net/shutterstock/videos/10431533/thumb/10.jpg",
                            "https://www.kcet.org/sites/kl/files/styles/kl_image_large/public/thumbnails/image/square_hero_desktop_2x_sfs_spaghetti_carbonara_clr-3.jpg?itok=T-rsBDIZ",
                            "https://cdn-image.foodandwine.com/sites/default/files/HD-201104-r-spaghetti-with-anchovy.jpg"
                        },
            Time = 15,
            Description = "-- Put the egg yolks into a bowl, finely grate in the Parmesan, season with pepper, then mix well with a fork and put to one side. Cut any hard skin off the pancetta and set aside, then chop the meat. Cook the spaghetti in a large pan of boiling salted water until al dente.\n\n -- Meanwhile, rub the pancetta skin, if you have any, all over the base of a medium frying pan (this will add fantastic flavour, or use 1 tablespoon of oil instead), then place over a medium-high heat. Peel the garlic, then crush with the palm of your hand, add it to the pan and leave it to flavour the fat for 1 minute. Stir in the pancetta, then cook for 4 minutes, or until it starts to crisp up. Pick out and discard the garlic from the pan, then, reserving some of the cooking water, drain and add the spaghetti.\n\n -- Toss well over the heat so it really soaks up all that lovely flavour, then remove the pan from the heat. Add a splash of the cooking water and toss well, season with pepper, then pour in the egg mixture – the pan will help to cook the egg gently, rather than scrambling it. Toss well, adding more cooking water until it’s lovely and glossy. Serve with a grating of Parmesan and an extra twist of pepper."
        };

        var lazaniaRecipe = new Recipe
        {
            Category = italianCategory,
            Title = "Lazania",
            Photo_url = "https://images8.alphacoders.com/817/817353.jpg",
            PhotosArray = new List<string>
                        {
                            "https://previews.123rf.com/images/somegirl/somegirl1509/somegirl150900048/46103208-top-view-of-a-delicious-traditional-italian-lasagna-made-with-minced-beef-bolognese-sauce-topped-wit.jpg",
                            "https://truffle-assets.imgix.net/87f324e4-YOUTUBE-NO-TXT.00_03_19_14.Imagen_fija001.jpg",
                            "https://images4.alphacoders.com/817/817350.jpg"
                        },
            Time = 60,
            Description = "-- Cook noodles according to package directions; drain. Meanwhile, in a Dutch oven, cook sausage, beef and onion over medium heat 8-10 minutes or until meat is no longer pink, breaking up meat into crumbles. Add garlic; cook 1 minute. Drain. Stir in tomatoes, tomato paste, water, sugar, 3 tablespoons parsley, basil, fennel, 1/2 teaspoon salt and pepper; bring to a boil. Reduce heat; simmer, uncovered, 30 minutes, stirring occasionally. In a small bowl, mix egg, ricotta cheese, and remaining parsley and salt. Preheat oven to 375°. Spread 2 cups meat sauce into an ungreased 13x9-in. baking dish. Layer with 3 noodles and a third of the ricotta mixture. Sprinkle with 1 cup mozzarella cheese and 2 tablespoons Parmesan cheese.\n\n -- Repeat layers twice. Top with remaining meat sauce and cheeses (dish will be full). Bake, covered, 25 minutes. Bake, uncovered, 25 minutes longer or until bubbly. Let stand 15 minutes before serving."
        };


        context.Recipes.AddRange(oatmealCookiesRecipe, smoothieTripleBerryRecipe, veganCookiesRecipe, pumpkinSpiceCookiesRecipe, browniesRecipe, fishTacosRecipe, chickenFajitasRecipe, buffaloPizzaRecipe, classicLasagnaRecipe, carbonaraRecipe, lazaniaRecipe);

        //context.RecipeIngredients.AddRange(
        //        new RecipeIngredient
        //        {
        //            recipe = oatmealCookiesRecipe,
        //            ingredient = oil,
        //            ingredient_quantity = "200ml"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = oatmealCookiesRecipe,
        //            ingredient = salt,
        //            ingredient_quantity = "5g"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = oatmealCookiesRecipe,
        //            ingredient = russetPotatoes,
        //            ingredient_quantity = "300g"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = smoothieTripleBerryRecipe,
        //            ingredient = banana,
        //            ingredient_quantity = "1"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = smoothieTripleBerryRecipe,
        //            ingredient = frozenStrawberries,
        //            ingredient_quantity = "1/2lbs"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = smoothieTripleBerryRecipe,
        //            ingredient = greekYogurt,
        //            ingredient_quantity = "1/2L"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = veganCookiesRecipe,
        //            ingredient = oil,
        //            ingredient_quantity = "2 quarts"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = veganCookiesRecipe,
        //            ingredient = eggs,
        //            ingredient_quantity = "1"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = veganCookiesRecipe,
        //            ingredient = allPurposeFlour,
        //            ingredient_quantity = "1 cup"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = veganCookiesRecipe,
        //            ingredient = water,
        //            ingredient_quantity = "1 cup"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = veganCookiesRecipe,
        //            ingredient = onions,
        //            ingredient_quantity = "1 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = veganCookiesRecipe,
        //            ingredient = salt,
        //            ingredient_quantity = "2 teaspoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = veganCookiesRecipe,
        //            ingredient = blackPepper,
        //            ingredient_quantity = "1/4 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = veganCookiesRecipe,
        //            ingredient = garlicPowder,
        //            ingredient_quantity = "1/8 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = veganCookiesRecipe,
        //            ingredient = msg,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = veganCookiesRecipe,
        //            ingredient = chickenBreast,
        //            ingredient_quantity = "4"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = pumpkinSpiceCookiesRecipe,
        //            ingredient = oil,
        //            ingredient_quantity = "2 tablespoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = pumpkinSpiceCookiesRecipe,
        //            ingredient = onionChopped,
        //            ingredient_quantity = "1/2"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = pumpkinSpiceCookiesRecipe,
        //            ingredient = garlicPowder,
        //            ingredient_quantity = "2 cloves"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = pumpkinSpiceCookiesRecipe,
        //            ingredient = paprika,
        //            ingredient_quantity = "1 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = pumpkinSpiceCookiesRecipe,
        //            ingredient = chilliPowder,
        //            ingredient_quantity = "1 tablespoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = pumpkinSpiceCookiesRecipe,
        //            ingredient = groundBeef,
        //            ingredient_quantity = "1lb"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = pumpkinSpiceCookiesRecipe,
        //            ingredient = salt,
        //            ingredient_quantity = "2 teaspoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = pumpkinSpiceCookiesRecipe,
        //            ingredient = blackPepper,
        //            ingredient_quantity = "2 teaspoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = pumpkinSpiceCookiesRecipe,
        //            ingredient = kidneyBeans,
        //            ingredient_quantity = "15 oz"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = pumpkinSpiceCookiesRecipe,
        //            ingredient = largeTortillas,
        //            ingredient_quantity = "8"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = pumpkinSpiceCookiesRecipe,
        //            ingredient = firtos,
        //            ingredient_quantity = "2"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = pumpkinSpiceCookiesRecipe,
        //            ingredient = shreddedCheddar,
        //            ingredient_quantity = "1 cup"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = salt,
        //            ingredient_quantity = "2 tablepoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = paprika,
        //            ingredient_quantity = "1 tablepoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = blackPepper,
        //            ingredient_quantity = "1 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = celerySalt,
        //            ingredient_quantity = "1/2 tespoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = driedSage,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = garlicPowder,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = groundAllspice,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = driedOregano,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = driedBasil,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = driedMarjoram,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = allPurposeFlour,
        //            ingredient_quantity = "1/2 cup"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = brownSugar,
        //            ingredient_quantity = "1 tablespoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = kosherSalt,
        //            ingredient_quantity = "1 tablespoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = wholeChicken,
        //            ingredient_quantity = "2 breast, 2 thighs, 2 drumsticks,2 wings"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = eggs,
        //            ingredient_quantity = "1"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = browniesRecipe,
        //            ingredient = quartsNeutralOil,
        //            ingredient_quantity = "2 quarts"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = fishTacosRecipe,
        //            ingredient = lime,
        //            ingredient_quantity = "juice of one"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = fishTacosRecipe,
        //            ingredient = chilliPowder,
        //            ingredient_quantity = "2 teaspoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = fishTacosRecipe,
        //            ingredient = oil,
        //            ingredient_quantity = "3 tablespoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = fishTacosRecipe,
        //            ingredient = paprika,
        //            ingredient_quantity = "1 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = fishTacosRecipe,
        //            ingredient = groundCumin,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = fishTacosRecipe,
        //            ingredient = cayennePepper,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = fishTacosRecipe,
        //            ingredient = blackPepper,
        //            ingredient_quantity = "2 teaspoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = fishTacosRecipe,
        //            ingredient = flakyWhiteFish,
        //            ingredient_quantity = "1/2 lb"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = fishTacosRecipe,
        //            ingredient = largeTortillas,
        //            ingredient_quantity = "8"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = fishTacosRecipe,
        //            ingredient = kosherSalt,
        //            ingredient_quantity = "2 teaspoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = fishTacosRecipe,
        //            ingredient = avocado,
        //            ingredient_quantity = "1"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = driedOregano,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = oil,
        //            ingredient_quantity = "4 tablespoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = salt,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = lime,
        //            ingredient_quantity = "2 tablespoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = groundCumin,
        //            ingredient_quantity = "1 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = garlicPowder,
        //            ingredient_quantity = "1 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = chilliPowder,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = paprika,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = chickenBreast,
        //            ingredient_quantity = "1 pound"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = onionChopped,
        //            ingredient_quantity = "1/2 cup"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = largeTortillas,
        //            ingredient_quantity = "6"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = onions,
        //            ingredient_quantity = "4"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = greenPepper,
        //            ingredient_quantity = "1/2"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = chickenFajitasRecipe,
        //            ingredient = redPepper,
        //            ingredient_quantity = "1/2"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = pizzaDough,
        //            ingredient_quantity = "1lb"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = ketchupSauce,
        //            ingredient_quantity = "1 cup"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = hotSauce,
        //            ingredient_quantity = "1/2 cup"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = butter,
        //            ingredient_quantity = "1/4 cup"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = heavyCream,
        //            ingredient_quantity = "2 tablespoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = wholeMilkPlainYogurt,
        //            ingredient_quantity = "1/2 cup"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = garlicPowder,
        //            ingredient_quantity = "1/4 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = celerySalt,
        //            ingredient_quantity = "1/4 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = lime,
        //            ingredient_quantity = "1/4 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = cheese,
        //            ingredient_quantity = "2 oz"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = allPurposeFlour,
        //            ingredient_quantity = "For dusting"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = blackPepper,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = celeryStalks,
        //            ingredient_quantity = "2"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = buffaloPizzaRecipe,
        //            ingredient = mozzarella,
        //            ingredient_quantity = "9 oz"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = classicLasagnaRecipe,
        //            ingredient = oil,
        //            ingredient_quantity = "200ml"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = classicLasagnaRecipe,
        //            ingredient = salt,
        //            ingredient_quantity = "5g"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = classicLasagnaRecipe,
        //            ingredient = russetPotatoes,
        //            ingredient_quantity = "300g"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = carbonaraRecipe,
        //            ingredient = parmesanCheese,
        //            ingredient_quantity = "50g"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = carbonaraRecipe,
        //            ingredient = pancetta,
        //            ingredient_quantity = "100g"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = carbonaraRecipe,
        //            ingredient = spaghetti,
        //            ingredient_quantity = "350g"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = carbonaraRecipe,
        //            ingredient = garlic,
        //            ingredient_quantity = "2 plump"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = carbonaraRecipe,
        //            ingredient = butter,
        //            ingredient_quantity = "50g"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = carbonaraRecipe,
        //            ingredient = eggs,
        //            ingredient_quantity = "3"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = carbonaraRecipe,
        //            ingredient = salt,
        //            ingredient_quantity = "2 teaspoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = carbonaraRecipe,
        //            ingredient = blackPepper,
        //            ingredient_quantity = "2 teaspoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = onions,
        //            ingredient_quantity = "1 large"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = groundBeef,
        //            ingredient_quantity = "1 pound"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = garlic,
        //            ingredient_quantity = "5 cloves"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = lasagnaNoodles,
        //            ingredient_quantity = "1 pound"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = italianSauce,
        //            ingredient_quantity = "1 pound"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = crushedTomatoes,
        //            ingredient_quantity = "1 28 ounce can"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = sugar,
        //            ingredient_quantity = "2 tablespoons"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = mincedFreshParsley,
        //            ingredient_quantity = "1/4 cup"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = driedBasil,
        //            ingredient_quantity = "1/2 cup"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = salt,
        //            ingredient_quantity = "1/2 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = fennelSeed,
        //            ingredient_quantity = "1 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = blackPepper,
        //            ingredient_quantity = "1/4 teaspoon"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = eggs,
        //            ingredient_quantity = "1 large"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = mozzarella,
        //            ingredient_quantity = "1 pound"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = parmesanCheese,
        //            ingredient_quantity = "1 cup"
        //        },
        //        new RecipeIngredient
        //        {
        //            recipe = lazaniaRecipe,
        //            ingredient = ricottaCheese,
        //            ingredient_quantity = "30 ounces"
        //        }
        //        );

        context.SaveChanges();

    }
}
