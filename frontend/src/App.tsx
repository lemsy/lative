/* Libraries */
import React, { useState } from 'react'

/* Components */
import Filter from './components/filter'
import Discounts from './components/discounts'

/* Styles */
import './App.scss'
import { EmployeeType } from './utils/types/employee-type'

const App = () => {

    let dArr: Array<EmployeeType> = []
    const [employees, setEmployees] = useState(dArr)

    return (
        <div className='app'>
            <Filter employees={employees} onEmployeesChange={(arr: Array<EmployeeType>) => setEmployees(arr)}/>
            <Discounts employees={employees} onEmployeesChange={(arr: Array<EmployeeType>) => setEmployees(arr)}/>
        </div>
    )
}

export default App
