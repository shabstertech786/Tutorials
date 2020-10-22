import * as React from "react";
import * as ReactDom from "react-dom";
import LoginLayout from "../Login/src/Layouts/LoginLayout"
import ReactDOM = require("react-dom");
import "bootstrap/dist/css/bootstrap.css";

ReactDom.render(
    <LoginLayout></LoginLayout>,
    document.getElementById("login")
);