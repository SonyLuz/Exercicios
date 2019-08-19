
$('#carregar').click(function () {
    $.ajax({
        url: window.location.origin + "/Home/CarregarListJson",
        type:"GET",
        contentType: "application/json",
        success: function (data) {
            var obj = JSON.parse(data);
            if (obj !== undefined && obj !== '') {
                var option = '<option>Selecione a Cidade</option>';
                obj.Cidades.forEach(function (item) {
                    option += '<option value="' + item + '"> '+item+'</option > ';                    
                });
                $('#cx-select').html(option).show();
            }
        },
        fail: function (data) {
            alert(data);
        }
    });
});