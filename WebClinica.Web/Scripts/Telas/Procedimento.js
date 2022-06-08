$(document).ready(function () {

    $('#VincularAProcedimentoTUSS').click(function () {
        mostrarCampoUSS();
    });

    if ($('#UtilizaUSS').val() == '1') {       
        $('#txtProcedimentoUSS').val($('#ProcedimentoTUSS').val());
        $("#divTabelaTISS").show();
        
    }
        
    $("#txtProcedimentoUSS").autocomplete({
        source: function (request, response) {
            $.ajax({
                url: "/Procedimento/obterTabelaTUSS",
                type: "POST",
                dataType: "json",
                data: { parametro: request.term },
                success: function (data) {
                    response($.map(data, function (item) {
                        return { label: item.CodigoTUSS + '-' + item.ProcedimentoTUSS, value: item.CodigoTUSS + '-' + item.ProcedimentoTUSS };
                    }))

                }
            })
        },
        messages: {
            noResults: "", results: ""  
        }
    });
})

function mostrarCampoUSS() {

    if ($('#VincularAProcedimentoTUSS').is(':checked'))
        $("#divTabelaTISS").show();
    else {
        $('#txtProcedimentoUSS').val('');
        $("#divTabelaTISS").hide();
    }
}

function OnSuccess(response) {
    $('#divMsg').html('Dados do procedimento salvos com sucesso.');
    //$('#myModal').modal('show');
    location.href = '/Procedimento/Index'
}   

function exibirModalErro() {

    $('#divMsg').html('Ocorreu um erro na gravação! Contacte o suporte.');
    $('#myModal').modal('show');
}