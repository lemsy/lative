/* Libraries */
import React, { useEffect, useState } from 'react'

/* Components */
import Calendar from './calendar'
import Form from 'react-bootstrap/Form'
import Nav from 'react-bootstrap/Nav'

/* Styles */
import './filter.scss'

import axios from 'axios'
import { AppProps } from '../utils/types/app-props'

const Filter = (props: AppProps) => {
    const [selectedDate, setSelectedDate] = useState(new Date())
    const [employeeType, setEmployeeType] = useState("Permanent")

    
    useEffect(()=>{

        async function loadEmployeesWithDiscounts(){
            let res = await axios.get(`https://localhost:7046/get-discounts/${selectedDate.toISOString().split('T')[0]}/${employeeType}`)
            props.onEmployeesChange(res.data)
        }

        loadEmployeesWithDiscounts()
    })

    return (
        <section>
            <Nav>
                <Nav.Item className='filter-logo'>
                    <img src='/images/lative-logo.png' alt='Lative Software' />
                </Nav.Item>
            </Nav>
            <h1 className='header'>Employees Discount</h1>
            <Form className='filter-form-container'>
                <Form.Group className='filter-form-group'>
                    <Form.Label>Employee Type</Form.Label>
                    <Form.Control as='select' value={employeeType} onChange={(e) => setEmployeeType(e.target.value)}>
                        <option>Permanent</option>
                        <option>Part-time</option>
                        <option>Intern</option>
                        <option>Contractor</option>
                    </Form.Control>
                </Form.Group>
                <Form.Group className='filter-form-group'>
                    <Form.Label>Date</Form.Label>
                    <Calendar
                        date={selectedDate}
                        onChange={(date) => setSelectedDate(date)}
                        calendarClassName='period-calendar'
                    />
                </Form.Group>
            </Form>
        </section>
    )
}

export default Filter
