using System;
namespace ProyectTarea1
{
    public class Person1
    {
        private string Nombre;
        private string Apellido;
        

        public Person1(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
            
        }

        public int Lanzar()
        {
            Random Numero = new Random();
            int CaChiPun = Numero.Next(0, 3);
            return CaChiPun;
        }
        public string SetCompleteName()
        {
            string CoNa = Nombre + " " + Apellido;
            return CoNa;
        }



       
    }
}
