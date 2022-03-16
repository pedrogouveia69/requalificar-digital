import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '@/views/HomeView.vue'
import ContactView from '@/views/ContactView.vue'
import PricingView from '@/views/PricingView.vue'
import LoginView from "@/views/LoginView.vue"
import ErrorView from '@/views/ErrorView.vue'

const routes = [
  {
    path: '/',
    name: 'home',
    component: HomeView
  },
  {
    path: '/contact',
    name: 'contact',
    component: ContactView
  },
  {
    path: '/pricing',
    name: 'pricing',
    component: PricingView
  },
  {
    path: '/login',
    name: 'login',
    component: LoginView
  },
  {
    path: '/:pathMatch(.*)*',
    name: 'error',
    component: ErrorView
  },
]

const router = createRouter({
  history: createWebHistory(),
  routes,
});

export default router
