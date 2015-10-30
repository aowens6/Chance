Option Strict On
Option Explicit On
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class AddName
    Dim player As New players
    
    Private Sub btnAddName_Click(sender As Object, e As EventArgs) Handles btnAddName.Click

        If txtPlayerName.Text <> "" Then
            player.playerName = txtPlayerName.Text
            player.playerScore = CInt(MainFrm.score)

            player.nameScore = player.playerName & "         " & player.playerScore.ToString

            Dim connectionString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Chance\Chance\Players.mdf"
            Dim dbConnection As New SqlConnection(connectionString)
            dbConnection.Open()

            
            Try
                Dim insertCommand As SqlCommand = prepareInsert(dbConnection)
                Dim result As Integer = insertCommand.ExecuteNonQuery()
                MessageBox.Show("Rows updated = " & result.ToString)
                insertCommand.Dispose()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try



            dbConnection.Close()
            dbConnection.Dispose()


            MainFrm.playersList.Add(player)

            MainFrm.populateCombos()
            MainFrm.lblTotalScore.Text = ""
            MainFrm.score = 0
            MainFrm.clearProgress()
            Me.Close()


        Else
            MessageBox.Show("Plese enter your name")
        End If
    End Sub

    Private Function prepareInsert(dbConnection As SqlConnection) As SqlCommand


        Dim insertSqlString As String = "INSERT INTO Players (name, score) VALUES (@name, @score)"
        Dim insertCommand As New SqlCommand(insertSqlString, dbConnection)



        insertCommand.Parameters.Add("@name", SqlDbType.VarChar).Value = player.playerName
        insertCommand.Parameters.Add("@score", SqlDbType.Int).Value = player.playerScore



        Return insertCommand
    End Function
End Class