' * Chris DePaul
' * 5/7/2023
' * IT-46308 Advanced Visual Basic Programming
' * GolfStatisticsContextManager


Public Class GolfStatisticsContextManager
    ' Create a private static read-only field to hold the context.
    Private Shared ReadOnly _context As New GolfStatisticsDbContext()

    ' Define a public static read-only property called "Context" that returns the context.
    Public Shared ReadOnly Property Context As GolfStatisticsDbContext
        Get
            Return _context
        End Get
    End Property
End Class
