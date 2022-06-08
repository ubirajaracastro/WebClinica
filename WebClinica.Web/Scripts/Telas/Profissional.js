$(document).ready(function () {   
    var id = parseInt($("#ProfissionalId").val());
          
    if (id > 0) {
        $('#Cidade').append($('<option selected></option>').val($('#codigoCidade').val()).html($('#nomeCidade').val()));               
    }
    
    obterCidadesPorEstadoBind();   
    
});

function exibirModalErro() {

    //var cpf = $('#CPFResponsavel').val();
    //var cnpj = $('#CNPJ').val();

    if (!validaCpf(cpf))
        $('#divMsg').html('CPF ou CNPJ Inválido!');   

    else
        $('#divMsg').html('Ocorreu um erro na gravação! Contacte o suporte.');


    $('#myModal').modal('show');
}

