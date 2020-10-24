import * as React from 'react';
import { useState } from 'react';
import { Button, Toast } from 'react-bootstrap';

function Toastify(props: any) {
    const [show, setShow] = useState(props.visible);
    const [Header] = useState(props.Header);
    const [Body] = useState(props.Body);
    return (
        <div className="container">
            <Toast onClose={() => setShow(false)} show={show} delay={2000} autohide>
                <Toast.Header>
                    <strong className="mr-auto">{Header}</strong>
                    <small>11 mins ago</small>
                </Toast.Header>
                <Toast.Body>{Body}</Toast.Body>
            </Toast>
        </div>
    );
}

export default Toastify;