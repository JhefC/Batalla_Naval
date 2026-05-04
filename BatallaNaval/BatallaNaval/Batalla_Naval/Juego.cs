using System;

class Program {
    static void Main() {
        // 1. Declarar la matriz de 5x5
        int[,] oceano = new int[5, 5];

        // 2. Posicionar 3 barcos manualmente
        oceano[1, 2] = 1; 
        oceano[3, 4] = 1;
        oceano[4, 0] = 1;

        Console.WriteLine("¡Océano generado y flota desplegada!");
        DibujarMapa(oceano); // Mostramos el radar inicial

        // 3. Sistema de ataque
        Console.Write("\nIngresa la Fila para atacar (0-4): ");
        int fila = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa la Columna para atacar (0-4): ");
        int columna = Convert.ToInt32(Console.ReadLine());

        // Búsqueda y Modificación
        if (oceano[fila, columna] == 1) {
            Console.WriteLine("¡IMPACTO CRÍTICO! Hundiste un barco.");
            oceano[fila, columna] = 8; 
        } else {
            Console.WriteLine("Fallaste. Solo le diste al agua.");
            oceano[fila, columna] = 9; 
        }

        // Mostramos el resultado del ataque
        DibujarMapa(oceano);
    }

    // Función para dibujar el mapa
    static void DibujarMapa(int[,] mapa) {
        Console.WriteLine("\n  0 1 2 3 4"); 
        for (int i = 0; i < 5; i++) {
            Console.Write(i + " "); 
            for (int j = 0; j < 5; j++) {
                char simbolo;
                switch (mapa[i, j]) {
                    case 1: simbolo = 'B'; break; 
                    case 8: simbolo = 'X'; break; 
                    case 9: simbolo = 'O'; break; 
                    default: simbolo = '~'; break; 
                }
                Console.Write(simbolo + " ");
            }
            Console.WriteLine();
        }
    }
    
    
}
