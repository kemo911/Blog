$(document).ready(function () {
    $('.title').fadeIn(3000);


    $('#btnSubmit').click(function () {

        var data = $('#myForm').serialize();

        $.ajax({
            type: "POST",
            url: "/Blog/Send",
            data: data,
            success: function(response) {
                $.toast({
                    heading: 'Success',
                    text: response.message,
                    hideAfter: 5000,
                    textAlign: 'center',
                    position: 'bottom-center',
                    icon: 'success',
                    loader: false
                });
                $('#myForm').trigger('reset');
            }
        });
    });
});