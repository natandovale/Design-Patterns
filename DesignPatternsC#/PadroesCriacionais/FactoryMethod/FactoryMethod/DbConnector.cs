namespace FactoryMethod
{
    public abstract class DbConnector
    {
        protected string ConnectionString { get; set; }
        public abstract Connection Connect();

        protected DbConnector(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
