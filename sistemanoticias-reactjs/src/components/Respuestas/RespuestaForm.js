import React, { useState } from 'react';

const RespuestaForm = ({ onSubmit }) => {
    const [contenido, setContenido] = useState('');

    const handleSubmit = (e) => {
        e.preventDefault();
        onSubmit({ contenido });
        setContenido('');
    };

    return (
        <form onSubmit={handleSubmit}>
            <textarea 
                placeholder="Escribe tu respuesta" 
                value={contenido} 
                onChange={(e) => setContenido(e.target.value)} 
                required 
            />
            <button type="submit">Responder</button>
        </form>
    );
};

export default RespuestaForm;
