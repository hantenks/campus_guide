Public Class MainForm
    'This form is the starting point to the program
    'It provides a menu-style interface to the rest of the program

    Public mapViewClickCount, campusTourClickCount As Integer

    'Function to handle map view button click
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mapViewClickCount += 1
        DetailMap.Show()
    End Sub

    'Function to handle campus tour button click
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        campusTourClickCount += 1
        CampusTour.Show()
    End Sub

    'Basic help with the modes
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim t As String = "Choose one of the 3 modes of the Explorer to start with."
        t += vbNewLine + vbNewLine + "Additional Information about that particular mode is available in the mode itself"
        t += vbNewLine + vbNewLine + "For more information, check the User Manual"
        MsgBox(t, , "Help")
    End Sub

    'About information
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim t As String = "IITG Campus Explorer"
        t += vbNewLine + vbNewLine + "This application was developed as part of Assignment 1 of Software Engineering Lab"
        t += vbNewLine + vbNewLine + "Credits:"
        t += vbNewLine + "Duddu Sai Meher Karthik" + vbNewLine + "Jainam Shah" + vbNewLine + "Ayush Mananiya" + vbNewLine + "Saikat Biswas" + vbNewLine + "Rahul"
        MsgBox(t, , "About this Application")
    End Sub

    'Exit button :)
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    'Initialise relevant variables
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mapViewClickCount = 0
        campusTourClickCount = 0
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DirectionsForm.Show()
    End Sub
End Class