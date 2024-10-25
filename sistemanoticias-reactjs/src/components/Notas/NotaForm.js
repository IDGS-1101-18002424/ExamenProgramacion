import React, { useState } from 'react';
import { createNota } from '../../services/notaService';

const NotaForm = () => {
    const [titulo, setTitulo] = useState('');
    const [contenido, setContenido] = useState('');
    const [idPersonal, setIdPersonal] = useState('');

    const handleSubmit = async (event) => {
        event.preventDefault();
        try {
            await createNota({ titulo, contenido, idPersonal });
            // Aquí podrías agregar lógica para limpiar el formulario o mostrar un mensaje
        } catch (error) {
            console.error("Error creating nota:", error);
        }
    };

    return (
        <div className="container mt-4">
            <h2>Crear Nueva Nota</h2>
            <form onSubmit={handleSubmit}>
                <div className="mb-3">
                    <label htmlFor="titulo" className="form-label">Título</label>
                    <input 
                        type="text" 
                        className="form-control" 
                        id="titulo" 
                        value={titulo} 
                        onChange={(e) => setTitulo(e.target.value)} 
                        required 
                    />
                </div>
                <div className="mb-3">
                    <label htmlFor="contenido" className="form-label">Contenido</label>
                    <textarea 
                        className="form-control" 
                        id="contenido" 
                        value={contenido} 
                        onChange={(e) => setContenido(e.target.value)} 
                        required 
                    />
                </div>
                <div className="mb-3">
                    <label htmlFor="idPersonal" className="form-label">ID Personal</label>
                    <input 
                        type="number" 
                        className="form-control" 
                        id="idPersonal" 
                        value={idPersonal} 
                        onChange={(e) => setIdPersonal(e.target.value)} 
                        required 
                    />
                </div>
                <button type="submit" className="btn btn-primary">Crear Nota</button>
            </form>
        </div>
    );
};

export default NotaForm;
