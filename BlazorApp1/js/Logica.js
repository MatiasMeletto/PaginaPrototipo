var listaChori = [];

function añadirChori(pcarro, pcriolla, pchimi, pcantidad, pprecio) {

    var nuevoChori = {
        carro: pcarro,
        criolla: pcriolla,
        chimi: pchimi,
        cantidad: pcantidad,
        precio: pprecio
    };
    console.log(nuevoChori);
    listaChori.push(nuevoChori);
}
