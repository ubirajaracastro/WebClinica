$(function () {
       
    atacharEventoBuscaPlanosdoConvenio();

    var id = parseInt($("#PacienteId").val());

    if (id > 0) {
        $('#Cidade').append($('<option selected></option>').val($('#codigoCidade').val()).html($('#nomeCidade').val()));
        obterPlanos();   
                              
     }
   
    obterCidadesPorEstadoBind();

    $("#btVoltar").click(function () {
        back();
    });

    $("#tabs-1").tabs();
      buscaCep();
});

function back() {
    location.href = '../Index';
}

function atacharEventoBuscaPlanosdoConvenio() {
     $("#ConvenioId").change(function () {
        obterPlanos();
    });
    
}

function obterPlanos() {        
    var selectedItem = $("#ConvenioId").val();
        var ddlPlano = $("#ddlPlano");
        $.ajax({
            cache: false,
            type: "POST",
            url: "../../Convenio/obterPlanos",
            data: { "ConvenioID": selectedItem },
            success: function (data) {
                ddlPlano.html('');
                $('#ddlPlano').append($('<option></option>').val(0).html('Selecione'));
                $('#ddlPlano option[value=0]').attr({ selected: "selected" });

                $.each(data, function (id, option) {
                    ddlPlano.append($('<option></option>').val(option.ConvenioPlanoID).html(option.DescricaoPlano));                   

                    if ($("#codigoPlano").val() > 0)
                        $('#ddlPlano option[value="' + $('#codigoPlano').val() + '"]').attr({ selected: "selected" });
                   

                    $("#divPlano").show();
                });               

              
            },
            error: function (xhr, ajaxOptions, thrownError) {
                bootbox.alert('Erro na requisição ao dado: ' + thrownError);


            }        

    });

}


function obterTabClicada() {
    var active = $("#tabs-1").tabs("option", "active");

    if (active > 1 && active <= 3) {
        if ($("#NomeCompleto").val() == ''
           || $("#DataNascimento").val() == ''
           || $("#CPF").val() == ''
           || $("#CPF").val() == ''
           || $("#Email").val() == ''
           || $("#EstadoID option:selected").val() == ''
           || $("#TelefoneCelular").val() == '') {

            $("#tabs-1").tabs({ active: 1 });
            $('form').valid();
        }

        else {
            if (active == 3) {

                if ($("#ConvenioId option:selected").val() == ''
                    || $("#NumeroCarteira").val() == ''
                    || $("#ValidadeCarteira").val() == '') {
                    $("#tabs-1").tabs({ active: 3 });
                    $('form').valid();


                }

            }

        }

    }

}