function obterCidadesPorEstadoBind() {
    $("#EstadoId").change(function () {
        var selectedItem = $(this).val();
        var ddlCidade = $("#Cidade");
        $.ajax({
            cache: false,
            type: "POST",
            url: "../../Estado/obterCidadePorEstado",
            data: { "estadoID": selectedItem },
            success: function (data) {
                ddlCidade.html('');
                $.each(data, function (id, option) {
                    ddlCidade.append($('<option></option>').val(option.CidadeId).html(option.Nome));
                });

            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert('Erro na requisição ao dado: ' + thrownError);


            }
        });
    });
}


$(document).ready(function () {
    obterCidadesPorEstadoBind();
    buscaCep();

    var cnpj = $("#CNPJ").val();

    if (cnpj.length > 0) {
        $('#Cidade').append($('<option selected></option>').val($('#codigoCidade').val()).html($('#nomeCidade').val()));
    }

    
    acaoCancelar();

});

function OnSuccess(mensagem) {
    bootbox.alert("Fornecedor cadastrado com sucesso.");
}

function OnErro() {
    bootbox.alert("Ocorreu um erro no cadastro. Contacte o suporte!");
}

function acaoCancelar() {
    $("#btCancelar").click(function () {
        location.href = '/Fornecedor/Index';
    });

}