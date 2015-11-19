Option Strict On
Option Explicit On
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class MainFrm
    Dim numGen As New Random()
    Dim currentScore As Integer
    Dim currentPlayer As players
    

    Dim numberOfRolls As Integer = 1
    Dim savedDice As New List(Of Integer)
    Public playersList As New bindingList(Of players)

    Public score As Integer


    Private Sub rollDice_Click(sender As Object, e As EventArgs) Handles btnRollDice.Click



        If numberOfRolls <= 3 Then


            If txtDice1.Enabled = True Then

                txtDice1.Text = setDice().ToString()
            End If

            If txtDice2.Enabled = True Then
                txtDice2.Text = setDice().ToString()
            End If

            If txtDice3.Enabled = True Then
                txtDice3.Text = setDice().ToString()
            End If

            If txtDice4.Enabled = True Then
                txtDice4.Text = setDice().ToString()
            End If

            If txtDice5.Enabled = True Then
                txtDice5.Text = setDice().ToString()
            End If

            numberOfRolls += 1

        End If

        If numberOfRolls > 3 Then

            btnRollDice.Enabled = False

        End If


    End Sub

    Private Function setDice() As Integer
        Return numGen.Next(1, 7)
    End Function

    Private Sub btnKeep1_Click(sender As Object, e As EventArgs) Handles btnKeep1.Click
        If txtDice1.Enabled = True Then
            txtDice1.Enabled = False
        ElseIf txtDice1.Enabled = False Then
            txtDice1.Enabled = True
        End If
    End Sub

    Private Sub btnKeep2_Click(sender As Object, e As EventArgs) Handles btnKeep2.Click
        If txtDice2.Enabled = True Then
            txtDice2.Enabled = False
        ElseIf txtDice2.Enabled = False Then
            txtDice2.Enabled = True
        End If
    End Sub

    Private Sub btnKeep3_Click(sender As Object, e As EventArgs) Handles btnKeep3.Click
        If txtDice3.Enabled = True Then
            txtDice3.Enabled = False
        ElseIf txtDice3.Enabled = False Then
            txtDice3.Enabled = True
        End If
    End Sub

    Private Sub btnKeep4_Click(sender As Object, e As EventArgs) Handles btnKeep4.Click
        If txtDice4.Enabled = True Then
            txtDice4.Enabled = False
        ElseIf txtDice4.Enabled = False Then
            txtDice4.Enabled = True
        End If
    End Sub

    Private Sub btnKeep5_Click(sender As Object, e As EventArgs) Handles btnKeep5.Click
        If txtDice5.Enabled = True Then
            txtDice5.Enabled = False
        ElseIf txtDice5.Enabled = False Then
            txtDice5.Enabled = True
        End If
    End Sub


    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles Me.Load
        populateCombos()

        lstPlayers.DataSource = playersList

<<<<<<< HEAD
        lstPlayers.DisplayMember = "playerScore"
=======
        lstPlayers.DisplayMember = "nameScore"
>>>>>>> 116dd3cd49da9f769c21a7c1377cbadcd997ce99

        
    End Sub



    Private Sub btnSaveDice_Click(sender As Object, e As EventArgs) Handles btnSaveDice.Click
        If txtDice1.Text <> "" And txtDice2.Text <> "" And txtDice3.Text <> "" And txtDice4.Text <> "" And txtDice5.Text <> "" Then
            savedDice.Add(CInt(txtDice1.Text))
            savedDice.Add(CInt(txtDice2.Text))
            savedDice.Add(CInt(txtDice3.Text))
            savedDice.Add(CInt(txtDice4.Text))
            savedDice.Add(CInt(txtDice5.Text))
        Else
            MessageBox.Show("You must roll the dice")
        End If

        savedDice.Sort()

        Dim index As Integer = 0
        Dim numOfDice As Integer = 0
        If lstCombos.SelectedItem Is "Aces" Then
            Aces()
        ElseIf lstCombos.SelectedItem Is "Twos" Then
            Twos()
        ElseIf lstCombos.SelectedItem Is "Threes" Then
            Threes()
        ElseIf lstCombos.SelectedItem Is "Fours" Then
            Fours()
        ElseIf lstCombos.SelectedItem Is "Fives" Then
            Fives()
        ElseIf lstCombos.SelectedItem Is "Sixes" Then
            Sixes()
        ElseIf lstCombos.SelectedItem Is "Three of a Kind" Then
            ThreeOfAKind()
        ElseIf lstCombos.SelectedItem Is "Four of a Kind" Then
            FourOfAKind()
        ElseIf lstCombos.SelectedItem Is "Full House" Then
            FullHouse()
        ElseIf lstCombos.SelectedItem Is "Small Straight" Then
            SmallStraight()
        ElseIf lstCombos.SelectedItem Is "Large Straight" Then
            LargeStraight()
        ElseIf lstCombos.SelectedItem Is "Scratch" Then
            Scratch()
        ElseIf lstCombos.SelectedItem Is "Chance!" Then
            Chance()
        Else
            MessageBox.Show("You must select one of the combinations from the list")
        End If

        lblTotalScore.Text = score.ToString()
        clearDice()
        openAddNameForm()

    End Sub
    Private Sub Aces()
        For Each dice As Integer In savedDice

            If dice = 1 Then
                score += 1
            End If

        Next


        chkAce.Checked = True
        lstCombos.Items.Remove("Aces")
    End Sub
    Private Sub Twos()
        For Each dice As Integer In savedDice

            If dice = 2 Then
                score += 2
            End If

        Next

        chkTwos.Checked = True
        lstCombos.Items.Remove("Twos")
    End Sub
    Private Sub Threes()
        For Each dice As Integer In savedDice

            If dice = 3 Then
                score += 3
            End If

        Next

        chkThrees.Checked = True
        lstCombos.Items.Remove("Threes")
    End Sub
    Private Sub Fours()
        For Each dice As Integer In savedDice

            If dice = 4 Then
                score += 4
            End If

        Next

        chkFours.Checked = True
        lstCombos.Items.Remove("Fours")
    End Sub
    Private Sub Fives()
        For Each dice As Integer In savedDice

            If dice = 5 Then
                score += 5
            End If

        Next

        chkFives.Checked = True
        lstCombos.Items.Remove("Fives")
    End Sub
    Private Sub Sixes()
        For Each dice As Integer In savedDice

            If dice = 6 Then
                score += 6
            End If

        Next

        chkSixes.Checked = True
        lstCombos.Items.Remove("Sixes")
    End Sub
    Private Sub FourOfAKind()
        Dim numOfOnes As Integer
        Dim numOfTwos As Integer
        Dim numOfThrees As Integer
        Dim numOfFours As Integer
        Dim numOfFives As Integer
        Dim numOfSix As Integer
        For Each dice As Integer In savedDice
            If dice = 1 Then
                numOfOnes += 1
            ElseIf dice = 2 Then
                numOfTwos += 1
            ElseIf dice = 3 Then
                numOfThrees += 1
            ElseIf dice = 4 Then
                numOfFours += 1
            ElseIf dice = 5 Then
                numOfFives += 1
            ElseIf dice = 6 Then
                numOfSix += 1
            End If
        Next

        If numOfOnes >= 4 Or numOfTwos >= 4 Or numOfThrees >= 4 Or numOfFours >= 4 Or numOfFives >= 4 Or numOfSix >= 4 Then
            For Each dice As Integer In savedDice
                score += dice
            Next

        End If
        chk4ofaKind.Checked = True
        lstCombos.Items.Remove("Four of a Kind")
    End Sub
    Private Sub ThreeOfAKind()
        Dim numOfOnes As Integer
        Dim numOfTwos As Integer
        Dim numOfThrees As Integer
        Dim numOfFours As Integer
        Dim numOfFives As Integer
        Dim numOfSix As Integer
        For Each dice As Integer In savedDice
            If dice = 1 Then
                numOfOnes += 1
            ElseIf dice = 2 Then
                numOfTwos += 1
            ElseIf dice = 3 Then
                numOfThrees += 1
            ElseIf dice = 4 Then
                numOfFours += 1
            ElseIf dice = 5 Then
                numOfFives += 1
            ElseIf dice = 6 Then
                numOfSix += 1
            End If
        Next

        If numOfOnes >= 3 Or numOfTwos >= 3 Or numOfThrees >= 3 Or numOfFours >= 3 Or numOfFives >= 3 Or numOfSix >= 3 Then
            For Each dice As Integer In savedDice
                score += dice
            Next

        End If
        chk3ofaKind.Checked = True
        lstCombos.Items.Remove("Three of a Kind")
    End Sub
    Private Sub FullHouse()
        Dim numOfOnes As Integer
        Dim numOfTwos As Integer
        Dim numOfThrees As Integer
        Dim numOfFours As Integer
        Dim numOfFives As Integer
        Dim numOfSix As Integer
        For Each dice As Integer In savedDice
            If dice = 1 Then
                numOfOnes += 1
            ElseIf dice = 2 Then
                numOfTwos += 1
            ElseIf dice = 3 Then
                numOfThrees += 1
            ElseIf dice = 4 Then
                numOfFours += 1
            ElseIf dice = 5 Then
                numOfFives += 1
            ElseIf dice = 6 Then
                numOfSix += 1
            End If
        Next
        If (numOfOnes >= 2 Or numOfTwos >= 2 Or numOfThrees >= 2 Or numOfFours >= 2 Or numOfFives >= 2 Or numOfSix >= 2) And (numOfOnes >= 3 Or numOfTwos >= 3 Or numOfThrees >= 3 Or numOfFours >= 3 Or numOfFives >= 3 Or numOfSix >= 3) Then
            score += 25
        End If
        chkFullHouse.Checked = True
        lstCombos.Items.Remove("Full House")
    End Sub
    Private Sub SmallStraight()
        Dim numOfOnes As Integer
        Dim numOfTwos As Integer
        Dim numOfThrees As Integer
        Dim numOfFours As Integer
        Dim numOfFives As Integer
        Dim numOfSix As Integer
        For Each dice As Integer In savedDice
            If dice = 1 Then
                numOfOnes += 1
            ElseIf dice = 2 Then
                numOfTwos += 1
            ElseIf dice = 3 Then
                numOfThrees += 1
            ElseIf dice = 4 Then
                numOfFours += 1
            ElseIf dice = 5 Then
                numOfFives += 1
            ElseIf dice = 6 Then
                numOfSix += 1
            End If
        Next
        If (numOfOnes >= 1 And numOfTwos >= 1 And numOfThrees >= 1 And numOfFours >= 1) Or (numOfTwos >= 1 And numOfThrees >= 1 And numOfFours >= 1 And numOfFives >= 1) Or (numOfThrees >= 1 And numOfFours >= 1 And numOfFives >= 1 And numOfSix >= 1) Then
            score += 30
        End If

        chkSmStraight.Checked = True
        lstCombos.Items.Remove("Small Straight")
    End Sub
    Private Sub LargeStraight()
        Dim numOfOnes As Integer
        Dim numOfTwos As Integer
        Dim numOfThrees As Integer
        Dim numOfFours As Integer
        Dim numOfFives As Integer
        Dim numOfSix As Integer
        For Each dice As Integer In savedDice
            If dice = 1 Then
                numOfOnes += 1
            ElseIf dice = 2 Then
                numOfTwos += 1
            ElseIf dice = 3 Then
                numOfThrees += 1
            ElseIf dice = 4 Then
                numOfFours += 1
            ElseIf dice = 5 Then
                numOfFives += 1
            ElseIf dice = 6 Then
                numOfSix += 1
            End If
        Next
        If (numOfOnes >= 1 And numOfTwos >= 1 And numOfThrees >= 1 And numOfFours >= 1 And numOfFives >= 1) Or (numOfTwos >= 1 And numOfThrees >= 1 And numOfFours >= 1 And numOfFives >= 1 And numOfSix >= 1) Then
            score += 40
        End If
        chkLgStraight.Checked = True
        lstCombos.Items.Remove("Large Straight")
    End Sub
    Private Sub Scratch()
        For Each dice As Integer In savedDice
            score += dice
        Next
        chkScratch.Checked = True
        lstCombos.Items.Remove("Scratch")
    End Sub
    Private Sub Chance()
        Dim numOfOnes As Integer
        Dim numOfTwos As Integer
        Dim numOfThrees As Integer
        Dim numOfFours As Integer
        Dim numOfFives As Integer
        Dim numOfSix As Integer
        For Each dice As Integer In savedDice
            If dice = 1 Then
                numOfOnes += 1
            ElseIf dice = 2 Then
                numOfTwos += 1
            ElseIf dice = 3 Then
                numOfThrees += 1
            ElseIf dice = 4 Then
                numOfFours += 1
            ElseIf dice = 5 Then
                numOfFives += 1
            ElseIf dice = 6 Then
                numOfSix += 1
            End If
        Next
        If numOfOnes = 5 Or numOfTwos = 5 Or numOfThrees = 5 Or numOfFours = 5 Or numOfFives = 5 Or numOfSix = 5 Then
            score += 50
        End If
        chkChance.Checked = True
        lstCombos.Items.Remove("Chance!")
    End Sub
    Private Sub clearDice()
        txtDice1.Text = ""
        txtDice2.Text = ""
        txtDice3.Text = ""
        txtDice4.Text = ""
        txtDice5.Text = ""
        txtDice1.Enabled = True
        txtDice2.Enabled = True
        txtDice3.Enabled = True
        txtDice4.Enabled = True
        txtDice5.Enabled = True
        btnRollDice.Enabled = True
        numberOfRolls = 0

        savedDice.Clear()
    End Sub

    Sub clearProgress()
        chkAce.Checked = False
        chkTwos.Checked = False
        chkThrees.Checked = False
        chkFours.Checked = False
        chkFives.Checked = False
        chkSixes.Checked = False
        chk3ofaKind.Checked = False
        chk4ofaKind.Checked = False
        chkFullHouse.Checked = False
        chkSmStraight.Checked = False
        chkLgStraight.Checked = False
        chkScratch.Checked = False
        chkChance.Checked = False
    End Sub

    Public Sub populateCombos()
<<<<<<< HEAD
        'lstCombos.Items.Add("Aces")
        'lstCombos.Items.Add("Twos")
        'lstCombos.Items.Add("Threes")
        'lstCombos.Items.Add("Fours")
        'lstCombos.Items.Add("Fives")
        'lstCombos.Items.Add("Sixes")
        'lstCombos.Items.Add("Three of a Kind")
        'lstCombos.Items.Add("Four of a Kind")
        'lstCombos.Items.Add("Full House")
        'lstCombos.Items.Add("Small Straight")
        'lstCombos.Items.Add("Large Straight")
        lstCombos.Items.Add("Scratch")
        'lstCombos.Items.Add("Chance!")
=======
        lstCombos.Items.Add("Aces")
        lstCombos.Items.Add("Twos")
        lstCombos.Items.Add("Threes")
        lstCombos.Items.Add("Fours")
        lstCombos.Items.Add("Fives")
        lstCombos.Items.Add("Sixes")
        lstCombos.Items.Add("Three of a Kind")
        lstCombos.Items.Add("Four of a Kind")
        lstCombos.Items.Add("Full House")
        lstCombos.Items.Add("Small Straight")
        lstCombos.Items.Add("Large Straight")
        lstCombos.Items.Add("Scratch")
        lstCombos.Items.Add("Chance!")
>>>>>>> 116dd3cd49da9f769c21a7c1377cbadcd997ce99
    End Sub
    Private Sub openAddNameForm()
        If lstCombos.Items.Count = 0 Then
            Dim frmAddName As New AddName
            frmAddName.ShowDialog()

        End If
    End Sub

    Private Sub lstPlayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPlayers.SelectedIndexChanged
        currentPlayer = CType(lstPlayers.SelectedItem, players)
        MessageBox.Show("This player's name is: " & currentPlayer.playerName)
    End Sub
End Class
