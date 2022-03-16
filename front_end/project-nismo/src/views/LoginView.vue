<template>
  <form style="margin-top: 300px">
    <input v-model="email" type="email" placeholder="Email" required="true" />
    <input
      v-model="password"
      type="password"
      placeholder="Password"
      required="true"
      minlength="6"
    />
    <button @click="signupRequest()">Register</button>
  </form>
</template>

<script>
export default {
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
        .createUserWithEmailAndPassword(this.email, this.password)
        .then(
          () => {
            this.successMessage = "Register Successfully.";
            alert(this.successMessage);
          },
          (error) => {
            let errorResponse = JSON.parse(error.message);
            this.errorMessage = errorResponse.error.message;
            alert(this.errorMessage);
          }
        );
    },
  },
};
</script>