$(document).ready(function () {
    configurarGrid();
    novoRegistro();
});

function configurarGrid() {

    var traducao = {
        infos: "Exbindo {{ctx.start}} até {{ctx.end}} de {{ctx.total}} registros",
        loading: "Aguarde, carregando...",
        noResults: "A pesquisa não encontrou resultados para o critério informado",
        refresh: "Atualizar",
        search: "Pesquisar"

    }

    var grid = $("#gridDadosUsuario").bootgrid(
        {
            ajax: true,
            url: "/Usuario/Listar",
            labels: traducao,
            searchSettings: {
                characters: 4
            },
            formatters: {
                "commands": function (column, row) {
                    return "<button type=\"button\" class=\"btn btn-xs btn-default command-edit\" data-row-id=\"" + row.Id + "\"><span class=\"glyphicon glyphicon-pencil\"></span></button> " +
                        "<button type=\"button\" class=\"btn btn-xs btn-default command-delete\" data-row-id=\"" + row.Id + "\"><span class=\"glyphicon glyphicon-trash\"></span></button>";
                }
            }
        }).on("loaded.rs.jquery.bootgrid", function () {
            /* Executes after data is loaded and rendered */
            grid.find(".command-edit").on("click", function (e) {
                var path = '/Fornecedor/Alterar/' + $(this).data("row-id");
                location.href = path;

            }).end().find(".command-delete").on("click", function (e) {
                var id = $(this).data("row-id");

                bootbox.confirm({
                    message: "Confirma a exclusão do Usuário?",
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
                        
                            
                    }
                });



            });

        });
}

function novoRegistro() {
    $("#btNovo").click(function () {
        location.href = '/Usuario/Novo';
    });

}