<template>
  <body>
    <div class="container" id="container" ref="container">
      <div class="form-container sign-up-container">
        <div class="form-subcontainer">
          <img class="logo" src="@/assets/img/nismo-logo.png" />
          <input
            type="email"
            id="reg-email"
            placeholder="Email"
            v-model="email"
          />
          <input
            type="password"
            id="reg-password"
            placeholder="Password"
            v-model="password"
          />
          <input
            type="password"
            id="reg-password-confirm"
            placeholder="Confirm Password"
            v-model="password_confirm"
          />
          <button @click="validateRegisterInputs">Register</button>
          <br />
          <span v-if="error_message.length > 0">{{ error_message }}</span>
        </div>
      </div>

      <div class="form-container sign-in-container">
        <div class="form-subcontainer">
          <img class="logo" src="@/assets/img/nismo-logo.png" />
          <input
            type="email"
            id="email"
            placeholder="Email"
            v-model="email_login"
          />
          <input
            type="password"
            id="password"
            placeholder="Password"
            v-model="password_login"
          />
          <button @click="validateLoginInputs">Login</button>
          <br />
          <span v-if="error_message.length > 0">{{ error_message }}</span>
        </div>
      </div>
      <div class="overlay-container">
        <div class="overlay">
          <div class="overlay-panel overlay-left">
            <h1>Already have an account?</h1>
            <p></p>
            <button class="ghost" id="signIn" @click="switchPanel">
              Login
            </button>
          </div>
          <div class="overlay-panel overlay-right">
            <h1>Don't have an account?</h1>
            <p></p>
            <button class="ghost" id="signUp" @click="switchPanel">
              Register
            </button>
          </div>
        </div>
      </div>
    </div>
  </body>
</template>

<script setup>
import { ref } from "vue";
import firebase from "firebase";
import { useRouter } from "vue-router"; // import router

const email = ref("");
const password = ref("");
const password_confirm = ref("");
const email_login = ref("");
const password_login = ref("");
const error_message = ref("");

const router = useRouter(); // get a reference to our vue router

function validateRegisterInputs() {
  if (!/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(email.value)) {
    error_message.value = "Invalid email address.";
  } else if (password.value.length < 6) {
    error_message.value = "Password must contain at least 6 characters.";
  } else if (password.value != password_confirm.value) {
    error_message.value = "Passwords do not match.";
  } else {
    register();
  }
}

function validateLoginInputs() {
  if (
    !/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(email_login.value)
  ) {
    error_message.value = "Invalid email address.";
  } else if (password_login.value.length < 6) {
    error_message.value = "Password must contain at least 6 characters.";
  } else {
    login();
  }
}
const register = () => {
  firebase
    .auth() // get the auth api
    .createUserWithEmailAndPassword(email.value, password.value) // need .value because ref()
    .then((data) => {
      router.push("/");
    })
    .catch((error) => {
      console.log(error);
      error_message.value = error.message;
    });
};

const login = () => {
  firebase
    .auth() // get the auth api
    .signInWithEmailAndPassword(email_login.value, password_login.value) // need .value because ref()
    .then((data) => {
      router.push("/"); // redirect to the feed
    })
    .catch((error) => {
      console.log(error);
      error_message.value = error.message;
    });
};

function switchPanel() {
  error_message.value = "";
  container.classList.toggle("right-panel-active");
}
</script>

<style scoped>
* {
  box-sizing: border-box;
}

body {
  display: flex;
  justify-content: center;
  align-items: center;
  flex-direction: column;
  font-family: "Open Sans", sans-serif;
  height: 100vh;
  margin: -20px 0 50px;
}

h1 {
  font-weight: bold;
  margin: 0;
  font-family: "Roboto", sans-serif;
}

h2 {
  text-align: center;
}

p {
  font-size: 14px;
  font-weight: 100;
  line-height: 20px;
  letter-spacing: 0.5px;
  margin: 20px 0 30px;
}

span {
  font-size: 12px;
}

a {
  color: #4d4643;
  font-size: 14px;
  text-decoration: none;
  margin: 15px 0;
}

button {
  border-radius: 4px;
  border: 1px solid #c1121f;
  background-color: #c1121f;
  color: #ffffff;
  font-size: 12px;
  font-weight: bold;
  padding: 12px 45px;
  letter-spacing: 1px;
  text-transform: uppercase;
  transition: transform 80ms ease-in;
  margin-top: 15px;
}

button:active {
  transform: scale(0.95);
}

button:focus {
  outline: none;
}

button.ghost {
  background-color: transparent;
  border-color: #ffffff;
  margin-top: -15px;
}

button:disabled {
  opacity: 60%;
}

input {
  padding: 12px 15px;
  margin: 8px 0;
  width: 100%;
  border: 1px solid #ced4da;
  border-radius: 4px;
  font-size: 14px;
}

input:focus {
  border: #c1121f;
}

.container {
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

.form-subcontainer {
  background-color: #ffffff;
  display: flex;
  align-items: center;
  justify-content: center;
  flex-direction: column;
  padding: 0 50px;
  height: 100%;
  text-align: center;
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
  color: #ffffff;
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
  border: 1px solid #dddddd;
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

