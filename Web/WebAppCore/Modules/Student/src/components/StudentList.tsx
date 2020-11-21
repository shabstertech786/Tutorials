import * as React from 'react';

class StudentList extends React.Component<any, any> {
    constructor(props: any) {
        super(props);
        this.state = {};
    }
    render() {
        return (
            <div>this is student component</div>
        );
    }

    componentDidCatch(error: any, info: any) {
        console.log(error);
    }
}

export default StudentList;