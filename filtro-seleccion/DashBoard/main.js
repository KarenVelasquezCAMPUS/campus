(function(){
    document.addEventListener('DOMContentLoaded', showCmpers);
    function showCampers() {
        console.log('desde IIFE');
    }
})();

const $openClose = document.getElementById("open-close"),
    $aside = document.getElementById("aside");

$openClose.addEventListener("click", ()=>{
    $aside.classList.toggle("desplegar")
})