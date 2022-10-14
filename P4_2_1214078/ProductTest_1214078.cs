using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214078
{
    internal class ProductTest_1214078
    {
        static void Main(string[] args)
        {

            //--------------------------------------
            No1Miya_1214078 product1 = new No1Miya_1214078("Miya", "Marksman");
            No2Balmon_1214078 product2 = new No2Balmon_1214078("Balmond", "Fighter");
            No3Saber_1214078 product3 = new No3Saber_1214078("Saber", "Assasin");
            No4Nana_1214078 product4 = new No4Nana_1214078("Nana", "Mage");
            No5Tigreal_1214078 product5 = new No5Tigreal_1214078("Tigreal", "Tank");
            No6Alucard_1214078 product6 = new No6Alucard_1214078("Alucard", "Fighter/Assasin");
            No7Akai_1214078 product7 = new No7Akai_1214078("Akai", "Tank/Support");
            No8Franco_1214078 product8 = new No8Franco_1214078("Franco", "Tank/Support");
            No9Bane_1214078 product9 = new No9Bane_1214078("Bane", "Fighter");
            No10Bruno_1214078 product10 = new No10Bruno_1214078("Bruno", "Marksman");
            No11Clint_1214078 product11 = new No11Clint_1214078("Clint", "Marksman");
            No12Rafaela_1214078 product12 = new No12Rafaela_1214078("Rafaela", "Tank/Support");
            No13Eudora_1214078 product13 = new No13Eudora_1214078("Eudora", "Mage");
            No14Zilong_1214078 product14 = new No14Zilong_1214078("Zilong", "Fighter");
            No15Fanny_1214078 product15 = new No15Fanny_1214078("Fanny", "Assasin");
            /*No16Layla_1214078 product16 = new No16Layla_1214078("Layla", "Marksman");
            No17Hayabusa_1214078 product17 = new No17Hayabusa_1214078("Bruno", "Assasin");
            No18Gord_1214078 product18 = new No10Bruno_1214078("Bruno", " Marksman");
            No19Kagura_1214078 product19 = new No10Bruno_1214078("Bruno", " Marksman");
            No20Chou_1214078 product20 = new No10Bruno_1214078("Bruno", " Marksman");
            No21Sun_1214078 product21 = new No10Bruno_1214078("Bruno", " Marksman");
            No22Alpha_1214078 product22 = new No10Bruno_1214078("Bruno", " Marksman");
            No23YSS_1214078 product23 = new No10Bruno_1214078("Bruno", " Marksman");
            No24Moskov_1214078 product24 = new No10Bruno_1214078("Bruno", " Marksman");
            No25Cyclops_1214078 product25 = new No10Bruno_1214078("Bruno", " Marksman");
            No26Estes_1214078 product26 = new No10Bruno_1214078("Bruno", " Marksman");
            No27Lapu_1214078 product27 = new No10Bruno_1214078("Bruno", " Marksman");
            No28Roger_1214078 product28 = new No10Bruno_1214078("Bruno", " Marksman");
            No29Karrie_1214078 product29 = new No10Bruno_1214078("Bruno", " Marksman");
            No30Gatot_1214078 product30 = new No10Bruno_1214078("Bruno", " Marksman");
            No31Harley_1214078 product31 = new No10Bruno_1214078("Bruno", " Marksman");
            No32Odette_1214078 product32 = new No10Bruno_1214078("Bruno", " Marksman");
            No33Lancelot_1214078 product33 = new No10Bruno_1214078("Bruno", " Marksman");
            No34Pharsa_1214078 product34 = new No10Bruno_1214078("Bruno", " Marksman");
            No35Jawhead_1214078 product35 = new No10Bruno_1214078("Bruno", " Marksman");
            No36Angela_1214078 product36 = new No10Bruno_1214078("Bruno", " Marksman");
            No37Gusion_1214078 product37 = new No10Bruno_1214078("Bruno", " Marksman");
            No38Uranus_1214078 product38 = new No10Bruno_1214078("Bruno", " Marksman");
            No39Change_1214078 product39 = new No10Bruno_1214078("Bruno", " Marksman");
            No40Selena_1214078 product40 = new No10Bruno_1214078("Bruno", " Marksman");
            No41Aldous_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No41Claude_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No43Vale_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No44Leomord_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No45Lunox_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No46Hanzo_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No47Kimmy_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No48Thamuz_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No49Faramis_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No50Granger_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No51Guiniver_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No52Ling_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No53Lylia_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No54Wanwan_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No55Cecilion_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No56Atlas_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No57Yuzhong_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No58Luoyi_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No59Brody_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No60Paquito_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");
            No61Silvana_1214078 product10 = new No10Bruno_1214078("Bruno", " Marksman");*/



            Console.WriteLine("1. Ini dari Clas Miya");
            Console.WriteLine("Product 1 is a {0} called \"{1}\" and {2} as his role", product1.MyType, product1.MyTitle, product1.Role);

            Console.WriteLine("");

            Console.WriteLine("2. Ini dari Class Balmon");
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and {2} as his role", product2.MyType, product2.MyTitle, product2.Role);

            Console.WriteLine("");

            Console.WriteLine("3. Ini dari Class Saber");
            Console.WriteLine("Product 3 is a {0} called \"{1}\" and {2} as his role", product3.MyType, product3.MyTitle, product3.Role);

            Console.WriteLine("");

            Console.WriteLine("4. Ini dari Class Nana");
            Console.WriteLine("Product 4 is a {0} called \"{1}\" and {2} as his role", product4.MyType, product4.MyTitle, product4.Role);

            Console.WriteLine("");

            Console.WriteLine("5. Ini dari Class Tigreal");
            Console.WriteLine("Product 5 is a {0} called \"{1}\" and {2} as his role", product5.MyType, product5.MyTitle, product5.Role);

            Console.WriteLine("");

            Console.WriteLine("6. Ini dari Class Alucard");
            Console.WriteLine("Product 6 is a {0} called \"{1}\" and {2} as his role", product6.MyType, product6.MyTitle, product6.Role);

            Console.WriteLine("");

            Console.WriteLine("7. Ini dari Class Akai");
            Console.WriteLine("Product 7 is a {0} called \"{1}\" and {2} as his role", product7.MyType, product7.MyTitle, product7.Role);

            Console.WriteLine("");

            Console.WriteLine("8. Ini dari Class Franco");
            Console.WriteLine("Product 8 is a {0} called \"{1}\" and {2} as his role", product8.MyType, product8.MyTitle, product8.Role);

            Console.WriteLine("");

            Console.WriteLine("9. Ini dari Class Bane");
            Console.WriteLine("Product 9 is a {0} called \"{1}\" and {2} as his role", product9.MyType, product9.MyTitle, product9.Role);

            Console.WriteLine("");

            Console.WriteLine("10. Ini dari Class Bruno");
            Console.WriteLine("Product 10 is a {0} called \"{1}\" and {2} as his role", product10.MyType, product10.MyTitle, product10.Role);

            Console.WriteLine("");

            Console.WriteLine("11. Ini dari Class Clint");
            Console.WriteLine("Product 10 is a {0} called \"{1}\" and {2} as his role", product10.MyType, product10.MyTitle, product10.Role);

            Console.WriteLine("");

            Console.WriteLine("12. Ini dari Class Rafaela");
            Console.WriteLine("Product 10 is a {0} called \"{1}\" and {2} as his role", product10.MyType, product10.MyTitle, product10.Role);

            Console.WriteLine("");

            Console.WriteLine("13. Ini dari Class Eudora");
            Console.WriteLine("Product 10 is a {0} called \"{1}\" and {2} as his role", product10.MyType, product10.MyTitle, product10.Role);

            Console.WriteLine("");

            Console.WriteLine("14. Ini dari Class Zilong");
            Console.WriteLine("Product 10 is a {0} called \"{1}\" and {2} as his role", product10.MyType, product10.MyTitle, product10.Role);

            Console.WriteLine("");

            Console.WriteLine("15. Ini dari Class Fanny");
            Console.WriteLine("Product 10 is a {0} called \"{1}\" and {2} as his role", product10.MyType, product10.MyTitle, product10.Role);

            Console.WriteLine("");

            /*Console.WriteLine("11. Ini dari Class Clint");
            Console.WriteLine("Product 10 is a {0} called \"{1}\" and {2} as his role", product10.MyType, product10.MyTitle, product10.Role);

            Console.WriteLine("");

            Console.WriteLine("11. Ini dari Class Clint");
            Console.WriteLine("Product 10 is a {0} called \"{1}\" and {2} as his role", product10.MyType, product10.MyTitle, product10.Role);

            Console.WriteLine("");

            Console.WriteLine("11. Ini dari Class Clint");
            Console.WriteLine("Product 10 is a {0} called \"{1}\" and {2} as his role", product10.MyType, product10.MyTitle, product10.Role);

            Console.WriteLine("");

            Console.WriteLine("11. Ini dari Class Clint");
            Console.WriteLine("Product 10 is a {0} called \"{1}\" and {2} as his role", product10.MyType, product10.MyTitle, product10.Role);

            Console.WriteLine("");*/

            

            Console.ReadKey();

            //--------------------------------

        }
    }
}
