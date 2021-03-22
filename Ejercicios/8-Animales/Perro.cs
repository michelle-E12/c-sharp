namespace Animales
{
    class Perro: Mamiferos
    {
        public bool Ladrar { get; set; }
        public bool Aullan { get; set; }
        public Perro(string nombre, int patas)
        {
            Nombre = nombre;
            Patas = patas;
        }

        public void MetodoPerro()
        {
            Comer = true;
            TomarAgua = true;
            Dormir = true;
            Caminar = true;
            Muerden = true;
            FuncionPerro();
        }

        private void FuncionPerro()
        {
            Ladrar = true;
            Aullan = true;
        }
    }
}