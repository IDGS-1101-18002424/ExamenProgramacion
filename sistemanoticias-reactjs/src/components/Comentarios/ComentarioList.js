// src/components/comentarios/ComentarioList.js

import React, { useEffect, useState } from 'react';
import { fetchComentariosByNota } from '../../services/comentarioService';

const ComentarioList = ({ idNota }) => {
  const [comentarios, setComentarios] = useState([]);
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const getComentarios = async () => {
      try {
        const data = await fetchComentariosByNota(idNota);
        setComentarios(data);
      } catch (error) {
        console.error('Error fetching comentarios:', error);
      } finally {
        setLoading(false);
      }
    };

    getComentarios();
  }, [idNota]);

  if (loading) {
    return <div>Cargando comentarios...</div>;
  }

  return (
    <div>
      <h3>Comentarios</h3>
      <ul>
        {comentarios.map((comentario) => (
          <li key={comentario.idComentario}>
            <p>{comentario.contenido}</p>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default ComentarioList;
