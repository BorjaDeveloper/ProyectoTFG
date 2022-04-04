const imagenes = document.querySelectorAll('.img-galeria');
const imagenesLight = document.querySelector('.agregar-imagen');
const contenedorLight = document.querySelector('.imagen-light');
const cerrar = document.querySelector('.close');
var num=1;



imagenes.forEach(imagen =>{
  imagen.addEventListener('click', ()=>{
    aparecerImagen(imagen.getAttribute('src'));
  })
})

contenedorLight.addEventListener('click', (e)=>{
  if (e.target == cerrar) {
    contenedorLight.classList.toggle('show')
    imagenesLight.classList.toggle('showImage')
  }
})

const aparecerImagen = (imagen)=>{
  imagenesLight.src = imagen
  contenedorLight.classList.toggle('show');
  imagenesLight.classList.toggle('showImage');
}
