namespace G19_ProductImport
{
    public class DatabaseImporter
    {
        private readonly string _connectionString;

        public DatabaseImporter(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }

        public void ImportData(IEnumerable<Category> categories)
        {
            throw new NotImplementedException();
        }
    }
}