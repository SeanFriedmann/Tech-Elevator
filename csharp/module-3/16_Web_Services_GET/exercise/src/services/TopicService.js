import axios from 'axios';

const http = axios.create({
    baseURL: "http://localhost:3000"
});

export default {

    list() {
      return http.get('/topics');
    }, //test using postman
    //make usable in components
  
    get(id) {
      return http.get(`/topics/${id}`);
    }
  
  }
