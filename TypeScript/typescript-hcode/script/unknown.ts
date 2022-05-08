let result: unknown;

result = { 
    sucesso: true,
};

result = "Deu tudo certo";
result = 200;

//========================

const info: any = 150;
const infoUnknown: unknown = 250;

const firstNumber: number = info;
//const secondNumber: number = infoUnknown;

// Tipo unknown depois que ele já teve o seu valor definido, não é possivel atribuilo a uma propridade 
// que possui um tipo diferente, diferentemente do tipo any que mesmo que já tenha recebido um valor de
// ele ainda poderá ser atribuido a uma propridade de um outro tipo. 