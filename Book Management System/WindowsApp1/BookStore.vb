Public Class BookStore
    Dim total As Decimal
    Dim Atotal As Decimal
    Dim discount As Decimal
    Dim Adiscount As Decimal
    Dim ResponseDialogResult As DialogResult


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Date.Now.ToString("dd MM yyyy")
        Label2.Text = Date.Now.ToString("hh:mm:ss")

    End Sub

    Private Sub txtNumbersOnly(sender As Object, e As KeyPressEventArgs) Handles txt1.KeyPress

        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
            MessageBox.Show("Please Enter A Valid Quantity In Number", "Invalid Quantity",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        rd1.Checked = True

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        nametext.Text = ComboBox1.SelectedItem

        If ComboBox1.SelectedItem = "A Ladder To The Success" Then
            TextBox1.Text = "110"
        ElseIf ComboBox1.SelectedItem = "Eleven Minutes" Then
            TextBox1.Text = "100"
        ElseIf ComboBox1.SelectedItem = "The Alchemist" Then
            TextBox1.Text = "90"
        ElseIf ComboBox1.SelectedItem = "A Monk Who Sold His Ferrari" Then
            TextBox1.Text = "80"
        ElseIf ComboBox1.SelectedItem = "The Fifth Mountain" Then
            TextBox1.Text = "40"
        ElseIf ComboBox1.SelectedItem = "Anna Karenina" Then
            TextBox1.Text = "120"
        ElseIf ComboBox1.SelectedItem = "To Kill A Mokingbird" Then
            TextBox1.Text = "105"
        ElseIf ComboBox1.SelectedItem = "The Great Gatsby" Then
            TextBox1.Text = "99"
        ElseIf ComboBox1.SelectedItem = "A Passage To India" Then
            TextBox1.Text = "35"
        ElseIf ComboBox1.SelectedItem = "Invisible Man" Then
            TextBox1.Text = "150"
        ElseIf ComboBox1.SelectedItem = "Who Am I?" Then
            TextBox1.Text = "125"
        ElseIf ComboBox1.SelectedItem = "Learn From Zero" Then
            TextBox1.Text = "170"


        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim sExit As DialogResult

        sExit = MessageBox.Show("Do you want to exit?", "Caldwell Store", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If sExit = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        If txt1.Text = 0 Then
            MessageBox.Show("Error In Quantity or Price Field", "Caldwell Store",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With txt1
                .Focus()
                .SelectAll()
            End With

        End If

        Atotal = TextBox1.Text * txt1.Text

        If rd1.Checked = True Then
            discount = (0.15 * Atotal)
            total = Atotal - discount
            total = total + 0.06 * total
        ElseIf rd2.Checked = True Then
            discount = (0.2 * Atotal)
            total = Atotal - discount
        ElseIf rd3.Checked = True Then
            discount = (0.1 * Atotal)
            total = Atotal - discount
            total = total + 0.06 * total
        ElseIf rd4.Checked = True Then
            discount = (0.1 * Atotal)
            total = Atotal - discount
            total = total + 0.06 * total
        ElseIf rd5.Checked = True Then
            discount = (0.05 * Atotal)
            total = Atotal - discount
            total = total + 0.06 * total
        End If
        Label9.Text = FormatCurrency(total)
    End Sub

    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryToolStripMenuItem.Click
        Dim ResponseDialogResult As DialogResult
        Dim first As String = FormatCurrency(total)
        Dim second As String = txt1.Text
        Dim third As String = FormatCurrency(discount)
        Dim four As String = nametext.Text
        ResponseDialogResult = MessageBox.Show("Name of The Book = " + four + vbNewLine + "Total Sales = " + first + vbNewLine + "Sales Count = " + second + vbNewLine + "Total Discounts without Tax= " + third, "Caldwell Store", MessageBoxButtons.OK, MessageBoxIcon.Information)
        If ResponseDialogResult = DialogResult.OK Then
            Me.Controls.Clear()
            Me.InitializeComponent()
        End If
    End Sub

End Class