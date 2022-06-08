function OnSuccess(response) {
    $('#divMsg').html('Dados do Convênio salvos com sucesso.');
    $('#myModal').modal('show');
}

function exibirModalErro() {

    $('#divMsg').html('Ocorreu um erro na gravação! Contacte o suporte.');
    $('#myModal').modal('show');
    
}

jQuery.fn.toggleText = function (a, b) {
    return this.html(this.html().replace(new RegExp("(" + a + "|" + b + ")"), function (x) { return (x == a) ? b : a; }));
}

$(document).ready(function () {   

    $("#ValorFilme").mask("#,##0.00", { reverse: true });
        
    
    if ($("#ConvenioID").val() > 0) {
        obterPlanos($("#ConvenioID").val());
        $('#divPlano').show();

    }


    $('.tgl').before('<span>Dados Básicos</span>');
    $('.tgl').css('display', 'none')

    $('.tgl2').before('<span>Médicos que Atendem por esse convênio</span>');
    $('.tgl2').css('display', 'none')

    $('.tgl3').before('<span>Informações de Acertos de Contrato</span>');
    $('.tgl3').css('display', 'none')

    //$('.tgl4').before('<span>Planos do Convênio</span>');
    //$('.tgl4').css('display', 'none')
    

    $('span', '#box-toggle').click(function () {
        $(this).next().slideToggle('slow')
            .siblings('.tgl:visible').slideToggle('fast');
        // aqui começa o funcionamento do plugin
        $(this).toggleText('Revelar', 'Esconder')
            .siblings('span').next('.tgl:visible').prev()
                .toggleText('Revelar', 'Esconder')
    });

    $("#AtendeRadiologia").click(function () {
       
        if ($(this).is(':checked')) {
            $('#ValorFilme').prop("disabled", false);
            $('#ValorFilme').val('21.90');
        }
        else {
            $('#ValorFilme').prop("disabled", true);
            $('#ValorFilme').val('0,00')
        }
    });

    $("#CalcularExtraCirurgia").click(function () {

        if ($(this).is(':checked')) {
            $('#HorarioSemanalHoraExtra').prop("disabled", false);
            $('#HorarioFinalSemanaHoraExtra').prop("disabled", false);
        }
        else {
            $('#HorarioSemanalHoraExtra').prop("disabled", true);
            $('#HorarioFinalSemanaHoraExtra').prop("disabled", true);
        }


        
    });

    $("#PagamentoAdicionalMedico").click(function () {

        if ($(this).is(':checked')) {
            $('#PercentualSobConsulta').prop("disabled", false);
            $('#PercentualSobProcedimento').prop("disabled", false);
        }
        else {
            $('#PercentualSobConsulta').prop("disabled", true);
            $('#PercentualSobProcedimento').prop("disabled", true);

        }

    });

    RemoveTableRow = function (item, ID) {

        removePlano(ID);

        var tr = $(item).closest('tr');
        tr.fadeOut(200, function () {
            tr.remove();
        });

        return false;
    }


})

var OnSuccessCadastro = function (data) {
    if (data.retorno == 'true' && data.msg=='') {        
        $("#Plano").html('Planos do Convênio ' + data.nomeConvenio);
        $("#ConvenioID").val(data.ID);
        $("#divPlano").show();       
        bootbox.alert('Convênio alterado.');        
    }
    else {
         bootbox.alert(data.msg);
    }
}

function obterTabelaUsada(id) {
    var tabela;

    $.ajax({
        url: "../../Convenio/obterTabelaProcedimento",
        data: {
            id: id
        },
        async: false,
        dataType: 'json',
        type: 'POST',
        success: function (result) {
                 tabela = result.nomeTabela;
           },
        error: function (xhr, ajaxOptions, thrownError) {
            bootbox.alert('Ocorre um erro na remoção do item!');


        }
    });
      
    return tabela;

}

function obterPlanos(convenioId) {
    $.ajax({
        url: "../../Convenio/obterPlanos",
        data: {
            ConvenioID: convenioId
        },
        dataType: 'json',
        type: 'POST',
        success: function (dados) {
            $(dados).each(function (i) {
                               
                var tr;               
                tr = $('<tr/>');
                tr.append("<td>" + dados[i].ConvenioPlanoID + "</td>");
                tr.append("<td>" + dados[i].DescricaoPlano + "</td>");
                               
                if (dados[i].TabelaID == null) {
                    tr.append("<td>" + $('#TabelaId :selected').text() + "</td>");
                }
                else {

                    var nomeTabela = obterTabelaUsada(dados[i].TabelaID);
                    tr.append("<td>" + nomeTabela + "</td>");
                }

                tr.append("<td>" + '<button class="btn btn-danger" onclick="RemoveTableRow(this,' + dados[i].ConvenioPlanoID + ')" type="button">Remover</button>' + "</td>");

                $('#tabelaDados').append(tr);                           

            });

            
        },
        error: function (xhr, ajaxOptions, thrownError) {
            bootbox.alert('Ocorre um erro na remoção do item!');


        }
    });


}

function removePlano(id) {
    $.ajax({
        url: "../../Convenio/ExcluirPlano",
        data: {
            id: id
        },
        dataType: 'json',
        type: 'POST',
        success: function (resultado) {
            if (resultado.retorno == 'true') {
               

            }

        },
        error: function (xhr, ajaxOptions, thrownError) {
            bootbox.alert('Ocorre um erro na remoção do item!');


        }
    });

}

function salvarPlano() {
    
    if ($("#Plano_NomePlano").val() == '')
        bootbox.alert('Preencha o nome do plano.');
    else {

        $.ajax({
            url: "../../Convenio/SalvarPlano",
            data: {
                idConvenio: $("#ConvenioID").val(), descricaoPlano: $("#Plano_NomePlano").val(),
                idTabela: $("#Plano_CodigoTabela option:selected").val()
            },
            dataType: 'json',
            type: 'POST',
            success: function (resultado) {
                if (resultado.retorno == 'true') {
                    var tr;
                    var Tabela = $('#Plano_CodigoTabela :selected').text() != 'Selecione' ? $('#Plano_CodigoTabela :selected').text() : $('#TabelaId :selected').text()

                    tr = $('<tr/>');
                    tr.append("<td>" + resultado.ID + "</td>");
                    tr.append("<td>" + resultado.plano + "</td>");
                    tr.append("<td>" + Tabela + "</td>");
                    tr.append("<td>" + '<button class="btn btn-danger" onclick="RemoveTableRow(this,' + resultado.ID + ')" type="button">Remover</button>' + "</td>");
                                            
                    $('#tabelaDados').append(tr);
                }

            },
            error: function (xhr, ajaxOptions, thrownError) {
                bootbox.alert('Erro');


            }
        });

    }

}

function Novo() {
    location.reload();
    $("#btNovo").prop('disabled', false);
}

function Finalizar() {
    location.href = '../Convenio/Mensagem';
}



