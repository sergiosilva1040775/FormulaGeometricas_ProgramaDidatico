Public Class formArea
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
    Friend WithEvents txtAreaTrianguloBase As System.Windows.Forms.TextBox
    Friend WithEvents txtAreaTrianguloAltura As System.Windows.Forms.TextBox
    Friend WithEvents txtBaseRetangulo As System.Windows.Forms.TextBox
    Friend WithEvents txtAlturaRetangulo As System.Windows.Forms.TextBox
    Friend WithEvents txtSideofQuadrado As System.Windows.Forms.TextBox
    Friend WithEvents txtBase1Trapezoide As System.Windows.Forms.TextBox
    Friend WithEvents txtBase2Trapezoide As System.Windows.Forms.TextBox
    Friend WithEvents txtAlturaTrapezoide As System.Windows.Forms.TextBox
    Friend WithEvents TabControl_Calculos As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnVolumeCalc As Button
    Friend WithEvents Label_Resultado As Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formArea))
        Me.txtAreaTrianguloBase = New System.Windows.Forms.TextBox()
        Me.txtAreaTrianguloAltura = New System.Windows.Forms.TextBox()
        Me.txtBaseRetangulo = New System.Windows.Forms.TextBox()
        Me.txtAlturaRetangulo = New System.Windows.Forms.TextBox()
        Me.txtSideofQuadrado = New System.Windows.Forms.TextBox()
        Me.txtBase1Trapezoide = New System.Windows.Forms.TextBox()
        Me.txtBase2Trapezoide = New System.Windows.Forms.TextBox()
        Me.txtAlturaTrapezoide = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl_Calculos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnVolumeCalc = New System.Windows.Forms.Button()
        Me.Label_Resultado = New System.Windows.Forms.Label()
        Me.TabControl_Calculos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAreaTrianguloBase
        '
        Me.txtAreaTrianguloBase.Location = New System.Drawing.Point(117, 148)
        Me.txtAreaTrianguloBase.Name = "txtAreaTrianguloBase"
        Me.txtAreaTrianguloBase.Size = New System.Drawing.Size(115, 27)
        Me.txtAreaTrianguloBase.TabIndex = 1
        Me.txtAreaTrianguloBase.Text = "Base"
        Me.txtAreaTrianguloBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAreaTrianguloAltura
        '
        Me.txtAreaTrianguloAltura.Location = New System.Drawing.Point(77, 80)
        Me.txtAreaTrianguloAltura.Name = "txtAreaTrianguloAltura"
        Me.txtAreaTrianguloAltura.Size = New System.Drawing.Size(115, 27)
        Me.txtAreaTrianguloAltura.TabIndex = 2
        Me.txtAreaTrianguloAltura.Text = "Altura"
        Me.txtAreaTrianguloAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBaseRetangulo
        '
        Me.txtBaseRetangulo.Location = New System.Drawing.Point(90, 127)
        Me.txtBaseRetangulo.Name = "txtBaseRetangulo"
        Me.txtBaseRetangulo.Size = New System.Drawing.Size(117, 27)
        Me.txtBaseRetangulo.TabIndex = 7
        Me.txtBaseRetangulo.Text = "Base"
        Me.txtBaseRetangulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAlturaRetangulo
        '
        Me.txtAlturaRetangulo.Location = New System.Drawing.Point(250, 71)
        Me.txtAlturaRetangulo.Name = "txtAlturaRetangulo"
        Me.txtAlturaRetangulo.Size = New System.Drawing.Size(117, 27)
        Me.txtAlturaRetangulo.TabIndex = 8
        Me.txtAlturaRetangulo.Text = "Altura"
        Me.txtAlturaRetangulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSideofQuadrado
        '
        Me.txtSideofQuadrado.Location = New System.Drawing.Point(167, 58)
        Me.txtSideofQuadrado.Name = "txtSideofQuadrado"
        Me.txtSideofQuadrado.Size = New System.Drawing.Size(128, 27)
        Me.txtSideofQuadrado.TabIndex = 13
        Me.txtSideofQuadrado.Text = "Tamanho Lado"
        Me.txtSideofQuadrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBase1Trapezoide
        '
        Me.txtBase1Trapezoide.Location = New System.Drawing.Point(111, 141)
        Me.txtBase1Trapezoide.Name = "txtBase1Trapezoide"
        Me.txtBase1Trapezoide.Size = New System.Drawing.Size(121, 27)
        Me.txtBase1Trapezoide.TabIndex = 18
        Me.txtBase1Trapezoide.Text = "Tamanho Base 1"
        Me.txtBase1Trapezoide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBase2Trapezoide
        '
        Me.txtBase2Trapezoide.Location = New System.Drawing.Point(117, 3)
        Me.txtBase2Trapezoide.Name = "txtBase2Trapezoide"
        Me.txtBase2Trapezoide.Size = New System.Drawing.Size(130, 27)
        Me.txtBase2Trapezoide.TabIndex = 19
        Me.txtBase2Trapezoide.Text = "Tamanho Base 2"
        Me.txtBase2Trapezoide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAlturaTrapezoide
        '
        Me.txtAlturaTrapezoide.Location = New System.Drawing.Point(13, 81)
        Me.txtAlturaTrapezoide.Name = "txtAlturaTrapezoide"
        Me.txtAlturaTrapezoide.Size = New System.Drawing.Size(117, 27)
        Me.txtAlturaTrapezoide.TabIndex = 20
        Me.txtAlturaTrapezoide.Text = "Altura"
        Me.txtAlturaTrapezoide.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(291, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(199, 40)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Calculando a Área"
        '
        'TabControl_Calculos
        '
        Me.TabControl_Calculos.Controls.Add(Me.TabPage1)
        Me.TabControl_Calculos.Controls.Add(Me.TabPage2)
        Me.TabControl_Calculos.Controls.Add(Me.TabPage3)
        Me.TabControl_Calculos.Controls.Add(Me.TabPage4)
        Me.TabControl_Calculos.Location = New System.Drawing.Point(10, 56)
        Me.TabControl_Calculos.Name = "TabControl_Calculos"
        Me.TabControl_Calculos.SelectedIndex = 0
        Me.TabControl_Calculos.Size = New System.Drawing.Size(629, 221)
        Me.TabControl_Calculos.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtAreaTrianguloBase)
        Me.TabPage1.Controls.Add(Me.txtAreaTrianguloAltura)
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(621, 188)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Triângulo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(325, 150)
        Me.Panel2.TabIndex = 39
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtBaseRetangulo)
        Me.TabPage2.Controls.Add(Me.txtAlturaRetangulo)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(621, 188)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Retângulo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 150)
        Me.Panel1.TabIndex = 40
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.txtSideofQuadrado)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(621, 188)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Quadrado"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(38, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(128, 27)
        Me.TextBox1.TabIndex = 41
        Me.TextBox1.Text = "Tamanho Lado"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(-91, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(387, 150)
        Me.Panel3.TabIndex = 40
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtBase1Trapezoide)
        Me.TabPage4.Controls.Add(Me.txtBase2Trapezoide)
        Me.TabPage4.Controls.Add(Me.txtAlturaTrapezoide)
        Me.TabPage4.Controls.Add(Me.Panel4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(621, 188)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Trapezóide"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), System.Drawing.Image)
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(10, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(242, 150)
        Me.Panel4.TabIndex = 40
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
        'formArea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 20)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(817, 286)
        Me.Controls.Add(Me.btnVolumeCalc)
        Me.Controls.Add(Me.Label_Resultado)
        Me.Controls.Add(Me.TabControl_Calculos)
        Me.Controls.Add(Me.Label9)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area"
        Me.TabControl_Calculos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CalcularAreaTriangulo()
        Dim erro As Boolean = False
        If txtAreaTrianguloAltura.Text = "Altura" Or txtAreaTrianguloAltura.Text.Length = 0 Or txtAreaTrianguloAltura.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtAreaTrianguloAltura.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        Else
            If txtAreaTrianguloBase.Text = "Base" Or txtAreaTrianguloBase.Text.Length = 0 Or txtAreaTrianguloBase.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtAreaTrianguloBase.BackColor = Color.OrangeRed
                erro = True
            End If
        End If
        If Not erro Then
            Dim intBaseTri As Decimal
            Dim intAlturaTri As Decimal
            Dim intAreaTri As Decimal
            intBaseTri = CDec(Me.txtAreaTrianguloBase.Text)
            intAlturaTri = CDec(Me.txtAreaTrianguloAltura.Text)
            intAreaTri = 1 / 2 * intBaseTri * intAlturaTri
            Me.Label_Resultado.Text = "Área = " & Math.Round(intAreaTri, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub CalcularAreaRetangulo()
        Dim erro As Boolean = False
        If txtAlturaRetangulo.Text = "Altura" Or txtAlturaRetangulo.Text.Length = 0 Or txtAlturaRetangulo.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtAlturaRetangulo.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        Else
            If txtBaseRetangulo.Text = "Base" Or txtBaseRetangulo.Text.Length = 0 Or txtBaseRetangulo.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtBaseRetangulo.BackColor = Color.OrangeRed
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                erro = True
            End If
        End If
        If Not erro Then
            Dim intBaseRetangulo As Decimal
            Dim intAlturaRetangulo As Decimal
            Dim intAreaRetangulo As Decimal
            intBaseRetangulo = CDec(Me.txtBaseRetangulo.Text)
            intAlturaRetangulo = CDec(Me.txtAlturaRetangulo.Text)
            intAreaRetangulo = intBaseRetangulo * intAlturaRetangulo
            Me.Label_Resultado.Text = "Área = " & Math.Round(intAreaRetangulo, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub CalcularAreaQuadrado()
        Dim erro As Boolean = False
        If txtSideofQuadrado.Text = "Tamanho Lado" Or txtSideofQuadrado.Text.Length = 0 Or txtSideofQuadrado.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtSideofQuadrado.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        End If
        If Not erro Then
            Dim intLadoQuadrado As Decimal
            Dim intAreaQuadrado As Decimal
            intLadoQuadrado = CDec(Me.txtSideofQuadrado.Text)
            intAreaQuadrado = intLadoQuadrado ^ 2
            Me.Label_Resultado.Text = "Área = " & Math.Round(intAreaQuadrado, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub CalcularAreaTrapezoide()
        Dim erro As Boolean = False
        If txtBase2Trapezoide.Text = "Tamanho Base 2" Or txtBase2Trapezoide.Text.Length = 0 Or txtBase2Trapezoide.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtBase2Trapezoide.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        Else
            If txtAlturaTrapezoide.Text = "Altura" Or txtAlturaTrapezoide.Text.Length = 0 Or txtAlturaTrapezoide.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtAlturaTrapezoide.BackColor = Color.OrangeRed
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                erro = True
            Else
                If txtBase1Trapezoide.Text = "Tamanho Base 1" Or txtBase1Trapezoide.Text.Length = 0 Or txtBase1Trapezoide.Text = "0" Then
                    My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                    txtBase1Trapezoide.BackColor = Color.OrangeRed
                    MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    erro = True
                End If
            End If
        End If
        If Not erro Then
            Dim intAlturaTrapezoide As Decimal
            Dim intBase1Trapezoide As Decimal
            Dim intBase2Trapezoide As Decimal
            Dim intAreaTrapezoide As Decimal
            intAlturaTrapezoide = CDec(Me.txtAlturaTrapezoide.Text)
            intBase1Trapezoide = CDec(Me.txtBase1Trapezoide.Text)
            intBase2Trapezoide = CDec(Me.txtBase2Trapezoide.Text)
            intAreaTrapezoide = 1 / 2 * intAlturaTrapezoide * (intBase1Trapezoide + intBase2Trapezoide)
            Me.Label_Resultado.Text = "Área = " & Math.Round(intAreaTrapezoide, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If
    End Sub


    Private Sub ControloDeDados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAreaTrianguloBase.KeyPress,
        txtAreaTrianguloAltura.KeyPress,
        txtSideofQuadrado.KeyPress,
        txtBaseRetangulo.KeyPress,
        txtAlturaRetangulo.KeyPress,
        txtBase1Trapezoide.KeyPress,
        txtBase2Trapezoide.KeyPress,
        txtAlturaTrapezoide.KeyPress

        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1))) Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                MessageBox.Show("Deverá só inserir números.", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If

    End Sub
    Private Sub formArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.opening, AudioPlayMode.Background)
    End Sub

    Private Sub limparCor()
        txtAreaTrianguloAltura.BackColor = Color.White
        txtAreaTrianguloBase.BackColor = Color.White
        txtAlturaRetangulo.BackColor = Color.White
        txtBaseRetangulo.BackColor = Color.White
        txtSideofQuadrado.BackColor = Color.White
        txtBase2Trapezoide.BackColor = Color.White
        txtAlturaTrapezoide.BackColor = Color.White
        txtBase1Trapezoide.BackColor = Color.White
    End Sub
    Private Sub limparCampos()
        txtAreaTrianguloAltura.Text = "Altura"
        txtAreaTrianguloBase.Text = "Base"
        txtAlturaRetangulo.Text = "Altura"
        txtBaseRetangulo.Text = "Base"
        txtSideofQuadrado.Text = "Tamanho Lado"
        txtBase2Trapezoide.Text = "Tamanho Base 2"
        txtAlturaTrapezoide.Text = "Altura"
        txtBase1Trapezoide.Text = "Tamanho Base 1"
        Label_Resultado.Text = ""
        limparCor()
    End Sub
    Private Sub TabControl_Calc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl_Calculos.SelectedIndexChanged
        limparCampos()
    End Sub

    Private Sub txtAreaTrianguloAltura_Click(sender As Object, e As EventArgs) Handles txtAreaTrianguloAltura.Click
        txtAreaTrianguloAltura.BackColor = Color.White
        If txtAreaTrianguloAltura.Text = "Altura" Or txtAreaTrianguloAltura.Text = "0" Then
            txtAreaTrianguloAltura.Clear()
        End If
    End Sub

    Private Sub txtAreaTrianguloBase_Click(sender As Object, e As EventArgs) Handles txtAreaTrianguloBase.Click
        txtAreaTrianguloBase.BackColor = Color.White
        If txtAreaTrianguloBase.Text = "Base" Or txtAreaTrianguloBase.Text = "0" Then
            txtAreaTrianguloBase.Clear()
        End If
    End Sub

    Private Sub txtAlturaRetangulo_Click(sender As Object, e As EventArgs) Handles txtAlturaRetangulo.Click

        txtAlturaRetangulo.BackColor = Color.White
        If txtAlturaRetangulo.Text = "Altura" Or txtAlturaRetangulo.Text = "0" Then
            txtAlturaRetangulo.Clear()
        End If
    End Sub

    Private Sub txtBaseRetangulo_Click(sender As Object, e As EventArgs) Handles txtBaseRetangulo.Click
        txtBaseRetangulo.BackColor = Color.White
        If txtBaseRetangulo.Text = "Base" Or txtBaseRetangulo.Text = "0" Then
            txtBaseRetangulo.Clear()
        End If
    End Sub

    Private Sub txtSideofQuadrado_Click(sender As Object, e As EventArgs) Handles txtSideofQuadrado.Click
        txtSideofQuadrado.BackColor = Color.White
        If txtSideofQuadrado.Text = "Tamanho Lado" Or txtSideofQuadrado.Text = "0" Then
            txtSideofQuadrado.Clear()
        End If
    End Sub

    Private Sub txtSideofQuadrado_TextChanged(sender As Object, e As EventArgs) Handles txtSideofQuadrado.TextChanged
        TextBox1.Text = txtSideofQuadrado.Text
    End Sub

    Private Sub txtBase2Trapezoide_Click(sender As Object, e As EventArgs) Handles txtBase2Trapezoide.Click
        txtBase2Trapezoide.BackColor = Color.White
        If txtBase2Trapezoide.Text = "Tamanho Base 2" Or txtBase2Trapezoide.Text = "0" Then
            txtBase2Trapezoide.Clear()
        End If
    End Sub

    Private Sub txtAlturaTrapezoide_Click(sender As Object, e As EventArgs) Handles txtAlturaTrapezoide.Click
        txtAlturaTrapezoide.BackColor = Color.White
        If txtAlturaTrapezoide.Text = "Altura" Or txtAlturaTrapezoide.Text = "0" Then
            txtAlturaTrapezoide.Clear()
        End If
    End Sub

    Private Sub txtBase1Trapezoide_Click(sender As Object, e As EventArgs) Handles txtBase1Trapezoide.Click
        txtBase1Trapezoide.BackColor = Color.White
        If txtBase1Trapezoide.Text = "Tamanho Base 1" Or txtBase1Trapezoide.Text = "0" Then
            txtBase1Trapezoide.Clear()
        End If
    End Sub

    Private Sub btnVolumeCalc_Click(sender As Object, e As EventArgs) Handles btnVolumeCalc.Click

        Label_Resultado.Text = ""
        limparCor()
        Select Case TabControl_Calculos.SelectedIndex
            Case 0 : CalcularAreaTriangulo()
            Case 1 : CalcularAreaRetangulo()
            Case 2 : CalcularAreaQuadrado()
            Case 3 : CalcularAreaTrapezoide()
        End Select
    End Sub


End Class
