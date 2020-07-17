
class Logger {

    constructor(){
        if(!Logger.instance) {
            Logger.instance = this;
        }
    }

    getInstance(){
        return Logger.instance;
    }

    imprimir(text){

        /* Si en vez de imprimirlo por consola quisiera guardarlo
        por ejemplo en un archivo, solo tendria que cambiar esta
        linea y el resto del programa no se enteraria */
        
        console.log(text);
        
    }

}

exports.Logger = Logger;

