let value: any;

value: true;
value: 1000;
value: "Gleyson";

console.log(typeof value);

// Tipo any não deve ser usado de qualquer forma, existem situações 
// em que ele é necessário como por exemplo ao se trabalhar com banco de dados.
// Apenas mais uma observação, por padrão propriedades que ainda são undefined retornam any
// porem ao ser atribuido um valor para ela a mesma passa a ser do tipo que foi inferido a ela atraves do valor.
 