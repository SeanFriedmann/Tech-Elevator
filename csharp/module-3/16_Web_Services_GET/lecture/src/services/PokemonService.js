import axios from 'axios';

const http = axios.create({
  baseURL: "http://pokeapi.co/api/v2/pokemon"
});

export default {
    getPokemon(name) {
        return http.get('/' + name);
    }
}