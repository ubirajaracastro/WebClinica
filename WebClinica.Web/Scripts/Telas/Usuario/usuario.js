var OnSuccess = function (data) {
    bootbox.alert(data.msg);
}
   
function OnErro() {     
    
    bootbox.alert("Ocorreu um erro no cadastro. Contacte o suporte!");
}