document.query('#btnGuardar').addEventListener('click', agregarChori);

function agregarChori() {
    var sCarro = 1;
    var sCriolla = document.querySelector('#criollak').value,
    var sChimi = document.querySelector('#chimi').value,
    var sCantidad = document.querySelector('#choripan').value,
    var sPrecio = Choripan.Precio

    añadirChori(sCarro,sCriolla,sChimi, sCantidad, sPrecio)
}
