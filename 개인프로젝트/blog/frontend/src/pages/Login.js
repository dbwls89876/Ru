import React from 'react';

const Login = () => {
    return (
        <div>
            <h1>
                Login
            </h1>
            <form>
                id : <input type="text" name = "id"></input><br/>
                pass : <input type="text" name = "password"></input>
            </form>
        </div>
    )
}

export default Login