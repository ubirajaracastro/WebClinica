$(document).ready(function () {   
    var id = parseInt($("#ClinicaId").val());
   
    if (id > 0) {
        $('#Cidade').append($('<option selected></option>').val($('#codigoCidade').val()).html($('#nomeCidade').val()));
        
        if($('#UtilizaISS').val()=='1')
            $("#divCNES").show();

    }

    if ($('#CNPJ').val() == '0') {
        $('#divMsg').html('CPF ou CNPJ Inválido!');
        $('#myModal').modal('show');
    }

    $('#UtilizaTISS').click(function () {
        mostrarCampoCNES();
    });

    obterCidadesPorEstadoBind();   
    
});

function mostrarCampoCNES() {

    if ($('#UtilizaTISS').is(':checked'))
        $("#divCNES").show();
    else
        $("#divCNES").hide();
  }

function obterCidadesPorEstadoBind() {
    $("#IdEstado").change(function () {
        var selectedItem = $(this).val();    
        var ddlCidade = $("#Cidade");
        $.ajax({
            cache: false,
            type: "POST",
            url: "Clinica/obterCidadePorEstado",
            data: { "estadoID": selectedItem },
            success: function (data) {
                ddlCidade.html('');
                $.each(data, function (id, option) {
                    ddlCidade.append($('<option></option>').val(option.CidadeId).html(option.Nome));
                });

            },
            error: function (xhr, ajaxOptions, thrownError) {
                alert('Erro na requisição ao dado: ' + thrownError);

            }
        });
    });
}

function exibirModalErro() {
        
    var cpf = $('#CPFResponsavel').val();
    var cnpj = $('#CNPJ').val();
    
    if (!validaCpf(cpf))
        $('#divMsg').html('CPF ou CNPJ Inválido!');

    else if(!validarCNPJ(cnpj))
        $('#divMsg').html('CPF ou CNPJ Inválido!');

    else
        $('#divMsg').html('Ocorreu um erro na gravação! Contacte o suporte.');

       
        $('#myModal').modal('show');
}

function OnSuccess(response) {
    $('#divMsg').html('Dados da Clínica salvos com sucesso.');
    $('#myModal').modal('show');
}

function validaCpf(numerocpf) {
    
    var cpf = numerocpf.replace(/[^0-9]/gi, ''); //Remove tudo que não for número
    if (cpf.length == 0)
        return true; //vazio
    if (cpf.length != 11 || cpf == "00000000000" || cpf == "11111111111" || cpf == "22222222222" || cpf == "33333333333" || cpf == "44444444444" || cpf == "55555555555" || cpf == "66666666666" || cpf == "77777777777" || cpf == "88888888888" || cpf == "99999999999")
        return false;
    add = 0;
    for (i = 0; i < 9; i++)
        add += parseInt(cpf.charAt(i)) * (10 - i);
    rev = 11 - (add % 11);
    if (rev == 10 || rev == 11)
        rev = 0;
    if (rev != parseInt(cpf.charAt(9)))
        return false;
    add = 0;
    for (i = 0; i < 10; i++)
        add += parseInt(cpf.charAt(i)) * (11 - i);
    rev = 11 - (add % 11);
    if (rev == 10 || rev == 11)
        rev = 0;
    if (rev != parseInt(cpf.charAt(10))) {        
        return false;

    }
    return true; //cpf válido

}

function validarCNPJ(cnpj) {

    cnpj = cnpj.replace(/[^\d]+/g, '');

    if (cnpj == '') return false;

    if (cnpj.length != 14)
        return false;

    // Elimina CNPJs invalidos conhecidos
    if (cnpj == "00000000000000" ||
        cnpj == "11111111111111" ||
        cnpj == "22222222222222" ||
        cnpj == "33333333333333" ||
        cnpj == "44444444444444" ||
        cnpj == "55555555555555" ||
        cnpj == "66666666666666" ||
        cnpj == "77777777777777" ||
        cnpj == "88888888888888" ||
        cnpj == "99999999999999")
        return false;

    // Valida DVs
    tamanho = cnpj.length - 2
    numeros = cnpj.substring(0, tamanho);
    digitos = cnpj.substring(tamanho);
    soma = 0;
    pos = tamanho - 7;
    for (i = tamanho; i >= 1; i--) {
        soma += numeros.charAt(tamanho - i) * pos--;
        if (pos < 2)
            pos = 9;
    }
    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
    if (resultado != digitos.charAt(0))
        return false;

    tamanho = tamanho + 1;
    numeros = cnpj.substring(0, tamanho);
    soma = 0;
    pos = tamanho - 7;
    for (i = tamanho; i >= 1; i--) {
        soma += numeros.charAt(tamanho - i) * pos--;
        if (pos < 2)
            pos = 9;
    }
    resultado = soma % 11 < 2 ? 0 : 11 - soma % 11;
    if (resultado != digitos.charAt(1))
        return false;

    return true;

}
