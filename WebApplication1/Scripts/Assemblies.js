$.get("Assemblies/ApplicationsList", function (data) {
    CreateList(data);
});
function CompareAssemblies(idApplicacion) {
    $.ajax({
        type: "POST",
        url: "Assemblies/CompareAssemblies/?idApplicacion=" + idApplicacion, fun
    });
}
function CreateList(data) {
    var contenido = "";
    var cantidad = data.length;
    contenido += "<table id='tabla-Applications' class='table'>";
    contenido += "    <thead>";
    contenido += "        <tr>";
    contenido += "            <td>Apicaciones</td>";
    contenido += "            <td>Descripcion</td>";
    contenido += "            <td>Estado</td>";
    contenido += "            <td>Ultima Ejecucion</td>";
    contenido += "            <td>Comparar</td>";
    contenido += "        </tr>";
    contenido += "    </thead>";
    contenido += "    <tbody>";

    for (var i = 0; i < cantidad; i++) {
        contenido += "        <tr>";
        contenido += "            <td>" + data[i].Nombre + "</td>";
        contenido += "            <td>" + data[i].Descripcion + "</td>";
        contenido += "            <td>" + data[i].Estado + "</td>";
        contenido += "            <td>" + data[i].FechaActualizacion + "</td>";
        contenido += "            <td><button type='button' class='btn btn-primary' onclick='CompareAssemblies(" + data[i].Id+")'>Start</button></td>";
        contenido += "        </tr>";
    }
    contenido += "    </tbody>";
    contenido += "</table>";

    document.getElementById("tabla").innerHTML = contenido;
    $("#tabla-Applications").Datatable();
}