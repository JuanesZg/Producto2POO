class EstadoGrupoViernes{
    //Atributos
    public string diaDeSemana { get; set; }
    public string AsuntosGrupo { get; set; }
    //Metodos
    public bool Viernes6PM(){
        if (diaDeSemana == "Viernes")
        {
            Console.WriteLine("Ingrese la hora del día");
            string HoraViernes = Console.ReadLine();
            if (HoraViernes == "6pm")
            {
                bool Mensaje = true;
                return Mensaje;

            }
            else
            {
                Console.WriteLine("Hoy es día viernes pero la lista de asuntos debe enviarse a las 6pm, intentelo luego");
                bool Mensaje = false;
                return Mensaje;
            }
        }
        else
        {
            Console.WriteLine("Hoy no es día viernes, no debe enviar la lista de asuntos de su grupo");
            bool Mensaje = false;
            return Mensaje;
        }
    }
    public void EstadoGrupo(){
        if (Viernes6PM()==true)
        {
            Console.WriteLine($"Hoy es día viernes, son las 6pm y la lista de asuntos de su grupo que se enviara es la siguiente: {AsuntosGrupo}");
        }
    }
}