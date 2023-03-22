using System;
using System.IO;
using System.Collections.Generic;

    public class Pelicula
    {
        //Campos
        private string titulo;
        private Int16 año;
        private string país;
        private string director;
        
        //Constructores
        public Pelicula()
        {

        } 
        
       // Faltan dos sobrecargas de Pelicula()  

       //Métodos
        public String GetTitulo() => titulo;
        public void SetTitulo(String titulo) => this.titulo = titulo;
        public Int16 GetAño() => año;
        public void SetAño(Int16 año) => this.año = año;    
    }


