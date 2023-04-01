class Prestamo{
    //Atributos de la clase
    public string nombreCliente { get; set; }

//     //Metodos
    public void Patrimonio(){
        Console.WriteLine("Cuentas con algun patrimonio(Propiedades, negocios, empresas, etc.)\nDigite Si o No");
        string PatrimonioCliente = Console.ReadLine();
        if (PatrimonioCliente == "Si"){
            bool Patrimonio = true; 
            
        }
        else
        {
            bool Patrimonio = false;
            
        }
    }
    public bool DeudasOtrosBancos(){
        Console.WriteLine("Tiene deudas en otros bancos?\nDigite Si o No");
        string DeudasExternas = Console.ReadLine();
        if (DeudasExternas == "No"){
            bool DeudasOtrosBancos = false; 
            
            return DeudasOtrosBancos;
        }
        else
        {
            bool DeudasOtrosBancos = true;
            
            return DeudasOtrosBancos;
        }
        
    }
    public void AntecedentesJudiciales(){
        Console.WriteLine("Ha tenido antecedentes penales?\nDigite Si o No");
        string AntecedentesCliente = Console.ReadLine();
        if (AntecedentesCliente == "No"){
            bool AntecedentesJudiciales = false; 
            
        }
        else
        {
            bool AntecedentesJudiciales = true;
            
        }
    }
    public void AutorizacionCredito(){
        Patrimonio();
        AntecedentesJudiciales();
        if (DeudasOtrosBancos()==false)
        {
            Console.WriteLine($"Señor(a){nombreCliente}, su Crédito ha sido aprobado, dirigete a una de nuestras sucursales y realiza la firma del contrato para recibir el depósito!");
        }
        else
        {
            Console.WriteLine($"Señor(a){nombreCliente}, su Crédito ha sido denegado, nuestro banco no cuenta con prestamos a clientes con deudas en entidades externas a la nuestra.");
        }
    }
    
}