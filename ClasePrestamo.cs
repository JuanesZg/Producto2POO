class Prestamo{
    //Atributos de la clase
    public string nombreCliente { get; set; }
    public bool PatrimonioCliente { get; set; }
    public int DeudasExternas { get; set; }
    public bool AntecedentesCliente { get; set; }

//     //Metodos
    public void AutorizacionCredito(){
        if (DeudasExternas==1)
        {
            Console.WriteLine("Tu Crédito ha sido aprobado, dirigete a una de nuestras sucursales y realiza la firma del contrato para recibir el depósito!");
        }
        else
        {
            Console.WriteLine("Tu Crédito ha sido denegado, nuestro banco no cuenta con prestamos a clientes con deudas en entidades externas a la nuestra.");
            break;
        }
        
        // switch (DeudasExternas)
        // {
        //     case 1:
        //         Console.WriteLine("Tu Crédito ha sido aprobado, dirigete a una de nuestras sucursales y realiza la firma del contrato para recibir el depósito!");
        //     default:
        //         Console.WriteLine("Tu Crédito ha sido denegado, nuestro banco no cuenta con prestamos a clientes con deudas en entidades externas a la nuestra.");
        //         break;
        // }
    }
    
}
    