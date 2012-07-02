Public Class Cuentas

    Private Sub Cuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim RM As Resources.ResourceManager
        RM = New Resources.ResourceManager("NOTARIA.Resources", System.Reflection.Assembly.GetExecutingAssembly)
        qtiBack.Icon = RM.GetObject("Back")
        qtiFwd.Icon = RM.GetObject("Forward")
        qtiHome.Icon = RM.GetObject("Home")



    End Sub
End Class