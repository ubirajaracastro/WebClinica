$(function () {
    loadBusca();
    AdicionaLinhaProcedimento();

    $("#btVoltar").click(function () {
        cancelarProntuario();
    });

});

function cancelarProntuario() {
    location.href = '/Prontuario/BuscaPaciente';
}

function loadBusca() {
    $("#DescricaoCID").autocomplete({
        minLength: 3,
        //delay: 200,
        source: function (request, response) {
            $.ajax({
                url: "/Prontuario/buscarDoencaCID",
                type: "POST",
                dataType: "json",
                data: { codigo: request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return {
                            label: item.CodigoCID + '-' + item.DescricaoCID
                        };

                    }))
                }
            })
        },

        select: function (e, ui) {
            //$("#divBotaoAtendimento").show();
        },

        messages: {
            noResults: "", results: ""
        }
    });

}

function OnErroProntuario() {

    if ($("#QueixaPrincipal").val() == '')
        bootbox.alert("Prencha o campo Queixa Principal do prontuário.");
    else if ($("#Conduta").val() == '')
        bootbox.alert("Prencha o campo Conduta do prontuário.");

    else if ($("#DescricaoCID").val() == '')
        bootbox.alert("Prencha o campo CID do prontuário.");

    else
        bootbox.alert("Ocorreu um erro no cadastro do prontuário. Contacte o suporte!");

}



function travaTelaProntuario() {

    $('#QueixaPrincipal').attr('disabled', 'disabled');
    $('#Conduta').attr('disabled', 'disabled');
    $('#ExameFisico_Peso').attr('disabled', 'disabled');
    $('#ExameFisico_FrequenciaRespiratoria').attr('disabled', 'disabled');
    $('#ExameFisico_Altura').attr('disabled', 'disabled');
    $('#ExameFisico_FrequenciaCardiaca').attr('disabled', 'disabled');
    $('#ExameFisico_IMC').attr('disabled', 'disabled');
    $('#ExameFisico_Press_oArterialsistotica').attr('disabled', 'disabled');
    $('#ExameFisico_Temperatura').attr('disabled', 'disabled');
    $('#ExameFisico_Press_oArterialdiastolica').attr('disabled', 'disabled');
    $('#ExameFisico_Hemoglucoteste').attr('disabled', 'disabled');
    $('#PrescricaoMedica').attr('disabled', 'disabled');
    $('#Atestado_Texto').attr('disabled', 'disabled');
    $('#DescricaoCID').attr('disabled', 'disabled');

    $.each($(".search"), function () {
        $("#" + this.id).attr('disabled', 'disabled');
    });

    $('form input[type=radio]').each(function () {
        $("#" + this.id).attr('disabled', 'disabled');
    });

    $('#add').attr('disabled', 'disabled');
    $('#btSalvar').attr('disabled', 'disabled');

}

var OnSuccessProntuario = function (data) {
    if (data.msg == 'OK') {
        $.ajax({
            cache: false,
            type: "POST",
            url: "../../Prontuario/obterProntuario",
            data: { "id": data.AtendimentoID },
            success: function (data) {
                travaTelaProntuario();
            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert('Erro na requisição ao dado: ' + thrownError);


            }
        });

    }

}

function AdicionaLinhaProcedimento() {
    var tableBody = $('#Products tbody');
    var url = "/Prontuario/Add"
    $('#add').click(function () {
        $.get(url, function (response) {
            tableBody.append(response);
        });
    });

}

