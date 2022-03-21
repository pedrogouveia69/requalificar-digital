<template>
  <div>
    <!-- ======= Breadcrumbs ======= -->
    <section id="breadcrumbs" class="breadcrumbs">
      <div class="container">
        <div class="d-flex justify-content-between align-items-center">
          <h2>Contact</h2>
          <ol>
            <li><a href="index.html">Home</a></li>
            <li>Contact</li>
          </ol>
        </div>
      </div>
    </section>
    <!-- End Breadcrumbs -->
    <section id="contact" class="contact">
      <div class="container">
        <div class="row mt-5 justify-content-center">
          <div class="col-lg-10">
            <form class="php-email-form">
              <div class="add-car">
                <h1>ADD CAR</h1>
                <img src="@\assets\img\cta-add-cars.png" />
              </div>
              <div class="add-car-form">
                <div>
                  <label>Base Price:</label>
                  <br />
                  <input
                    type="number"
                    id="name"
                    placeholder="Base Price"
                    v-model="basePrice"
                    style="width: 350px"
                  />
                </div>
                <br />
                <div>
                  <label>Image URL:</label>
                  <br />
                  <textarea
                    rows="5"
                    v-model="imageUrl"
                    style="width: 350px"
                  ></textarea>
                </div>
                <br />
                <div>
                  <button type="submit" @click="postToFirebase">Submit</button>
                </div>
              </div>
            </form>
          </div>
        </div>
      </div>
    </section>
  </div>
</template>

<script>
import axios from "axios";

export default {
  data() {
    return {
      imageUrl: "",
      basePrice: 0,
    };
  },
  methods: {
    postToFirebase() {
      axios
        .post(
          "https://proj-web1-8efd2-default-rtdb.europe-west1.firebasedatabase.app/.json",
          {
            imageUrl: this.imageUrl,
            basePrice: this.basePrice,
          }
        )
        .then((res) => console.log(res.data.imageUrl));
    },
  },
};
</script>

<style scoped>
@font-face {
  font-family: "NissanOpti";
  src: local("NissanOpti"),
    url(@/assets/fonts/NissanOpti.otf) format("truetype");
}
/*--------------------------------------------------------------
# Contact
--------------------------------------------------------------*/
h1 {
  font-family: "NissanOpti";
}

.contact .info-wrap {
  box-shadow: 0px 2px 15px rgba(0, 0, 0, 0.1);
  padding: 30px;
}
.contact .info {
  background: #fff;
}
.contact .info i {
  font-size: 20px;
  color: #c1121f;
  float: left;
  width: 44px;
  height: 44px;
  border: 1px solid #c1121f;
  display: flex;
  justify-content: center;
  align-items: center;
  border-radius: 50px;
  transition: all 0.3s;
}
.contact .info h4 {
  padding: 0 0 0 60px;
  font-size: 22px;
  font-weight: 600;
  margin-bottom: 5px;
  color: #111;
}
.contact .info p {
  padding: 0 0 0 60px;
  margin-bottom: 0;
  font-size: 14px;
  color: #444444;
}
.contact .info:hover i {
  background: #c1121f;
  color: #fff;
}
.contact .php-email-form {
  width: 100%;
  box-shadow: 0 0 24px 0 rgba(0, 0, 0, 0.12);
  padding: 30px;
  background: #fff;
  display: flex;
}
.contact .php-email-form .form-group {
  padding-bottom: 8px;
}
.contact .php-email-form .error-message {
  display: none;
  color: #fff;
  background: #ed3c0d;
  text-align: left;
  padding: 15px;
  font-weight: 600;
}
.contact .php-email-form .error-message br + br {
  margin-top: 25px;
}
.contact .php-email-form .sent-message {
  display: none;
  color: #fff;
  background: #c1121f;
  text-align: center;
  padding: 15px;
  font-weight: 600;
}
.contact .php-email-form .loading {
  display: none;
  background: #fff;
  text-align: center;
  padding: 15px;
}
.contact .php-email-form .loading:before {
  content: "";
  display: inline-block;
  border-radius: 50%;
  width: 24px;
  height: 24px;
  margin: 0 10px -6px 0;
  border: 3px solid #c1121f;
  border-top-color: #eee;
  -webkit-animation: animate-loading 1s linear infinite;
  animation: animate-loading 1s linear infinite;
}
.contact .php-email-form input,
.contact .php-email-form textarea {
  border-radius: 0;
  box-shadow: none;
  font-size: 14px;
  border-radius: 4px;
}
.contact .php-email-form input:focus,
.contact .php-email-form textarea:focus {
  border-color: #c1121f;
}
.contact .php-email-form input {
  height: 44px;
}
/* .contact .php-email-form textarea {
  padding: 10px 12px;
} */
.contact .php-email-form button[type="submit"] {
  background: #c1121f;
  border: 0;
  padding: 10px 24px;
  color: #fff;
  transition: 0.4s;
  border-radius: 4px;
}
.contact .php-email-form button[type="submit"]:hover {
  background: #c1121f;
}
.add-car {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}
.add-car-form {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  width: 500px;
}

@-webkit-keyframes animate-loading {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
}
@keyframes animate-loading {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
}
</style>