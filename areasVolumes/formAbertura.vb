Public Class formAbertura
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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuSair As System.Windows.Forms.MenuItem
    Friend WithEvents mnuArea As System.Windows.Forms.MenuItem
    Friend WithEvents mnuLSA As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.MenuItem
    Friend WithEvents mnuTSA As System.Windows.Forms.MenuItem
    Friend WithEvents mnuVolume As System.Windows.Forms.MenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents mnuCircle As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAbertura))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.mnuSair = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.mnuArea = New System.Windows.Forms.MenuItem()
        Me.mnuLSA = New System.Windows.Forms.MenuItem()
        Me.mnuTSA = New System.Windows.Forms.MenuItem()
        Me.mnuVolume = New System.Windows.Forms.MenuItem()
        Me.mnuCircle = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.mnuAbout = New System.Windows.Forms.MenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem3, Me.MenuItem4})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSair})
        Me.MenuItem1.Text = "&Arquivo"
        '
        'mnuSair
        '
        Me.mnuSair.Index = 0
        Me.mnuSair.Text = "Sair"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 1
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem6, Me.mnuVolume, Me.mnuCircle})
        Me.MenuItem3.Text = "Fórmulas"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 0
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuArea, Me.mnuLSA, Me.mnuTSA})
        Me.MenuItem6.Text = "Área"
        '
        'mnuArea
        '
        Me.mnuArea.Index = 0
        Me.mnuArea.Text = "Fórmulas"
        '
        'mnuLSA
        '
        Me.mnuLSA.Index = 1
        Me.mnuLSA.Text = "Superfície Lateral"
        '
        'mnuTSA
        '
        Me.mnuTSA.Index = 2
        Me.mnuTSA.Text = "Superfície Total"
        '
        'mnuVolume
        '
        Me.mnuVolume.Index = 1
        Me.mnuVolume.Text = "Volume"
        '
        'mnuCircle
        '
        Me.mnuCircle.Index = 2
        Me.mnuCircle.Text = "Fórmulas - Círculo"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 2
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAbout})
        Me.MenuItem4.Text = "Ajuda"
        '
        'mnuAbout
        '
        Me.mnuAbout.Index = 0
        Me.mnuAbout.Text = "Sobre Fórmulas Geométricas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(50, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(381, 296)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(227, 107)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(82, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 152)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cálculo de Área, Volume, círculo, superfície lateral, e total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Amateur", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 406)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(657, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Desenvolvido por: Sérgio M Duarte da Silva"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'formAbertura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(669, 448)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "formAbertura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fórmulas Geométricas"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub mnuVolume_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuVolume.Click
        Dim myVolume As New formVolume()
        myVolume.TopMost = True
        myVolume.ShowDialog()

    End Sub

    Private Sub mnuArea_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuArea.Click
        Dim myArea As New formArea()
        myArea.TopMost = True
        myArea.ShowDialog()
    End Sub

    Private Sub mnuCircle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuCircle.Click
        Dim myCircle As New formCirculo()
        myCircle.TopMost = True
        myCircle.ShowDialog()
    End Sub

    Private Sub mnuLSA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuLSA.Click
        Dim myLSA As New formLateralSurfaceArea()
        myLSA.TopMost = True
        myLSA.ShowDialog()
    End Sub

    Private Sub mnuTSA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuTSA.Click
        Dim myTSA As New formTotalSurfaceArea()
        myTSA.TopMost = True
        myTSA.ShowDialog()
    End Sub

    Private Sub mnuSair_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSair.Click
        End
    End Sub

    Private Sub mnuAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuAbout.Click
        My.Computer.Audio.Play(My.Resources._exit, AudioPlayMode.Background)
        Dim myAbout As New formAbout()
        myAbout.TopMost = True
        myAbout.ShowDialog()
    End Sub

    Private Sub formAbertura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.opening, AudioPlayMode.Background)
    End Sub


End Class
