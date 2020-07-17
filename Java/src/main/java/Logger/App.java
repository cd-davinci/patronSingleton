package Logger;

import java.util.Scanner;

public class App {

    public static void main( String[] args ){

        // Obtengo el objeto Logger
        Logger logger = Logger.getInstance();

        // Hago una cuenta
        int num = 5;
        num = num * 43;

        // Log del resultado
        logger.imprimir(Integer.toString(num));

        // Mantengo la consola en espera para poder leer el resultado
        Scanner scanner = new Scanner(System.in); 
        scanner.nextLine();
        scanner.close();
        
    }
    
}
