import * as React from 'react';
import StudentList from "../components/StudentList"

class component extends React.Component<any, any> {
    constructor(props: any) {
        super(props);
        this.state = {
        };
    }
    render() {
        return (
            <StudentList>
            </StudentList>
        );
    }
}

export default component;