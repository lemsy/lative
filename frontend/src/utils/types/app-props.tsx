import { EmployeeType } from "./employee-type";

interface OnEmployeesChange{

    (arr: Array<EmployeeType>): void
}

export type AppProps = {
    employees: Array<EmployeeType>
    onEmployeesChange: OnEmployeesChange
}