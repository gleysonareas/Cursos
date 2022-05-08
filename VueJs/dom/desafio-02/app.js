new Vue({
    el: '#desafio',
    data: {
        valor: ''
    },
    methods:{
        alertar(){
            alert('Isso é um alerta!')
        },
        armazenar(event){
            this.valor = event.target.value
        }
    }
})