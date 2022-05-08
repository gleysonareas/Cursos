"use strict";
exports.__esModule = true;
//Lembrando que para criar uma clase você deve sempre utilizar a primeira letra em caixa alta
var Spacecraft = /** @class */ (function () {
    //toda classe vai ter sempre um construtor
    function Spacecraft(propulsor) {
        this.propulsor = propulsor;
    }
    //aqui fazemos a declaração de um método
    Spacecraft.prototype.JumpInToHyperSpace = function () {
        console.log("Entering hyperspace with " + this.propulsor);
    };
    return Spacecraft;
}());
exports.Spacecraft = Spacecraft;
