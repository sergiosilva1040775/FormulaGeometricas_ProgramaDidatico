Public Class formVolume
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
    Friend WithEvents txtSideofCube As System.Windows.Forms.TextBox
    Friend WithEvents btnVolumeCalc As System.Windows.Forms.Button
    Friend WithEvents txtAlturaRP As System.Windows.Forms.TextBox
    Friend WithEvents txtWidthRP As System.Windows.Forms.TextBox
    Friend WithEvents Label_Resultado As System.Windows.Forms.Label
    Friend WithEvents txtRadiusSphere As System.Windows.Forms.TextBox
    Friend WithEvents txtRadiusRCC As System.Windows.Forms.TextBox
    Friend WithEvents txtAlturaRCC As System.Windows.Forms.TextBox
    Friend WithEvents txtRadiusRCCone As System.Windows.Forms.TextBox
    Friend WithEvents txtAlturaRCCone As System.Windows.Forms.TextBox
    Friend WithEvents txtLadoPiramede As System.Windows.Forms.TextBox
    Friend WithEvents txtAlturaRSP As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel_Cubo As Panel
    Friend WithEvents Panel_Esfera As Panel
    Friend WithEvents TabControl_Calculos As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel_CC As Panel
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Panel_PQ As Panel
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Panel_Cil_Cir As Panel
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents txtLengthRPL As TextBox
    Friend WithEvents Panel_Pris_Recta As Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formVolume))
        Me.txtSideofCube = New System.Windows.Forms.TextBox()
        Me.btnVolumeCalc = New System.Windows.Forms.Button()
        Me.txtAlturaRP = New System.Windows.Forms.TextBox()
        Me.txtWidthRP = New System.Windows.Forms.TextBox()
        Me.Label_Resultado = New System.Windows.Forms.Label()
        Me.txtRadiusSphere = New System.Windows.Forms.TextBox()
        Me.txtRadiusRCC = New System.Windows.Forms.TextBox()
        Me.txtAlturaRCC = New System.Windows.Forms.TextBox()
        Me.txtRadiusRCCone = New System.Windows.Forms.TextBox()
        Me.txtAlturaRCCone = New System.Windows.Forms.TextBox()
        Me.txtLadoPiramede = New System.Windows.Forms.TextBox()
        Me.txtAlturaRSP = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel_Cubo = New System.Windows.Forms.Panel()
        Me.Panel_Esfera = New System.Windows.Forms.Panel()
        Me.TabControl_Calculos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel_CC = New System.Windows.Forms.Panel()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel_PQ = New System.Windows.Forms.Panel()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel_Cil_Cir = New System.Windows.Forms.Panel()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.txtLengthRPL = New System.Windows.Forms.TextBox()
        Me.Panel_Pris_Recta = New System.Windows.Forms.Panel()
        Me.TabControl_Calculos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSideofCube
        '
        Me.txtSideofCube.Location = New System.Drawing.Point(10, 146)
        Me.txtSideofCube.Name = "txtSideofCube"
        Me.txtSideofCube.Size = New System.Drawing.Size(104, 27)
        Me.txtSideofCube.TabIndex = 1
        Me.txtSideofCube.Text = "Tamanho Lado"
        Me.txtSideofCube.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVolumeCalc
        '
        Me.btnVolumeCalc.BackColor = System.Drawing.SystemColors.Control
        Me.btnVolumeCalc.Location = New System.Drawing.Point(675, 71)
        Me.btnVolumeCalc.Name = "btnVolumeCalc"
        Me.btnVolumeCalc.Size = New System.Drawing.Size(85, 85)
        Me.btnVolumeCalc.TabIndex = 2
        Me.btnVolumeCalc.Text = "Calcular"
        Me.btnVolumeCalc.UseVisualStyleBackColor = False
        '
        'txtAlturaRP
        '
        Me.txtAlturaRP.Location = New System.Drawing.Point(151, 87)
        Me.txtAlturaRP.Name = "txtAlturaRP"
        Me.txtAlturaRP.Size = New System.Drawing.Size(98, 27)
        Me.txtAlturaRP.TabIndex = 7
        Me.txtAlturaRP.Text = "Altura"
        Me.txtAlturaRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtWidthRP
        '
        Me.txtWidthRP.Location = New System.Drawing.Point(377, 142)
        Me.txtWidthRP.Name = "txtWidthRP"
        Me.txtWidthRP.Size = New System.Drawing.Size(98, 27)
        Me.txtWidthRP.TabIndex = 8
        Me.txtWidthRP.Text = "Largura"
        Me.txtWidthRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_Resultado
        '
        Me.Label_Resultado.BackColor = System.Drawing.Color.Gainsboro
        Me.Label_Resultado.Location = New System.Drawing.Point(644, 173)
        Me.Label_Resultado.Name = "Label_Resultado"
        Me.Label_Resultado.Size = New System.Drawing.Size(157, 23)
        Me.Label_Resultado.TabIndex = 10
        '
        'txtRadiusSphere
        '
        Me.txtRadiusSphere.Location = New System.Drawing.Point(85, 53)
        Me.txtRadiusSphere.Name = "txtRadiusSphere"
        Me.txtRadiusSphere.Size = New System.Drawing.Size(101, 27)
        Me.txtRadiusSphere.TabIndex = 13
        Me.txtRadiusSphere.Text = "Raio"
        Me.txtRadiusSphere.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRadiusRCC
        '
        Me.txtRadiusRCC.Location = New System.Drawing.Point(98, 22)
        Me.txtRadiusRCC.Name = "txtRadiusRCC"
        Me.txtRadiusRCC.Size = New System.Drawing.Size(97, 27)
        Me.txtRadiusRCC.TabIndex = 18
        Me.txtRadiusRCC.Text = "Raio"
        Me.txtRadiusRCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAlturaRCC
        '
        Me.txtAlturaRCC.Location = New System.Drawing.Point(290, 83)
        Me.txtAlturaRCC.Name = "txtAlturaRCC"
        Me.txtAlturaRCC.Size = New System.Drawing.Size(97, 27)
        Me.txtAlturaRCC.TabIndex = 19
        Me.txtAlturaRCC.Text = "Altura"
        Me.txtAlturaRCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRadiusRCCone
        '
        Me.txtRadiusRCCone.Location = New System.Drawing.Point(84, 139)
        Me.txtRadiusRCCone.Name = "txtRadiusRCCone"
        Me.txtRadiusRCCone.Size = New System.Drawing.Size(104, 27)
        Me.txtRadiusRCCone.TabIndex = 24
        Me.txtRadiusRCCone.Text = "Raio"
        Me.txtRadiusRCCone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAlturaRCCone
        '
        Me.txtAlturaRCCone.Location = New System.Drawing.Point(85, 74)
        Me.txtAlturaRCCone.Name = "txtAlturaRCCone"
        Me.txtAlturaRCCone.Size = New System.Drawing.Size(104, 27)
        Me.txtAlturaRCCone.TabIndex = 25
        Me.txtAlturaRCCone.Text = "Altura"
        Me.txtAlturaRCCone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLadoPiramede
        '
        Me.txtLadoPiramede.Location = New System.Drawing.Point(143, 122)
        Me.txtLadoPiramede.Name = "txtLadoPiramede"
        Me.txtLadoPiramede.Size = New System.Drawing.Size(117, 27)
        Me.txtLadoPiramede.TabIndex = 30
        Me.txtLadoPiramede.Text = "Tamanho Lado"
        Me.txtLadoPiramede.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAlturaRSP
        '
        Me.txtAlturaRSP.Location = New System.Drawing.Point(90, 63)
        Me.txtAlturaRSP.Name = "txtAlturaRSP"
        Me.txtAlturaRSP.Size = New System.Drawing.Size(100, 27)
        Me.txtAlturaRSP.TabIndex = 31
        Me.txtAlturaRSP.Text = "Altura"
        Me.txtAlturaRSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(338, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(177, 30)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Calcular Volume"
        '
        'Panel_Cubo
        '
        Me.Panel_Cubo.BackgroundImage = CType(resources.GetObject("Panel_Cubo.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Cubo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Cubo.Location = New System.Drawing.Point(10, 10)
        Me.Panel_Cubo.Name = "Panel_Cubo"
        Me.Panel_Cubo.Size = New System.Drawing.Size(150, 150)
        Me.Panel_Cubo.TabIndex = 36
        '
        'Panel_Esfera
        '
        Me.Panel_Esfera.BackgroundImage = CType(resources.GetObject("Panel_Esfera.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Esfera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Esfera.Location = New System.Drawing.Point(10, 10)
        Me.Panel_Esfera.Name = "Panel_Esfera"
        Me.Panel_Esfera.Size = New System.Drawing.Size(150, 150)
        Me.Panel_Esfera.TabIndex = 37
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
        Me.TabControl_Calculos.TabIndex = 38
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtSideofCube)
        Me.TabPage1.Controls.Add(Me.Panel_Cubo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(621, 200)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cubo"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtRadiusSphere)
        Me.TabPage2.Controls.Add(Me.Panel_Esfera)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(621, 207)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Esfera"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtAlturaRCCone)
        Me.TabPage3.Controls.Add(Me.txtRadiusRCCone)
        Me.TabPage3.Controls.Add(Me.Panel_CC)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(621, 207)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Cone Circular"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel_CC
        '
        Me.Panel_CC.BackgroundImage = CType(resources.GetObject("Panel_CC.BackgroundImage"), System.Drawing.Image)
        Me.Panel_CC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_CC.Location = New System.Drawing.Point(10, 10)
        Me.Panel_CC.Name = "Panel_CC"
        Me.Panel_CC.Size = New System.Drawing.Size(150, 150)
        Me.Panel_CC.TabIndex = 38
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txtLadoPiramede)
        Me.TabPage4.Controls.Add(Me.txtAlturaRSP)
        Me.TabPage4.Controls.Add(Me.Panel_PQ)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(621, 207)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Pirâmede Quadrada"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel_PQ
        '
        Me.Panel_PQ.BackgroundImage = CType(resources.GetObject("Panel_PQ.BackgroundImage"), System.Drawing.Image)
        Me.Panel_PQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_PQ.Location = New System.Drawing.Point(10, 10)
        Me.Panel_PQ.Name = "Panel_PQ"
        Me.Panel_PQ.Size = New System.Drawing.Size(150, 150)
        Me.Panel_PQ.TabIndex = 38
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtRadiusRCC)
        Me.TabPage5.Controls.Add(Me.txtAlturaRCC)
        Me.TabPage5.Controls.Add(Me.Panel_Cil_Cir)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(621, 207)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Cilindro Circular"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel_Cil_Cir
        '
        Me.Panel_Cil_Cir.BackgroundImage = CType(resources.GetObject("Panel_Cil_Cir.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Cil_Cir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Cil_Cir.Location = New System.Drawing.Point(135, 5)
        Me.Panel_Cil_Cir.Name = "Panel_Cil_Cir"
        Me.Panel_Cil_Cir.Size = New System.Drawing.Size(166, 184)
        Me.Panel_Cil_Cir.TabIndex = 38
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.txtLengthRPL)
        Me.TabPage6.Controls.Add(Me.txtWidthRP)
        Me.TabPage6.Controls.Add(Me.txtAlturaRP)
        Me.TabPage6.Controls.Add(Me.Panel_Pris_Recta)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(621, 207)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Prisma Retangular"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'txtLengthRPL
        '
        Me.txtLengthRPL.Location = New System.Drawing.Point(246, 167)
        Me.txtLengthRPL.Name = "txtLengthRPL"
        Me.txtLengthRPL.Size = New System.Drawing.Size(112, 27)
        Me.txtLengthRPL.TabIndex = 39
        Me.txtLengthRPL.Text = "Tamanho Lado"
        Me.txtLengthRPL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel_Pris_Recta
        '
        Me.Panel_Pris_Recta.BackgroundImage = CType(resources.GetObject("Panel_Pris_Recta.BackgroundImage"), System.Drawing.Image)
        Me.Panel_Pris_Recta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel_Pris_Recta.Location = New System.Drawing.Point(230, 5)
        Me.Panel_Pris_Recta.Name = "Panel_Pris_Recta"
        Me.Panel_Pris_Recta.Size = New System.Drawing.Size(187, 172)
        Me.Panel_Pris_Recta.TabIndex = 38
        '
        'formVolume
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 20)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(817, 294)
        Me.Controls.Add(Me.btnVolumeCalc)
        Me.Controls.Add(Me.TabControl_Calculos)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label_Resultado)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formVolume"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Volume"
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

    Private Sub VolumeCubo()
        If txtSideofCube.Text = "Tamanho Lado" Or txtSideofCube.Text.Length = 0 Or txtSideofCube.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtSideofCube.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim intLado As Decimal
            Dim intVolumeCubo As Decimal
            intLado = CDec(Me.txtSideofCube.Text)
            intVolumeCubo = intLado ^ 3
            Me.Label_Resultado.Text = "Volume = " & Math.Round(intVolumeCubo, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub VolumePrismaRetangular()

        If txtAlturaRP.Text = "Altura" Or txtAlturaRP.Text.Length = 0 Or txtAlturaRP.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtAlturaRP.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If txtWidthRP.Text = "Largura" Or txtWidthRP.Text.Length = 0 Or txtWidthRP.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtWidthRP.BackColor = Color.OrangeRed
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If txtLengthRPL.Text = "Tamanho Lado" Or txtLengthRPL.Text.Length = 0 Or txtLengthRPL.Text = "0" Then
                    My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                    txtLengthRPL.BackColor = Color.OrangeRed
                    MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    Dim intCumprimento As Decimal
                    Dim intLargura As Decimal
                    Dim intAltura As Decimal
                    Dim intVolumeRP As Decimal
                    intCumprimento = CDec(Me.txtLengthRPL.Text)
                    intLargura = CDec(Me.txtWidthRP.Text)
                    intAltura = CDec(Me.txtAlturaRP.Text)
                    intVolumeRP = intCumprimento * intLargura * intAltura
                    Me.Label_Resultado.Text = "Volume = " & Math.Round(intVolumeRP, 2, MidpointRounding.AwayFromZero)
                    My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
                End If
            End If
        End If


    End Sub

    Private Sub VolumeEsfera()
        If txtRadiusSphere.Text = "Raio" Or txtRadiusSphere.Text.Length = 0 Or txtRadiusSphere.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtRadiusSphere.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim intRaio As Decimal
            Dim intVolumeEsfera As Decimal
            intRaio = CDec(Me.txtRadiusSphere.Text)
            intVolumeEsfera = 4 / 3 * intPi * intRaio ^ 3
            Me.Label_Resultado.Text = "Volume = " & Math.Round(intVolumeEsfera, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub VolumeCilindroCircular()
        Dim erro As Boolean = False
        If txtRadiusRCC.Text = "Raio" Or txtRadiusRCC.Text.Length = 0 Or txtRadiusRCC.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtRadiusRCC.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        Else
            If txtAlturaRCC.Text = "Altura" Or txtAlturaRCC.Text.Length = 0 Or txtAlturaRCC.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtAlturaRCC.BackColor = Color.OrangeRed
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                erro = True
            End If
        End If
        If Not erro Then
            Dim intRaioRCC As Decimal
            Dim intAlturaRCC As Decimal
            Dim intVolumeRCC As Decimal
            intRaioRCC = CDec(Me.txtRadiusRCC.Text)
            intAlturaRCC = CDec(Me.txtAlturaRCC.Text)
            intVolumeRCC = intPi * intRaioRCC ^ 2 * intAlturaRCC
            Me.Label_Resultado.Text = "Volume = " & Math.Round(intVolumeRCC, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub VolumeRCCone()
        Dim erro As Boolean = False
        If txtAlturaRCCone.Text = "Altura" Or txtAlturaRCCone.Text.Length = 0 Or txtAlturaRCCone.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtAlturaRCCone.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        Else
            If txtRadiusRCCone.Text = "Raio" Or txtRadiusRCCone.Text.Length = 0 Or txtRadiusRCCone.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtRadiusRCCone.BackColor = Color.OrangeRed
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                erro = True
            End If
        End If
        If Not erro Then
            Dim intRaioRCCone As Decimal
            Dim intAlturaRCCone As Decimal
            Dim intVolumeRCCone As Decimal
            intRaioRCCone = CDec(Me.txtRadiusRCCone.Text)
            intAlturaRCCone = CDec(Me.txtAlturaRCCone.Text)
            intVolumeRCCone = 1 / 3 * intPi * intRaioRCCone ^ 2 * intAlturaRCCone
            Me.Label_Resultado.Text = "Volume = " & Math.Round(intVolumeRCCone, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub VolumePiramedeQuadrada()
        Dim erro As Boolean = False
        If txtAlturaRSP.Text = "Altura" Or txtAlturaRSP.Text.Length = 0 Or txtAlturaRSP.Text = "0" Then
            My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
            txtAlturaRSP.BackColor = Color.OrangeRed
            MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            erro = True
        Else
            If txtLadoPiramede.Text = "Raio" Or txtLadoPiramede.Text.Length = 0 Or txtLadoPiramede.Text = "0" Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                txtLadoPiramede.BackColor = Color.OrangeRed
                MessageBox.Show(Me, "Valores inexistentes ou inválidos!" + vbNewLine + "Insira um valor válido", "Mensagem de Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                erro = True
            End If
        End If
        If Not erro Then
            Dim intLadoRSP As Decimal
            Dim intAlturaPQ As Decimal
            Dim intVolumeRSP As Decimal
            intLadoRSP = CDec(Me.txtLadoPiramede.Text)
            intAlturaPQ = CDec(Me.txtAlturaRSP.Text)
            intVolumeRSP = 1 / 3 * intLadoRSP ^ 2 * intAlturaPQ
            Me.Label_Resultado.Text = "Volume = " & Math.Round(intVolumeRSP, 2, MidpointRounding.AwayFromZero)
            My.Computer.Audio.Play(My.Resources.ding, AudioPlayMode.Background)
        End If

    End Sub

    Private Sub formVolume_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.opening, AudioPlayMode.Background)
    End Sub

    Private Sub ControloDeDados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSideofCube.KeyPress, txtRadiusSphere.KeyPress,
txtRadiusRCCone.KeyPress,
        txtAlturaRCCone.KeyPress,
        txtLengthRPL.KeyPress,
        txtWidthRP.KeyPress,
        txtAlturaRP.KeyPress,
        txtRadiusRCC.KeyPress,
        txtAlturaRCC.KeyPress,
        txtLadoPiramede.KeyPress,
        txtAlturaRSP.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or ((e.KeyChar = ",") And (sender.Text.IndexOf(".") = -1 And sender.Text.IndexOf(",") = -1))) Then
                My.Computer.Audio.Play(My.Resources.doh, AudioPlayMode.Background)
                MessageBox.Show("Deverá só inserir números.", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub limparCampos()
        txtSideofCube.Text = "Tamanho Lado"
        txtRadiusSphere.Text = "Raio"
        txtAlturaRCCone.Text = "Altura"
        txtRadiusRCCone.Text = "Raio"
        txtAlturaRSP.Text = "Altura"
        txtLadoPiramede.Text = "Tamanho Lado"
        txtRadiusRCC.Text = "Raio"
        txtAlturaRCC.Text = "Altura"
        txtAlturaRP.Text = "Altura"
        txtLengthRPL.Text = "Tamanho Lado"
        txtWidthRP.Text = "Largura"
        limparCor()
        Label_Resultado.Text = ""
    End Sub

    Private Sub limparCor()
        txtSideofCube.BackColor = Color.White
        txtRadiusSphere.BackColor = Color.White
        txtAlturaRCCone.BackColor = Color.White
        txtRadiusRCCone.BackColor = Color.White
        txtAlturaRSP.BackColor = Color.White
        txtLadoPiramede.BackColor = Color.White
        txtRadiusRCC.BackColor = Color.White
        txtAlturaRCC.BackColor = Color.White
        txtAlturaRP.BackColor = Color.White
        txtLengthRPL.BackColor = Color.White
        txtWidthRP.BackColor = Color.White
    End Sub

    Private Sub TabControl_Calculos_TabIndexChanged(sender As Object, e As EventArgs) Handles TabControl_Calculos.TabIndexChanged
        limparCampos()
    End Sub

    Private Sub btnVolumeCalc_Click(sender As Object, e As EventArgs) Handles btnVolumeCalc.Click
        Label_Resultado.Text = ""
        limparCor()
        Select Case TabControl_Calculos.SelectedIndex
            Case 0 : VolumeCubo()
            Case 1 : VolumeEsfera()
            Case 2 : VolumeRCCone()
            Case 3 : VolumePiramedeQuadrada()
            Case 4 : VolumeCilindroCircular()
            Case 5 : VolumePrismaRetangular()
        End Select
    End Sub

    Private Sub TabControl_Calculos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl_Calculos.SelectedIndexChanged
        limparCampos()
    End Sub

    Private Sub txtSideofCube_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSideofCube.MouseClick
        txtSideofCube.BackColor = Color.White
        If txtSideofCube.Text = "Tamanho Lado" Or txtSideofCube.Text = "0" Then
            txtSideofCube.Clear()
        End If
    End Sub

    Private Sub txtRadiusSphere_MouseClick(sender As Object, e As MouseEventArgs) Handles txtRadiusSphere.MouseClick
        txtRadiusSphere.BackColor = Color.White
        If txtRadiusSphere.Text = "Raio" Or txtRadiusSphere.Text = "0" Then
            txtRadiusSphere.Clear()
        End If
    End Sub

    Private Sub txtAlturaRCCone_MouseClick(sender As Object, e As MouseEventArgs) Handles txtAlturaRCCone.MouseClick
        txtAlturaRCCone.BackColor = Color.White
        If txtAlturaRCCone.Text = "Altura" Or txtAlturaRCCone.Text = "0" Then
            txtAlturaRCCone.Clear()
        End If
    End Sub

    Private Sub txtRadiusRCCone_MouseClick(sender As Object, e As MouseEventArgs) Handles txtRadiusRCCone.MouseClick
        txtRadiusRCCone.BackColor = Color.White
        If txtRadiusRCCone.Text = "Raio" Or txtRadiusRCCone.Text = "0" Then
            txtRadiusRCCone.Clear()
        End If
    End Sub

    Private Sub txtAlturaRSP_MouseClick(sender As Object, e As MouseEventArgs) Handles txtAlturaRSP.MouseClick
        txtAlturaRSP.BackColor = Color.White
        If txtAlturaRSP.Text = "Altura" Or txtAlturaRSP.Text = "0" Then
            txtAlturaRSP.Clear()
        End If
    End Sub

    Private Sub txtLadoPiramede_MouseClick(sender As Object, e As MouseEventArgs) Handles txtLadoPiramede.MouseClick
        txtLadoPiramede.BackColor = Color.White
        If txtLadoPiramede.Text = "Tamanho Lado" Or txtLadoPiramede.Text = "0" Then
            txtLadoPiramede.Clear()
        End If
    End Sub

    Private Sub txtRadiusRCC_MouseClick(sender As Object, e As MouseEventArgs) Handles txtRadiusRCC.MouseClick
        txtRadiusRCC.BackColor = Color.White
        If txtRadiusRCC.Text = "Raio" Or txtRadiusRCC.Text = "0" Then
            txtRadiusRCC.Clear()
        End If
    End Sub

    Private Sub txtAlturaRCC_MouseClick(sender As Object, e As MouseEventArgs) Handles txtAlturaRCC.MouseClick
        txtAlturaRCC.BackColor = Color.White
        If txtAlturaRCC.Text = "Altura" Or txtAlturaRCC.Text = "0" Then
            txtAlturaRCC.Clear()
        End If
    End Sub

    Private Sub txtAlturaRP_MouseClick(sender As Object, e As MouseEventArgs) Handles txtAlturaRP.MouseClick
        txtAlturaRP.BackColor = Color.White
        If txtAlturaRP.Text = "Altura" Or txtAlturaRP.Text = "0" Then
            txtAlturaRP.Clear()
        End If
    End Sub



    Private Sub txtWidthRP_MouseClick(sender As Object, e As MouseEventArgs) Handles txtWidthRP.MouseClick
        txtWidthRP.BackColor = Color.White
        If txtWidthRP.Text = "Largura" Or txtWidthRP.Text = "0" Then
            txtWidthRP.Clear()
        End If
    End Sub

    Private Sub txtLengthRP_Click(sender As Object, e As EventArgs) Handles txtLengthRPL.Click
        txtLengthRPL.BackColor = Color.White
        If txtLengthRPL.Text = "Tamanho Lado" Or txtLengthRPL.Text = "0" Then
            txtLengthRPL.Clear()
        End If
    End Sub
End Class
