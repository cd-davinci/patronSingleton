
from Logger import Logger

if __name__ == "__main__":

    # Obtengo el objeto Logger
    logger = Logger().getInstance()

    # Hago una cuenta
    num = 5
    num = num * 43

    # Log del resultado
    logger.imprimir(num)

    # Mantengo la consola en espera para poder leer el resultado
    input()