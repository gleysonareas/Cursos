import Vue from 'vue'
import App from './App.vue'
import Contadores from './Contadores.vue' //Registro de forma Global

Vue.config.productionTip = false
Vue.component('app-contadores', Contadores) //Feito dessa forma

new Vue({
  render: h => h(App),
}).$mount('#app')
