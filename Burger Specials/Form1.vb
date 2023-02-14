Public Class frmBurger
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picPrime.Visible = False
        picVeggie.Visible = False
        btnSelectMeal.Enabled = False
        btnExit.Enabled = False
        lblConfirmation.Hide()
    End Sub

    Private Sub lblHeading_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub

    Private Sub picPrime_Click(sender As Object, e As EventArgs) Handles picPrime.Click

    End Sub

    Private Sub btnPrime_Click(sender As Object, e As EventArgs) Handles btnPrime.Click
        picPrime.Visible = True
        picVeggie.Visible = False
        btnExit.Enabled = False
        btnSelectMeal.Enabled = True


    End Sub

    Private Sub btnSelectMeal_Click(sender As Object, e As EventArgs) Handles btnSelectMeal.Click
        btnExit.Enabled = True
        btnSelectMeal.Enabled = False
        btnVeggie.Enabled = False
        btnPrime.Enabled = False
        lblInstructions.Enabled = False
        lblConfirmation.Show()
        lblInstructions.Hide()
    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        picPrime.Visible = False
        picVeggie.Visible = True
        btnExit.Enabled = False
        btnSelectMeal.Enabled = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
