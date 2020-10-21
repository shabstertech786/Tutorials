import * as React from 'react';

class Login extends React.Component<any, any> {
    state = {}
    render() {
        return (
            <React.Fragment>
                <input type="textbox" id="username"></input>
                <input type="textbox" id="password"></input>
            </React.Fragment>
        );
    }
}

export default Login;