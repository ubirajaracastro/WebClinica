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

    var grid = $("#gridDadosPaciente").bootgrid(
        {
            ajax: true,
            url: "/Paciente/Listar",
            labels: traducao,
            searchSettings: {
                characters: 4
            },
            formatters: {
                "commands": function (column, row) {
                    return "<button type=\"button\" class=\"btn btn-xs btn-default command-edit\" data-row-id=\"" + row.PacienteId + "\"><span class=\"glyphicon glyphicon-pencil\"></span></button> " +
                        "<button type=\"button\" class=\"btn btn-xs btn-default command-delete\" data-row-id=\"" + row.PacienteId + "\"><span class=\"glyphicon glyphicon-trash\"></span></button>";
                }
            }

            //converters: {
            //    datetime: {
            //        from: function (value) { return moment(value); },
            //        to: function (value) { return value.format("lll"); }
            //    }
            //}

        }).on("loaded.rs.jquery.bootgrid", function () {
            /* Executes after data is loaded and rendered */
            grid.find(".command-edit").on("click", function (e) {                
                var path = '/Paciente/Alterar/' + $(this).data("row-id");               
                location.href = path;

            }).end().find(".command-delete").on("click", function (e) {
                alert("You pressed delete on row: " + $(this).data("row-id"));
            });

        });


}
