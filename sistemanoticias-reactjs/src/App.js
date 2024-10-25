// src/App.js

import React from 'react';
import NotaList from './components/Notas/NotaList';
import NotaForm from './components/Notas/NotaForm';
import 'bootstrap/dist/css/bootstrap.min.css';


const App = () => {
  return (
    <div>
      <h1>Sistema de Noticias</h1>
      <NotaForm />
      <NotaList />
    </div>
  );
};

export default App;
