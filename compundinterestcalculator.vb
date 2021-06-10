Imports System

Public Module Module1

	Public Sub Main()
		console.WriteLine("what is the amount? ")
		dim amount as integer = console.ReadLine()
		console.WriteLine("how many years? ")
		dim years as integer = console.ReadLine()
		console.WriteLine("what is the interest rate? ")
		dim rate as integer = console.ReadLine()
		dim interest as integer =(amount * (1 + rate / 100) ^ years)
		console.WriteLine("the interest is(in dollars) " & interest)
	End Sub
End Module
