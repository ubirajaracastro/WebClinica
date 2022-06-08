function OnSuccess(response) {
    $('#divMsg').html('Dados do Tipo de Consulta salvos com sucesso.');
    $('#myModal').modal('show');    
}

function exibirModalErro() {

    $('#divMsg').html('Ocorreu um erro na gravação! Contacte o suporte.');
    $('#myModal').modal('show');
}

$(".modal").on("hidden.bs.modal", function () {
    windows.location = "your-url"; 
});