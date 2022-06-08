$(function () {     
       $("form input").tooltipValidation({
        placement: "right"
    });

    $("form select").tooltipValidation({
        placement: "right"
    });

           
});


function obterCidadesPorEstadoBind() {

    $("#EstadoID").change(function () {
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

function buscaCep() {
    $("#Cep").blur(function () {

        //Nova variável "cep" somente com dígitos.
        var cep = $(this).val().replace(/\D/g, '');

        //Verifica se campo cep possui valor informado.
        if (cep != "") {

            //Expressão regular para validar o CEP.
            var validacep = /^[0-9]{8}$/;

            //Valida o formato do CEP.
            if (validacep.test(cep)) {

                //Consulta o webservice viacep.com.br/
                $.getJSON("//viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {

                    if (!("erro" in dados)) {
                        //Atualiza os campos com os valores da consulta.
                        $("#Endereco").val(dados.logradouro);
                        $("#Bairro").val(dados.bairro);

                    } //end if.
                    else {
                        //CEP pesquisado não foi encontrado.
                        //limpa_formulário_cep();
                        bootbox.alert("CEP não encontrado.");
                    }
                });
            } //end if.
            else {
                //cep é inválido.

                bootbox.alert("Formato de CEP inválido.");
            }
        } //end if.
        else {
            //cep sem valor, limpa formulário.

        }
    });

}

//callback de retorno de actions de salvamento
var OnSuccess = function (data) {
    bootbox.alert(data.msg);
}

function OnErro() {

    bootbox.alert("Ocorreu um erro no cadastro. Contacte o suporte!");
}
