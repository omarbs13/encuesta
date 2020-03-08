
function dtListas(){
    $("#mytable").DataTable({
        destroy: true,
        responsive: true,
        ajax: {
            type: "POST",
            url: "/Page/ListarEncuesta",
            contentType: "application/json",
            dataType: "json",
            data: function (d) {
                return JSON.stringify(d); // convierte a una cadena json
            },
            dataSrc: "d.data"

        },
        columns: [
            { "data": "Id" },
            { "data": "TipoEncuesta" },
            { "data": "CantidadPreguntas" },
            { "data": "Descripcion" },
            { "data": "Status" }
        ]
    });
}