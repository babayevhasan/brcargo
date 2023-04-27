
// Part Of Rates
$(".buttonTr").click(function(){
  $(".buttonTr").css("background","#ff8c00",);
  $(".buttonUsa").css("background","#fff");
  $(".rates").show();
  $(".tarif2").hide();
});

$(".buttonUsa").click(function(){
  $(".buttonUsa").css("background","#ff8c00");
  $(".buttonTr").css("background","#fff");
  $(".tarif2").show();
  $(".rates").hide();
});

//Part Of Login
const signInBtn = document.getElementById("signIn");
const signUpBtn = document.getElementById("signUp");
const fistForm = document.getElementById("form1");
const secondForm = document.getElementById("form2");
const container = document.querySelector(".container");

signInBtn.addEventListener("click", () => {
  container.classList.remove("right-panel-active");
});

signUpBtn.addEventListener("click", () => {
  container.classList.add("right-panel-active");
});

fistForm.addEventListener("submit", (e) => e.preventDefault());
secondForm.addEventListener("submit", (e) => e.preventDefault());


