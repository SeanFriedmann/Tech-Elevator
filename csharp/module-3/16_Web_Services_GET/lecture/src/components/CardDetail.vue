<template>
  <div>
    <h1>{{card.title}}</h1>
    <h2>{{card.status}} -- {{card.date}}</h2>
    <p>{{card.description}}</p>
    <comments-list v-bind:comments="card.comments"/>
  </div>
</template>

<script>
import boardService from '../services/BoardService.js';
import commentsList from '../components/CommentsList.vue';

export default {
  name: "card-detail",
  components: { commentsList },
  data() {
    return {
      card: {}
    }
  },
  //get data from api, put the call in the created hook
  created() {
    boardService.getCard(this.$route.params.boardID, 
    this.$route.params.cardID).then((response) => {
      this.card = response; //do not need .data for this one
    })
    //handles promise in the function and passes data back to the component
  }
};
</script>
