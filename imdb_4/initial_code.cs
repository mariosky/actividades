using System;
using System.IO;
using System.Collections.Generic;

    public class Pelicula
    {
        //Campos
        private String titulo;
        private Int16 año;
        private String país;
        private String director;
        private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula()
        {

        } 
        public Pelicula(string titulo, Int16 año )
        {
            this.titulo = titulo;
            this.año = año;
        }
        //Métodos
        public String GetTitulo() => titulo;
        public void SetTitulo(String titulo) => this.titulo = titulo;
        public Int16 GetAño() => año;
        public void SetAño(Int16 año) => this.año = año;

        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");
        }

        public void AgregaActor(Actor a)
        {

        }

        public void ImprimeActores()
        {

        }

    }

    public class Actor
    {
        //Propiedades

        //Constructores
        public Actor(String nombre, Int16 año){

        } 

        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }
