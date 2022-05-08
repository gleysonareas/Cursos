<template>
    <div class="contadores">
        <h1>Contadores</h1>
        <app-contador v-for="c in 5" :key="c"/>
    </div>
</template>

<script>
import Contador from './Contador.vue' //aqui o registro de forma local 
export default {
    components: { 'app-contador': Contador} //feito dessa forma

}
</script>

<style>

</style>
