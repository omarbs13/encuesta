
function tableSinFiltro(tableName) {
    $(tableName).DataTable({
        "pageLength": 5, "bFilter": true, "ordering": false, "bLengthChange": false, "sDom": "<'row-fluid'<'span6'l><'span6'f>r>t<'row-fluid'<'span6'i><'span6'p>>", "language": {
            "zeroRecords": "No existe información que mostrar  ", "info": "pagina _PAGE_ de _PAGES_", "infoEmpty": "No hay datos que mostrar", "infoFiltered": "(Filtrado de _MAX_  registros totales)", "oPaginate": {
                "sFirst": "First", "sPrevious": "Anterior", "sNext": "Siguiente", "sLast": "Last", "sSearch": "Buscar"
            }
        }
    });
}