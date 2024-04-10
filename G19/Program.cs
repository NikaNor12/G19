namespace G19_ProductImport
{
    internal class Program
    {
        static void Main()
        {
            const string filePath = @"D:\products.txt";
            const string connectionString = "Server=.;Database=ProductImport;Integrated Security=True;";

            try
            {
                var categories = FileManager.ReadData(filePath);
                foreach (var category in categories)
                {
                    Console.WriteLine(category);
                    foreach(var product in category.Products)
                    {
                        Console.WriteLine($"\t{product}");
                    }
                }

                //importer.ImportData(categories);
                //var importer = new DatabaseImporter(connectionString);
                //Console.WriteLine("Data imported.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}