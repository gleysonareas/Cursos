let year: number = 2011;

//Formas de converter uma string para um tipo numérico
let year_two: number = Number("2021");
// year_two = +"2022"; 
// year_two = parseInt("1992");
// year_two = parseFloat("3.1");

console.log(year + year_two);

const LARGENUMBER = 50n;
//Porem nesse caso é gerado o erro pois a versão para a qual o meu TS está tranpilando o 
//código é um ES5 e este tipo só está disponivel a partir do ES2020.