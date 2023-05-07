// Part Of Rates
$(".buttonTr").click(function () {
  $(".buttonTr").css("background", "#ff8c00");
  $(".buttonUsa").css("background", "#fff");
  $(".rates").show();
  $(".tarif2").hide();
});

$(".buttonUsa").click(function () {
  $(".buttonUsa").css("background", "#ff8c00");
  $(".buttonTr").css("background", "#fff");
  $(".tarif2").show();
  $(".rates").hide();
});

///Inputlarin cagirilmasi
const countrySelect = document.querySelector(".calculator-country select");
const agirliqInput = document.querySelector("#kg");
const enInput = document.querySelector("#en");
const hundurlukInput = document.querySelector("#hundurluk");
const uzunluqInput = document.querySelector("#uzunluq");
const resultParagraph = document.querySelector(".calculator-number p");

///Her inputun bir qiymete menimsedilmesi
const PRICE_KG = 2;
const PRICE_EN = 1.5;
const PRICE_HUNDURLUK = 2;
const PRICE_UZUNLUQ = 2.5;

///Her inputun degerinin hesablanmasi hem tek halda hem cem halda
function calculatePrice() {
  let totalkg = parseFloat(agirliqInput.value) || 0;
  let totalen = parseFloat(enInput.value) || 0;
  let totalhundurluk = parseFloat(hundurlukInput.value) || 0;
  let totaluzunluq = parseFloat(uzunluqInput.value) || 0;

  let totalCost =
    totalkg * PRICE_KG +
    totalen * PRICE_EN +
    totalhundurluk * PRICE_HUNDURLUK +
    totaluzunluq * PRICE_UZUNLUQ;

  // olkeye göre pul elave etsin
  if (countrySelect.value === "ABŞ") {
    totalCost += 2;
  }

  // reqem yazilmayanda eyni reqemi qaytarsin
  if (totalCost <= 0) {
    resultParagraph.textContent = "$0.00";
    return;
  }

  // neticeni göstermek
  resultParagraph.textContent = `$ ${totalCost.toFixed(2)}`;
}

// Toplam neticeni hesaplamaq ucun için input eventi
[agirliqInput, enInput, hundurlukInput, uzunluqInput].forEach((input) => {
  input.addEventListener("input", calculatePrice);
});
