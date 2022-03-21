import { createApp } from 'vue'
import App from './App.vue'
import router from './router'
import firebase from 'firebase'

// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
// TODO: Add SDKs for Firebase products that you want to use
// https://firebase.google.com/docs/web/setup#available-libraries

// Your web app's Firebase configuration
const firebaseConfig = {
  apiKey: "AIzaSyB_djwnz13dZi4GndGj3BPQ85aQGdkF9U0",
  authDomain: "proj-web1-8efd2.firebaseapp.com",
  projectId: "proj-web1-8efd2",
  storageBucket: "proj-web1-8efd2.appspot.com",
  messagingSenderId: "345030686286",
  appId: "1:345030686286:web:e7fceb1a748f24957eb51f"
};

// Initialize Firebase
firebase.initializeApp(firebaseConfig);

createApp(App).use(router).mount('#app')

