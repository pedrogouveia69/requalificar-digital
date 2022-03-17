<template>
  <div class="form-main" id="container">
    <div class="login-container" id="login-container">
      <div class="form-subcontainer">
        <div class="form-container sign-up-container">
          <img class="logo" src="@/assets/img/nismo-logo.png" />
          <form>
            <input
              class="form-input"
              id="reg-email"
              type="email"
              placeholder="Email"
              required="true"
              v-model="email"
            />
            <input
              class="form-input"
              id="reg-password"
              type="password"
              placeholder="Password"
              required="true"
              minlength="6"
              v-model="password"
            />
            <!-- <input class="form-input"
        id="reg-password-confirm"
        type="password"
        placeholder="Confirm Password"
        required="true"
      /> -->
            <button class="form-button" @click="register">Register</button>
          </form>
        </div>
      </div>
      <div class="form-container sign-in-container">
        <div class="form-subcontainer">
          <img class="logo" src="@/assets/img/nismo-logo.png" />
            <input
              class="form-input"
              id="email"
              type="email"
              placeholder="Email"
              required="true"
              v-model="email_login"
            />
            <input
              class="form-input"
              id="password"
              type="password"
              placeholder="Password"
              required="true"
              minlength="6"
              v-model="password_login"
            />
            <input type="submit" class="form-button" value="Login" @click="login">
          <a class="form-a" href="#">Forgot your password?</a>
        </div>
      </div>
      <div class="overlay-container">
        <div class="overlay">
          <div class="overlay-panel overlay-left">
            <h1 class="form-h1">Already have an account?</h1>
            <p class="form-p">></p>
            <button class="form-button ghost" id="signIn">Login</button>
          </div>
          <div class="overlay-panel overlay-right">
            <h1 class="form-h1">Don't have an account?</h1>
            <p class="form-p"></p>
            <button class="form-button ghost" id="signUp">Register</button>
          </div>
        </div>
      </div>
    </div>
  </div>
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
      // alert(error.message);
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
      // alert(error.message);
    });
};

let loginScript = document.createElement("script");
loginScript.setAttribute("src", "@/assets/css/js/login.js");
document.head.appendChild(loginScript);
</script>

