$(document).ready(function () {
    configurarGrid();

});

function configurarGrid() {

    var traducao = {
        infos: "Exbindo {{ctx.start}} até {{ctx.end}} de {{ctx.total}} registros",
        loading: "Aguarde, carregando...",
        noResults: "A pesquisa não encontrou resultados para o critério informado",
        refresh: "Atualizar",
        search: "Pesquisar"

    }

    var grid = $("#gridDadosAnamnese").bootgrid(
        {
            ajax: true,
            url: "/ModeloAnamnese/Listar",
            labels: traducao,
            searchSettings: {
                characters: 4
            },
            formatters: {
                "commands": function (column, row) {
                    return "<button type=\"button\" class=\"btn btn-xs btn-default command-edit\" data-row-id=\"" + row.ModeloId + "\"><span class=\"glyphicon glyphicon-pencil\"></span></button> " +
                    "<button type=\"button\" class=\"btn btn-xs btn-default command-delete\" data-row-id=\"" + row.ModeloId + "\"><span class=\"glyphicon glyphicon-trash\"></span></button>";
                }
            }
        }).on("loaded.rs.jquery.bootgrid", function () {
            grid.find(".command-edit").on("click", function (e) {
                //alert("You pressed edit on row: " + $(this).data("row-id"));
                //alert("You pressed edit on row: " + $(this).data("row-id"));
                var path = '/ModeloAnamnese/Alterar/' + $(this).data("row-id");
                location.href = path;

            }).end().find(".command-delete").on("click", function (e) {
                var id = $(this).data("row-id");

                bootbox.confirm({
                    message: "Confirma a exclusão do modelo?",
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
                              excluirModelo(id);
                    }
                });

            });

        });
}

function excluirModelo(modeloId) {
    $.ajax({
        url: "../../ModeloAnamnese/Excluir",
        data: { "modeloID": modeloId },
        dataType: 'json',
        type: 'POST',
        success: function (resultado) {
            if (resultado.OK == true) {
                bootbox.alert("O modelo foi excluído.");
                //location.href = '@Url.Action("Index","ModeloAnamnese")';
            }
        },
        error: function (xhr, ajaxOptions, thrownError) {
            bootbox.alert("Ocorreu um erro na operação. Contacte o suporte!");
        }
    });
}