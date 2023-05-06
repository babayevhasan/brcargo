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

// inputları seç
const countrySelect = document.querySelector(".calculator-country select");
const sizeInputs = document.querySelectorAll(".calculator-input input");
const resultParagraph = document.querySelector(".calculator-number p");

// ağırlığı hesablamaq ucun
function calculatePrice() {
  let totalWeight = 0;
  let totalCost = 0;

  // ağırlığı cevirmek ucun
  sizeInputs.forEach((input) => {
    if (input.value) {
      totalWeight += parseFloat(input.value);
    }
  });

  // olkeye göre qiymet hesaplama
  if (countrySelect.value === "ABŞ") {
    totalCost += 2; // ABŞ için ek maliyet
  }

  // agirliq araligina göre qiymet hesaplamaq
  if (totalWeight >= 1 && totalWeight <= 1.5) {
    totalCost += totalWeight * 2.5;
  } else if (totalWeight > 1.5 && totalWeight <= 2) {
    totalCost += totalWeight * 3;
  } else if (totalWeight > 2 && totalWeight <= 3) {
    totalCost += totalWeight * 3.5;
  } else {
    // sehv yazilanda netice qaytaar
    resultParagraph.textContent = "Xətalı giriş, zəhmət olmasa düzgün yazın.";
    return;
  }

  // Nəticəni görmək
  resultParagraph.textContent = `$ ${totalCost.toFixed(2)}`;
}

sizeInputs.forEach((input) => {
  input.addEventListener("keyup", calculatePrice);
});
