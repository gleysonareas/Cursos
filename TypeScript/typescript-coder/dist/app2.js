"use strict";
exports.__esModule = true;
var base_ships_1 = require("./base-ships");
var starfighters_1 = require("./starfighters");
//forma name space import com o underline que é a variavel padrão do lodash
var _ = require("lodash");
console.log(_.pad("Typescript Example", 40, "="));
//chamada de uma clase
var ship = new base_ships_1.Spacecraft('hyperdrive');
ship.JumpInToHyperSpace();
//chamada de classe sem parametros
var falcon = new starfighters_1.MilenniumFalcon();
falcon.JumpInToHyperSpace();
var goodForTheJob = function (ship) { return ship.cargoContainers > 2; };
console.log("Is Falcon good for the job? " + (goodForTheJob(falcon) ? 'Yes' : 'No'));
