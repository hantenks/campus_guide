
Public Class DetailsForm
    'This class gives a postcard-style description of the relevant location

    Private Declare Function HideCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean   ' Functions to hide the cursor
    Private Declare Function ShowCaret Lib "user32.dll" (ByVal hWnd As IntPtr) As Boolean   ' Functions to show the cursor

    'Function to load the required data that is already kept ready in the superglobal variables in DetailMap form
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Location = New Point(DetailMap.Location.X + DetailMap.Size.Width / 4, DetailMap.Location.Y + DetailMap.Size.Height / 4)
        Me.Location = DetailMap.cursorPos
        PictureBox1.Image = DetailMap.picsaikat
        RichTextBox1.Text = DetailMap.txtsaikat
    End Sub

    'Handling the cursor blinking in the RichTextBox
    Private Sub RichTextBox1_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles RichTextBox1.ChangeUICues
        HideCaret(RichTextBox1.Handle)
    End Sub
    'Handling the cursor blinking in the RichTextBox
    Private Sub RichTextBox1_Enter(sender As Object, e As EventArgs) Handles RichTextBox1.Enter
        HideCaret(RichTextBox1.Handle)
    End Sub
    'Handling the cursor blinking in the RichTextBox
    Private Sub RichTextBox1_Leave(sender As Object, e As EventArgs) Handles RichTextBox1.Leave
        HideCaret(RichTextBox1.Handle)
    End Sub

    'Function to close this form as soon as focus is lost by it
    Private Sub DetailsForm_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        Me.Close()
    End Sub
End Class