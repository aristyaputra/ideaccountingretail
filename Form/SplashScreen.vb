Public Class SplashScreen
    Sub New
        InitializeComponent()
    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
    End Sub

    Public Enum SplashScreenCommand
        SomeCommandId
    End Enum

    Private Sub SplashScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'splash screen logo
        Try
            PictureBox1.Image = Image.FromFile(Application.StartupPath & "\pi-accounting-small.png")
        Catch ex As Exception
        End Try

    End Sub
End Class
