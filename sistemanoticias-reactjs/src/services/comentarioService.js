// src/services/comentarioService.js

import axios from '../utils/axiosConfig';

export const fetchComentariosByNota = async (idNota) => {
  try {
    const response = await axios.get(`/nota/${idNota}/comentario`); // Cambia el endpoint si es necesario
    return response.data;
  } catch (error) {
    console.error('Error fetching comentarios:', error);
    throw error;
  }
};

export const createComentario = async (comentario) => {
  try {
    const response = await axios.post('/comentario', comentario); // Cambia el endpoint si es necesario
    return response.data;
  } catch (error) {
    console.error('Error creating comentario:', error);
    throw error;
  }
};
