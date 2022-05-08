//Import de arquivos com caminhos relativos
import {Spacecraft, Containership} from './base-ships'

//extensão de classes
export class MilenniumFalcon extends Spacecraft implements Containership{
    cargoContainers: number

    constructor(){
        super('hyperdrive')
        this.cargoContainers = 2
    }

    JumpInToHyperSpace(){
        if(Math.random() >= 0.5){
            super.JumpInToHyperSpace()
        }else{
            console.log('Failed to jump into hyper space!')
        }
    }
}