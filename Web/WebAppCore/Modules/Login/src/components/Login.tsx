import * as React from 'react';
import Toastify from './Toastify';
import { Button } from 'react-bootstrap';

class Login extends React.Component<any, any> {
    state = {
        Toast: {
            Header: "Toast Header",
            Body: "fallowing is saved no further action needed",
        },
    }
    render() {
        return (
            <React.Fragment>
                <input type="textbox" id="username"></input>
                <input type="textbox" id="password"></input>
                <Button>Login</Button>
                <Toastify Header={this.state.Toast.Header} Body={this.state.Toast.Body} visible={true}></Toastify>
            </React.Fragment>
        );
    }

    componentDidCatch(error: any, info: any) {
        console.log(error);
    }
}

export default Login;