$(document).ready(function () {
    obterDadosPorConvenio();
    $("#ddlProcedimento").removeAttr("disabled");
    $("#ddlProfissional").removeAttr("disabled");

});

function obterDadosPorConvenio() {
    $("#ConvenioId").change(function () {
        var selectedItem = $(this).val();
        var ddlProcedimento = $("#ddlProcedimento");
        //ddlProcedimento.html('');
        $.ajax({
            cache: false,
            type: "POST",
            url: "../../Comissao/obterProcedimentoPorConvenio",
            data: { "ConvenioID": selectedItem },
            success: function (data) {
                ddlProcedimento.html('');
                $.each(data, function (id, option) {
                    ddlProcedimento.append($('<option></option>').val(option.ProcedimentoId).html(option.Descricao));
                    $('#ddlProcedimento option[value=0]').attr({ selected: "selected" });
                });

            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert('Erro na requisição ao dado: ' + thrownError);


            }

            
        });

        var ddlProfissonal = $("#ddlProfissional");
        $.ajax({
            cache: false,
            type: "POST",
            url: "../../Comissao/obterProfissionalPorConvenio",
            data: { "ConvenioID": selectedItem },
            success: function (data) {
                ddlProfissonal.html('');
                $.each(data, function (id, option) {
                    ddlProfissonal.append($('<option></option>').val(option.ProfissionalId).html(option.Nome));
                });

            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert('Erro na requisição ao dado: ' + thrownError);


            }
        });


    });
}

var Items = new Object();
Items.ItemComissaoViewModel = new Array();


function adicionarColuna() {
    //var var_id = $("#TelefoneId").val();
    //var var_telefone = $("#TelefoneNumero").val();

    var nomeConvenio;
    var nomeProcedimento;
    var nomeProfissional;
    var valorComissao;
    var descricaoComissao;

    descricaoComissao = $("#DescricaoComissao").val();
    nomeConvenio = $('#ConvenioId :selected').text();
    var convenioId = $("#ConvenioId option:selected").val();
    nomeProcedimento = $('#ddlProcedimento :selected').text();
    var procedimentoId = $("#ddlProcedimento option:selected").val();
    nomeProfissional = $('#ddlProfissional :selected').text()
    var profissionalId = $("#ddlProfissional option:selected").val();
    valorComissao = $("#ValorComissao").val();


    if ((descricaoComissao == '') || (nomeConvenio == 'Selecione') || (nomeProcedimento == 'Selecione') || (nomeProfissional == 'Selecione')
            || (valorComissao <= 0)) {
        $('#divMsg').html('Todos os campos devem ser preenchidos para o cadastro da comissão.');
        $('#myModal').modal('show');
    }

    else {

        if (findLista(nomeConvenio, nomeProcedimento, nomeProfissional)) {
            $('#divMsg').html('Já existe uma comissão adicionada para este Convênio/Procedimento/Profissional.');
            $('#myModal').modal('show');
        }

        else {

            Items.ItemComissaoViewModel.push(new Object({
                NomeConvenio: nomeConvenio, ConvenioId: convenioId, NomeProcedimento: nomeProcedimento, ProcedimentoId: procedimentoId,
                NomeProfissional: nomeProfissional, ProfissionalId: profissionalId, ValorComissao: valorComissao,
                ID: convenioId, Descricao: descricaoComissao
            }
                ));


            AddTableRow(descricaoComissao, nomeConvenio, nomeProcedimento, nomeProfissional, valorComissao, convenioId);
           
        }

    }

    
    ////$("#resultado").empty();
        //$(Items.ItemComissaoViewModel).each(function () {
        //    //$("#resultado").append('Convenio ' + this.NomeConvenio + " -" + 'Código ' + this.ConvenioId + "<br>");

    }

function habilitaBotao(){
    if ($(Items.ItemComissaoViewModel.length >0))
        $('#btSalvar').removeAttr("disabled");
    else
        $('#btSalvar').attr('disabled', 'disabled');
}

function SalvarItens() {

    var dados = $.toJSON(Items);
   
    $.ajax({
        url: "../../Comissao/Salvar",
        data: { Items: dados },
        dataType: 'json',
        type: 'POST',
        success: function (resultado) {            
            if (resultado.Msg == 'OK') {
                OnSuccess('Dados de Comissão de Profissionais salvos com sucesso.');
            }            
            else {
                OnSuccess(resultado.Msg);
             }    
           },
        error: function (xhr, ajaxOptions, thrownError) {
            OnErro();


        }
    });

}

$(document).ready(function () {
    $("#btSalvar").click(function () {
        SalvarItens();
    });
});

(function ($) {
    AddTableRow = function (descricaoComissao,convenio, procedimento, profissional, valorComissao, ID) {

        var newRow = $("<tr>");
        var cols = "";

        cols += '<td>' + descricaoComissao + '</td>';
        cols += '<td>' + ID + '</td>';
        cols += '<td>' + convenio + '</td>';
        cols += '<td>' + procedimento + '</td>';
        cols += '<td>' + profissional + '</td>';
        cols += '<td>' + valorComissao + '</td>';
        cols += '<td>';
        cols += '<button class="btn btn-danger" onclick="RemoveTableRow(this,' + ID +')" type="button">Remover</button>';
        cols += '</td>';

        newRow.append(cols);
        $("#tabelaDados").append(newRow);

        $('#btSalvar').removeAttr("disabled");

        return false;
    };
})(jQuery);


(function ($) {
    RemoveTableRow = function (item,ID) {
       
        var index = Items.ItemComissaoViewModel.indexOf(ID.toString());      
        Items.ItemComissaoViewModel.splice(index, 1);
        
        //alert(Items.ItemComissaoViewModel.length);
        
        var tr = $(item).closest('tr');
         tr.fadeOut(200, function () {
             tr.remove();          
        });

         
         if (Items.ItemComissaoViewModel.length == 0)
             $('#btSalvar').attr('disabled', 'disabled');
        
        return false;
    }
})(jQuery);

function OnSuccess(mensagem) {
    //$("#resultado").empty();
    $('#divMsg').html(mensagem);
    $('#myModal').modal('show');
}

function OnErro() {
    $('#divMsg').html('Ocorreu um erro no cadastro da comissão. Contacte o suporte!');
    $('#myModal').modal('show');
}


function findLista(convenio,procedimento,profissional) {

    var achou = false;

    for (var cont1 = 0; cont1 < Items.ItemComissaoViewModel.length; cont1++)
    {
        if (Items.ItemComissaoViewModel[cont1]["NomeConvenio"]==convenio
            && Items.ItemComissaoViewModel[cont1]["NomeProcedimento"]==procedimento
            && Items.ItemComissaoViewModel[cont1]["NomeProfissional"]==profissional)

            achou = true;

    }
        
    return achou;
}