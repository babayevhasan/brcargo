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
