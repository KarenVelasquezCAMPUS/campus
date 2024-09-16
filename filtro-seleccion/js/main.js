const user = JSON.parse(localStorage.getItem('longin_success')) || false
if (!user){
    window.location.href = 'longin.html'
}

const logOut = document.querySelector('#logOut')

logOut.addEventListener('click', ()=>{
    alert('Hasta pronto')
    localStorage.removeItem('login_success')
    window.location.href = 'longin.html'
})