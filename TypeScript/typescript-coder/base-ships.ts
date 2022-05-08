//Lembrando que para criar uma clase você deve sempre utilizar a primeira letra em caixa alta
class Spacecraft{
    //toda classe vai ter sempre um construtor
    constructor(public propulsor: string){}

    //aqui fazemos a declaração de um método
    JumpInToHyperSpace() {
        console.log(`Entering hyperspace with ${this.propulsor}`)
    }
}

//Criação de inteface
interface Containership {
    cargoContainers: number
}

//fazendo um export de class e interface
export {Spacecraft, Containership}