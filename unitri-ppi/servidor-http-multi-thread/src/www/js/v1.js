function validateForm() {
    var meuForm = document.forms.gerarSenha;
    var nome = meuForm.elements.item(0).value;
    var sobrenome = meuForm.elements.item(1).value;

    return fieldIsValid(nome) && fieldIsValid(sobrenome);
}

function fieldIsValid(field){
    if(field == ""){
        alert("O campo " + field + " não pode ser vazio!");
        return false;
    }
    if(field.includes(" ")){
        alert("O campo " + field + " não pode ter espaços em branco!");
        return false;
    }
    if(field.length < 2){
        alert("O campo " + field + " deve ser maior que zero!");
        return false;
    }
    return true;
}