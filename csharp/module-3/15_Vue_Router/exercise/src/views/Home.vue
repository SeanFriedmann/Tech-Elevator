<template>
    <div id="home">
        
        <best-seller-list/>
        <new-release-list/>
    
    
    </div>
</template>

<script>
import BestSellerList from '../components/BestSellerList.vue';
import NewReleaseList from '../components/NewReleasesList.vue';

export default {
    components: {
        BestSellerList,
        NewReleaseList
    }
}
</script>

<style>

</style>