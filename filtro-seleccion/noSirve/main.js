/* let signUp = document.getElementById("singUp");
let singIn = document.getElementById("singIn");
let nameInput = document.getElementById("nameInput");
let title = document.getElementById("title");

let cerrar = document.querySelectorAll(".close")[0];
let abrir = document.querySelectorAll(".cta")[0];
let modal = document.querySelectorAll(".modal")[0];
let modalC = document.querySelectorAll(".modal-container")[0];

singIn.onclick = function() {
    nameInput.style.maxHeight = "0";
    title.innerHTML = "Login";
    signUp.classList.add("disable");
    singIn.classList.remove("disable");
}

signUp.onclick = function(){ 
    nameInput.style.maxHeight = "60px";
    title.innerHTML = "Registro";
    signUp.classList.remove("disable");
    singIn.classList.add("disable");
}

abrir.addEventListener("click", function(e) {
    e.preventDefault();
    modalC.style.opacity = "1";
    modalC.style.visibility = "visible";
    modal.classList.toggle("modal-close");
});

cerrar.addEventListener("click", function(){
    modal.classList.toggle("modal-close");
    setTimeout(function(){
        modalC.style.opacity = "0";
    modalC.style.visibility = "hidden";
    }, 850)
})

window.addEventListener("click", function(e){
    if(e.target == modalC) {
        modal.classList.toggle("modal-close");
        this.setTimeout(function (){
            modalC.style.opacity = "0";
            modalC.style.visibility = "hidden";
        }, 900)
    }
}) */