<template>
  <form
    id="reg-form"
    @submit="loginRequest()"
    action="https://vuejs.org/"
  >
    <input id="email" type="email" placeholder="Email" required="true" />
    <input
      id="password"
      type="password"
      placeholder="Password"
      required="true"
      minlength="6"
    />
    <button>Register</button>
  </form>
</template>

<script>
import firebase from "firebase/compat/app";
import "firebase/compat/auth";
import "firebase/compat/firestore";

export default {
  name: "Register",
  data() {
    return {
      email: "",
      password: "",
    };
  },
  methods: {
    signupRequest() {
      firebase
        .auth()
        .signInWithEmailAndPassword(email, password)
        .then((userCredential) => {
          // Signed in
          var user = userCredential.user;
          // ...
        })
        .catch((error) => {
          var errorCode = error.code;
          var errorMessage = error.message;
        });
    },
    loginRequest(){
      firebase.auth().signInWithEmailAndPassword(email, password)
  .then((userCredential) => {
    // Signed in
    var user = userCredential.user;
    // ...
  })
  .catch((error) => {
    var errorCode = error.code;
    var errorMessage = error.message;
  });
    }
  },
};
</script>