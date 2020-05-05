using System;
using System.Collections;

namespace SoftwareEducationalService
{
    class Program
    {
        static void Main(string[] args)
        {
            Collections collection1 = new Collections("Chromatography", "Soji", "Chemistry", 4, "Primary");
            Collections collection2 = new Collections("Lemon Volcano", "Samuel", "Physics", 2, "Higher");
            Collections collection3 = new Collections("DIY Bouncy Balls", "Ifeanyi", "Integrated Science", 1, "Labs");
            Collections collection4 = new Collections("Shiny Pennies", "Abayomi", "Chemistry", 1, "Higher");
            Collections collection5 = new Collections("Regrow Vegetable Scraps", "Gozie", "Agric", 3, "Primary");
            Collections collection6 = new Collections("DIY Stethoscope", "Buhary", "Physics", 2, "Labs");
            Collections collection7 = new Collections("Simple Circuit", "Bankole", "Physics", 2, "Primary");
            Collections collection8 = new Collections("Exploring Density with Salt", "Fatai", "Geography", 4, "Higher");
            Collections collection9 = new Collections("Rainbow Rubber Eggs", "Michael", "Maths", 3, "Labs");
            Collections collection10 = new Collections("Magic Rollback Can", "Tolu", "Futher Maths", 1, "Primary");
            Collections collection11 = new Collections("Bleeding Blossoms", "Grace", "Biology", 5, "Labs");
            Collections collection12 = new Collections("Teleidoscopes", "Faith", "Integrated Science", 3, "Higher");
            Collections collection13 = new Collections("Density Tower", "May", "Physics", 5, "Primary");
            Collections collection14 = new Collections("Magnet Magic", "John", "Chemistry", 4, "Labs");
            Collections collection15 = new Collections("Overnight Crystals", "Caleb", "Geography", 5, "Higher");

            ArrayList list = new ArrayList(15);
            list.Add(collection1);
            list.Add(collection2);
            list.Add(collection3);
            list.Add(collection4);
            list.Add(collection5);
            list.Add(collection6);
            list.Add(collection7);
            list.Add(collection8);
            list.Add(collection9);
            list.Add(collection10);
            list.Add(collection11);
            list.Add(collection12);
            list.Add(collection13);
            list.Add(collection14);
            list.Add(collection15);

            list.RemoveAt(3);
            foreach(Collections item in list)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine($"{list.Count}");

            Hashtable col1 = new Hashtable();
            col1.Add(60, "58 2000");
            col1.Add(70, "67 2001");
            col1.Add(50, "45 2000");
            col1.Add(90, "85 2001");
            col1.Add(80, "76 2000");
            col1.Add(69, "64 2001");
            col1.Add(78, "69 2000");
            col1.Add(53, "46 2001");
            col1.Add(66, "60 2000");
            col1.Add(93, "87 2001");
            col1.Add(59, "57 2000");
            col1.Add(72, "68 2001");
            col1.Add(87, "83 2000");
            col1.Add(47, "55 2001");
            col1.Add(57, "56 2000");
             ICollection objCollection = col1.Keys;

            for(var i = 0; i < col1.Count; i++)
            {
                foreach(var item in objCollection){
                    if( > 70)
                }
            }


            

        }
    }
}
