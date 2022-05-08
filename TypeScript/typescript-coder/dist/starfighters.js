"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    }
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
exports.__esModule = true;
//Import de arquivos com caminhos relativos
var base_ships_1 = require("./base-ships");
//extensão de classes
var MilenniumFalcon = /** @class */ (function (_super) {
    __extends(MilenniumFalcon, _super);
    function MilenniumFalcon() {
        var _this = _super.call(this, 'hyperdrive') || this;
        _this.cargoContainers = 2;
        return _this;
    }
    MilenniumFalcon.prototype.JumpInToHyperSpace = function () {
        if (Math.random() >= 0.5) {
            _super.prototype.JumpInToHyperSpace.call(this);
        }
        else {
            console.log('Failed to jump into hyper space!');
        }
    };
    return MilenniumFalcon;
}(base_ships_1.Spacecraft));
exports.MilenniumFalcon = MilenniumFalcon;
