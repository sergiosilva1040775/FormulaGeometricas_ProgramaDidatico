Public Class formCirculo
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCircunferenciaCirculo As System.Windows.Forms.Button
    Friend WithEvents lblCircunferenciaCirculo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRaioCirculoCircunferencia As System.Windows.Forms.TextBox
    Friend WithEvents btnAreaCirculo As System.Windows.Forms.Button
    Friend WithEvents lblAreaCirculo As System.Windows.Forms.Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel2 As Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formCirculo))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCircunferenciaCirculo = New System.Windows.Forms.Button()
        Me.lblCircunferenciaCirculo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRaioCirculoCircunferencia = New System.Windows.Forms.TextBox()
        Me.btnAreaCirculo = New System.Windows.Forms.Button()
        Me.lblAreaCirculo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Circunferência"
        '
        'btnCircunferenciaCirculo
        '
        Me.btnCircunferenciaCirculo.BackColor = System.Drawing.SystemColors.Control
        Me.btnCircunferenciaCirculo.Location = New System.Drawing.Point(32, 101)
        Me.btnCircunferenciaCirculo.Name = "btnCircunferenciaCirculo"
        Me.btnCircunferenciaCirculo.Size = New System.Drawing.Size(187, 48)
        Me.btnCircunferenciaCirculo.TabIndex = 2
        Me.btnCircunferenciaCirculo.Text = "Calcular"
        Me.btnCircunferenciaCirculo.UseVisualStyleBackColor = False
        '
        'lblCircunferenciaCirculo
        '
        Me.lblCircunferenciaCirculo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblCircunferenciaCirculo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCircunferenciaCirculo.Location = New System.Drawing.Point(32, 152)
        Me.lblCircunferenciaCirculo.Name = "lblCircunferenciaCirculo"
        Me.lblCircunferenciaCirculo.Size = New System.Drawing.Size(187, 24)
        Me.lblCircunferenciaCirculo.TabIndex = 6
        Me.lblCircunferenciaCirculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(521, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 40)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Área"
        '
        'txtRaioCirculoCircunferencia
        '
        Me.txtRaioCirculoCircunferencia.Location = New System.Drawing.Point(331, 148)
        Me.txtRaioCirculoCircunferencia.Name = "txtRaioCirculoCircunferencia"
        Me.txtRaioCirculoCircunferencia.Size = New System.Drawing.Size(106, 27)
        Me.txtRaioCirculoCircunferencia.TabIndex = 8
        Me.txtRaioCirculoCircunferencia.Text = "Raio"
        Me.txtRaioCirculoCircunferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAreaCirculo
        '
        Me.btnAreaCirculo.BackColor = System.Drawing.SystemColors.Control
        Me.btnAreaCirculo.Location = New System.Drawing.Point(468, 101)
        Me.btnAreaCirculo.Name = "btnAreaCirculo"
        Me.btnAreaCirculo.Size = New System.Drawing.Size(187, 48)
        Me.btnAreaCirculo.TabIndex = 9
        Me.btnAreaCirculo.Text = "Calcular"
        Me.btnAreaCirculo.UseVisualStyleBackColor = False
        '
        'lblAreaCirculo
        '
        Me.lblAreaCirculo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblAreaCirculo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAreaCirculo.Location = New System.Drawing.Point(468, 152)
        Me.lblAreaCirculo.Name = "lblAreaCirculo"
        Me.lblAreaCirculo.Size = New System.Drawing.Size(187, 24)
        Me.lblAreaCirculo.TabIndex = 11
        Me.lblAreaCirculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(122, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(458, 40)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Cálculo da Circunferência e Área do Círculo"
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(260, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(150, 150)
        Me.Panel2.TabIndex = 38
        '
        'formCirculo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 20)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(698, 256)
        Me.Controls.Add(Me.txtRaioCirculoCircunferencia)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblAreaCirculo)
        Me.Controls.Add(Me.btnAreaCirculo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCircunferenciaCirculo)
        Me.Controls.Add(Me.btnCircunferenciaCirculo)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formCirculo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Círculo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim intPi As Decimal = 22 / 7

    Private Sub btnCircunferenciaCirculo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCircunferenciaCirculo.Click

        Dim intRaioCirculo As Decimal
        Dim intCircunferenciaCirculo As Decimal
        lblCircunferenciaCirculo.Text = ""
        If txtRaioCirculoCircunferencia.Text = "Raio" Or txtRaioCirculoCircunferencia.Text.Length = 0 Or txtRaioCirculoCircunferencia.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            intRaioCirculo = CDec(Me.txtRaioCirculoCircunferencia.Text)
            intCircunferenciaCirculo = 2 * intPi * intRaioCirculo
            Me.lblCircunferenciaCirculo.Text = "Circunferência = " & Math.Round(intCircunferenciaCirculo, 2, MidpointRounding.AwayFromZero)
            lblAreaCirculo.Text = ""
            txtRaioCirculoCircunferencia.Text = "Raio"
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub btnAreaCirculo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAreaCirculo.Click

        Dim intRaioCirculo As Decimal
        Dim intAreaCirculo As Decimal
        lblAreaCirculo.Text = ""
        If txtRaioCirculoCircunferencia.Text = "Raio" Or txtRaioCirculoCircunferencia.Text.Length = 0 Or txtRaioCirculoCircunferencia.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            intRaioCirculo = CDec(Me.txtRaioCirculoCircunferencia.Text)
            intAreaCirculo = intPi * intRaioCirculo ^ 2
            Me.lblAreaCirculo.Text = "Area = " & Math.Round(intAreaCirculo, 2, MidpointRounding.AwayFromZero)
            txtRaioCirculoCircunferencia.Text = "Raio"
            lblCircunferenciaCirculo.Text = ""
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If
    End Sub



    Private Sub ControloDeDados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRaioCirculoCircunferencia.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1))) Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                MessageBox.Show("Deverá só inserir números.", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub formCirculo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.opening, AudioPlayMode.Background)
    End Sub

    Private Sub txtRaioCirculoCircunferencia_MouseClick(sender As Object, e As MouseEventArgs) Handles txtRaioCirculoCircunferencia.MouseClick
        Me.lblCircunferenciaCirculo.Text = ""
        Me.lblAreaCirculo.Text = ""
        If txtRaioCirculoCircunferencia.Text = "Raio" Or txtRaioCirculoCircunferencia.Text = "0" Then
            txtRaioCirculoCircunferencia.Clear()
        End If
    End Sub


End Class
