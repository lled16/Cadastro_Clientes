 function EnviarCadastro(){
    var cpf = document.getElementById('cpf');
    var nome = document.getElementById('nome');
    var dtNascimento = document.getElementById('dtNascimento');
    var endereco = document.getElementById('endereco');
    var estado = document.getElementById('estado');
    var cidade = document.getElementById('cidade');
    var sexo =  displayRadioValue();
    
    const date = dtNascimento.value.split('-');
    console.log(date[2]);

    var data = date[2] + '/' + date[1] + '/' + date[0] + " 00:00:00";



    var registraCliente = cadCliente("https://localhost:7299/Cliente/CadastraCliente?Cpf=" + cpf.value 
    + '&Nome=' + nome.value 
    + '&DataNascimento =' + data
    + '&Endereco=' + endereco.value
    + '&Estado=' + estado.value
    + '&Cidade=' + cidade.value 
    + '&Sexo=' + sexo
    );


    data = registraCliente;
    location.replace('./index.html');
}


function cadCliente(url) {
    let request = new XMLHttpRequest();
    request.open("POST", url, false);
    request.send();
    console.log(request.responseText);
    return request.responseText;


}
    
function displayRadioValue() {
    var radio = document.getElementsByName('sexo');
      
    for(i = 0; i < radio.length; i++) {
        if(radio[i].checked)
        sexo = radio[i].value;
        
    }
    return sexo;
}

function limpaDigitado() {
    document.getElementById("cpf").innerHTML = "";
    document.getElementById("nome").innerHTML = "";
    document.getElementById("dtnascimento").innerHTML = "";
    document.getElementById("endereco").innerHTML = "";
    document.getElementById("feminino").innerHTML = "";
    document.getElementById("masculino").innerHTML = "";
    document.getElementById("estado").innerHTML = "";
    document.getElementById("cidade").innerHTML = "";


}

