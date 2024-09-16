const singInForm = document.querySelector('#singInForm')
singInForm.addEventListener('submit', (e)=>{
    e.preventDefault()
    const name = document.querySelector('#name')
    const email = document.querySelector('#email')
    const password = document.querySelector('#password')

    const Users = JSON.parse(localStorage.getItem('users')) || []
    const isUsersRegistred = Users.find(user => user.email === email)
    if(isUsersRegistred){
        return alert('El usuario ya está registrado')
    }

    Users.push({name: name, email: email, password: password})
    localStorage.setItem('users', JSON.stringify(Users))
    alert('Registro Exitoso')
    window.location.href = 'longin.html'
})