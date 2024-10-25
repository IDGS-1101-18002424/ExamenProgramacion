// src/utils/axiosConfig.js

import axios from 'axios';

const instance = axios.create({
  baseURL: 'http://localhost:5096/api', // Cambia esto a la URL de tu API
  timeout: 1000, // Tiempo de espera para la solicitud
});

export default instance;
