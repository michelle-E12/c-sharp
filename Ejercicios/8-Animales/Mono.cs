namespace Animales
{
    class Mono: Mamiferos
    {
        public bool Maullar { get; set; }
        public bool Violentos { get; set; }
        public Mono(string nombre, int patas)
        {
            Nombre = nombre;
            Patas = patas;
        }

        public void MetodoMono()
        {
            Comer = true;
            TomarAgua = true;
            Dormir = true;
            Caminar = true;
            Muerden = true;
           FuncionMono();
        }

        private void FuncionMono()
        {
            Maullar = true;
            Violentos = true;

        }
    }
}