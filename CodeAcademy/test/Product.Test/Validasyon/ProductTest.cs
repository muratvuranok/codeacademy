namespace Product.Test.Validasyon;

public class ProductTest : CoreData
{
    #region Old
    //[Fact]
    ////public void ProductCreateValidation_NameNullEmptyMin255_ReturnError()
    ////1) public void ProductCreateValidation_NameEmpty_ReturnError()
    ////public void ProductCreateValidation_NameNull_ReturnError()
    //public void ProductCreateValidation_NameMin255_ReturnError()
    //{
    //    // Arrange
    //    var validation = new ProductCreateValidation();
    //    var model = new P.Product
    //    {
    //        //1) ProductName = ""
    //        //2) ProductName = null
    //        ProductName = new String('*', 256)
    //    };

    //    // Act
    //    var result = validation.TestValidate(model);

    //    // Assert

    //    result.ShouldHaveValidationErrorFor(x => x.ProductName);
    //} 
    #endregion 

    [Theory, MemberData(nameof(String256))]
    //[InlineData("")]
    //[InlineData(null)]
    //[InlineData("Theory'de :) 256 karakter var sayın :)")]
    public void ProductCreateValidation_NameNullEmptyMin255_ReturnError(string productName)
    {
        // Arrange
        var validation = new ProductCreateValidation();
        var model = new P.Product
        {
            ProductName = productName
        };

        // Act
        var result = validation.TestValidate(model);

        // Assert

        result.ShouldHaveValidationErrorFor(x => x.ProductName);
    }
}
