using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int playingRacoons = 3;
            int leavingRacoons = 2;
            int leftinWoods = playingRacoons - leavingRacoons;
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int flowers = 5;
            int bees = 3;
            int beesThanFlowers = flowers - bees;
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int firstLonelyPigeon = 1;
            int secondPigeon = 1;
            int amountOfPigeons = firstLonelyPigeon + secondPigeon;
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int firstSetOfOwls = 3;
            int additionalOwls = 2;
            int totalOwls = firstSetOfOwls + additionalOwls;
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int workingBeavers = 2;
            int beaverGoingSwimming = 1;
            int stillWorkingBeavers = workingBeavers - beaverGoingSwimming;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int originalToucans = 2;
            int additionalToucans = 1;
            int totalToucans = originalToucans + additionalToucans;
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int squirrelsInTree = 4;
            int nuts = 2;
            int moreSquirrelsThanNuts = squirrelsInTree - nuts;
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal quarter = (decimal)0.25;
            decimal dime = (decimal)0.10;
            decimal nickel = (decimal)0.05;
            decimal totalAmountMrsHilt = quarter + dime + nickel + nickel;
            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int mrsBrierMuffins = 18;
            int mrsMacAdamsMuffins = 20;
            int mrsFlanneryMuffins = 17;
            int totalMuffins = mrsBrierMuffins + mrsMacAdamsMuffins + mrsFlanneryMuffins;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal yoyo = (decimal)0.24;
            decimal whistle = (decimal)0.14;
            decimal totalSpentForToys = yoyo + whistle;
            /*
            13. Mrs. Hilt made 5 Rice Krispies Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */
            int largeMarshmallows = 8;
            int miniMarshmallows = 10;
            int totalMarshmallows = largeMarshmallows + miniMarshmallows;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltSnow = 29;
            int brecknockSnow = 17;
            int snowDifference = hiltSnow - brecknockSnow;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            int hiltStartingMoney = 10;
            int toyTruck = 3;
            int pencil = 2;
            decimal hiltMoneyLeft = hiltStartingMoney - toyTruck - pencil;
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int joshMarbleCollection = 16;
            int joshLostMarbles = 7;
            int joshCurrentCollection = joshMarbleCollection - joshLostMarbles;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int meganCollection = 19;
            int collectionGoal = 25;
            int amountNeededForGoal = collectionGoal - meganCollection;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int bradTotalBalloons = 17;
            int redBalloons = 8;
            int greenBallons = bradTotalBalloons - redBalloons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int booksOnShelf = 38;
            int martaAdditionalBooks = 10;
            int newBookTotalOnShelf = booksOnShelf + martaAdditionalBooks;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int legsOnBee = 6;
            int numberOfBees = 8;
            int legsOnEightBees = legsOnBee * numberOfBees;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal iceCreamCone = (decimal)0.99;
            decimal twoCones = iceCreamCone + iceCreamCone;
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int completeRockBorder = 125;
            int hiltRockAmount = 64;
            int rocksNeededForBorder = completeRockBorder - hiltRockAmount;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int hiltOriginalMarbles = 38;
            int hiltLostMarbles = 15;
            int hiltMarblesLeft = hiltOriginalMarbles - hiltLostMarbles;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int concertDrive = 78;
            int droveBeforeGas = 32;
            int driveAfterGas = concertDrive - droveBeforeGas;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */
            int saturdayMorningShoveling = 90;
            int saturdayAfternoonShoveling = 45;
            int totalShovelingMinutes = saturdayAfternoonShoveling + saturdayMorningShoveling;
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int numberOfHotDogs = 6;
            decimal costOfHotDogs = 0.50M;
            decimal totalCostOfDogs = numberOfHotDogs * costOfHotDogs;
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            int mrsHiltMoney = 50;
            int pencilCost = 7;
            int numberOfPencilsBought = mrsHiltMoney / pencilCost;
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int totalButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = totalButterflies - orangeButterflies;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal kateGaveClerk = 1.00M;
            decimal candyCost = 0.54M;
            decimal kateChange = kateGaveClerk - candyCost;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int markTreesInYard = 13;
            int additionalPlantedTrees = 12;
            int totalTreesInYard = markTreesInYard + additionalPlantedTrees;
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int daysUntilJoyAtGrandma = 2;
            int hoursInDay = 24;
            int hoursUntilGrandma = daysUntilJoyAtGrandma * hoursInDay;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int kimCousins = 4;
            int pieceOfGumToEach = 5;
            int totalGunNeeded = 20;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal danMoney = 3.00M;
            decimal candyBarCost = 1.00M;
            decimal danMoneyLeft = danMoney - candyBarCost;
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int boatsInLake = 5;
            int peopleInBoat = 3;
            int peopleInBoatsOnLake = boatsInLake * peopleInBoat;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int ellenLegos = 380;
            int ellenLostLegos = 57;
            int amountAfterLossLegos = ellenLegos - ellenLostLegos;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int arthurBakedMuffins = 35;
            int totaArthurlMuffins = 83;
            int moreArthurMuffinsNeeded = totaArthurlMuffins - arthurBakedMuffins;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int numberWillyCrayonsMoreThanLucy = willyCrayons - lucyCrayons;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersOnPage = 10;
            int pagesOfStickers = 22;
            int totalStickers = stickersOnPage * pagesOfStickers;
            /*
            39. There are 100 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            decimal totalCupcakes = 100M;
            decimal childrenWantingCupcakes = 8M;
            decimal cupcakesPerChild = totalCupcakes / childrenWantingCupcakes;
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies, how many
            cookies will not be placed in a jar?
            */
            int gingerbreadCookies = 47;
            int cookiesInJar = 6;
            int leftoverGingerbreadCookies = gingerbreadCookies % cookiesInJar;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received an equal number of croissants,
            how many will be left with Marian?
            */
            int croissantsPrepared = 59;
            int croissantNeighbors = 8;
            int leftoverCroissants = croissantsPrepared % croissantNeighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int marianCookieTotal = 276;
            int cookiesOnTray = 12;
            int marianTotalTrays = marianCookieTotal / cookiesOnTray;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int biteSizePretzels = 480;
            int oneServingPretzels = 12;
            int totalPretzelServings = biteSizePretzels / oneServingPretzels;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int orphanageLemonCupcakes = 53;
            int cakesLeftAtHome = 2;
            int cakesPerBox = 3;
            int boxesGivenAway = (orphanageLemonCupcakes - cakesLeftAtHome) / cakesPerBox;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int totalCarrotSticks = 74;
            int carrotPeople = 12;
            int sticksLeftUneaten = totalCarrotSticks % carrotPeople;
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int totalTeddyBears = 98;
            int bearsPerShelf = 7;
            int shelvesFilledWithBears = totalTeddyBears / bearsPerShelf;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int susiePictures = 480;
            int picsInAlbum = 20;
            int albumsNeeded = susiePictures / picsInAlbum;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int joeTradingCards = 94;
            int cardsInBox = 8;
            int boxesFilled = joeTradingCards / cardsInBox;
            int unfilledBoxesAmount = joeTradingCards % cardsInBox;
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int susieBooks = 210;
            int susieBookshelves = 10;
            int booksPerShelf = susieBooks / susieBookshelves;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int cristinaCroissants = 17;
            double cristinaCroissantGuests = 7;
            double croissantsPerGuest = cristinaCroissants / cristinaCroissantGuests;
            /*
            51. Bill and Jill are house painters. Bill can paint a standard room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 standard rooms?
            Hint: Calculate the rate at which each painter can complete a room (rooms / hour), combine those rates,
            and then divide the total number of rooms to be painted by the combined rate.
            */

            
            double billRoomsRate = 1 / 2.15;
            double jillRoomsRate = 1 / 1.90;
            double combinedRoomsRate = jillRoomsRate + billRoomsRate;
            //Console.WriteLine(combinedRoomsRate);
            int standardRooms = 5;
            double timeToCompleteFiveRooms = standardRooms / combinedRoomsRate;
           
            //Console.WriteLine(timeToCompleteFiveRooms);

            


            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */
            string firstName = "Grace";
            string middleInitial = "B";
            string lastName = "Hopper";
            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";
            //Console.WriteLine(fullName);
            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */
            decimal newYorkToChicago = 800M;
            decimal distanceTraveled = 537M;
           decimal percentageCompletedOnTrip = (distanceTraveled / newYorkToChicago) * 100;
            int percentageInInt = (int)percentageCompletedOnTrip;
           //Console.WriteLine(percentageCompletedOnTrip);
        }
    }
}
