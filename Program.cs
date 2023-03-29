//Se le solicitan al cliente que busca el prestamo los datos necesarios
Console.WriteLine("Ingrese su nombre");
string nombreDeudor = Console.ReadLine();

Console.WriteLine("Cuentas con algun patrimonio(Propiedades, negocios, empresas, etc.)?");
bool Patrimonio = bool.Parse(Console.ReadLine());

Console.WriteLine("Tiene deudas en otros bancos?\n1.Si\n2.No");
int Deuda = int.Parse(Console.ReadLine());

Console.WriteLine("Ha tenido antecedentes penales?");
bool antecedentesPen = bool.Parse(Console.ReadLine());


var BancoPereira = new Prestamo(){
    nombreCliente = nombreDeudor,
    PatrimonioCliente = Patrimonio,
    DeudasExternas = Deuda,
    AntecedentesCliente = antecedentesPen
};

BancoPereira.AutorizacionCredito();
