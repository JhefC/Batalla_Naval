using System.Runtime.Intrinsics.X86;

static void MenuDias()
{
    Console.WriteLine("1) ingrese ventas del lunes"     );
    Console.WriteLine("2) ingrese ventas del martes"    );
    Console.WriteLine("3) ingrese ventas del miercoles" );
    Console.WriteLine("4) ingrese ventas del jueves"    );
    Console.WriteLine("5) ingrese ventas del viernes"   );
    Console.WriteLine("6) ingrese ventas del sabado"    );
    Console.WriteLine("7) ingrese ventas del domingo"   );

}

float[] ventasLunes = new float[3];
float[] ventasMartes = new float[3];
float[] ventasMiercoles = new float[3];
float[] ventasJueves = new float[3];
float[] ventasViernes = new float[3];
float[] ventasSabado = new float[3];
float[] ventasDomingo = new float[3];


MenuDias();
System.Console.WriteLine("ingrese opcion");
int opcion = int.Parse(System.Console.ReadLine());




switch (opcion)   
{
    case 1:
        {
            System.Console.WriteLine("ingrese ventas del lunes");
            for (int i = 0; i < ventasLunes.Length; i++)
            {
                System.Console.WriteLine($"ingrese venta {i + 1}");
                ventasLunes[i] = float.Parse(System.Console.ReadLine());
            }
        }
        break;
    case 2:
        {
            System.Console.WriteLine("ingrese ventas del martes");
            for (int i = 0; i < ventasMartes.Length; i++)
            {
                System.Console.WriteLine($"ingrese venta {i + 1}");
                ventasMartes[i] = float.Parse(System.Console.ReadLine());
            }
        }
        break;
    case 3:
        {
            System.Console.WriteLine("ingrese ventas del miercoles");
            for (int i = 0; i < ventasMiercoles.Length; i++)
            {
                System.Console.WriteLine($"ingrese venta {i + 1}");
                ventasMiercoles[i] = float.Parse(System.Console.ReadLine());
            }
        }
        break;
    case 4:
        {
            System.Console.WriteLine("ingrese ventas del jueves");
            for (int i = 0; i < ventasJueves.Length; i++)
            {
                System.Console.WriteLine($"ingrese venta {i + 1}");
                ventasJueves[i] = float.Parse(System.Console.ReadLine());
            }
        }
        break;
    case 5:
        {
            System.Console.WriteLine("ingrese ventas del viernes");
            for (int i = 0; i < ventasViernes.Length; i++)
            {
                System.Console.WriteLine($"ingrese venta {i + 1}");
                ventasViernes[i] = float.Parse(System.Console.ReadLine());
            }
        }
        break;
    case 6:
        {
            System.Console.WriteLine("ingrese ventas del sabado");
            for (int i = 0; i < ventasSabado.Length; i++)
            {
                System.Console.WriteLine($"ingrese venta {i + 1}");
                ventasSabado[i] = float.Parse(System.Console.ReadLine());
            }
        }
        break;
    case 7:
        {
            System.Console.WriteLine("ingrese ventas del domingo");
            for (int i = 0; i < ventasDomingo.Length; i++)
            {
                System.Console.WriteLine($"ingrese venta {i + 1}");
                ventasDomingo[i] = float.Parse(System.Console.ReadLine());
            }
        }
        break;
    default:
        System.Console.WriteLine("opcion no valida");
        break;
}

//totatizar dias

float ACUMULADOR = 0;
float[] DiasTotal = new float[7]; //SE PONE 7 POR QUE SON 7 DIAS DE LA SEMANA

//total del Lunes
for(int i=0; i < ventasLunes.Length; i++)
{
    ACUMULADOR = ACUMULADOR + ventasLunes[i];
}
DiasTotal [0] = ACUMULADOR;

//total del Martes
for(int i=0; i < ventasMartes.Length; i++)
{
    ACUMULADOR = ACUMULADOR + ventasMartes[i];
}
DiasTotal [1] = ACUMULADOR;

//total del Miercoles
for(int i=0; i < ventasMiercoles.Length; i++)
{
    ACUMULADOR = ACUMULADOR + ventasMiercoles[i];
}
DiasTotal [2] = ACUMULADOR;

//total del Jueves 
for(int i=0; i < ventasJueves.Length; i++)
{
    ACUMULADOR = ACUMULADOR + ventasJueves[i];
}
DiasTotal [3] = ACUMULADOR;

//total del Viernes
for(int i=0; i < ventasViernes.Length; i++)
{
    ACUMULADOR = ACUMULADOR + ventasViernes[i];
}
DiasTotal [4] = ACUMULADOR;

//total del Sabado
for(int i=0; i < ventasSabado.Length; i++)
{
    ACUMULADOR = ACUMULADOR + ventasSabado[i];
}
DiasTotal [5] = ACUMULADOR;

//total del Domingo
for(int i=0; i < ventasDomingo.Length; i++)
{
    ACUMULADOR = ACUMULADOR + ventasDomingo[i];
}
DiasTotal [6] = ACUMULADOR;

//imprimir ventas totales de la semana
Console.WriteLine($"ACUMULADOR{ACUMULADOR}");
for(int i=0; i < DiasTotal.Length; i++)
{
    System.Console.WriteLine($"el total del dia {i + 1} es: {DiasTotal[i]}");
}