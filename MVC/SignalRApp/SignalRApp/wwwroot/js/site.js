$(() => {
 
    let connection = new signalR.HubConnectionBuilder().withUrl("/signalServer").build()
    connection.start(); 

    connection.on("refreshFilterCoffe", function () {
        loadProducts();
    });  

    loadProducts(); 
    function loadProducts() {
         
        var tr = '';
        $.ajax({
            url: '/Home/Products',
            method: 'GET',
            success: (result) => {

                console.log(result)
                $.each(result, (key, value) => {
                    tr = tr + `<tr>   
                                   <td> ${value.id}           </td>
                                   <td> ${value.productName}  </td>
                                   <td> ${value.description}  </td>
                                   <td> ${value.unitsInStock} </td>
                                   <td> ${value.unitPrice}    </td>
                               </tr>`;
                })
                $('#products').html(tr);
            },
            error: (result) => {
                console.log(result);
            }
        })
    }
});