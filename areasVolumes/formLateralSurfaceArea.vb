Public Class formLateralSurfaceArea
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
    Friend WithEvents txtTamanhoLSARP As System.Windows.Forms.TextBox
    Friend WithEvents txtLarguraLSARP As System.Windows.Forms.TextBox
    Friend WithEvents txtAlturaLSARP As System.Windows.Forms.TextBox
    Friend WithEvents txtRaioLSARCC As System.Windows.Forms.TextBox
    Friend WithEvents txtAlturaLSARCC As System.Windows.Forms.TextBox
    Friend WithEvents txtRaioLSARCCone As System.Windows.Forms.TextBox
    Friend WithEvents txtLSALadoRSP As System.Windows.Forms.TextBox
    Friend WithEvents txtSlantAlturaRSP As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TabControl_Calculos As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnVolumeCalc As Button
    Friend WithEvents Label_Resultado As Label
    Friend WithEvents txtSlantAlturaLSARCCone As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLateralSurfaceArea))
        Me.txtTamanhoLSARP = New System.Windows.Forms.TextBox()
        Me.txtLarguraLSARP = New System.Windows.Forms.TextBox()
        Me.txtAlturaLSARP = New System.Windows.Forms.TextBox()
        Me.txtRaioLSARCC = New System.Windows.Forms.TextBox()
        Me.txtAlturaLSARCC = New System.Windows.Forms.TextBox()
        Me.txtRaioLSARCCone = New System.Windows.Forms.TextBox()
        Me.txtSlantAlturaLSARCCone = New System.Windows.Forms.TextBox()
        Me.txtLSALadoRSP = New System.Windows.Forms.TextBox()
        Me.txtSlantAlturaRSP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl_Calculos = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnVolumeCalc = New System.Windows.Forms.Button()
        Me.Label_Resultado = New System.Windows.Forms.Label()
        Me.TabControl_Calculos.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTamanhoLSARP
        '
        Me.txtTamanhoLSARP.Location = New System.Drawing.Point(366, 141)
        Me.txtTamanhoLSARP.Name = "txtTamanhoLSARP"
        Me.txtTamanhoLSARP.Size = New System.Drawing.Size(103, 27)
        Me.txtTamanhoLSARP.TabIndex = 1
        Me.txtTamanhoLSARP.Text = "Tamanho Lado"
        Me.txtTamanhoLSARP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLarguraLSARP
        '
        Me.txtLarguraLSARP.Location = New System.Drawing.Point(244, 167)
        Me.txtLarguraLSARP.Name = "txtLarguraLSARP"
        Me.txtLarguraLSARP.Size = New System.Drawing.Size(103, 27)
        Me.txtLarguraLSARP.TabIndex = 2
        Me.txtLarguraLSARP.Text = "Largura"
        Me.txtLarguraLSARP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAlturaLSARP
        '
        Me.txtAlturaLSARP.Location = New System.Drawing.Point(150, 85)
        Me.txtAlturaLSARP.Name = "txtAlturaLSARP"
        Me.txtAlturaLSARP.Size = New System.Drawing.Size(103, 27)
        Me.txtAlturaLSARP.TabIndex = 3
        Me.txtAlturaLSARP.Text = "Altura"
        Me.txtAlturaLSARP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRaioLSARCC
        '
        Me.txtRaioLSARCC.Location = New System.Drawing.Point(97, 27)
        Me.txtRaioLSARCC.Name = "txtRaioLSARCC"
        Me.txtRaioLSARCC.Size = New System.Drawing.Size(99, 27)
        Me.txtRaioLSARCC.TabIndex = 8
        Me.txtRaioLSARCC.Text = "Raio"
        Me.txtRaioLSARCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAlturaLSARCC
        '
        Me.txtAlturaLSARCC.Location = New System.Drawing.Point(292, 81)
        Me.txtAlturaLSARCC.Name = "txtAlturaLSARCC"
        Me.txtAlturaLSARCC.Size = New System.Drawing.Size(99, 27)
        Me.txtAlturaLSARCC.TabIndex = 9
        Me.txtAlturaLSARCC.Text = "Altura"
        Me.txtAlturaLSARCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRaioLSARCCone
        '
        Me.txtRaioLSARCCone.Location = New System.Drawing.Point(84, 141)
        Me.txtRaioLSARCCone.Name = "txtRaioLSARCCone"
        Me.txtRaioLSARCCone.Size = New System.Drawing.Size(103, 27)
        Me.txtRaioLSARCCone.TabIndex = 14
        Me.txtRaioLSARCCone.Text = "Raio"
        Me.txtRaioLSARCCone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSlantAlturaLSARCCone
        '
        Me.txtSlantAlturaLSARCCone.Location = New System.Drawing.Point(106, 74)
        Me.txtSlantAlturaLSARCCone.Name = "txtSlantAlturaLSARCCone"
        Me.txtSlantAlturaLSARCCone.Size = New System.Drawing.Size(157, 27)
        Me.txtSlantAlturaLSARCCone.TabIndex = 15
        Me.txtSlantAlturaLSARCCone.Text = "Altura Inclinação"
        Me.txtSlantAlturaLSARCCone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLSALadoRSP
        '
        Me.txtLSALadoRSP.Location = New System.Drawing.Point(123, 116)
        Me.txtLSALadoRSP.Name = "txtLSALadoRSP"
        Me.txtLSALadoRSP.Size = New System.Drawing.Size(116, 27)
        Me.txtLSALadoRSP.TabIndex = 20
        Me.txtLSALadoRSP.Text = "Tamanho Lado"
        Me.txtLSALadoRSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSlantAlturaRSP
        '
        Me.txtSlantAlturaRSP.Location = New System.Drawing.Point(119, 45)
        Me.txtSlantAlturaRSP.Name = "txtSlantAlturaRSP"
        Me.txtSlantAlturaRSP.Size = New System.Drawing.Size(117, 27)
        Me.txtSlantAlturaRSP.TabIndex = 21
        Me.txtSlantAlturaRSP.Text = "Altura Inclinação"
        Me.txtSlantAlturaRSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(145, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(356, 30)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Calcular Área da Superfície Lateral"
        '
        'TabControl_Calculos
        '
        Me.TabControl_Calculos.Controls.Add(Me.TabPage3)
        Me.TabControl_Calculos.Controls.Add(Me.TabPage4)
        Me.TabControl_Calculos.Controls.Add(Me.TabPage5)
        Me.TabControl_Calculos.Controls.Add(Me.TabPage6)
        Me.TabControl_Calculos.Location = New System.Drawing.Point(10, 50)
        Me.TabControl_Calculos.Name = "TabControl_Calculos"
        Me.TabControl_Calculos.SelectedIndex = 0
        Me.TabControl_Calculos.Size = New System.Drawing.Size(629, 233)
        Me.TabControl_Calculos.TabIndex = 40
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtSlantAlturaLSARCCone)
        Me.TabPage3.Controls.Add(Me.txtRaioLSARCCone)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(621, 200)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cone Circular"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(10, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(150, 150)
        Me.Panel3.TabIndex = 38
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtSlantAlturaRSP)
        Me.TabPage4.Controls.Add(Me.txtLSALadoRSP)
        Me.TabPage4.Controls.Add(Me.Panel4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(621, 207)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Pirâmede Quadrada"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(10, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(150, 150)
        Me.Panel4.TabIndex = 38
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtAlturaLSARCC)
        Me.TabPage5.Controls.Add(Me.txtRaioLSARCC)
        Me.TabPage5.Controls.Add(Me.Panel5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(621, 207)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Cilindro Circular"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), System.Drawing.Image)
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Location = New System.Drawing.Point(135, 5)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(166, 184)
        Me.Panel5.TabIndex = 38
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.txtTamanhoLSARP)
        Me.TabPage6.Controls.Add(Me.txtLarguraLSARP)
        Me.TabPage6.Controls.Add(Me.txtAlturaLSARP)
        Me.TabPage6.Controls.Add(Me.Panel6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(621, 200)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Prisma Retangular"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackgroundImage = CType(resources.GetObject("Panel6.BackgroundImage"), System.Drawing.Image)
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel6.Location = New System.Drawing.Point(230, 5)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(187, 172)
        Me.Panel6.TabIndex = 38
        '
        'btnVolumeCalc
        '
        Me.btnVolumeCalc.BackColor = System.Drawing.SystemColors.Control
        Me.btnVolumeCalc.Location = New System.Drawing.Point(675, 71)
        Me.btnVolumeCalc.Name = "btnVolumeCalc"
        Me.btnVolumeCalc.Size = New System.Drawing.Size(85, 85)
        Me.btnVolumeCalc.TabIndex = 42
        Me.btnVolumeCalc.Text = "Calcular"
        Me.btnVolumeCalc.UseVisualStyleBackColor = False
        '
        'Label_Resultado
        '
        Me.Label_Resultado.BackColor = System.Drawing.Color.Gainsboro
        Me.Label_Resultado.Location = New System.Drawing.Point(644, 173)
        Me.Label_Resultado.Name = "Label_Resultado"
        Me.Label_Resultado.Size = New System.Drawing.Size(157, 23)
        Me.Label_Resultado.TabIndex = 43
        '
        'formLateralSurfaceArea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 20)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(817, 294)
        Me.Controls.Add(Me.btnVolumeCalc)
        Me.Controls.Add(Me.Label_Resultado)
        Me.Controls.Add(Me.TabControl_Calculos)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formLateralSurfaceArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Área da Superfície Lateral"
        Me.TabControl_Calculos.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim intPi As Decimal = 22 / 7

    Private Sub LSARP()
        Dim erro As Boolean = False
        If txtAlturaLSARP.Text = "Altura" Or txtAlturaLSARP.Text.Length = 0 Or txtAlturaLSARP.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtAlturaLSARP.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        Else
            If txtLarguraLSARP.Text = "Largura" Or txtLarguraLSARP.Text.Length = 0 Or txtLarguraLSARP.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtLarguraLSARP.BackColor = Color.OrangeRed
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                erro = True
            Else
                If txtTamanhoLSARP.Text = "Tamanho Lado" Or txtTamanhoLSARP.Text.Length = 0 Or txtTamanhoLSARP.Text = "0" Then
                    My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                    txtTamanhoLSARP.BackColor = Color.OrangeRed
                    MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    erro = True
                End If
            End If
        End If
        If Not erro Then
            Dim intTamanhoLSARP As Decimal
            Dim intLarguraLSARP As Decimal
            Dim intAlturaLSARP As Decimal
            Dim intLSARP As Decimal
            intTamanhoLSARP = CDec(Me.txtTamanhoLSARP.Text)
            intLarguraLSARP = CDec(Me.txtLarguraLSARP.Text)
            intAlturaLSARP = CDec(Me.txtAlturaLSARP.Text)
            intLSARP = 2 * (intAlturaLSARP * intLarguraLSARP) + 2 * (intTamanhoLSARP * intAlturaLSARP)
            Me.Label_Resultado.Text = "Volume = " & Math.Round(intLSARP, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub LSARCC()
        Dim erro As Boolean = False
        If txtRaioLSARCC.Text = "Raio" Or txtRaioLSARCC.Text.Length = 0 Or txtRaioLSARCC.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtRaioLSARCC.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        Else
            If txtAlturaLSARCC.Text = "Altura" Or txtAlturaLSARCC.Text.Length = 0 Or txtAlturaLSARCC.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtAlturaLSARCC.BackColor = Color.OrangeRed
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                erro = True
            End If
        End If
        If Not erro Then
            Dim intRaioLSARCC As Decimal
            Dim intAlturaLSARCC As Decimal
            Dim intLSARCC As Decimal
            intRaioLSARCC = CDec(Me.txtRaioLSARCC.Text)
            intAlturaLSARCC = CDec(Me.txtAlturaLSARCC.Text)
            intLSARCC = 2 * intPi * intRaioLSARCC * intAlturaLSARCC
            Me.Label_Resultado.Text = "Área = " & Math.Round(intLSARCC, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub LSARCCone()
        Dim erro As Boolean = False
        If txtSlantAlturaLSARCCone.Text = "Altura Inclinação" Or txtSlantAlturaLSARCCone.Text.Length = 0 Or txtSlantAlturaLSARCCone.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtSlantAlturaLSARCCone.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        Else
            If txtRaioLSARCCone.Text = "Raio" Or txtRaioLSARCCone.Text.Length = 0 Or txtRaioLSARCCone.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtRaioLSARCCone.BackColor = Color.OrangeRed
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                erro = True
            End If
        End If
        If Not erro Then
            Dim intRaioLSARCCone As Decimal
            Dim intSlantAlturaLSARCCone As Decimal
            Dim intLSARCCone As Decimal
            intRaioLSARCCone = CDec(Me.txtRaioLSARCCone.Text)
            intSlantAlturaLSARCCone = CDec(Me.txtSlantAlturaLSARCCone.Text)
            intLSARCCone = intPi * intRaioLSARCCone * intSlantAlturaLSARCCone
            Me.Label_Resultado.Text = "Área = " & Math.Round(intLSARCCone, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub LSARSP()
        Dim erro As Boolean = False
        If txtSlantAlturaRSP.Text = "Altura Inclinação" Or txtSlantAlturaRSP.Text.Length = 0 Or txtSlantAlturaRSP.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtSlantAlturaRSP.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        Else
            If txtLSALadoRSP.Text = "Tamanho Lado" Or txtLSALadoRSP.Text.Length = 0 Or txtLSALadoRSP.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtLSALadoRSP.BackColor = Color.OrangeRed
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                erro = True
            End If
        End If
        If Not erro Then
            Dim intLSALadoRSP As Decimal
            Dim intSlantAlturaRSP As Decimal
            Dim intLSARSP As Decimal
            intLSALadoRSP = CDec(Me.txtLSALadoRSP.Text)
            intSlantAlturaRSP = CDec(Me.txtSlantAlturaRSP.Text)
            intLSARSP = 2 * intLSALadoRSP * intSlantAlturaRSP
            Me.Label_Resultado.Text = "Área = " & Math.Round(intLSARSP, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub formLateralSurfaceArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.opening, AudioPlayMode.Background)
    End Sub


    Private Sub ControloDeDados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTamanhoLSARP.KeyPress,
        txtLarguraLSARP.KeyPress,
        txtAlturaLSARP.KeyPress,
        txtRaioLSARCC.KeyPress,
        txtAlturaLSARCC.KeyPress,
        txtRaioLSARCCone.KeyPress,
        txtSlantAlturaLSARCCone.KeyPress,
        txtLSALadoRSP.KeyPress,
        txtSlantAlturaRSP.KeyPress

        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1))) Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                MessageBox.Show("Deverá só inserir números.", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub btnVolumeCalc_Click(sender As Object, e As EventArgs) Handles btnVolumeCalc.Click

        Label_Resultado.Text = ""
        limparCor()
        Select Case TabControl_Calculos.SelectedIndex
            Case 0 : LSARCCone()
            Case 1 : LSARSP()
            Case 2 : LSARCC()
            Case 3 : LSARP()
        End Select
    End Sub

    Private Sub limparCor()
        txtRaioLSARCCone.BackColor = Color.White
        txtSlantAlturaRSP.BackColor = Color.White
        txtLSALadoRSP.BackColor = Color.White
        txtRaioLSARCC.BackColor = Color.White
        txtAlturaLSARCC.BackColor = Color.White
        txtAlturaLSARP.BackColor = Color.White
        txtLarguraLSARP.BackColor = Color.White
        txtTamanhoLSARP.BackColor = Color.White
        txtSlantAlturaLSARCCone.BackColor = Color.White
    End Sub

    Private Sub limparCampos()
        txtSlantAlturaLSARCCone.Text = "Altura Inclinação"
        txtRaioLSARCCone.Text = "Raio"
        txtSlantAlturaRSP.Text = "Altura Inclinação"
        txtLSALadoRSP.Text = "Tamanho Lado"
        txtRaioLSARCC.Text = "Raio"
        txtAlturaLSARCC.Text = "Altura"
        txtAlturaLSARP.Text = "Altura"
        txtLarguraLSARP.Text = "Largura"
        txtTamanhoLSARP.Text = "Tamanho Lado"
        limparCor()
        Label_Resultado.Text = ""
    End Sub
    Private Sub TabControl_Calculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl_Calculos.SelectedIndexChanged
        limparCampos()
    End Sub

    Private Sub txtSlantAlturaLSARCCone_Click(sender As Object, e As EventArgs) Handles txtSlantAlturaLSARCCone.Click
        txtSlantAlturaLSARCCone.BackColor = Color.White
        If txtSlantAlturaLSARCCone.Text = "Altura Inclinação" Or txtSlantAlturaLSARCCone.Text = "0" Then
            txtSlantAlturaLSARCCone.Clear()
        End If
    End Sub

    Private Sub txtRaioLSARCCone_Click(sender As Object, e As EventArgs) Handles txtRaioLSARCCone.Click
        txtRaioLSARCCone.BackColor = Color.White
        If txtRaioLSARCCone.Text = "Raio" Or txtRaioLSARCCone.Text = "0" Then
            txtRaioLSARCCone.Clear()
        End If
    End Sub

    Private Sub txtSlantAlturaRSP_Click(sender As Object, e As EventArgs) Handles txtSlantAlturaRSP.Click
        txtSlantAlturaRSP.BackColor = Color.White
        If txtSlantAlturaRSP.Text = "Altura Inclinação" Or txtSlantAlturaRSP.Text = "0" Then
            txtSlantAlturaRSP.Clear()
        End If
    End Sub

    Private Sub txtLSALadoRSP_Click(sender As Object, e As EventArgs) Handles txtLSALadoRSP.Click
        txtLSALadoRSP.BackColor = Color.White
        If txtLSALadoRSP.Text = "Tamanho Lado" Or txtLSALadoRSP.Text = "0" Then
            txtLSALadoRSP.Clear()
        End If
    End Sub

    Private Sub txtRaioLSARCC_Click(sender As Object, e As EventArgs) Handles txtRaioLSARCC.Click
        txtRaioLSARCC.BackColor = Color.White
        If txtRaioLSARCC.Text = "Raio" Or txtRaioLSARCC.Text = "0" Then
            txtRaioLSARCC.Clear()
        End If
    End Sub

    Private Sub txtAlturaLSARCC_Click(sender As Object, e As EventArgs) Handles txtAlturaLSARCC.Click
        txtAlturaLSARCC.BackColor = Color.White
        If txtAlturaLSARCC.Text = "Altura" Or txtAlturaLSARCC.Text = "0" Then
            txtAlturaLSARCC.Clear()
        End If
    End Sub

    Private Sub txtAlturaLSARP_Click(sender As Object, e As EventArgs) Handles txtAlturaLSARP.Click
        txtAlturaLSARP.BackColor = Color.White
        If txtAlturaLSARP.Text = "Altura" Or txtAlturaLSARP.Text = "0" Then
            txtAlturaLSARP.Clear()
        End If
    End Sub

    Private Sub txtLarguraLSARP_Click(sender As Object, e As EventArgs) Handles txtLarguraLSARP.Click
        txtLarguraLSARP.BackColor = Color.White
        If txtLarguraLSARP.Text = "Largura" Or txtLarguraLSARP.Text = "0" Then
            txtLarguraLSARP.Clear()
        End If
    End Sub

    Private Sub txtTamanhoLSARP_Click(sender As Object, e As EventArgs) Handles txtTamanhoLSARP.Click
        txtTamanhoLSARP.BackColor = Color.White
        If txtTamanhoLSARP.Text = "Tamanho Lado" Or txtTamanhoLSARP.Text = "0" Then
            txtTamanhoLSARP.Clear()
        End If
    End Sub
End Class
