$.get("Seccion/ListaPersonas", function (data) {

   // alert(JSON.stringify( data))
    var contenido = "";
    var cantidad = data.length;
    contenido += "<table class='table'>";
    contenido += "    <thead>";
    contenido += "        <tr>";
    contenido += "            <td>Nombre</td>";
    contenido += "            <td>Paterno</td>";
    contenido += "            <td>Materno</td>";
    contenido += "        </tr>";
    contenido += "    </thead>";
    contenido += "    <tbody>";

    for (var i = 0; i < cantidad; i++) {
        contenido += "        <tr>";
        contenido += "            <td>" + data[i].Idpersona +"</td>";
        contenido += "            <td>" + data[i].Nombre +"</td>";
        contenido += "            <td>" + data[i].ApellidoPaterno +"</td>";
        contenido += "        </tr>";
    }
    contenido += "    </tbody>";
    contenido += "</table>";

    document.getElementById("tablaPersonas").innerHTML = contenido;

})