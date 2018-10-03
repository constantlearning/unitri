function validateForm() {
    var firstMonth = document.forms['calcularImposto']['firstMonth'];
    var secondMonth = document.forms['calcularImposto']['secondMonth'];
    var thirdMonth = document.forms['calcularImposto']['thirdMonth'];

    return fieldIsValid(firstMonth) && fieldIsValid(secondMonth) && fieldIsValid(thirdMonth);
}

function fieldIsValid(field){
    if(field.value == ""){
        alert("O campo " + field.name + " não pode ser vazio!");
        return false;
    }
    if(field.value <= 0){
        alert("O campo " + field.name + " deve ser maior que zero!");
        return false;
    }
    return true;
}