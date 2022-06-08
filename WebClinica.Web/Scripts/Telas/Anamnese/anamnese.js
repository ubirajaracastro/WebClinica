$('.nav-tabs a').click(function () {
    $(this).tab('show');
})

function OnSuccessAnamnese(response) {
    $('#divMsg').html('Modelo do Anamnese salvo com sucesso.');
    $('#myModal').modal('show');
}

function exibirModalErro() {
    $('#divMsg').html('Ocorreu um erro na gravação! Contacte o suporte.');
    $('#myModal').modal('show');
}

function configurarGrid() {

    var traducao = {
        infos: "Exbindo {{ctx.start}} até {{ctx.end}} de {{ctx.total}} registros",
        loading: "Aguarde, carregando...",
        noResults: "A pesquisa não encontrou resultados para o critério informado",
        refresh: "Atualizar",
        search: "Pesquisar"

    }

    var grid = $("#gridDadosPergunta").bootgrid(
        {
            ajax: true,
            url: "/ModeloAnamnese/ListarPerguntas",
            labels: traducao,
            searchSettings: {
                characters: 4
            },
            formatters: {
                "commands": function (column, row) {
                    return "<button type=\"button\" class=\"btn btn-xs btn-default command-delete\" data-row-id=\"" + row.PerguntaId + "\"><span class=\"glyphicon glyphicon-trash\"></span></button>";
                }
            }
        }).on("loaded.rs.jquery.bootgrid", function () {           
            grid.find(".command-delete").on("click", function (e) {               

                var id = $(this).data("row-id");

                bootbox.confirm({
                    message: "Confirma a exclusão da pergunta? Perguntas do tipo Múltipla escolha terão suas respectivas respostas também removidas.",
                    buttons: {
                        confirm: {
                            label: 'Sim',
                            className: 'btn-success'
                        },
                        cancel: {
                            label: 'Não',
                            className: 'btn-danger'
                        }
                    },
                    callback: function (result) {
                        if (result)
                            excluirPergunta(id);
                    }
                });



            });

        });
}

$(document).ready(function () {
    configurarGrid();
       
      
    $("#btn-create").click(function () {

        $("#modal").load("/Pergunta/Novo", function () {          
                                          
            $("#modal").show();

        })        
    });

    $("#PadraodaClinica").click(function () {

        if ($("#hdModelo").val() == 0) {

            $.ajax({
                url: "../../ModeloAnamnese/TemModeloPadrao",
                dataType: 'json',
                type: 'POST',
                success: function (resultado) {
                    if (resultado.count != '0') {
                        $('#divMsg').html('Já existe um modelo cadastrado como padrão. Para definir outro modelo como padrão, efetue a alteração, desmarque a opção de modelo padrão do atual e tente novamente.');
                        $('#myModal').modal('show');
                        $("#PadraodaClinica").attr("checked", false);
                    }

                },
                error: function (xhr, ajaxOptions, thrownError) {
                    OnErro();


                }
            });

        }

        
    });  

});

function excluirPergunta(perguntaId) {
    $.ajax({
        url: "../../Pergunta/Excluir",
        data: { "perguntaID": perguntaId },
        dataType: 'json',
        type: 'POST',
        success: function (resultado) {
            if (resultado.OK == true) {
                bootbox.alert("A pergunta foi excluída.");
                //location.href = '@Url.Action("Index","ModeloAnamnese")';
            }
        },
        error: function (xhr, ajaxOptions, thrownError) {
            bootbox.alert("Ocorreu um erro na operação. Contacte o suporte!");
        }
    });
}




