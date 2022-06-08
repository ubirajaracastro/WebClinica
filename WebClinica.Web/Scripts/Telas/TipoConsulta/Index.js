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

    var grid = $("#gridDadosTipoConsulta").bootgrid(
        {
            ajax: true,
            url: "/TipodeConsulta/Listar",
            labels: traducao,
            searchSettings: {
                characters: 4
            },
            formatters: {
                "commands": function (column, row) {
                    return "<button type=\"button\" class=\"btn btn-xs btn-default command-delete\" data-row-id=\"" + row.TipoConsultaId + "\"><span class=\"glyphicon glyphicon-trash\"></span></button>";
                }
            }
        }).on("loaded.rs.jquery.bootgrid", function () {
            /* Executes after data is loaded and rendered */
            grid.find(".command-delete").on("click", function (e) {           
                var id = $(this).data("row-id");               
                bootbox.confirm({
                    message: "Confirma a exclusão do tipo de consulta?",
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
                            excluirTipoConsulta(id);
                    }
                });


            });

        });

}

function excluirTipoConsulta(tipoId) {
    $.ajax({
        url: "../../TipodeConsulta/Excluir",
        data: { "tipoConsultaID": tipoId },
        dataType: 'json',
        type: 'POST',
        success: function (resultado) {
            if (resultado.OK == true) {
                bootbox.alert("Tipo de consulta excluído.");
                window.location.reload();
                //location.href = '@Url.Action("Index","ModeloAnamnese")';
            }
        },
        error: function (xhr, ajaxOptions, thrownError) {
            bootbox.alert("Ocorreu um erro na operação. Contacte o suporte!");
        }
    });
}


