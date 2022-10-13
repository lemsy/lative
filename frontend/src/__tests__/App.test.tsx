/* Libraries */
import React from 'react'
import { render, screen } from '@testing-library/react'

/* Components */
import App from '../App'

test('renders learn react link', () => {
    // Arrange
    render(<App />)

    // Act
    const linkElement = screen.getByText(/Employees Discount/i)

    // Assert
    expect(linkElement).toBeInTheDocument()
})
