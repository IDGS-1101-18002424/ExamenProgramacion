import axios from 'axios';

const API_URL = 'http://localhost:5096/api/nota'; // Asegúrate de que esta sea la URL correcta

const getNotas = async () => {
  try {
    const response = await axios.get(API_URL);
    return response.data;
  } catch (error) {
    console.error("Error fetching notas:", error);
    throw error;
  }
};

export const fetchNotas = async () => {
  return await axios.get(API_URL);
};

const createNota = async (nota) => {
  try {
    const response = await axios.post(API_URL, nota);
    return response.data;
  } catch (error) {
    console.error("Error creating nota:", error);
    throw error;
  }
};

export { getNotas, createNota };
