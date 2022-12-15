<template>
    <div>
        <h1>Products</h1>
        <products-list/>
    </div>
</template>

<script>
//import the components you want to use in the vue
import ProductsList from '../components/ProductsList.vue'

export default {
    //add components used to the components object
    components: {
        ProductsList
    }
}
</script>

<style>

</style>