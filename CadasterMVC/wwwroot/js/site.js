
$(document).ready(function () {
    // Activate tooltip
    $('[data-toggle="tooltip"]').tooltip()

    // Select/Deselect checkboxes
    var checkbox = $('table tbody input[type="checkbox"]')
    $("#selectAll").click(function () {
        if (this.checked) {
            checkbox.each(function () {
                this.checked = true
            })
        } else {
            checkbox.each(function () {
                this.checked = false
            })
        }
    })
    checkbox.click(function () {
        if (!this.checked) {
            $("#selectAll").prop("checked", false)
        }
    })
})


let id = document.getElementById('idEditar')
let nome = document.getElementById('nomeEditar')
let empresa = document.getElementById('empresaEditar')
let contato = document.getElementById('contatoEditar')
let sexo = document.getElementById('sexoEditar')

function obterDadosPessoa(id) {
   
    $.ajax({
        dataType: "json",
        type: "GET",
        url: `https://localhost:5001/Pessoa/ObterPessoa/${id}`,
        success: function (resultado) {
            return preencherCamposEditar(resultado)
        }
    })
}

function preencherCamposEditar(dados) {
       debugger
    id.setAttribute('value', dados.id)
    nome.setAttribute('value', dados.nome)
    empresa.setAttribute('value', dados.empresa)
    contato.setAttribute('value', dados.contato)
    sexo.setAttribute('value', dados.sexo)
}