namespace Animales
{
    class Loro: Aves
    {
        public bool Hablar { get; set; }
        public Loro(string nombre, string colorPlumaje)
        {
            Nombre = nombre;
            ColorPlumaje = colorPlumaje;
        }

        public void MetodoLoro()
        {
            Comer = true;
            TomarAgua = true;
            Dormir = true;
            Volar = true;
            PonenHuevos = true;
            FuncionLoro();
        }

        private void FuncionLoro()
        {
            Hablar = true;
        }
    } 
}