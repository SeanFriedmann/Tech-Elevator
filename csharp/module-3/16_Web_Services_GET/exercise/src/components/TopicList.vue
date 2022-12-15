<template>
  <div class="topic-list">
    <div v-for="topic in topics" v-bind:key="topic.id" class="topic">
      {{ topic.title }}
      <router-link v-bind:to="{name: 'Messages', params: {id: topic.id}}">{{ topic.title }}</router-link>
      <!--manage list of topics-->
    </div>
  </div>
</template>

<script>
import TopicService from '../services/TopicService.js'

export default {
  name: 'topic-list',
  data() {
    return {
      topics: []
    }
  },
  created(){
    //lifecycle hook
    TopicService.list()
      .then((response) => {
        this.topics = response.data;
      });
    //gives us the list, do something with it

  }
}
</script>

<style>
.topic-list {
  padding: 20px 20px;
  margin: 0 auto;
  max-width: 600px;
}
.topic {
  font-size: 24px;
  border-bottom: 1px solid #f2f2f2;
  padding: 10px 20px;
}
.topic:last-child {
  border: 0px;
}
</style>