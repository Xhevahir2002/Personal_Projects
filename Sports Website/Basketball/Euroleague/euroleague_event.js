document.addEventListener("DOMContentLoaded", function () {
    var footballLink = document.querySelector('.click_on_football'); 
    var arrow = document.querySelector(".football_dropdn_arrow");
    var subMenu = document.querySelector(".football_sub_menu");

    footballLink.addEventListener("click", function () {
        arrow.classList.toggle("rotated");
        subMenu.style.display = subMenu.style.display === "contents" ? "none" : "contents";
    });

    var basketballLink = document.querySelector('.click_on_basketball'); 
    var arrowBasketball = document.querySelector(".basketball_dropdn_arrow");
    var subMenuBasketball = document.querySelector(".basketball_sub_menu");

    basketballLink.addEventListener("click", function () {
        arrowBasketball.classList.toggle("rotated");
        subMenuBasketball.style.display = subMenuBasketball.style.display === "contents" ? "none" : "contents";
    });
});