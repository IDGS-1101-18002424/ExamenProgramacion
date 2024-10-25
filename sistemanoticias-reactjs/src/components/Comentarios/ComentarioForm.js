// src/components/comentarios/ComentarioForm.js

import React, { useState } from 'react';
import { createComentario } from '../../services/comentarioService';

const ComentarioForm = ({ idNota }) => {
  const [contenido, setContenido] = useState('');

  const handleSubmit = async (e) => {
    e.preventDefault();
    const nuevoComentario = { contenido, idNota, esInterno: false }; // Ajusta según la estructura de tu API
    try {
      await createComentario(nuevoComentario);
      setContenido('');
      alert('Comentario creado exitosamente');
    } catch (error) {
      console.error('Error creando comentario:', error);
      alert('Error al crear el comentario');
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      <h3>Agregar Comentario</h3>
      <div>
        <label>Comentario:</label>
        <textarea
          value={contenido}
          onChange={(e) => setContenido(e.target.value)}
          required
        />
      </div>
      <button type="submit">Agregar Comentario</button>
    </form>
  );
};

export default ComentarioForm;
