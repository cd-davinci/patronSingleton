
class Logger:

    __instance = None

    def __init__(self):

        if Logger.__instance != None:
            raise Exception("Esta clase es singleton!")
        else:
            Logger.__instance = self

    @staticmethod
    def getInstance():

        if Logger.__instance == None:
            Logger()
        return Logger.__instance

    def imprimir(self, text):

        """ Si en vez de imprimirlo por consola quisiera guardarlo
        por ejemeplo en un archivo, solo tendria que cambiar esta
        linea y el resto del programa no se enteraria
        """
        print(text)