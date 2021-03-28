$(function () {
    let cookieVal = Cookies.get("cartItem")
    if (typeof cookieVal !== "undefined" && cookieVal !== '') {
        cookieVal = [...cookieVal.split('-')]
        $(".header-action-num").text(cookieVal.length);
    }
    var productIds = cookieVal ?? [];
    
    $(".add-to-cart").click(function () {
        const productId = $(this).attr("alis");
        productIds.push(productId)
        $(".header-action-num").text(productIds.length);
        CartAdded()
    })


    $(".add-cart").click(function () {
        const productId = $(this).attr("alis");

        const inputVal = $(".cart-plus-minus-box").val()
        for (var i = 0; i < inputVal; i++) {
            productIds.push(productId)
        }
        $(".header-action-num").text(productIds.length);
        CartAdded();
    })

    function CartAdded() {
        Cookies.set("cartItem", productIds.join('-'))
        Swal.fire({
            position: 'bottom-end',
            icon: 'success',
            title: 'Product added to cart',
            showConfirmButton: false,
            timer: 1500
        })
    }
})


