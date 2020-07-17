
const {Logger} = require("./Logger");

var logger = new Logger().getInstance();

var num = 5;
num = num * 43;

logger.imprimir(num);