import {Spacecraft, Containership} from './base-ships'
import {MilenniumFalcon} from './starfighters'
//forma name space import com o underline que é a variavel padrão do lodash
import * as _ from 'lodash'

console.log(_.pad("Typescript Example", 40, "="))

//chamada de uma clase
let ship = new Spacecraft('hyperdrive')
ship.JumpInToHyperSpace()

//chamada de classe sem parametros
let falcon = new MilenniumFalcon()
falcon.JumpInToHyperSpace()

let goodForTheJob = (ship: Containership) => ship.cargoContainers > 2

console.log(`Is Falcon good for the job? ${goodForTheJob(falcon)? 'Yes':'No'}`)