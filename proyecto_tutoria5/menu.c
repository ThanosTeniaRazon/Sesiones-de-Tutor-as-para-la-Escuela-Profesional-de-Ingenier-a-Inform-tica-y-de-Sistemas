#include <stdio.h>
#include <unistd.h>
#include <time.h>
#include <signal.h> 
#include <termios.h> // Necesario para manejar el modo de terminal
////////////////    EJERCICIO 1   ////////////////////
// Prototipo de la función de manejo de señales
// sigHandler --  Manejador de señales
static void manejoSeñal(int señal) // numero de la señal que activo la señal 
{
	// mensaje para cuando ya se recibio la señal
    printf("\nLa señal se registro correctamente !\n\n");
}

// Mostrar marca del tiempo

void marcaTiempo() 
{
	// almacenar el tiempo actual en segundos
    time_t t;
    // puntero a una estructura tm para descomponer el tiempo
    struct tm *ts;
    char buf[40];
    // Obtener la hora actual
    t = time(0);
    // Formatear e imprimir el tiempo en el formato especificado
    // convertir el tiempo almacenado ts ajustando a la zona horaria
    ts = localtime(&t);
    // strftime para formatear la estructura
    strftime(buf, sizeof(buf), "%H:%M:%S %p", ts);
    printf("La hora en el sistenma es: %s\n", buf);
}

int ejercicio1() 
{
    //  Mostrar en pantalla  
    printf("Ejercicio 1 .. Programa que espera una interrucion para mostrar la hora del sistema\n\n");
    printf("Presione Ctrl + Z \n\n");
    // Registrar el manejador de señales
    // signal se utiliza para establecer el manejo de señales
    
    if (signal(SIGTSTP, manejoSeñal) == SIG_ERR)
        return 1;

    // mensaje de espera
    printf("En espera ...!\n\n");
    // Pausar la ejecucion hasta esperar dicha ejecucion
    while (1) 
    {
       pause();
        // mostrar hora del sistema despues de la señal
        marcaTiempo();
        printf("En espera .....!\n\n");
    }
    // Salir (del bucle
    return 0;
}
///////////////   EJERCICIO 2  ////////////////////////////
int contador = 0;

// Manejador de señales
static void durmiendo(int sig) {
    // Mostrar mensaje al recibir una señal
    printf("\nSe recibió la señal\n");
    contador++;
}


int ejercicio2() {
    // Indicar propósito del programa
    printf("ESPERANDO LA COMBINACIÓN DE TECLAS CTL + Z PARA CONTINUAR\n");
    printf("\nPRESIONE CTL + Z\n");

    // Registramos nuestro manejador de señales sigHandler para la señal SIGINT
    if (signal(SIGTSTP, durmiendo) == SIG_ERR)
        exit(1);

    // Mostrar resultados
    printf("Durmiendo zzz\n\n");

    // Pausamos la ejecución del proceso
    while (contador < 2) {
        if (contador == 1) {
            printf("Sigo durmiendo zzz\n\n");
            printf("\nVuelva a interrumpir para terminar\n");
        }
        pause();
    }

    printf("Proceso terminado!\n");

    // Salir
    return 0;
}

//////////////////// EJERCICIO 3 //////////////////////////////
int ContadorSeniales = 0;

// Nuestro manejador de señales
static void sigHandler(int sig)
{
    ContadorSeniales++;
    // Mensaje que se muestra al recibir una señal
    printf("\nSe recibio senial!\t\t\t\t\t\t\tTotal: %d\n", ContadorSeniales);
    if (ContadorSeniales == 1)
        printf("\nPresione Enter para continuar o vuelva a interrumpir para terminar\n");
}

void alarmHandler()
{
    if (ContadorSeniales > 0)
        ContadorSeniales--;
    printf("\n\tSe recibio una señal de 5 segundos de inactividad\t\tTotal: %d\a\n", ContadorSeniales);
}

// Función para leer una tecla
char leerTecla()
{
    struct termios t;
    char tecla;

    // Configurar el terminal para leer una tecla sin necesidad de Enter
    tcgetattr(STDIN_FILENO, &t);
    t.c_lflag &= ~ICANON; // Desactivar modo canónico
    t.c_lflag &= ~ECHO;   // Desactivar eco de la tecla
    tcsetattr(STDIN_FILENO, TCSANOW, &t);

    // Leer una tecla
    tecla = getchar();

    // Restaurar la configuración original del terminal
    t.c_lflag |= ICANON;
    t.c_lflag |= ECHO;
    tcsetattr(STDIN_FILENO, TCSANOW, &t);

    return tecla;
}

int ejercicio3()
{
    // Variables
    int j;
    char tecla;

    // Indicar propósito del programa
    printf("ESTE PROGRAMA ESPERA LA COMBINACION DE TECLAS ENTER PARA CONTINUAR\n");
    printf("\nPRESIONE ENTER CUANDO DESEE\n");

    // Registramos nuestro manejador de señales
    if (signal(SIGINT, sigHandler) == SIG_ERR)
    {    exit(1);
    }
    // Registrar manejador de alarma
    signal(SIGALRM, alarmHandler);

    printf("DURMIENDO...\n\n");

    // Pausamos la ejecución del Proceso
    while (ContadorSeniales < 2)
    {
        // Configurar la alarma para 5 segundos
        alarm(5);
        // Leer una tecla
        tecla = leerTecla();
        // Si la tecla es Enter, aumentar el contador de señales
        if (tecla == '\n')
        {
            ContadorSeniales++;
            // Mensaje que se muestra al recibir una señal
            printf("\nSe recibio senial!\t\t\t\t\t\t\tTotal: %d\n", ContadorSeniales);
            if (ContadorSeniales == 1)
                printf("\nPresione Enter para continuar o vuelva a interrumpir para terminar\n");
        }
    }

    printf("Proceso terminado!\n");

    // Salir
    return 0;
}
int main() {
    int opcion;

    do {
        // Mostrar el menú
        printf("\n---- MENÚ ----\n");
        printf("1. Ejercicio 1\n");
        printf("2. Ejercicio 2\n");
        printf("3. Ejercicio 3\n");
        printf("4. Salir\n");

        // Pedir al usuario que elija una opción
        printf("Ingrese el número de la opción deseada: ");
        scanf("%d", &opcion);

        // Realizar acciones basadas en la opción seleccionada
        switch (opcion) {
            case 1:
                ejercicio1();
                break;
            case 2:
                ejercicio2();
                break;
            case 3:
                ejercicio3();
                break;
            case 0:
                printf("Saliendo del programa. ¡Hasta luego!\n");
                break;
            default:
                printf("Opción no válida. Por favor, ingrese una opción válida.\n");
        }
    } while (opcion != 0);

    return 0;
}
