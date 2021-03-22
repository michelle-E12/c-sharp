namespace Animales
{
    class PezGlobo: Peces
    {
        public bool Inflarse { get; set; }
        public bool Venenoso { get; set; }
        public PezGlobo(string nombre, int numeroAletas)
        {
            Nombre = nombre;
            NumeroAletas = numeroAletas;
        }
        public void MetodoPezGlobo()
        {
            Comer = true;
            TomarAgua = true;
            Dormir = true;
            Nadar = true;
            FuncionPezGlobo();
        }
        private void FuncionPezGlobo()
        {
            Inflarse = true;
            Venenoso =true;
        }
    }
}