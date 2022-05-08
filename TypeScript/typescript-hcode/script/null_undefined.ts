const elementHtml: HTMLHeadingElement | null = document.querySelector("h2");

let db: string | null = "mysql, 127.0.0.1, password";

db = null;

let myVar: string | undefined;

if (new Date().getDate() === 15) {
  myVar = "Hoje é dia 15";
}

console.log(myVar);

//Diferenças:  null o valor não existe, já o undefined o valor ou a propriedade existe porem ainda não foi definida.
