{
    //declaração de variavel tipo string
    var message = "help me, Obi-Wan Kenobi. You're my only hope!";
    console.log(message);
    //declaração de variavel tipo número
    var episode = 4;
    console.log("This is episode: " + 4);
    episode = episode + 1;
    console.log("Next episode is:" + episode);
    /*
    Lembrando que se eu não tipar a variavel ela pode ser auto definida como any.
    O que talvez possa gerar algum erro mais adiante caso seja uma variavel especifica.
    Então é sempre uma boa pratica tipar as variaveis.
    */
    var favoriteDroid = void 0;
    favoriteDroid = 'bb-8';
    console.log("My favorite droid is " + favoriteDroid);
    //Function normal
    var isEnoughToBeatMF = function (parsecs) {
        return parsecs < 12;
    };
    var distance = 11;
    console.log("Is " + distance + " parsecs enough to beat Millennium Falcon? " + (isEnoughToBeatMF(distance) ? 'Yes' : 'No') + " ");
    //Arron function
    var call = function (name) { return console.log("Do you copy, " + name + "?"); };
    call('R2');
    //função de incremento
    function inc(speed, inc) {
        if (inc === void 0) { inc = 1; }
        return speed + inc;
    }
    console.log("inc(5,1) = " + inc(5, 1));
    console.log("inc(5) = " + inc(5));
}
