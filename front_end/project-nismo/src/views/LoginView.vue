<template>
  <h1 style="margin-top: 300px">Create an Account</h1>
  <p><input type="text" placeholder="Email" v-model="email" /></p>
  <p><input type="password" placeholder="Password" v-model="password" /></p>
  <p><button @click="register()">Submit</button></p>
  <br />
  <br />
  <h1>Login</h1>
  <p><input type="text" placeholder="Email" v-model="email_login" /></p>
  <p><input type="password" placeholder="Password" v-model="password_login" /></p>
  <p><button @click="login()">Submit</button></p>
</template>

<script setup>
import { ref } from "vue";
import firebase from "firebase";
import { useRouter } from "vue-router"; // import router
const email = ref("");
const password = ref("");
const email_login = ref("");
const password_login = ref("");
const router = useRouter(); // get a reference to our vue router

const register = () => {
  firebase
    .auth() // get the auth api
    .createUserWithEmailAndPassword(email.value, password.value) // need .value because ref()
    .then((data) => {
      console.log("Successfully registered!");
      router.push("/"); // redirect to the feed
    })
    .catch((error) => {
      console.log(error.code);
      alert(error.message);
    });
};

const login = () => {
  firebase
    .auth() // get the auth api
    .signInWithEmailAndPassword(email_login.value, password_login.value) // need .value because ref()
    .then((data) => {
      console.log("Successfully logged in!");
      router.push("/"); // redirect to the feed
    })
    .catch((error) => {
      console.log(error.code);
      alert(error.message);
    });
};
</script>