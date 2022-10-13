/* Libraries */
import React from 'react'

/* Components */
import DatePicker from 'react-datepicker'

/* Styles */
import './calendar.scss'
import 'react-datepicker/dist/react-datepicker.css'

const Calendar: React.FC<{
    date: Date
    onChange: (date: Date) => void
    calendarClassName: string
}> = ({ date, onChange, calendarClassName }) => {
    return (
        <div>
            <DatePicker
                dateFormat='yyyy/MM/dd'
                dayClassName={() => 'date-picker-day'}
                closeOnScroll
                selected={date}
                onChange={onChange}
                calendarClassName={calendarClassName}
            />
        </div>
    )
}

export default Calendar
