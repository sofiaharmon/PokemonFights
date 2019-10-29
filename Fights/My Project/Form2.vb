Public Class Form2
    Dim charFight As Fight

    Public Sub LoadCharacters(ByVal fightTemp As Fight)
        charFight = fightTemp
        lblChar1.Text = charFight.getChar1.CharName
        lblChar2.Text = charFight.getChar2.CharName
        For i = 0 To charFight.getChar1.getAttacks().count - 1
            Dim lvwItem1 As New ListViewItem(Convert.ToString(charFight.getChar1.getAttacks(i).AttackName()))
            Dim lvwItem2 As New ListViewItem(Convert.ToString(charFight.getChar2.getAttacks(i).AttackName()))
            lvwItem1.SubItems.Add(charFight.getChar1.getAttacks(i).getPower)
            lvwItem1.SubItems.Add(charFight.getChar1.getAttacks(i).getEnergy)
            lvwChar1.Items.Add(lvwItem1)
            lvwItem2.SubItems.Add(charFight.getChar2.getAttacks(i).getPower)
            lvwItem2.SubItems.Add(charFight.getChar2.getAttacks(i).getEnergy)
            lvwChar2.Items.Add(lvwItem2)
        Next
    End Sub

    Private Sub BtnBattle_Click(sender As Object, e As EventArgs) Handles btnBattle.Click
        charFight.fight(lvwChar1.SelectedIndices(0), lvwChar2.SelectedIndices(0))
        charFight.getRoundCount += 1
        prbHealth1.Value = charFight.getHealth1()
        prbHealth2.Value = charFight.getHealth2()
        prbEnergy1.Value = charFight.getEnergy1
        prbEnergy2.Value = charFight.getEnergy2
        If charFight.IsBattleOver() = True Then
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        prbHealth1.Maximum = charFight.getChar1.charHealth()
        prbHealth2.Maximum = charFight.getChar2.charHealth()
        prbHealth1.Value = charFight.getHealth1()
        prbHealth2.Value = charFight.getHealth2()
        prbEnergy1.Value = charFight.getEnergy1
        prbEnergy2.Value = charFight.getEnergy2
    End Sub
End Class