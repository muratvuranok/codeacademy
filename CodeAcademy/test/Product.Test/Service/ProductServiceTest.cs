using MockQueryable.Moq;

namespace Product.Test.Service;

public class ProductServiceTest
{
    private readonly ProductService _sut;
    private readonly Mock<IProductRepository> _productRepositoryMock;
    public ProductServiceTest()
    {
        this._productRepositoryMock = new Mock<IProductRepository>();
        this._sut = new ProductService(_productRepositoryMock.Object);


        this._productRepositoryMock.Setup(x => x.Table).Returns(new List<P.Product>
        {
            new P.Product{ Id = Guid.Parse("bfb68e87-e5e8-4566-b350-7d707fd42d15"), ProductName = "Urun Adi 1", UnitPrice = 10, UnitsInStock = 20},
            new P.Product{ Id = Guid.Parse("67e80044-f1ca-4856-9ccb-d1fd6185a096"), ProductName = "Urun Adi 2", UnitPrice = 10, UnitsInStock = 20},
            new P.Product{ Id = Guid.Parse("63643e7a-5796-476c-90aa-b61fd373fcc3"), ProductName = "Urun Adi 3", UnitPrice = 10, UnitsInStock = 20},
            new P.Product{ Id = Guid.Parse("1b66b2da-58f9-4094-8805-0e8596d7131f"), ProductName = "Urun Adi 4", UnitPrice = 10, UnitsInStock = 20},
            new P.Product{ Id = Guid.Parse("8db19849-2033-4c9f-91bb-150a4c425286"), ProductName = "Urun Adi 5", UnitPrice = 10, UnitsInStock = 20}
        }.BuildMock());
    }



    [Fact]
    public async Task CreateProductReturnProduct()
    {
        // Arrange 
        var product = new P.Product
        {
            Id = Guid.NewGuid(),
            ProductName = "Test Product",
            UnitPrice = 30,
            UnitsInStock = 50
        };


        // Act 
        var result = await this._sut.CreateAsync(product);


        // Assert
        Assert.Equal("Test Product", result.ProductName);
        Assert.Equal(30, product.UnitPrice);
        Assert.Equal(50, product.UnitsInStock);
        Assert.NotEqual(Guid.NewGuid(), product.Id);
    }

    [Fact]
    public async Task GetAllProductReturnProducts()
    {
        // Arrange 

        // Act 
        var result = await this._sut.GetAllAsync();

        // Assert

        Assert.NotNull(result);
        Assert.Equal(5, result.Count());
    }
}
