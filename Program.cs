//Producto 1 Proceso hacer un prestamo en una entidad financiera

// //Se le solicitan al cliente que busca el prestamo los datos necesarios
Console.WriteLine("Producto 1 - Proceso para hacer un prestamo para una entidad financiera");
Console.WriteLine("Ingrese su nombre");
string nombreDeudor = Console.ReadLine();

var BancoPereira = new Prestamo(){
    nombreCliente = nombreDeudor
};

BancoPereira.AutorizacionCredito();

//-------------------------------------------------------------------------------------------------------------------------------------------

//Producto 2 Verificar el estado de grupo de trabajo

//Verificar dia de la semana - Verificar hora - Verificar estado del grupo - Lista actual de asuntos
Console.WriteLine("Producto 2 - Proceso para verificar actividad y enviar listado de asuntos de un grupo de trabajo");
Console.WriteLine("Ingrese el día de la semana");
string diaSemana = Console.ReadLine();

Console.WriteLine("Ingrese los asuntos que trata su grupo actualmente");
string AsuntosdeGrupo = Console.ReadLine();

var GrupoTrabajo3 = new EstadoGrupoViernes(){
    diaDeSemana = diaSemana,
    AsuntosGrupo = AsuntosdeGrupo
};


GrupoTrabajo3.EstadoGrupo();