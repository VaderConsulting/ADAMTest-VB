Imports System.DirectoryServices.AccountManagement

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Debug.Print(CheckPassword)
    End Sub

    Private Function CheckPassword() As Boolean
        Dim Result As Boolean = False
        Dim ServerName As String = "VIRTUALXP:389"
        'Dim ServerPath As String = "LDAP://" & ServerName
        Dim Container As String = "OU=Client,DC=robinson,DC=int"
        Dim SelectedBindType As ContextOptions = ContextOptions.SimpleBind
        Dim ConnectionAccountUsername As String = String.Empty`r`n        Dim ConnectionAccountPassword As String = String.Empty`r`n        Dim Context As New PrincipalContext(ContextType.ApplicationDirectory, ServerName, Container, SelectedBindType, ConnectionAccountUsername, ConnectionAccountPassword)

        Dim User As New UserPrincipal(Context)



        Return Result
    End Function


End Class

