namespace Animales
{
    class Gato: Mamiferos
    {
        public bool Maullar { get; set; }
        public bool Ronronear { get; set; }
        public Gato(string nombre, int patas)
        {
            Nombre = nombre;
            Patas = patas;
        }

        public void MetodoGato()
        {
            Comer = true;
            TomarAgua = true;
            Dormir = true;
            Caminar = true;
            Muerden = true;
            FuncionGato();
        }

        private void FuncionGato()
        {
            Maullar = true;
            Ronronear = true;
        }
    }
}