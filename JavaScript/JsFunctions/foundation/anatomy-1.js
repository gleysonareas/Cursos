//function declaration

//Função sem parametro e sem retorno
function sayHello() {
    console.log('Hello!')
}

sayHello()

//Funcão sem retorno mais com parametro
function sayHelloTwo(name) {
    console.log('Hello ' + name)
    console.log(`Hello ${name}!`)
}

sayHelloTwo('Gleyson')

//Função com retorno
function returnHi() {
    return 'Hi'
}

let greeting = returnHi()
console.log(greeting)

console.log(returnHi())

//função com retorno e com parametro
function returnHitwo(name) {
    return `Hi ${name}!`
}

console.log(returnHitwo('Gleyson'))