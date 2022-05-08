{
    //declaração de variavel tipo string
    let message: string = "help me, Obi-Wan Kenobi. You're my only hope!"
    console.log(message)
    
    //declaração de variavel tipo número
    let episode: number = 4
    console.log("This is episode: " + 4)
    episode = episode + 1
    console.log("Next episode is:" + episode)

    /*
    Lembrando que se eu não tipar a variavel ela pode ser auto definida como any. 
    O que talvez possa gerar algum erro mais adiante caso seja uma variavel especifica.
    Então é sempre uma boa pratica tipar as variaveis.
    */
    let favoriteDroid
    favoriteDroid = 'bb-8'
    console.log("My favorite droid is " + favoriteDroid)

    //Function normal
    let isEnoughToBeatMF = function(parsecs: number): boolean {
        return parsecs < 12
    }

    let distance = 11
    console.log(`Is ${distance} parsecs enough to beat Millennium Falcon? ${isEnoughToBeatMF(distance) ? 'Yes': 'No'} `)

    //Arron function
    let call = (name: string) => console.log(`Do you copy, ${name}?`)
    call ('R2')


    //função de incremento
    function inc (speed: number, inc: number = 1): number{
        return speed + inc
    }
    console.log(`inc(5,1) = ${inc(5,1)}`)
    console.log(`inc(5) = ${inc(5)}`)
}