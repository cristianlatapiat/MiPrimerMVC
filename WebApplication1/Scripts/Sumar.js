var btnSumar = document.getElementById("btnSumar");
btnSumar.onclick = function () {
    var num1 = document.getElementById("txtnumero1").value * 1;
    var num2 = document.getElementById("txtnumero2").value * 1;
    var suma = num1 + num2;

    document.getElementById("lblTotal").innerHTML = suma;
    //alert(suma);

}

var btnLimpiar = document.getElementById("btnLimpiar");
btnLimpiar.onclick = function () {
    document.getElementById("txtnumero1").value = "";
    document.getElementById("txtnumero2").value = "";
    document.getElementById("lblTotal").innerHTML = "";
}