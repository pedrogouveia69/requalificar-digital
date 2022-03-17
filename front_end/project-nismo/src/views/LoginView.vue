<template>
  <div class="form-main" id="container">
    <div class="login-container" id="login-container">
      <div class="form-subcontainer">
        <div class="form-container sign-up-container">
          <img class="logo" src="@/assets/img/nismo-logo.png" />
          <input
            class="form-input"
            id="reg-email"
            type="text"
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
            v-model="password_login"
          />
          <button class="form-button" @click="login">Login</button>
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

let loginScript = document.createElement("script");
loginScript.setAttribute("src", "@/assets/css/js/login.js");
document.head.appendChild(loginScript);

</script>

<style scoped>
.form-main {
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;
    font-family: "Open Sans", sans-serif;
    height: 100vh;
    margin: -20px 0 50px;
}

.form-h1 {
    font-weight: bold;
    margin: 0;
    font-family: "Roboto", sans-serif;
}

.form-h2 {
    text-align: center;
}

.form-p {
    font-size: 14px;
    font-weight: 100;
    line-height: 20px;
    letter-spacing: 0.5px;
    margin: 20px 0 30px;
}

.form-span {
    font-size: 12px;
}

.form-a {
    color: #4d4643;
    font-size: 14px;
    text-decoration: none;
    margin: 15px 0;
}

.form-button {
    border-radius: 4px;
    border: 1px solid #c1121f;
    background-color: #c1121f;
    color: #FFFFFF;
    font-size: 12px;
    font-weight: bold;
    padding: 12px 45px;
    letter-spacing: 1px;
    text-transform: uppercase;
    transition: transform 80ms ease-in;
    margin-top: 15px;
}

.form-button:active {
    transform: scale(0.95);
}

.form-button:focus {
    outline: none;
}

button.ghost {
    background-color: transparent;
    border-color: #FFFFFF;
    margin-top: -15px;
}

.form-subcontainer {
    background-color: #FFFFFF;
    display: flex;
    align-items: center;
    justify-content: center;
    flex-direction: column;
    padding: 0 50px;
    height: 100%;
    text-align: center;
}

.form-input {
    padding: 12px 15px;
    margin: 8px 0;
    width: 100%;
    border: 1px solid #ced4da;
    border-radius: 4px;
    font-size: 14px;
}

.form-input:focus {
    border: #c1121f;
}

.login-container {
    background-color: #fff;

    box-shadow: 0 0 24px 0 rgb(0 0 0 / 12%);
    position: relative;
    overflow: hidden;
    width: 768px;
    max-width: 100%;
    min-height: 480px;
}

.form-container {
    position: absolute;
    top: 0;
    height: 100%;
    transition: all 0.6s ease-in-out;
}

.sign-in-container {
    left: 0;
    width: 50%;
    z-index: 2;
}

.container.right-panel-active .sign-in-container {
    transform: translateX(100%);
}

.sign-up-container {
    left: 0;
    width: 50%;
    opacity: 0;
    z-index: 1;
}

.container.right-panel-active .sign-up-container {
    transform: translateX(100%);
    opacity: 1;
    z-index: 5;
    animation: show 0.6s;
}

@keyframes show {

    0%,
    49.99% {
        opacity: 0;
        z-index: 1;
    }

    50%,
    100% {
        opacity: 1;
        z-index: 5;
    }
}

.overlay-container {
    position: absolute;
    top: 0;
    left: 50%;
    width: 50%;
    height: 100%;
    overflow: hidden;
    transition: transform 0.6s ease-in-out;
    z-index: 100;
}

.container.right-panel-active .overlay-container {
    transform: translateX(-100%);
}

.overlay {
    background: #c1121f;
    background-repeat: no-repeat;
    background-size: cover;
    background-position: 0 0;
    color: #FFFFFF;
    position: relative;
    left: -100%;
    height: 100%;
    width: 200%;
    transform: translateX(0);
    transition: transform 0.6s ease-in-out;
}

.container.right-panel-active .overlay {
    transform: translateX(50%);
}

.overlay-panel {
    position: absolute;
    display: flex;
    align-items: center;
    justify-content: center;
    flex-direction: column;
    padding: 0 40px;
    text-align: center;
    top: 0;
    height: 100%;
    width: 50%;
    transform: translateX(0);
    transition: transform 0.6s ease-in-out;
}

.overlay-left {
    transform: translateX(-20%);
}

.container.right-panel-active .overlay-left {
    transform: translateX(0);
}

.overlay-right {
    right: 0;
    transform: translateX(0);
}

.container.right-panel-active .overlay-right {
    transform: translateX(20%);
}

.social-container {
    margin: 20px 0;
}

.social-container a {
    border: 1px solid #DDDDDD;
    border-radius: 50%;
    display: inline-flex;
    justify-content: center;
    align-items: center;
    margin: 0 5px;
    height: 40px;
    width: 40px;
}

.logo {
    margin-bottom: -25px;
}
</style>
