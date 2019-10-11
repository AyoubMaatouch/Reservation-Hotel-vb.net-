<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjouterRes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Button1 As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AjouterRes))
        Me.tele = New System.Windows.Forms.TextBox
        Me.email = New System.Windows.Forms.TextBox
        Me.cin = New System.Windows.Forms.TextBox
        Me.prenom = New System.Windows.Forms.TextBox
        Me.nom = New System.Windows.Forms.TextBox
        Me.NumClt = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.total = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.retour = New System.Windows.Forms.Button
        Me.prix = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.vip = New System.Windows.Forms.CheckBox
        Me.food = New System.Windows.Forms.CheckBox
        Me.trans = New System.Windows.Forms.CheckBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateRes = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.NumRes = New System.Windows.Forms.TextBox
        Me.annuler = New System.Windows.Forms.Button
        Me.ajouter = New System.Windows.Forms.Button
        Me.DateDeprt = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.jour = New System.Windows.Forms.TextBox
        Me.TTL = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.edtClt = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dlx = New System.Windows.Forms.RadioButton
        Me.dble = New System.Windows.Forms.RadioButton
        Me.sngl = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.dx = New System.Windows.Forms.PictureBox
        Me.sg = New System.Windows.Forms.PictureBox
        Me.db = New System.Windows.Forms.PictureBox
        Me.codeGen = New System.Windows.Forms.TextBox
        Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dx, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button1.ForeColor = System.Drawing.Color.DarkRed
        Button1.Location = New System.Drawing.Point(1024, 3)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(48, 25)
        Button1.TabIndex = 2
        Button1.Text = "X"
        Button1.UseVisualStyleBackColor = True
        AddHandler Button1.Click, AddressOf Me.Button1_Click
        '
        'tele
        '
        Me.tele.Location = New System.Drawing.Point(280, 357)
        Me.tele.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tele.Name = "tele"
        Me.tele.ReadOnly = True
        Me.tele.Size = New System.Drawing.Size(132, 23)
        Me.tele.TabIndex = 24
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(280, 283)
        Me.email.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        Me.email.Size = New System.Drawing.Size(132, 23)
        Me.email.TabIndex = 23
        '
        'cin
        '
        Me.cin.Location = New System.Drawing.Point(280, 208)
        Me.cin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cin.Name = "cin"
        Me.cin.ReadOnly = True
        Me.cin.Size = New System.Drawing.Size(132, 23)
        Me.cin.TabIndex = 22
        '
        'prenom
        '
        Me.prenom.Location = New System.Drawing.Point(280, 151)
        Me.prenom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prenom.Name = "prenom"
        Me.prenom.ReadOnly = True
        Me.prenom.Size = New System.Drawing.Size(132, 23)
        Me.prenom.TabIndex = 21
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(280, 102)
        Me.nom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nom.Name = "nom"
        Me.nom.ReadOnly = True
        Me.nom.Size = New System.Drawing.Size(132, 23)
        Me.nom.TabIndex = 20
        '
        'NumClt
        '
        Me.NumClt.Location = New System.Drawing.Point(280, 49)
        Me.NumClt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumClt.Name = "NumClt"
        Me.NumClt.ReadOnly = True
        Me.NumClt.Size = New System.Drawing.Size(132, 23)
        Me.NumClt.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 15)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Télé"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 283)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Email"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 15)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "CIN"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Prénom"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 15)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Nom"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 15)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Num Client"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(813, 554)
        Me.total.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Size = New System.Drawing.Size(132, 23)
        Me.total.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Forte", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(689, 554)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 14)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Total"
        '
        'retour
        '
        Me.retour.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.retour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.retour.Location = New System.Drawing.Point(936, 46)
        Me.retour.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.retour.Name = "retour"
        Me.retour.Size = New System.Drawing.Size(99, 23)
        Me.retour.TabIndex = 36
        Me.retour.Text = "Retour"
        Me.retour.UseVisualStyleBackColor = False
        '
        'prix
        '
        Me.prix.Location = New System.Drawing.Point(952, 346)
        Me.prix.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.prix.Name = "prix"
        Me.prix.ReadOnly = True
        Me.prix.Size = New System.Drawing.Size(83, 23)
        Me.prix.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(847, 351)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Prix Chamber"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.vip)
        Me.GroupBox1.Controls.Add(Me.food)
        Me.GroupBox1.Controls.Add(Me.trans)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Location = New System.Drawing.Point(657, 416)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(416, 68)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Services"
        '
        'vip
        '
        Me.vip.AutoSize = True
        Me.vip.Location = New System.Drawing.Point(315, 23)
        Me.vip.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.vip.Name = "vip"
        Me.vip.Size = New System.Drawing.Size(47, 20)
        Me.vip.TabIndex = 3
        Me.vip.Text = "VIP"
        Me.vip.UseVisualStyleBackColor = True
        '
        'food
        '
        Me.food.AutoSize = True
        Me.food.Location = New System.Drawing.Point(155, 23)
        Me.food.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.food.Name = "food"
        Me.food.Size = New System.Drawing.Size(63, 20)
        Me.food.TabIndex = 1
        Me.food.Text = "Buffet"
        Me.food.UseVisualStyleBackColor = True
        '
        'trans
        '
        Me.trans.AutoSize = True
        Me.trans.Location = New System.Drawing.Point(9, 23)
        Me.trans.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.trans.Name = "trans"
        Me.trans.Size = New System.Drawing.Size(87, 20)
        Me.trans.TabIndex = 0
        Me.trans.Text = "Transport"
        Me.trans.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(777, 345)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(60, 24)
        Me.ComboBox1.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(647, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Chamber Reservé"
        '
        'DateRes
        '
        Me.DateRes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateRes.Location = New System.Drawing.Point(807, 137)
        Me.DateRes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateRes.MinDate = New Date(2018, 4, 12, 0, 0, 0, 0)
        Me.DateRes.Name = "DateRes"
        Me.DateRes.Size = New System.Drawing.Size(130, 23)
        Me.DateRes.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(654, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Date Reservation"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(654, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Num Reservation"
        '
        'NumRes
        '
        Me.NumRes.Location = New System.Drawing.Point(807, 79)
        Me.NumRes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NumRes.Name = "NumRes"
        Me.NumRes.ReadOnly = True
        Me.NumRes.Size = New System.Drawing.Size(136, 23)
        Me.NumRes.TabIndex = 27
        '
        'annuler
        '
        Me.annuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.annuler.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.annuler.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.annuler.Location = New System.Drawing.Point(909, 596)
        Me.annuler.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.annuler.Name = "annuler"
        Me.annuler.Size = New System.Drawing.Size(99, 28)
        Me.annuler.TabIndex = 40
        Me.annuler.Text = "Annuler"
        Me.annuler.UseVisualStyleBackColor = False
        '
        'ajouter
        '
        Me.ajouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ajouter.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ajouter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ajouter.Location = New System.Drawing.Point(638, 596)
        Me.ajouter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ajouter.Name = "ajouter"
        Me.ajouter.Size = New System.Drawing.Size(99, 28)
        Me.ajouter.TabIndex = 39
        Me.ajouter.Text = "Ajouter"
        Me.ajouter.UseVisualStyleBackColor = False
        '
        'DateDeprt
        '
        Me.DateDeprt.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateDeprt.Location = New System.Drawing.Point(807, 178)
        Me.DateDeprt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateDeprt.MinDate = New Date(2018, 4, 12, 0, 0, 0, 0)
        Me.DateDeprt.Name = "DateDeprt"
        Me.DateDeprt.Size = New System.Drawing.Size(130, 23)
        Me.DateDeprt.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(654, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 16)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Date de départ"
        '
        'jour
        '
        Me.jour.Location = New System.Drawing.Point(976, 150)
        Me.jour.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.jour.Name = "jour"
        Me.jour.ReadOnly = True
        Me.jour.Size = New System.Drawing.Size(46, 23)
        Me.jour.TabIndex = 43
        '
        'TTL
        '
        Me.TTL.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.TTL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TTL.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TTL.Location = New System.Drawing.Point(813, 502)
        Me.TTL.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TTL.Name = "TTL"
        Me.TTL.Size = New System.Drawing.Size(99, 28)
        Me.TTL.TabIndex = 44
        Me.TTL.Text = "Total"
        Me.TTL.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(973, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "N°Jour"
        '
        'edtClt
        '
        Me.edtClt.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.edtClt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.edtClt.Font = New System.Drawing.Font("Forte", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtClt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.edtClt.Location = New System.Drawing.Point(200, 474)
        Me.edtClt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.edtClt.Name = "edtClt"
        Me.edtClt.Size = New System.Drawing.Size(99, 28)
        Me.edtClt.TabIndex = 48
        Me.edtClt.Text = "Edit"
        Me.edtClt.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dlx)
        Me.GroupBox2.Controls.Add(Me.dble)
        Me.GroupBox2.Controls.Add(Me.sngl)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox2.Location = New System.Drawing.Point(672, 256)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(369, 64)
        Me.GroupBox2.TabIndex = 49
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chamber Type:"
        '
        'dlx
        '
        Me.dlx.AutoSize = True
        Me.dlx.Location = New System.Drawing.Point(248, 23)
        Me.dlx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dlx.Name = "dlx"
        Me.dlx.Size = New System.Drawing.Size(70, 20)
        Me.dlx.TabIndex = 2
        Me.dlx.Text = "Deluxe"
        Me.dlx.UseVisualStyleBackColor = True
        '
        'dble
        '
        Me.dble.AutoSize = True
        Me.dble.Location = New System.Drawing.Point(127, 23)
        Me.dble.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dble.Name = "dble"
        Me.dble.Size = New System.Drawing.Size(72, 20)
        Me.dble.TabIndex = 1
        Me.dble.Text = "Double"
        Me.dble.UseVisualStyleBackColor = True
        '
        'sngl
        '
        Me.sngl.AutoSize = True
        Me.sngl.Checked = True
        Me.sngl.Location = New System.Drawing.Point(16, 23)
        Me.sngl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sngl.Name = "sngl"
        Me.sngl.Size = New System.Drawing.Size(66, 20)
        Me.sngl.TabIndex = 0
        Me.sngl.TabStop = True
        Me.sngl.Text = "Single"
        Me.sngl.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.NumClt)
        Me.GroupBox3.Controls.Add(Me.nom)
        Me.GroupBox3.Controls.Add(Me.prenom)
        Me.GroupBox3.Controls.Add(Me.cin)
        Me.GroupBox3.Controls.Add(Me.email)
        Me.GroupBox3.Controls.Add(Me.tele)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Italic)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(22, 46)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(456, 404)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Client Information"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Panel1.Controls.Add(Button1)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(1, -10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1104, 48)
        Me.Panel1.TabIndex = 51
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Italic)
        Me.Label16.Location = New System.Drawing.Point(474, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(203, 23)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Ajouter Reservation"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Italic)
        Me.Label15.Location = New System.Drawing.Point(474, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(203, 23)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Ajouter Reservation"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.0!, System.Drawing.FontStyle.Italic)
        Me.Label14.Location = New System.Drawing.Point(474, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(203, 23)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Ajouter Reservation"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dx)
        Me.GroupBox4.Controls.Add(Me.sg)
        Me.GroupBox4.Controls.Add(Me.db)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox4.Location = New System.Drawing.Point(12, 529)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(398, 170)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Chamber Type"
        '
        'dx
        '
        Me.dx.Image = CType(resources.GetObject("dx.Image"), System.Drawing.Image)
        Me.dx.Location = New System.Drawing.Point(10, 13)
        Me.dx.Name = "dx"
        Me.dx.Size = New System.Drawing.Size(382, 150)
        Me.dx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dx.TabIndex = 2
        Me.dx.TabStop = False
        '
        'sg
        '
        Me.sg.Image = CType(resources.GetObject("sg.Image"), System.Drawing.Image)
        Me.sg.Location = New System.Drawing.Point(21, 25)
        Me.sg.Name = "sg"
        Me.sg.Size = New System.Drawing.Size(361, 139)
        Me.sg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.sg.TabIndex = 1
        Me.sg.TabStop = False
        '
        'db
        '
        Me.db.Image = CType(resources.GetObject("db.Image"), System.Drawing.Image)
        Me.db.Location = New System.Drawing.Point(19, 23)
        Me.db.Name = "db"
        Me.db.Size = New System.Drawing.Size(363, 140)
        Me.db.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.db.TabIndex = 0
        Me.db.TabStop = False
        '
        'codeGen
        '
        Me.codeGen.Location = New System.Drawing.Point(812, 45)
        Me.codeGen.Name = "codeGen"
        Me.codeGen.Size = New System.Drawing.Size(100, 23)
        Me.codeGen.TabIndex = 53
        '
        'AjouterRes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1073, 711)
        Me.Controls.Add(Me.codeGen)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.edtClt)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.prix)
        Me.Controls.Add(Me.TTL)
        Me.Controls.Add(Me.jour)
        Me.Controls.Add(Me.DateDeprt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.annuler)
        Me.Controls.Add(Me.ajouter)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.retour)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateRes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NumRes)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AjouterRes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AjouterRes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dx, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tele As System.Windows.Forms.TextBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents cin As System.Windows.Forms.TextBox
    Friend WithEvents prenom As System.Windows.Forms.TextBox
    Friend WithEvents nom As System.Windows.Forms.TextBox
    Friend WithEvents NumClt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents retour As System.Windows.Forms.Button
    Friend WithEvents prix As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents vip As System.Windows.Forms.CheckBox
    Friend WithEvents food As System.Windows.Forms.CheckBox
    Friend WithEvents trans As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateRes As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NumRes As System.Windows.Forms.TextBox
    Friend WithEvents annuler As System.Windows.Forms.Button
    Friend WithEvents ajouter As System.Windows.Forms.Button
    Friend WithEvents DateDeprt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents jour As System.Windows.Forms.TextBox
    Friend WithEvents TTL As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents edtClt As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dlx As System.Windows.Forms.RadioButton
    Friend WithEvents dble As System.Windows.Forms.RadioButton
    Friend WithEvents sngl As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents db As System.Windows.Forms.PictureBox
    Friend WithEvents dx As System.Windows.Forms.PictureBox
    Friend WithEvents sg As System.Windows.Forms.PictureBox
    Friend WithEvents codeGen As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
