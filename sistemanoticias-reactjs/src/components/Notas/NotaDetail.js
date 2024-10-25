import React from 'react';

const NotaDetail = ({ nota }) => {
    return (
        <div>
            <h2>{nota.titulo}</h2>
            <p>{nota.contenido}</p>
            <p>Publicado el: {new Date(nota.fecha_Publicacion).toLocaleString()}</p>
        </div>
    );
};

export default NotaDetail;
