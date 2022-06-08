$(document).ready(function () {

    $("#ValorUCO").mask("#,##0.00", { reverse: true });
    $("#NovoValorAcordado").mask("#,##0.00", { reverse: true });


    $('#NomeProcedimento').on('autocompletechange change', function () {
        //$('#tagsname').html('You selected: ' + this.value);
        $("#CodigoProcedimento").val(this.value.substring(0, 8));
        $("#ValorUCO").focus();

    }).change();


    loadBusca();
    //bindCampoCodigo();

    $("#btSalvar").click(function () {
        SalvarItens();

    });

    $("#btNovaBusca").click(function () {
        novaPesquisa();

    });

    if ($("#hdCodigoTabela").val() > 0) {
        bindItens($("#hdCodigoTabela").val());
    }


})

//function bindCampoCodigo() {
//    $("#NomeProcedimento").blur(function () {
//        var codigo = $("#NomeProcedimento").val();
//        $("#CodigoProcedimento").val(codigo.substring(0, 8));
       
//    })
//}



function loadBusca() {

    $("#NomeProcedimento").autocomplete({
        minLength: 3,
        //delay: 200,
        source: function (request, response) {
            $.ajax({
                url: "/TabelaDerivada/obterProcedimentosCBHPM",
                type: "POST",
                dataType: "json",               
                data: { parametro: request.term },
                success: function (data) {                    
                    response($.map(data, function (item) {
                        return {
                            label: item.Codigo + '-' + item.Procedimento + ' Valor do UCO ' + item.ValorUCO
                           
                        };
                        
                    }))

                   
                }
            })
        },
        messages: {
            noResults: "", results: ""
        }
    });
}

var Items = new Object();
Items.ItemTabelaViewModel = new Array();


function adicionarColuna() {

    var codigoProcedimento;
    var nomeTabela;
    var ValorUCO;
    var novoValor;
    var TabelaBaseID;

    codigoProcedimento = $("#CodigoProcedimento").val();
    nomeTabela = $("#NomeTabela").val();

    if ($("#ValorUCO").val() == '')
        ValorUCO = 0;
    else
        ValorUCO = $("#ValorUCO").val();
    TabelaBaseID = 1;
    novoValor = $("#NovoValorAcordado").val();


    if ((nomeTabela == '') || (codigoProcedimento == '') || (novoValor == '')) {
        bootbox.alert('Preencha os campos Nome da Tabela,Código Procedimento e Novo valor para a nova tabela.');
    }

    else {

        if (findLista(codigoProcedimento)) {
            bootbox.alert('Procedimento já adicionado a nova tabela.');
        }

        else {

            Items.ItemTabelaViewModel.push(new Object({
                Procedimento: codigoProcedimento, Tabela: nomeTabela, ValorUCO: ValorUCO, NovoValor: novoValor,
                TabelaBaseID: TabelaBaseID
            }
                ));


            AddTableRow(codigoProcedimento, nomeTabela, ValorUCO, novoValor, TabelaBaseID);

        }

    }
    ////$("#resultado").empty();
    //$(Items.ItemComissaoViewModel).each(function () {
    //    //$("#resultado").append('Convenio ' + this.NomeConvenio + " -" + 'Código ' + this.ConvenioId + "<br>");

}

function habilitaBotao() {
    if ($(Items.ItemTabelaViewModel.length > 0))
        $('#btSalvar').removeAttr("disabled");
    else
        $('#btSalvar').attr('disabled', 'disabled');
}

function novaPesquisa() {

    $("#CodigoProcedimento").val('');
    $("#NomeProcedimento").val('');

}

(function ($) {
    AddTableRow = function (Procedimento, nomeTabela, ValorUCO, NovoValor, TabelaBaseID) {

        var newRow = $("<tr>");
        var cols = "";
        cols += '<td>' + Procedimento + '</td>';
        cols += '<td>' + ValorUCO + '</td>';
        cols += '<td>' + NovoValor + '</td>';
        //cols += '<td>' + TabelaBaseID + '</td>';      
        cols += '<td>';
        cols += '<button class="btn btn-danger" onclick="RemoveTableRow(this,' + Procedimento + ')" type="button">Remover</button>';
        cols += '</td>';

        newRow.append(cols);
        $("#tabelaDados").append(newRow);

        $('#btSalvar').removeAttr("disabled");

        $("#CodigoProcedimento").val('');       
        $("#ValorUCO").val('');
        $("#NovoValorAcordado").val('');
        $("#NomeProcedimento").val('');

        return false;
    };
})(jQuery);


(function ($) {
    RemoveTableRow = function (item, ID) {
        
        if ($("#hdCodigoTabela").val() > 0) {
            RemoveItem(ID);
        }

        var index = Items.ItemTabelaViewModel.indexOf(ID.toString());

        if(index>0)
            Items.ItemTabelaViewModel.splice(index, 1);

        //alert(Items.ItemTabelaViewModel.length);

        var tr = $(item).closest('tr');
        tr.fadeOut(200, function () {
            tr.remove();
        });


        //if (Items.ItemTabelaViewModel.length == 0)
        //    $('#btSalvar').attr('disabled', 'disabled');

        return false;
    }
})(jQuery);


function findLista(codigoProcedimeto) {

    var achou = false;

    for (var cont1 = 0; cont1 < Items.ItemTabelaViewModel.length; cont1++) {
        if (Items.ItemTabelaViewModel[cont1]["Procedimento"] == codigoProcedimeto)
            achou = true;
    }

    return achou;
}

function RemoveItem(id) {

    $.ajax({
        url: "../../TabelaDerivada/removerItem",
        data: {
            id: id
        },
        dataType: 'json',
        type: 'POST',
        success: function (resultado) {          
                bootbox.alert(resultao.Msg);                       
        },
        error: function (xhr, ajaxOptions, thrownError) {
            bootbox.alert('Ocorre um erro na remoção do item!');
        }
    });


}

function bindItens(id) {

    $.ajax({
        url: "../../TabelaDerivada/obterItensTabelaProcedimento",
        data: {
            id: id
        },
        dataType: 'json',
        type: 'POST',
        success: function (dados) {
            $(dados).each(function (i) {

                var tr;
                tr = $('<tr/>');
                tr.append("<td>" + dados[i].CodigoProcedimento + "</td>");
                tr.append("<td>" + dados[i].ValorUCO.toFixed(2) + "</td>");
                tr.append("<td>" + dados[i].NovoValor.toFixed(2) + "</td>");
                               
                tr.append("<td>" + '<button class="btn btn-danger" onclick="RemoveTableRow(this,' + dados[i].TabelaDerivadaCobrancaProcedimentoItemID + ')" type="button">Remover</button>' + "</td>");

                $('#tabelaDados').append(tr);
                $('#divPlano').show();

            });


        },
        error: function (xhr, ajaxOptions, thrownError) {
            bootbox.alert('Ocorre um erro na obtenção dos registros!');


        }
    });

}

function SalvarItens() {

    if (Items.ItemTabelaViewModel.length == 0)
        bootbox.alert('Preencha os procedimentos para a nova tabela');

    else {
        var dados = $.toJSON(Items);

        $.ajax({
            url: "../../TabelaDerivada/Salvar",
            data: { Items: dados },
            dataType: 'json',
            type: 'POST',
            success: function (resultado) {

                $("#CodigoProcedimento").val('');
                $("#NomeTabela").val('');
                $("#ValorUCO").val('');
                $("#NovoValorAcordado").val('');
                 
                Items.ItemTabelaViewModel.splice(0, Items.ItemTabelaViewModel.length)
                $("#tabelaDados tbody tr").remove();

                bootbox.alert(resultado.Msg);
            },
            error: function (xhr, ajaxOptions, thrownError) {
                OnErro();


            }
        });

    }

}