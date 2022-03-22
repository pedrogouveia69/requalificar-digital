<template>
  <header-main v-if="isNotLoginPage && isNotErrorPage"/>
  <router-view />
  <footer-main v-if="isNotLoginPage && isNotErrorPage"/>
</template>

<script>
// @ is an alias to /src
import HeaderMain from "@/components/HeaderMain.vue";
import FooterMain from "@/components/FooterMain.vue";

export default {
  name: "App",
  components: {
    HeaderMain,
    FooterMain,
  },
  computed: {
    isNotLoginPage() {
      return this.$route.name !== "login";
    },
    isNotErrorPage(){
      return this.$route.name !== 'error';
    },
  },
};
</script>

<style>
/* Google Font */
@import url("https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Roboto:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i");
@font-face {
  font-family: "NissanOpti";
  src: local("NissanOpti"),
    url(@/assets/fonts/NissanOpti.otf) format("truetype");
}


/* Vendor CSS Files */
@import "@/assets/vendor/animate.css/animate.min.css";
@import "@/assets/vendor/aos/aos.css";
@import "@/assets/vendor/bootstrap/css/bootstrap.min.css";
@import "@/assets/vendor/bootstrap-icons/bootstrap-icons.css";
@import "@/assets/vendor/boxicons/css/boxicons.min.css";
@import "@/assets/vendor/glightbox/css/glightbox.min.css";
@import "@/assets/vendor/remixicon/remixicon.css";
@import "@/assets/vendor/swiper/swiper-bundle.min.css";

/* Main CSS File */
@import "@/assets/css/style.css";
</style>


