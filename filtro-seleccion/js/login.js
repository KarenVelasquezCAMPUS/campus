const longinForm = document.querySelector('#longinForm')
longinForm.addEventListener('submit', (e)=>{
    e.preventDefault()
    const email = document.querySelector('#email').value 
    const password = document.querySelector('#password').value 
    const Users = JSON.parse(localStorage.getItem('users')) || []
    const valIdUser = Users.find(user => user.email === email && user.password === password)
    if (!valIdUser){
        return alert("Usuario y/o contraseña incorrecto")
    }
    alert('Bienvenido $[valIdUser.name]')
    localStorage.setItem('longin_success', JSON.stringify(valIdUser))
    window.location.href = 'index.html'
})