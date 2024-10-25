import React from 'react';

const RespuestaList = ({ respuestas }) => {
    return (
        <div>
            <h4>Respuestas</h4>
            <ul>
                {respuestas.map(respuesta => (
                    <li key={respuesta.idRespuesta}>
                        <p>{respuesta.contenido}</p>
                    </li>
                ))}
            </ul>
        </div>
    );
};

export default RespuestaList;
