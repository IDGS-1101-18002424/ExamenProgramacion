import React, { useEffect, useState } from 'react';
import { fetchNotas } from '../../services/notaService'; // Asegúrate de que esta función esté correctamente exportada
import 'bootstrap/dist/css/bootstrap.min.css';

const NotaList = () => {
    const [notas, setNotas] = useState([]);
    const [loading, setLoading] = useState(true);

    const getNotas = async () => {
        try {
            const response = await fetchNotas();
            if (response && response.data) {
                setNotas(response.data);
            } else {
                console.log("No se encontraron notas.");
            }
        } catch (error) {
            console.error("Error fetching notas:", error);
        } finally {
            setLoading(false);
        }
    };

    useEffect(() => {
        getNotas();
    }, []);

    if (loading) {
        return <p>Cargando notas...</p>;
    }

    return (
        <div className="container mt-4">
            <h2>Lista de Notas</h2>
            {notas.length === 0 ? (
                <p>No se encontraron notas.</p>
            ) : (
                <table className="table">
                    <thead>
                        <tr>
                            <th>Título</th>
                            <th>Contenido</th>
                            <th>Fecha de Publicación</th>
                        </tr>
                    </thead>
                    <tbody>
                        {notas.map(nota => (
                            <tr key={nota.idNota}>
                                <td>{nota.titulo}</td>
                                <td>{nota.contenido}</td>
                                <td>{new Date(nota.fecha_Publicacion).toLocaleDateString()}</td>
                            </tr>
                        ))}
                    </tbody>
                </table>
            )}
        </div>
    );
};

export default NotaList;
