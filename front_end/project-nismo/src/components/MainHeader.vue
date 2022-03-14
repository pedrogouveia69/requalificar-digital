<template>
  <!-- ======= Header ======= -->
  <header id="header" class="fixed-top">
    <div class="container d-flex align-items-center">
      <a href="/"><img id="navbar_logo" src="@/assets/img/nismo-logo.png" /></a>
      <h1 class="logo me-auto"></h1>
      <!-- Uncomment below if you prefer to use an image logo -->
      <!-- <a href="index.html" class="logo me-auto me-lg-0"><img src="assets/img/logo.png" alt="" class="img-fluid"></a>-->

      <nav id="navbar" class="navbar order-last order-lg-0">
        <ul>
          <li><a href="/" class="active">Home</a></li>
          <li><a href="/pricing">Buy</a></li>
          <li><a href="/contact">Contact</a></li>
          <li style="border-right: 1px solid #4d4643; padding-right: 20px">
             
          </li>
          <li><a href="/login">Register</a></li>
          <li><a href="/login">Login</a></li>
        </ul>
        <i class="bi bi-list mobile-nav-toggle"></i>
      </nav>
      <!-- .navbar -->
    </div>
  </header>
  <!-- End Header -->
</template>

<script>
import "@/assets/vendor/aos/aos.js";
import "@/assets/vendor/bootstrap/js/bootstrap.bundle.min.js";
import "@/assets/vendor/glightbox/js/glightbox.min.js";
import "@/assets/vendor/isotope-layout/isotope.pkgd.min.js";
import "@/assets/vendor/swiper/swiper-bundle.min.js";
import "@/assets/vendor/waypoints/noframework.waypoints.js";
import "@/assets/vendor/php-email-form/validate.js";

export default {
  name: "MainHeader",
  mounted() {
    let main = document.createElement("script");
    main.setAttribute(
      "src",
      "@/assets/js/main.js"
    );
    document.head.appendChild(main);
  },
};
</script>