namespace G19_ProductImport
{
    public static class FileManager
    {
        public static IEnumerable<Category> ReadData(string filePath)
        {
            if (filePath == null) throw new ArgumentNullException(nameof(filePath));
            if (!File.Exists(filePath)) throw new FileNotFoundException("File not found.", filePath);

            var categories = new List<Category>();
            // var categories2 = new Dictionary<string, Category>();
            using var reader = new StreamReader(filePath);
            while (!reader.EndOfStream)
            {
                string[] parts = reader.ReadLine()!.Split('\t');
                Category category = GetCategoryFromList(Category.GetCategory(parts), categories);
                Product product = Product.GetProduct(parts);
                category.Products.Add(product);
            }

            return categories;
        }

        //TODO: vifiqrot siswrafis optimizaciaze. ecadet gadaaketot logika dictionary-ze
        private static Category GetCategoryFromList(Category category, List<Category> categories)
        {
            foreach (var item in categories)
            {
                if (item.Name == category.Name)
                {
                    return item;
                }
            }

            categories.Add(category);
            return category;
        }

    }
}