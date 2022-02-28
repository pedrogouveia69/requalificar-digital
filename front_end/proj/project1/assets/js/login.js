const signUpButton = document.getElementById('signUp');
const signInButton = document.getElementById('signIn');
const container = document.getElementById('container');

signUpButton.addEventListener('click', () => {
    container.classList.add("right-panel-active");
});

signInButton.addEventListener('click', () => {
    container.classList.remove("right-panel-active");
});


// JQuery Validation /////////////////////////////////////
// $(document).ready(function () {
//     $("#login-form").validate({
//         rules: {
//             email: {
//                 required: true,
//                 email:true
//             },
//             password: {
//                 required: true
//             }
//         },
//         messages: {
//             email: {
//                 required: "Please enter your email",
//                 email: "Invalid Email Format"
//             },
//             password: {
//                 required: "Please enter your password",
//             }
//         }
//     });
// });

// Check if password confirmation matches
//https://stackoverflow.com/questions/21727317/how-to-check-confirm-password-field-in-form-without-reloading-page