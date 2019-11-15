$.get("Curso/CursosList", function (data) {
    CreateList(data)
});

function CreateList(data) {
    var contenido = "";
    var cantidad = data.length;
    contenido += "<table id='tabla-curso' class='table'>";
    contenido += "    <thead>";
    contenido += "        <tr>";
    contenido += "            <td>Id</td>";
    contenido += "            <td>Curso</td>";
    contenido += "            <td>Descripcion</td>";
    contenido += "        </tr>";
    contenido += "    </thead>";
    contenido += "    <tbody>";

    for (var i = 0; i < cantidad; i++) {
        contenido += "        <tr>";
        contenido += "            <td>" + data[i].IIDCURSO + "</td>";
        contenido += "            <td>" + data[i].NOMBRE + "</td>";
        contenido += "            <td>" + data[i].DESCRIPCION + "</td>";
        contenido += "        </tr>";
    }
    contenido += "    </tbody>";
    contenido += "</table>";

    document.getElementById("tabla").innerHTML = contenido;
    $("#tabla-curso").Datatable();
}