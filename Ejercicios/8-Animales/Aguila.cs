namespace Animales
{
    class Aguila: Aves
    {
        public bool VolarAlto { get; set; }
        public Aguila(string nombre, string colorPlumaje)
        {
            Nombre = nombre;
            ColorPlumaje = colorPlumaje;
        }
        public void MetodoAguila()
        {
            Comer = true;
            TomarAgua = true;
            Dormir = true;
            Volar = true;
            PonenHuevos = true;
            FuncionAguila();
            
        }

        private void FuncionAguila()
        {
            VolarAlto = true;

        }
    }
}