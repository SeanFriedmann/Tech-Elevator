import Vue from 'vue'
import VueRouter from 'vue-router'
import Products from '../views/Products.vue'
import ProductDetail from '../views/ProductDetail.vue'
import AddReview from '../components/AddReview.vue'

Vue.use(VueRouter)

const routes = [
  //define the routes to views
  //each route is its own object
  {
    path: '/', //this is the route
    name: 'products', //good practice to give route a name
    component: Products //this is the view
  },
  {
    path: '/products/:id', //dynamic route based on product id
    name: 'product-detail', //route name
    component: ProductDetail //view
  },
  {
    path: '/products/:id/add-review', //add review to a specific product
    name: 'add-review',
    component: AddReview
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
