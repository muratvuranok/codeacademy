namespace SignalRApp.Repositories;

public class ProductRepository : IProductRepository
{
    #region Constructor
    private readonly IConfiguration _configuration;
    private readonly IHubContext<SignalServer> _context;

    public ProductRepository(
        IConfiguration configuration,
        IHubContext<SignalServer> context
        )
    {
        this._context = context;
        this._configuration = configuration;
    }
    #endregion

    public List<Product> GetAll()
    {
        string connectionString = _configuration.GetConnectionString("DefaultConnection");

        var products = new List<Product>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            SqlDependency.Start(connectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select [Id], [ProductName], [Description], [UnitsInStock], [UnitPrice] from Products";
            cmd.Connection = connection;


            SqlDependency dependency = new SqlDependency(cmd);
            dependency.OnChange += new OnChangeEventHandler(Dependency_OnChange);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var product = new Product
                {
                    Id = reader.GetInt32("id"),
                    ProductName = reader.GetString("ProductName"),
                    Description = reader.GetString("Description"),
                    UnitPrice = reader.GetDecimal("UnitPrice"),
                    UnitsInStock = reader.GetInt16("UnitsInStock")
                };

                products.Add(product);
            };

            return products;
        }
    }

    private void Dependency_OnChange(object sender, SqlNotificationEventArgs e)
    {
        _context.Clients.All.SendAsync("refreshFilterCoffe");
    }
}