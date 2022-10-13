/* Libraries */
import React from 'react'

/* Components */
import Card from 'react-bootstrap/Card'
import { cardBackgroundColorByEmployeeType } from '../utils/mappings/employee-card-background-color'
import { AppProps } from '../utils/types/app-props'

/* Styles */
import './discounts.scss'

/* Mock data */
//import { employees } from '../mock-data/employees'

const Discounts = (props: AppProps) => {
    return (
        <div className='discounts-container'>
            {props.employees.map((employee) => (
                <Card key={employee.identifier}>
                    <Card.Header className='card-header' style={{backgroundColor: cardBackgroundColorByEmployeeType[employee.type.toLowerCase()]}}>
                        {employee.firstName + ' ' + employee.lastName}
                    </Card.Header>
                    <Card.Body className='card-body'>
                        <Card.Title>{employee.type}</Card.Title>
                        <Card.Text>{employee.discount + '%'}</Card.Text>
                    </Card.Body>
                </Card>
            ))}
        </div>
    )
}

export default Discounts
