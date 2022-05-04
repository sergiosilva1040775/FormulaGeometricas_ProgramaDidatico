Public Class formTotalSurfaceArea
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
    Friend WithEvents txtCumprimentoTSACubo As System.Windows.Forms.TextBox
    Friend WithEvents txtTSACumprimentoRP As System.Windows.Forms.TextBox
    Friend WithEvents txtTSALarguraRP As System.Windows.Forms.TextBox
    Friend WithEvents txtTSAAlturaRP As System.Windows.Forms.TextBox
    Friend WithEvents txtTSARaioEsfera As System.Windows.Forms.TextBox
    Friend WithEvents txtTSARaioRCC As System.Windows.Forms.TextBox
    Friend WithEvents txtTSAAlturaRCC As System.Windows.Forms.TextBox
    Friend WithEvents txtTSARaioRCCone As System.Windows.Forms.TextBox
    Friend WithEvents txtTSASlantAlturaRCCone As System.Windows.Forms.TextBox
    Friend WithEvents txtTSASideRSP As System.Windows.Forms.TextBox
    Friend WithEvents txtTSASlantAlturaRSP As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TabControl_Calculos As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel2 As Panel
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formTotalSurfaceArea))
        Me.txtCumprimentoTSACubo = New System.Windows.Forms.TextBox()
        Me.txtTSACumprimentoRP = New System.Windows.Forms.TextBox()
        Me.txtTSALarguraRP = New System.Windows.Forms.TextBox()
        Me.txtTSAAlturaRP = New System.Windows.Forms.TextBox()
        Me.txtTSARaioEsfera = New System.Windows.Forms.TextBox()
        Me.txtTSARaioRCC = New System.Windows.Forms.TextBox()
        Me.txtTSAAlturaRCC = New System.Windows.Forms.TextBox()
        Me.txtTSARaioRCCone = New System.Windows.Forms.TextBox()
        Me.txtTSASlantAlturaRCCone = New System.Windows.Forms.TextBox()
        Me.txtTSASideRSP = New System.Windows.Forms.TextBox()
        Me.txtTSASlantAlturaRSP = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabControl_Calculos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCumprimentoTSACubo
        '
        Me.txtCumprimentoTSACubo.Location = New System.Drawing.Point(10, 146)
        Me.txtCumprimentoTSACubo.Name = "txtCumprimentoTSACubo"
        Me.txtCumprimentoTSACubo.Size = New System.Drawing.Size(121, 27)
        Me.txtCumprimentoTSACubo.TabIndex = 1
        Me.txtCumprimentoTSACubo.Text = "Tamanho Lado"
        Me.txtCumprimentoTSACubo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTSACumprimentoRP
        '
        Me.txtTSACumprimentoRP.Location = New System.Drawing.Point(241, 166)
        Me.txtTSACumprimentoRP.Name = "txtTSACumprimentoRP"
        Me.txtTSACumprimentoRP.Size = New System.Drawing.Size(110, 27)
        Me.txtTSACumprimentoRP.TabIndex = 6
        Me.txtTSACumprimentoRP.Text = "Tamanho Lado"
        Me.txtTSACumprimentoRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTSALarguraRP
        '
        Me.txtTSALarguraRP.Location = New System.Drawing.Point(372, 139)
        Me.txtTSALarguraRP.Name = "txtTSALarguraRP"
        Me.txtTSALarguraRP.Size = New System.Drawing.Size(87, 27)
        Me.txtTSALarguraRP.TabIndex = 7
        Me.txtTSALarguraRP.Text = "Largura"
        Me.txtTSALarguraRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTSAAlturaRP
        '
        Me.txtTSAAlturaRP.Location = New System.Drawing.Point(163, 83)
        Me.txtTSAAlturaRP.Name = "txtTSAAlturaRP"
        Me.txtTSAAlturaRP.Size = New System.Drawing.Size(87, 27)
        Me.txtTSAAlturaRP.TabIndex = 8
        Me.txtTSAAlturaRP.Text = "Altura"
        Me.txtTSAAlturaRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTSARaioEsfera
        '
        Me.txtTSARaioEsfera.Location = New System.Drawing.Point(87, 55)
        Me.txtTSARaioEsfera.Name = "txtTSARaioEsfera"
        Me.txtTSARaioEsfera.Size = New System.Drawing.Size(100, 27)
        Me.txtTSARaioEsfera.TabIndex = 13
        Me.txtTSARaioEsfera.Text = "Raio"
        Me.txtTSARaioEsfera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTSARaioRCC
        '
        Me.txtTSARaioRCC.Location = New System.Drawing.Point(113, 27)
        Me.txtTSARaioRCC.Name = "txtTSARaioRCC"
        Me.txtTSARaioRCC.Size = New System.Drawing.Size(82, 27)
        Me.txtTSARaioRCC.TabIndex = 18
        Me.txtTSARaioRCC.Text = "Raio"
        Me.txtTSARaioRCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTSAAlturaRCC
        '
        Me.txtTSAAlturaRCC.Location = New System.Drawing.Point(290, 81)
        Me.txtTSAAlturaRCC.Name = "txtTSAAlturaRCC"
        Me.txtTSAAlturaRCC.Size = New System.Drawing.Size(82, 27)
        Me.txtTSAAlturaRCC.TabIndex = 19
        Me.txtTSAAlturaRCC.Text = "Altura"
        Me.txtTSAAlturaRCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTSARaioRCCone
        '
        Me.txtTSARaioRCCone.Location = New System.Drawing.Point(85, 140)
        Me.txtTSARaioRCCone.Name = "txtTSARaioRCCone"
        Me.txtTSARaioRCCone.Size = New System.Drawing.Size(100, 27)
        Me.txtTSARaioRCCone.TabIndex = 24
        Me.txtTSARaioRCCone.Text = "Raio"
        Me.txtTSARaioRCCone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTSASlantAlturaRCCone
        '
        Me.txtTSASlantAlturaRCCone.Location = New System.Drawing.Point(117, 75)
        Me.txtTSASlantAlturaRCCone.Name = "txtTSASlantAlturaRCCone"
        Me.txtTSASlantAlturaRCCone.Size = New System.Drawing.Size(127, 27)
        Me.txtTSASlantAlturaRCCone.TabIndex = 25
        Me.txtTSASlantAlturaRCCone.Text = "Altura Inclinação"
        Me.txtTSASlantAlturaRCCone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTSASideRSP
        '
        Me.txtTSASideRSP.Location = New System.Drawing.Point(127, 122)
        Me.txtTSASideRSP.Name = "txtTSASideRSP"
        Me.txtTSASideRSP.Size = New System.Drawing.Size(117, 27)
        Me.txtTSASideRSP.TabIndex = 30
        Me.txtTSASideRSP.Text = "Tamanho Lado"
        Me.txtTSASideRSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTSASlantAlturaRSP
        '
        Me.txtTSASlantAlturaRSP.Location = New System.Drawing.Point(136, 50)
        Me.txtTSASlantAlturaRSP.Name = "txtTSASlantAlturaRSP"
        Me.txtTSASlantAlturaRSP.Size = New System.Drawing.Size(138, 27)
        Me.txtTSASlantAlturaRSP.TabIndex = 31
        Me.txtTSASlantAlturaRSP.Text = "Altura Inclinação"
        Me.txtTSASlantAlturaRSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(260, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(338, 30)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Calcular Área da Superfície Total"
        '
        'TabControl_Calculos
        '
        Me.TabControl_Calculos.Controls.Add(Me.TabPage1)
        Me.TabControl_Calculos.Controls.Add(Me.TabPage2)
        Me.TabControl_Calculos.Controls.Add(Me.TabPage3)
        Me.TabControl_Calculos.Controls.Add(Me.TabPage4)
        Me.TabControl_Calculos.Controls.Add(Me.TabPage5)
        Me.TabControl_Calculos.Controls.Add(Me.TabPage6)
        Me.TabControl_Calculos.Location = New System.Drawing.Point(10, 50)
        Me.TabControl_Calculos.Name = "TabControl_Calculos"
        Me.TabControl_Calculos.SelectedIndex = 0
        Me.TabControl_Calculos.Size = New System.Drawing.Size(629, 233)
        Me.TabControl_Calculos.TabIndex = 39
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtCumprimentoTSACubo)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(621, 200)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cubo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 150)
        Me.Panel1.TabIndex = 36
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtTSARaioEsfera)
        Me.TabPage2.Controls.Add(Me.Panel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(621, 207)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Esfera"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(10, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(150, 150)
        Me.Panel2.TabIndex = 37
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtTSARaioRCCone)
        Me.TabPage3.Controls.Add(Me.txtTSASlantAlturaRCCone)
        Me.TabPage3.Controls.Add(Me.Panel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(621, 207)
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
        Me.TabPage4.Controls.Add(Me.txtTSASlantAlturaRSP)
        Me.TabPage4.Controls.Add(Me.txtTSASideRSP)
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
        Me.TabPage5.Controls.Add(Me.txtTSAAlturaRCC)
        Me.TabPage5.Controls.Add(Me.txtTSARaioRCC)
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
        Me.TabPage6.Controls.Add(Me.txtTSAAlturaRP)
        Me.TabPage6.Controls.Add(Me.txtTSALarguraRP)
        Me.TabPage6.Controls.Add(Me.txtTSACumprimentoRP)
        Me.TabPage6.Controls.Add(Me.Panel6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(621, 207)
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
        Me.btnVolumeCalc.TabIndex = 40
        Me.btnVolumeCalc.Text = "Calcular"
        Me.btnVolumeCalc.UseVisualStyleBackColor = False
        '
        'Label_Resultado
        '
        Me.Label_Resultado.BackColor = System.Drawing.Color.Gainsboro
        Me.Label_Resultado.Location = New System.Drawing.Point(644, 173)
        Me.Label_Resultado.Name = "Label_Resultado"
        Me.Label_Resultado.Size = New System.Drawing.Size(157, 23)
        Me.Label_Resultado.TabIndex = 41
        '
        'formTotalSurfaceArea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 20)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(817, 294)
        Me.Controls.Add(Me.btnVolumeCalc)
        Me.Controls.Add(Me.Label_Resultado)
        Me.Controls.Add(Me.TabControl_Calculos)
        Me.Controls.Add(Me.Label13)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formTotalSurfaceArea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Área da Superfície Total"
        Me.TabControl_Calculos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
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
    Private Sub TSACubo()
        If txtCumprimentoTSACubo.Text = "Tamanho Lado" Or txtCumprimentoTSACubo.Text.Length = 0 Or txtCumprimentoTSACubo.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCumprimentoTSACubo.BackColor = Color.Red
        Else
            Dim intTSASideCubo As Decimal
            Dim intTSACubo As Decimal
            intTSASideCubo = CDec(Me.txtCumprimentoTSACubo.Text)
            intTSACubo = 6 * intTSASideCubo ^ 2
            Me.Label_Resultado.Text = "Área = " & Math.Round(intTSACubo, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub STPrismaRetangular()
        Dim erro As Boolean = False
        If txtTSAAlturaRP.Text = "Altura" Or txtTSAAlturaRP.Text.Length = 0 Or txtTSAAlturaRP.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtTSAAlturaRP.BackColor = Color.Red
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        Else
            If txtTSALarguraRP.Text = "Largura" Or txtTSALarguraRP.Text.Length = 0 Or txtTSALarguraRP.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtTSALarguraRP.BackColor = Color.Red
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                erro = True
            Else
                If txtTSACumprimentoRP.Text = "Tamanho Lado" Or txtTSACumprimentoRP.Text.Length = 0 Or txtTSACumprimentoRP.Text = "0" Then
                    My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                    txtTSACumprimentoRP.BackColor = Color.Red
                    MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    erro = True
                End If
            End If
        End If
        If Not erro Then
            Dim intTSACumprimentoRP As Decimal
            Dim intTSALarguraRP As Decimal
            Dim intTSAAlturaRP As Decimal
            Dim intTSARP As Decimal
            intTSACumprimentoRP = CDec(Me.txtTSACumprimentoRP.Text)
            intTSALarguraRP = CDec(Me.txtTSALarguraRP.Text)
            intTSAAlturaRP = CDec(Me.txtTSAAlturaRP.Text)
            intTSARP = 2 * (intTSACumprimentoRP * intTSALarguraRP) + 2 * (intTSAAlturaRP * intTSALarguraRP) + 2 * (intTSACumprimentoRP * intTSAAlturaRP)
            Me.Label_Resultado.Text = "Volume = " & Math.Round(intTSARP, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub TSAEsfera()
        If txtTSARaioEsfera.Text = "Raio" Or txtTSARaioEsfera.Text.Length = 0 Or txtTSARaioEsfera.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtTSARaioEsfera.BackColor = Color.Red
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim intTSARaioEsfera As Decimal
            Dim intTSAEsfera As Decimal
            intTSARaioEsfera = CDec(Me.txtTSARaioEsfera.Text)
            intTSAEsfera = 4 * intPi * intTSARaioEsfera ^ 2
            Me.Label_Resultado.Text = "Área = " & Math.Round(intTSAEsfera, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub STCilindroCircular()
        Dim erro As Boolean = False
        If txtTSAAlturaRCC.Text = "Altura" Or txtTSAAlturaRCC.Text.Length = 0 Or txtTSAAlturaRCC.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtTSAAlturaRCC.BackColor = Color.Red
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        Else
            If txtTSARaioRCC.Text = "Raio" Or txtTSARaioRCC.Text.Length = 0 Or txtTSARaioRCC.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtTSARaioRCC.BackColor = Color.Red
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                erro = True
            End If
        End If
        If Not erro Then
            Dim intTSARaioRCC As Decimal
            Dim intTSAAlturaRCC As Decimal
            Dim intTSARCC As Decimal
            intTSARaioRCC = CDec(Me.txtTSARaioRCC.Text)
            intTSAAlturaRCC = CDec(Me.txtTSAAlturaRCC.Text)
            intTSARCC = (2 * intPi * intTSARaioRCC ^ 2) + (2 * intPi * intTSARaioRCC * intTSAAlturaRCC)
            Me.Label_Resultado.Text = "Volume = " & Math.Round(intTSARCC, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub TSARCCone()
        Dim erro As Boolean = False
        If txtTSASlantAlturaRCCone.Text = "Altura Inclinação" Or txtTSASlantAlturaRCCone.Text.Length = 0 Or txtTSASlantAlturaRCCone.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtTSASlantAlturaRCCone.BackColor = Color.Red
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        Else
            If txtTSARaioRCCone.Text = "Raio" Or txtTSARaioRCCone.Text.Length = 0 Or txtTSARaioRCCone.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtTSARaioRCCone.BackColor = Color.Red
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                erro = True
            End If
        End If
        If Not erro Then
            Dim intTSARaioRCCone As Decimal
            Dim intTSASlantAlturaRCCone As Decimal
            Dim intTSARCCone As Decimal
            intTSARaioRCCone = CDec(Me.txtTSARaioRCCone.Text)
            intTSASlantAlturaRCCone = CDec(Me.txtTSASlantAlturaRCCone.Text)
            intTSARCCone = (intPi * intTSARaioRCCone ^ 2) + (intPi * intTSARaioRCCone * intTSASlantAlturaRCCone)
            Me.Label_Resultado.Text = "Área = " & Math.Round(intTSARCCone, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub TSARSP()
        If txtTSASlantAlturaRSP.Text = "Altura Inclinação" Or txtTSASlantAlturaRSP.Text.Length = 0 Or txtTSASlantAlturaRSP.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtTSASlantAlturaRSP.BackColor = Color.Red
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtTSASideRSP.Text = "Tamanho Lado" Or txtTSASideRSP.Text.Length = 0 Or txtTSASideRSP.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtTSASideRSP.BackColor = Color.Red
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim intTSASideRSP As Decimal
                Dim intTSASlantAlturaRSP As Decimal
                Dim intTSARSP As Decimal
                intTSASideRSP = CDec(Me.txtTSASideRSP.Text)
                intTSASlantAlturaRSP = CDec(Me.txtTSASlantAlturaRSP.Text)
                intTSARSP = intTSASideRSP ^ 2 + (2 * intTSASideRSP * intTSASlantAlturaRSP)
                Me.Label_Resultado.Text = "Volume = " & Math.Round(intTSARSP, 2, MidpointRounding.AwayFromZero)
                My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)

            End If
        End If

    End Sub

    Private Sub formTotalSurfaceArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.opening, AudioPlayMode.Background)
    End Sub


    Private Sub ControloDeDados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCumprimentoTSACubo.KeyPress,
txtTSARaioEsfera.KeyPress,
        txtTSARaioRCCone.KeyPress,
        txtTSASlantAlturaRCCone.KeyPress,
        txtTSACumprimentoRP.KeyPress,
        txtTSALarguraRP.KeyPress,
        txtTSAAlturaRP.KeyPress,
        txtTSARaioRCC.KeyPress,
        txtTSAAlturaRCC.KeyPress,
        txtTSASideRSP.KeyPress,
        txtTSASlantAlturaRSP.KeyPress

        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1))) Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                MessageBox.Show("Deverá só inserir números.", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub limparCampos()
        txtCumprimentoTSACubo.Text = "Tamanho Lado"
        txtTSARaioEsfera.Text = "Raio"
        txtTSASlantAlturaRCCone.Text = "Altura Inclinação"
        txtTSARaioRCCone.Text = "Raio"
        txtTSASlantAlturaRSP.Text = "Altura Inclinação"
        txtTSASideRSP.Text = "Tamanho Lado"
        txtTSARaioRCC.Text = "Raio"
        txtTSAAlturaRCC.Text = "Altura"
        txtTSAAlturaRP.Text = "Altura"
        txtTSACumprimentoRP.Text = "Tamanho Lado"
        txtTSALarguraRP.Text = "Largura"
        limparCor()
        Label_Resultado.Text = ""
    End Sub

    Private Sub limparCor()
        txtCumprimentoTSACubo.BackColor = Color.White
        txtTSARaioEsfera.BackColor = Color.White
        txtTSASlantAlturaRCCone.BackColor = Color.White
        txtTSARaioRCCone.BackColor = Color.White
        txtTSASlantAlturaRSP.BackColor = Color.White
        txtTSASideRSP.BackColor = Color.White
        txtTSARaioRCC.BackColor = Color.White
        txtTSAAlturaRCC.BackColor = Color.White
        txtTSAAlturaRP.BackColor = Color.White
        txtTSACumprimentoRP.BackColor = Color.White
        txtTSALarguraRP.BackColor = Color.White
    End Sub
    Private Sub btnVolumeCalc_Click(sender As Object, e As EventArgs) Handles btnVolumeCalc.Click
        Label_Resultado.Text = ""
        limparCor()
        Select Case TabControl_Calculos.SelectedIndex
            Case 0 : TSACubo()
            Case 1 : TSAEsfera()
            Case 2 : TSARCCone()
            Case 3 : TSARSP()
            Case 4 : STCilindroCircular()
            Case 5 : STPrismaRetangular()
        End Select
    End Sub

    Private Sub TabControl_Calculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl_Calculos.SelectedIndexChanged
        limparCampos()
    End Sub

    Private Sub txtCumprimentoTSACubo_Click(sender As Object, e As EventArgs) Handles txtCumprimentoTSACubo.Click
        txtCumprimentoTSACubo.BackColor = Color.White
        If txtCumprimentoTSACubo.Text = "Tamanho Lado" Or txtCumprimentoTSACubo.Text = "0" Then
            txtCumprimentoTSACubo.Clear()
        End If
    End Sub

    Private Sub txtTSARaioEsfera_Click(sender As Object, e As EventArgs) Handles txtTSARaioEsfera.Click
        txtTSARaioEsfera.BackColor = Color.White
        If txtTSARaioEsfera.Text = "Raio" Or txtTSARaioEsfera.Text = "0" Then
            txtTSARaioEsfera.Clear()
        End If
    End Sub

    Private Sub txtTSASlantAlturaRCCone_Click(sender As Object, e As EventArgs) Handles txtTSASlantAlturaRCCone.Click
        txtTSASlantAlturaRCCone.BackColor = Color.White
        If txtTSASlantAlturaRCCone.Text = "Altura Inclinação" Or txtTSASlantAlturaRCCone.Text = "0" Then
            txtTSASlantAlturaRCCone.Clear()
        End If
    End Sub

    Private Sub txtTSARaioRCCone_Click(sender As Object, e As EventArgs) Handles txtTSARaioRCCone.Click
        txtTSARaioRCCone.BackColor = Color.White
        If txtTSARaioRCCone.Text = "Raio" Or txtTSARaioRCCone.Text = "0" Then
            txtTSARaioRCCone.Clear()
        End If
    End Sub

    Private Sub txtTSASlantAlturaRSP_Click(sender As Object, e As EventArgs) Handles txtTSASlantAlturaRSP.Click
        txtTSASlantAlturaRSP.BackColor = Color.White
        If txtTSASlantAlturaRSP.Text = "Altura Inclinação" Or txtTSASlantAlturaRSP.Text = "0" Then
            txtTSASlantAlturaRSP.Clear()
        End If
    End Sub

    Private Sub txtTSASideRSP_Click(sender As Object, e As EventArgs) Handles txtTSASideRSP.Click
        txtTSASideRSP.BackColor = Color.White
        If txtTSASideRSP.Text = "Tamanho Lado" Or txtTSASideRSP.Text = "0" Then
            txtTSASideRSP.Clear()
        End If
    End Sub

    Private Sub txtTSARaioRCC_Click(sender As Object, e As EventArgs) Handles txtTSARaioRCC.Click
        txtTSARaioRCC.BackColor = Color.White
        If txtTSARaioRCC.Text = "Raio" Or txtTSARaioRCC.Text = "0" Then
            txtTSARaioRCC.Clear()
        End If
    End Sub

    Private Sub txtTSAAlturaRCC_Click(sender As Object, e As EventArgs) Handles txtTSAAlturaRCC.Click
        txtTSAAlturaRCC.BackColor = Color.White
        If txtTSAAlturaRCC.Text = "Altura" Or txtTSAAlturaRCC.Text = "0" Then
            txtTSAAlturaRCC.Clear()
        End If
    End Sub

    Private Sub txtTSAAlturaRP_Click(sender As Object, e As EventArgs) Handles txtTSAAlturaRP.Click
        txtTSAAlturaRP.BackColor = Color.White
        If txtTSAAlturaRP.Text = "Altura" Or txtTSAAlturaRP.Text = "0" Then
            txtTSAAlturaRP.Clear()
        End If
    End Sub

    Private Sub txtTSACumprimentoRP_Click(sender As Object, e As EventArgs) Handles txtTSACumprimentoRP.Click
        txtTSACumprimentoRP.BackColor = Color.White
        If txtTSACumprimentoRP.Text = "Tamanho Lado" Or txtTSACumprimentoRP.Text = "0" Then
            txtTSACumprimentoRP.Clear()
        End If
    End Sub

    Private Sub txtTSALarguraRP_Click(sender As Object, e As EventArgs) Handles txtTSALarguraRP.Click
        txtTSALarguraRP.BackColor = Color.White
        If txtTSALarguraRP.Text = "Largura" Or txtTSALarguraRP.Text = "0" Then
            txtTSALarguraRP.Clear()
        End If
    End Sub
End Class
