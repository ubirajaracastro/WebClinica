function OnSuccessAnamnese(response) {
    $('#divMsg').html('Modelo do Anamnese salvo com sucesso.');
    $('#myModal').modal('show');
}

function OnSuccessPergunta(response) {
    $('#divMsg').html('Pergunta do Anamnese salva com sucesso.');
    $('#myModal').modal('show');
}

function exibirModalErro() {
    $('#divMsg').html('Ocorreu um erro na gravação! Contacte o suporte.');
    $('#myModal').modal('show');
}

function closeModal() {
    $('#modal').hide();

}

var Items = new Object();
Items.ItensRespostaModel = new Array();

$(document).ready(function () {

    $("#btFechar").click(function () {
        closeModal();
    });

    $(".close").click(function () {
        closeModal();
    });

});

function mostrarDivdeAlternativas() {
    $("#TipoPergunta").change(function () {
        var tipoPergunta = $("#TipoPergunta option:selected").val();

        if (tipoPergunta == 4)
            $("#divAlternativas").show();
        else
            $("#divAlternativas").css('display', 'none');
    })
}

function adicionarColuna() {
    var descricaoResposta;
    AddTableRow();
}

(function ($) {
    AddTableRow = function () {
        var id;
        var newRow = $("<tr>");
        var cols = "";
        cols += '<td><input type=text style="width: 700px;" id=txtDescricao name=txtDescricao/></td>';
        //cols += '<td><input type=checkbox id=chkAtivo checked/></td>';               
        cols += '<td>';
        cols += '<button class="btn btn-danger" onclick="RemoveTableRow(this)" type="button">Remover</button>';
        cols += '</td>';

        newRow.append(cols);
        $("#tabelaDados").append(newRow);
        $('#btSalvar').removeAttr("disabled");

        return false;
    };
})(jQuery);

(function ($) {
    RemoveTableRow = function (item) {

        //var index = Items.ItemRespostaModel.indexOf(resposta);
        //Items.ItemRespostaModel.splice(index, 1);


        //alert(Items.ItemComissaoViewModel.length);

        var tr = $(item).closest('tr');
        tr.fadeOut(200, function () {
            tr.remove();
        });

        if (Items.ItemRespostaModel.length == 0)
            $('#btSalvar').attr('disabled', 'disabled');

        return false;
    }
})(jQuery);

function findLista(resposta) {

    var achou = false;

    for (var cont1 = 0; cont1 < Items.ItemRespostaModel.length; cont1++) {
        if (Items.ItemComissaoViewModel[cont1]["DescricaoResposta"] == resposta)
            achou = true;
    }

    return achou;
}

function validateFields() {

    var descricaoPergunta = $("#Descricao").val();
    var tipoPergunta = $("#TipoPergunta option:selected").val();

    if (descricaoPergunta == '') {
        bootbox.alert("O campo Descrição da Pergunta é obrigatório.");
        return false;
    }

    if (tipoPergunta == '') {
        bootbox.alert("O campo Tipo da Pergunta é obrigatório.");
        return false;
    }   

    return true;
}


function SalvarPergunta() {

    if (validateFields()) {

        if ($("#TipoPergunta option:selected").val() == 4) {

            // Pegar todas as linhas da tabela #tabela que contém um input ou um select (para evitar linhas desnecessárias, como o cabeçalho)
            // Passo 1.
            $('table#tabelaDados tr:has(input,select)').each(function () {
                var self = $(this);
                Items.ItensRespostaModel.push({
                    DescricaoResposta: self.find('#txtDescricao').val(),
                    DescricaoPergunta: $('#Descricao').val(),
                    TipoPergunta: $("#TipoPergunta option:selected").val()
                });
            });

        }
        else {
            Items.ItensRespostaModel.push({
                DescricaoPergunta: $('#Descricao').val(),
                TipoPergunta: $("#TipoPergunta option:selected").val()
            });
        }

        var dados = $.toJSON(Items);

        $.ajax({
            url: "../../Pergunta/Salvar",
            data: { Items: dados },
            dataType: 'json',
            type: 'POST',
            success: function (resultado) {

                Items.ItensRespostaModel = [];
                $("#TabelaDados tr").remove();
                $('#Descricao').val('');

                bootbox.alert(resultado.Msg);

            },
            error: function (xhr, ajaxOptions, thrownError) {
                bootbox.alert("Ocorreu um erro no cadastro. Contacte o suporte!");

            }
        });
    }

}



