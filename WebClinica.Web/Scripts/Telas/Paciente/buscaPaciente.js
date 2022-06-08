$(function () {

    loadBusca();

    $("#btAtendimento").click(function () {
      });
          
});

function loadBusca() {

    $("#txtPaciente").autocomplete({
        minLength: 3,
        //delay: 200,
        source: function (request, response) {
            $.ajax({
                url: "/Paciente/buscarPacientePorNome",
                type: "POST",
                dataType: "json",
                data: { nome: request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return {
                            label: item.PacienteId + '-' + item.NomeCompleto

                        };

                    }))
                }
            })
        },

        select: function(e, ui) {
            $("#divBotaoAtendimento").show();
        },

        messages: {
            noResults: "", results: ""
        }
    });
}