import Reservas from './classes/Reservas.js';
import UI from './classes/UI.js';

import {
    fechaSele,
    horaSele,
    nombreSele,
    telefonoSele,
    servicioSele,
    formulario,
    contenedorReservas,
    DivMostrarReservas
} from './selectores.js';



const ui = new UI();
export let DB;

const administrarReservas = new Reservas();



let editando;
const reservaObj = {
    fecha: '',
    hora: '',
    nombre: '',
    telefono: '',
    servicio: '',

}