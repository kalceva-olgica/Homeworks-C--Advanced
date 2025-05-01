namespace Homework_Class1_C_Advanced;
using System.Collections.Generic;
using System.Linq;
internal class Program
    {
        static void Main(string[] args)
        {
          
            List<Product> products = new List<Product>()
         
            {    
                
                new Product(1, "iPhone 9", "An apple mobile which is nothing like apple", 549, 4.69, 94, "Apple", ProductCategory.Smartphones),
    
                new Product(2, "iPhone X", "SIM-Free, Model A19211 6.5-inch Super Retina HD display with OLED technology A12 Bionic chip with ...", 899, 4.44, 34, "Apple", ProductCategory.Smartphones),
    
                new Product(3, "Samsung Universe 9", "Samsung's new variant which goes beyond Galaxy to the Universe", 1249, 4.09, 36, "Samsung", ProductCategory.Smartphones),
    
                new Product(4, "OPPOF19", "OPPO F19 is officially announced on April 2021.", 280, 4.3, 123, "OPPO", ProductCategory.Smartphones),
   
                new Product(5, "Huawei P30", "Huawei’s re-badged P30 Pro New Edition was officially unveiled yesterday in Germany and now the device has made its way to the UK.", 499, 4.09, 32, "Huawei", ProductCategory.Smartphones),
    
                new Product(6, "MacBook Pro", "MacBook Pro 2021 with mini-LED display may launch between September, November", 1749, 4.57, 83, "Apple", ProductCategory.Laptops),
   
                new Product(7, "Samsung Galaxy Book", "Samsung Galaxy Book S (2020) Laptop With Intel Lakefield Chip, 8GB of RAM Launched", 1499, 4.25, 50, "Samsung", ProductCategory.Laptops),
   
                new Product(8, "Microsoft Surface Laptop 4", "Style and speed. Stand out on HD video calls backed by Studio Mics. Capture ideas on the vibrant touchscreen.", 1499, 4.43, 68, "Microsoft Surface", ProductCategory.Laptops),
   
                new Product(9, "Infinix INBOOK", "Infinix Inbook X1 Ci3 10th 8GB 256GB 14 Win10 Grey – 1 Year Warranty", 1099, 4.54, 96, "Infinix", ProductCategory.Laptops),
    
                new Product(10, "HP Pavilion 15-DK1056WM", "HP Pavilion 15-DK1056WM Gaming Laptop 10th Gen Core i5, 8GB, 256GB SSD, GTX 1650 4GB, Windows 10", 1099, 4.43, 89, "HP Pavilion", ProductCategory.Laptops),
    
                new Product(11, "perfume Oil", "Mega Discount, Impression of Acqua Di Gio by GiorgioArmani concentrated attar perfume Oil", 13, 4.26, 65, "Impression of Acqua Di Gio", ProductCategory.Fragrances),
   
                new Product(12, "Brown Perfume", "Royal_Mirage Sport Brown Perfume for Men & Women - 120ml", 40, 4, 52, "Royal_Mirage", ProductCategory.Fragrances),
    
                new Product(13, "Fog Scent Xpressio Perfume", "Product details of Best Fog Scent Xpressio Perfume 100ml For Men cool long lasting perfumes for Men", 13, 4.59, 61, "Fog Scent Xpressio", ProductCategory.Fragrances),
    
                new Product(14, "Non-Alcoholic Concentrated Perfume Oil", "Original Al Munakh® by Mahal Al Musk | Our Impression of Climate | 6ml Non-Alcoholic Concentrated Perfume Oil", 120, 4.21, 114, "Al Munakh", ProductCategory.Fragrances),
   
                new Product(15, "Eau De Perfume Spray", "Genuine  Al-Rehab spray perfume from UAE/Saudi Arabia/Yemen High Quality", 30, 4.7, 105, "Lord - Al-Rehab", ProductCategory.Fragrances),
  
                new Product(16, "Hyaluronic Acid Serum", "L'OrÃ©al Paris introduces Hyaluron Expert Replumping Serum formulated with 1.5% Hyaluronic Acid", 19, 4.83, 110, "L'Oreal Paris", ProductCategory.Skincare),
   
                new Product(17, "Tree Oil 30ml", "Tea tree oil contains a number of compounds, including terpinen-4-ol, that have been shown to kill certain bacteria,", 12, 4.52, 78, "Hemani Tea", ProductCategory.Skincare),
    
                new Product(18, "Oil Free Moisturizer 100ml", "Dermive Oil Free Moisturizer with SPF 20 is specifically formulated with ceramides, hyaluronic acid & sunscreen.", 40, 4.56, 88, "Dermive", ProductCategory.Skincare),
    
                new Product(19, "Skin Beauty Serum.", "Product name: rorec collagen hyaluronic acid white face serum riceNet weight: 15 m", 46, 4.42, 54, "ROREC White Rice", ProductCategory.Skincare),
   
                new Product(20, "Freckle Treatment Cream- 15gm", "Fair & Clear is Pakistan's only pure Freckle cream which helpsfade Freckles, Darkspots and pigments. Mercury level is 0%, so there are no side effects.", 70, 4.06, 140, "Fair & Clear", ProductCategory.Skincare),
    
                new Product(21, "- Daal Masoor 500 grams", "Fine quality Branded Product Keep in a cool and dry place", 20, 4.44, 133, "Saaf & Khaas", ProductCategory.Groceries),
    
                new Product(22, "Elbow Macaroni - 400 gm", "Product details of Bake Parlor Big Elbow Macaroni - 400 gm", 14, 4.57, 146, "Bake Parlor Big", ProductCategory.Groceries),
    
                new Product(23, "Orange Essence Food Flavou", "Specifications of Orange Essence Food Flavour For Cakes and Baking Food Item", 14, 4.85, 26, "Baking Food Items", ProductCategory.Groceries)



            };

        // Get all products that belong to the "Smartphones" category.

        var allSmartphones = from product in products
                             where product.Category == ProductCategory.Smartphones
                             select product;

        foreach (var product in allSmartphones)
        {
            Console.WriteLine("Smartphone:  " + product.Title);
        }


        //Select the names(titles) of all products.

        var allNamesOfTgeProducts = products.Where(product => product.Title == product.Title);

        foreach (var product in allNamesOfTgeProducts)
        {
            Console.WriteLine("Name of the product:  " + product.Title);
        }

        // Get all products with a price greater than 1000.

        var productWithPriceGreaterThanThousand = products.Where(product => product.Price > 1000);

        foreach(var product in productWithPriceGreaterThanThousand)
        {
            Console.WriteLine("Product greater than 1000 " + product.Price);
        }

        // Select the brands of all skincare products.

        var allSkincareBrands = from product in products
                             where product.Category == ProductCategory.Skincare
                             select product;

        foreach (var product in allSkincareBrands)
        {
            Console.WriteLine("Skincar Product:  " + product.Brand);
        }

        // Get the first product that has a rating above 4.8.

        var firstTopRatedProduct = products.FirstOrDefault(product => product.Rating > 4.8);

        Console.WriteLine(firstTopRatedProduct != null
            ? $"Title of the product: {firstTopRatedProduct.Title},rating: {firstTopRatedProduct.Rating}"
            : "There is no product here!!");

        // Get all products that are out of stock (stock equal to 0).

        var allProductsOutOfStock = from product in products
                                    where product.Stock == 0
                                    select product;

        foreach(var product in allProductsOutOfStock)
        {
            Console.WriteLine("All products that are out of stock: " + product.Stock); // ne mi vrakja nisto bidejki nema proizvodi sto se out of stock ili ednakvi na 0, testirav so stock > 100, i mi vrati rezultati taka
        }

        // Select the prices of all fragrance products.
        var pricesOfAllFragranceProducts = from product in products
                                           where product.Category == ProductCategory.Fragrances
                                           select product;

        foreach (var product in pricesOfAllFragranceProducts)
        {
            Console.WriteLine("Prices of all fragrance products  " + product.Price);
        }

        // Retrieve the description of the first product with a rating equal to 4.43.
        var desc = products.FirstOrDefault(product => product.Rating > 4.8);

        Console.WriteLine(desc != null
            ? $"Description of the product: {desc.Description},rating: {desc.Rating}"
            : "There is no product here!!");

        // Get the title of the last Skincare product with a price under $50.

        var lastSkinCareProductWithPriceUnderFfifty = products.LastOrDefault(product => product.Price < 50); // znam deka mozebi ne treba tolku dolgi iminja na variabli no deka e za domasno pa da imate pocista preglednost :)

        Console.WriteLine(desc != null
            ? $"Title of the product: {desc.Title}, Price : {desc.Price}"
            : "There is no product here!!");

        // Get the title of the first product in the Fragrances category with a price above $100.

        var expensiveFragrance = products.FirstOrDefault(p =>
             p.Category == ProductCategory.Fragrances && p.Price > 100);

         Console.WriteLine(expensiveFragrance != null
            ? $"Title: {expensiveFragrance.Title}"
            : "There is no fragrance over $100");


        // Select the brand of the last product that has a stock lower than 40.
        var lowStockProduct = products.LastOrDefault(p => p.Stock < 40);

        Console.WriteLine(lowStockProduct != null
            ? $"Brand:; {lowStockProduct.Brand}"
            : "There is no product found with stock lower than 40");

        // Select the title of the first Laptop that has a stock greater than 80.

        var firstLaptopWithStockAboveEighty = products.FirstOrDefault(p =>
            p.Category == ProductCategory.Laptops && p.Stock > 80);

        Console.WriteLine(firstLaptopWithStockAboveEighty != null
            ? $"Title: {firstLaptopWithStockAboveEighty.Title}"
            : "There is no laptop found with stock greater than 80");

        // Retrieve the title of the first product that has a price above $1200.

        var expensiveProduct = products.FirstOrDefault(p => p.Price > 1200);

        Console.WriteLine(expensiveProduct != null
            ? $"Title: {expensiveProduct.Title}"
            : "There is no product found with price above $1200");

        // Select the stock count of the last product that belongs to the Smartphones category.
        var lastSmartphone = products.LastOrDefault(p => p.Category == ProductCategory.Smartphones);

        Console.WriteLine(lastSmartphone != null
            ? $"Stock: {lastSmartphone.Stock}"
            : "No smartphone founded");




    }


}

