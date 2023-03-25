using System.Runtime.ConstrainedExecution;

void advivina()
{
    const int Oportunidades = 4;
    int numeroCPU, numeroUsuario;
    byte Intentos, BanderaCotrol;
    string linea;
    Random ran = new Random();
    do
    {
        numeroCPU = Convert.ToInt32(ran.Next(100));
        Console.WriteLine(numeroCPU);

    } while (!(numeroCPU >= 1 & (numeroCPU >= 20)));
    Intentos = 1;
    BanderaCotrol = 0;
    do
    {

        Console.WriteLine("Hola estoy pensando en un´número, cual crees que es?");
        numeroUsuario = Convert.ToInt32(Console.ReadLine());

        if (numeroUsuario == numeroCPU)
        {
            Console.WriteLine("Yes, adivinaste");
            BanderaCotrol = 1;

        }
        else
        {
            if (numeroUsuario < numeroCPU)
            {
                Console.WriteLine("El numero que ingresaste es menor, piensa otro numero");
            }
            else
            {
                Console.WriteLine("El numero que ingresaste es mayor, piensa otro numero");
            }
        }
        Intentos++;
    } while ((Intentos <= Oportunidades) & (BanderaCotrol == 0));
    if (BanderaCotrol == 0)
    {
        Console.WriteLine("Lo siento no adivinaste");
    }
}

void buscaMayor()
{
    int mayor = 0;
    int numero = 0;
    Random rand = new Random();

    for (int i = 0; i < 5; i++)
    {
        numero = rand.Next(100);
        if (numero > mayor)
        {
            mayor = numero;
        }
    }
    Console.WriteLine("El numero mayor es:" + mayor);
}
//buscaMayor();
//Adivina();
void buscaMenor()
{
    int menor= 100;
    int numero = 0;
    Random rand = new Random();

    for (int i = 0; i < 5; i++)
    {
        numero = rand.Next(100);
        if (numero < menor)
        {
            menor = numero;
        }
    }
    Console.WriteLine("El numero menor es:" + menor );
}
//buscaMenor();
//Console.ReadLine();
void arreglos()
{
    int[] notas = new int[10];
    Random rand = new Random();
    for (int i=0; i< notas.Length; i++)
    {
        notas [i] = rand.Next(100);
    }
    Console.WriteLine("desplegando informacion");
   for (int i =0; i< notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
    }
    //double promedioNotas = (double)sumaNotas / notas.Length;

}

void nombres()
{
    string[] nombre = new string[11];
    nombre[0] = "Jairo";
    nombre[1] = "Pedro";
    nombre[2] = "Javier";
    nombre[3] = "Fatima";
    nombre[4] = "Daniela";
    nombre[5] = "Ardany";
    nombre[6] = "Angela";
    nombre[7] = "Ruldyn";
    nombre[8] = "Nixon";
    nombre[9] = "Dayanee";
    /*for (int i = 0; i < nombre.Length; i++)
    {
        Console.WriteLine(i + ":" + nombre[i]);
    }*/
    Random rnd = new Random();

    int primerLugar = rnd.Next(0, nombre.Length);

    int segundoLugar;
    do
    {
        segundoLugar = rnd.Next(0, nombre.Length);
    } while (segundoLugar == primerLugar);

    string primerLugarx = nombre[primerLugar];
    string segundoLugarxx = nombre[segundoLugar];

    Console.WriteLine("El ganador del cerdo sin pierna es : " + primerLugar );
    Console.WriteLine("El ganador de la pierna de cerdo es: "+ segundoLugar);
}
   

nombres();
Console.ReadLine();