Public Class Form1
    Private pokemonList As New List(Of Character)
    Private roundList As New List(Of Fight)


    Private Sub cmbChar1_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbChar1.SelectedValueChanged
        If (cmbChar1.Text = "") Then
            lblChar1.Text = ""
        Else
            pbxChar1.Image = My.Resources.ResourceManager.GetObject(findName(cmbChar1.Text).getPicName())
            lblChar1.Text = findName(cmbChar1.Text).CharName & ":" & vbCrLf &
            "Strength: " & findName(cmbChar1.Text).CharStrength & vbCrLf &
            "Health: " & findName(cmbChar1.Text).CharHealth
        End If
    End Sub

    Private Sub displayNames()
        For i = 0 To pokemonList.Count - 1
            If (pokemonList(i).CharHealth > 0) Then
                cmbChar1.Items.Add(pokemonList(i).CharName)
                cmbChar2.Items.Add(pokemonList(i).CharName)
            End If
        Next
    End Sub

    Private Sub cmbChar2_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbChar2.SelectedValueChanged
        If (cmbChar2.Text = "") Then
            lblChar2.Text = ""
        Else
            pbxChar2.Image = My.Resources.ResourceManager.GetObject(findName(cmbChar2.Text).getPicName())
            lblChar2.Text = findName(cmbChar2.Text).CharName & ":" & vbCrLf &
           "Strength: " & findName(cmbChar2.Text).CharStrength & vbCrLf &
           "Health: " & findName(cmbChar2.Text).CharHealth
        End If
    End Sub

    Private Function findName(ByVal name As String) As Character
        For i = 0 To pokemonList.Count - 1
            If (pokemonList(i).CharName = name) Then
                Return pokemonList(i)
            End If
        Next
        Return New Character("", "", 0, 0, New List(Of Attack))
    End Function

    Private Sub MnuFight_Click(sender As Object, e As EventArgs) Handles mnuFight.Click
        Dim fightTemp As New Fight(findName(cmbChar1.Text), findName(cmbChar2.Text))
        roundList.Add(fightTemp)
        Me.Visible = False
        Dim frmFight As New Form2
        frmFight.LoadCharacters(fightTemp)
        If (frmFight.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            If (fightTemp.Winner() = 1) Then
                lblChar1.Text = findName(cmbChar1.Text).CharName & ":" & vbCrLf &
                    "Strength: " & findName(cmbChar1.Text).CharStrength & vbCrLf &
                    "Health: " & findName(cmbChar1.Text).CharHealth
                lblChar2.Text = ""
                cmbChar2.Text = ""
                pbxChar2.Image = Nothing
            ElseIf (fightTemp.Winner() = 2) Then
                lblChar2.Text = findName(cmbChar2.Text).CharName & ":" & vbCrLf &
                    "Strength: " & findName(cmbChar2.Text).CharStrength & vbCrLf &
                    "Health: " & findName(cmbChar2.Text).CharHealth
                lblChar1.Text = ""
                cmbChar1.Text = ""
                pbxChar1.Image = Nothing
            Else
                pbxChar1.Image = Nothing
                pbxChar2.Image = Nothing
                lblChar1.Text = ""
                cmbChar1.Text = ""
                lblChar2.Text = ""
                cmbChar2.Text = ""
            End If
        End If
        Me.Visible = True
    End Sub

    Private Sub mnuLoad_Click(sender As Object, e As EventArgs) Handles mnuLoad.Click
        Dim charName As String = ""
        Dim picName As String = ""
        Dim charHealth, charStrength As Integer
        Dim attName As String = ""
        Dim attPower, attEnergy As Integer
        Dim attList As New List(Of Attack)
        If (dlgLoad.ShowDialog = Windows.Forms.DialogResult.OK) Then
            FileOpen(1, dlgLoad.FileName, OpenMode.Input)
            Do Until EOF(1)
                Input(1, charName)
                Input(1, charHealth)
                Input(1, charStrength)
                Input(1, picName)
                Do Until EOF(1)
                    Input(1, attName)
                    Input(1, attPower)
                    Input(1, attEnergy)
                    attList.Add(New Attack(attName, attPower, attEnergy))
                Loop
                pokemonList.Add(New Character(charName, picName, charHealth, charStrength, attList))
                attList = New List(Of Attack)
            Loop
        End If
        cmbChar1.Items.Clear()
        cmbChar2.Items.Clear()
        displayNames()
        FileClose(1)
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        pokemonList.Clear()
        roundList.Clear()
        cmbChar1.Items.Clear()
        cmbChar2.Items.Clear()
        cmbChar1.Text = ""
        cmbChar2.Text = ""
        lblChar1.Text = ""
        lblChar2.Text = ""
        pbxChar1.Image = Nothing
        pbxChar2.Image = Nothing
    End Sub

    Private Sub mnuSave_Click(sender As Object, e As EventArgs) Handles mnuSave.Click
        If (dlgLoad.ShowDialog = Windows.Forms.DialogResult.OK) Then
            FileOpen(2, dlgLoad.FileName, OpenMode.Output)
            For Each c In roundList
                If c.Winner() = 1 Then
                    PrintLine(2, c.getChar1.CharName() & " beat " & c.getChar2.CharName() &
                              " in " & c.getRoundCount() & " rounds.")
                ElseIf (c.Winner() = 2) Then
                    PrintLine(2, c.getChar2.CharName() & " beat " & c.getChar1.CharName() &
                              " in " & c.getRoundCount() & " rounds.")
                Else
                    PrintLine(2, c.getChar1.CharName() & " tied " & c.getChar2.CharName() &
                              " in " & c.getRoundCount() & " rounds.")
                End If
            Next
        End If
        FileClose(2)
    End Sub
End Class

'change winner to just function not property

