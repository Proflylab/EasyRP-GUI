<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class main
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.BtnOpenMyApps = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Divider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.LblClientId = New MaterialSkin.Controls.MaterialLabel()
        Me.TabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.IdentifiersTab = New System.Windows.Forms.TabPage()
        Me.ReqClientId = New System.Windows.Forms.Label()
        Me.TxtClientId = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.StateTab = New System.Windows.Forms.TabPage()
        Me.ReqDetails = New System.Windows.Forms.Label()
        Me.ReqState = New System.Windows.Forms.Label()
        Me.TxtDetails = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.LblDetails = New MaterialSkin.Controls.MaterialLabel()
        Me.TxtState = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.LblState = New MaterialSkin.Controls.MaterialLabel()
        Me.ImagesTab = New System.Windows.Forms.TabPage()
        Me.Divider2 = New MaterialSkin.Controls.MaterialDivider()
        Me.AssetsInfo = New MaterialSkin.Controls.MaterialLabel()
        Me.AssetsTabSelector = New MaterialSkin.Controls.MaterialTabSelector()
        Me.AssetsTabControl = New MaterialSkin.Controls.MaterialTabControl()
        Me.LargeImageTab = New System.Windows.Forms.TabPage()
        Me.ReqLargeAssetName = New System.Windows.Forms.Label()
        Me.LblLargeAssetName = New MaterialSkin.Controls.MaterialLabel()
        Me.TxtLargeAssetTooltip = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TxtLargeAssetName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.LblLargeAssetTooltip = New MaterialSkin.Controls.MaterialLabel()
        Me.SmallImageTab = New System.Windows.Forms.TabPage()
        Me.LblSmallAssetName = New MaterialSkin.Controls.MaterialLabel()
        Me.TxtSmallAssetTooltip = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TxtSmallAssetName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.LblSmallAssetTooltip = New MaterialSkin.Controls.MaterialLabel()
        Me.TabSelector = New MaterialSkin.Controls.MaterialTabSelector()
        Me.BtnUpdateConfig = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.BtnGithub = New MaterialSkin.Controls.MaterialFlatButton()
        Me.BtnLog = New MaterialSkin.Controls.MaterialFlatButton()
        Me.LblRequired = New MaterialSkin.Controls.MaterialLabel()
        Me.LblRequiredStar = New System.Windows.Forms.Label()
        Me.LblNote = New MaterialSkin.Controls.MaterialLabel()
        Me.ChxHideInTray = New MaterialSkin.Controls.MaterialCheckBox()
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BtnRestart = New MaterialSkin.Controls.MaterialFlatButton()
        Me.TabControl.SuspendLayout()
        Me.IdentifiersTab.SuspendLayout()
        Me.StateTab.SuspendLayout()
        Me.ImagesTab.SuspendLayout()
        Me.AssetsTabControl.SuspendLayout()
        Me.LargeImageTab.SuspendLayout()
        Me.SmallImageTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnOpenMyApps
        '
        Me.BtnOpenMyApps.Depth = 0
        Me.BtnOpenMyApps.Location = New System.Drawing.Point(12, 78)
        Me.BtnOpenMyApps.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnOpenMyApps.Name = "BtnOpenMyApps"
        Me.BtnOpenMyApps.Primary = True
        Me.BtnOpenMyApps.Size = New System.Drawing.Size(178, 38)
        Me.BtnOpenMyApps.TabIndex = 0
        Me.BtnOpenMyApps.Text = "Open my apps"
        Me.BtnOpenMyApps.UseVisualStyleBackColor = True
        '
        'Divider1
        '
        Me.Divider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Divider1.Depth = 0
        Me.Divider1.Location = New System.Drawing.Point(12, 131)
        Me.Divider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Divider1.Name = "Divider1"
        Me.Divider1.Size = New System.Drawing.Size(368, 1)
        Me.Divider1.TabIndex = 1
        Me.Divider1.Text = "MaterialDivider1"
        '
        'LblClientId
        '
        Me.LblClientId.AutoSize = True
        Me.LblClientId.Depth = 0
        Me.LblClientId.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.LblClientId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblClientId.Location = New System.Drawing.Point(13, 17)
        Me.LblClientId.MouseState = MaterialSkin.MouseState.HOVER
        Me.LblClientId.Name = "LblClientId"
        Me.LblClientId.Size = New System.Drawing.Size(78, 19)
        Me.LblClientId.TabIndex = 2
        Me.LblClientId.Text = "CLIENT ID"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.IdentifiersTab)
        Me.TabControl.Controls.Add(Me.StateTab)
        Me.TabControl.Controls.Add(Me.ImagesTab)
        Me.TabControl.Depth = 0
        Me.TabControl.Location = New System.Drawing.Point(12, 274)
        Me.TabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(382, 294)
        Me.TabControl.TabIndex = 5
        '
        'IdentifiersTab
        '
        Me.IdentifiersTab.BackColor = System.Drawing.Color.White
        Me.IdentifiersTab.Controls.Add(Me.ReqClientId)
        Me.IdentifiersTab.Controls.Add(Me.LblClientId)
        Me.IdentifiersTab.Controls.Add(Me.TxtClientId)
        Me.IdentifiersTab.Location = New System.Drawing.Point(4, 22)
        Me.IdentifiersTab.Name = "IdentifiersTab"
        Me.IdentifiersTab.Padding = New System.Windows.Forms.Padding(3)
        Me.IdentifiersTab.Size = New System.Drawing.Size(374, 268)
        Me.IdentifiersTab.TabIndex = 0
        Me.IdentifiersTab.Text = "IDENTIFIERS"
        '
        'ReqClientId
        '
        Me.ReqClientId.AutoSize = True
        Me.ReqClientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReqClientId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReqClientId.Location = New System.Drawing.Point(87, 17)
        Me.ReqClientId.Name = "ReqClientId"
        Me.ReqClientId.Size = New System.Drawing.Size(17, 24)
        Me.ReqClientId.TabIndex = 14
        Me.ReqClientId.Text = "*"
        '
        'TxtClientId
        '
        Me.TxtClientId.BackColor = System.Drawing.Color.White
        Me.TxtClientId.Depth = 0
        Me.TxtClientId.Hint = "123456789012345678"
        Me.TxtClientId.Location = New System.Drawing.Point(17, 39)
        Me.TxtClientId.MouseState = MaterialSkin.MouseState.HOVER
        Me.TxtClientId.Name = "TxtClientId"
        Me.TxtClientId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtClientId.SelectedText = ""
        Me.TxtClientId.SelectionLength = 0
        Me.TxtClientId.SelectionStart = 0
        Me.TxtClientId.Size = New System.Drawing.Size(275, 23)
        Me.TxtClientId.TabIndex = 3
        Me.TxtClientId.UseSystemPasswordChar = False
        '
        'StateTab
        '
        Me.StateTab.BackColor = System.Drawing.Color.White
        Me.StateTab.Controls.Add(Me.ReqDetails)
        Me.StateTab.Controls.Add(Me.ReqState)
        Me.StateTab.Controls.Add(Me.TxtDetails)
        Me.StateTab.Controls.Add(Me.LblDetails)
        Me.StateTab.Controls.Add(Me.TxtState)
        Me.StateTab.Controls.Add(Me.LblState)
        Me.StateTab.Location = New System.Drawing.Point(4, 22)
        Me.StateTab.Name = "StateTab"
        Me.StateTab.Padding = New System.Windows.Forms.Padding(3)
        Me.StateTab.Size = New System.Drawing.Size(374, 268)
        Me.StateTab.TabIndex = 1
        Me.StateTab.Text = "STATE"
        '
        'ReqDetails
        '
        Me.ReqDetails.AutoSize = True
        Me.ReqDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReqDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReqDetails.Location = New System.Drawing.Point(77, 79)
        Me.ReqDetails.Name = "ReqDetails"
        Me.ReqDetails.Size = New System.Drawing.Size(17, 24)
        Me.ReqDetails.TabIndex = 15
        Me.ReqDetails.Text = "*"
        '
        'ReqState
        '
        Me.ReqState.AutoSize = True
        Me.ReqState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReqState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReqState.Location = New System.Drawing.Point(64, 17)
        Me.ReqState.Name = "ReqState"
        Me.ReqState.Size = New System.Drawing.Size(17, 24)
        Me.ReqState.TabIndex = 14
        Me.ReqState.Text = "*"
        '
        'TxtDetails
        '
        Me.TxtDetails.BackColor = System.Drawing.Color.White
        Me.TxtDetails.Depth = 0
        Me.TxtDetails.Hint = "for 18 minutes"
        Me.TxtDetails.Location = New System.Drawing.Point(17, 101)
        Me.TxtDetails.MouseState = MaterialSkin.MouseState.HOVER
        Me.TxtDetails.Name = "TxtDetails"
        Me.TxtDetails.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtDetails.SelectedText = ""
        Me.TxtDetails.SelectionLength = 0
        Me.TxtDetails.SelectionStart = 0
        Me.TxtDetails.Size = New System.Drawing.Size(275, 23)
        Me.TxtDetails.TabIndex = 9
        Me.TxtDetails.UseSystemPasswordChar = False
        '
        'LblDetails
        '
        Me.LblDetails.AutoSize = True
        Me.LblDetails.Depth = 0
        Me.LblDetails.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.LblDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblDetails.Location = New System.Drawing.Point(13, 79)
        Me.LblDetails.MouseState = MaterialSkin.MouseState.HOVER
        Me.LblDetails.Name = "LblDetails"
        Me.LblDetails.Size = New System.Drawing.Size(68, 19)
        Me.LblDetails.TabIndex = 8
        Me.LblDetails.Text = "DETAILS"
        '
        'TxtState
        '
        Me.TxtState.BackColor = System.Drawing.Color.White
        Me.TxtState.Depth = 0
        Me.TxtState.Hint = "Playing level 13"
        Me.TxtState.Location = New System.Drawing.Point(17, 39)
        Me.TxtState.MouseState = MaterialSkin.MouseState.HOVER
        Me.TxtState.Name = "TxtState"
        Me.TxtState.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtState.SelectedText = ""
        Me.TxtState.SelectionLength = 0
        Me.TxtState.SelectionStart = 0
        Me.TxtState.Size = New System.Drawing.Size(275, 23)
        Me.TxtState.TabIndex = 7
        Me.TxtState.UseSystemPasswordChar = False
        '
        'LblState
        '
        Me.LblState.AutoSize = True
        Me.LblState.Depth = 0
        Me.LblState.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.LblState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblState.Location = New System.Drawing.Point(13, 17)
        Me.LblState.MouseState = MaterialSkin.MouseState.HOVER
        Me.LblState.Name = "LblState"
        Me.LblState.Size = New System.Drawing.Size(55, 19)
        Me.LblState.TabIndex = 3
        Me.LblState.Text = "STATE"
        '
        'ImagesTab
        '
        Me.ImagesTab.BackColor = System.Drawing.Color.White
        Me.ImagesTab.Controls.Add(Me.Divider2)
        Me.ImagesTab.Controls.Add(Me.AssetsInfo)
        Me.ImagesTab.Controls.Add(Me.AssetsTabSelector)
        Me.ImagesTab.Controls.Add(Me.AssetsTabControl)
        Me.ImagesTab.Location = New System.Drawing.Point(4, 22)
        Me.ImagesTab.Name = "ImagesTab"
        Me.ImagesTab.Size = New System.Drawing.Size(374, 268)
        Me.ImagesTab.TabIndex = 2
        Me.ImagesTab.Text = "IMAGES"
        '
        'Divider2
        '
        Me.Divider2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Divider2.Depth = 0
        Me.Divider2.Location = New System.Drawing.Point(17, 98)
        Me.Divider2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Divider2.Name = "Divider2"
        Me.Divider2.Size = New System.Drawing.Size(337, 1)
        Me.Divider2.TabIndex = 14
        Me.Divider2.Text = "MaterialDivider2"
        '
        'AssetsInfo
        '
        Me.AssetsInfo.Depth = 0
        Me.AssetsInfo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.AssetsInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AssetsInfo.Location = New System.Drawing.Point(13, 43)
        Me.AssetsInfo.MouseState = MaterialSkin.MouseState.HOVER
        Me.AssetsInfo.Name = "AssetsInfo"
        Me.AssetsInfo.Size = New System.Drawing.Size(354, 51)
        Me.AssetsInfo.TabIndex = 9
        Me.AssetsInfo.Text = "Upload asset images in your app on Discord Developers"
        '
        'AssetsTabSelector
        '
        Me.AssetsTabSelector.BaseTabControl = Me.AssetsTabControl
        Me.AssetsTabSelector.Depth = 0
        Me.AssetsTabSelector.Location = New System.Drawing.Point(-4, 3)
        Me.AssetsTabSelector.MouseState = MaterialSkin.MouseState.HOVER
        Me.AssetsTabSelector.Name = "AssetsTabSelector"
        Me.AssetsTabSelector.Size = New System.Drawing.Size(372, 23)
        Me.AssetsTabSelector.TabIndex = 13
        Me.AssetsTabSelector.Text = "MaterialTabSelector2"
        '
        'AssetsTabControl
        '
        Me.AssetsTabControl.Controls.Add(Me.LargeImageTab)
        Me.AssetsTabControl.Controls.Add(Me.SmallImageTab)
        Me.AssetsTabControl.Depth = 0
        Me.AssetsTabControl.Location = New System.Drawing.Point(3, 104)
        Me.AssetsTabControl.MouseState = MaterialSkin.MouseState.HOVER
        Me.AssetsTabControl.Name = "AssetsTabControl"
        Me.AssetsTabControl.SelectedIndex = 0
        Me.AssetsTabControl.Size = New System.Drawing.Size(354, 162)
        Me.AssetsTabControl.TabIndex = 12
        '
        'LargeImageTab
        '
        Me.LargeImageTab.BackColor = System.Drawing.Color.White
        Me.LargeImageTab.Controls.Add(Me.ReqLargeAssetName)
        Me.LargeImageTab.Controls.Add(Me.LblLargeAssetName)
        Me.LargeImageTab.Controls.Add(Me.TxtLargeAssetTooltip)
        Me.LargeImageTab.Controls.Add(Me.TxtLargeAssetName)
        Me.LargeImageTab.Controls.Add(Me.LblLargeAssetTooltip)
        Me.LargeImageTab.Location = New System.Drawing.Point(4, 22)
        Me.LargeImageTab.Name = "LargeImageTab"
        Me.LargeImageTab.Padding = New System.Windows.Forms.Padding(3)
        Me.LargeImageTab.Size = New System.Drawing.Size(346, 136)
        Me.LargeImageTab.TabIndex = 0
        Me.LargeImageTab.Text = "LARGE IMAGE"
        '
        'ReqLargeAssetName
        '
        Me.ReqLargeAssetName.AutoSize = True
        Me.ReqLargeAssetName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReqLargeAssetName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ReqLargeAssetName.Location = New System.Drawing.Point(108, 16)
        Me.ReqLargeAssetName.Name = "ReqLargeAssetName"
        Me.ReqLargeAssetName.Size = New System.Drawing.Size(17, 24)
        Me.ReqLargeAssetName.TabIndex = 14
        Me.ReqLargeAssetName.Text = "*"
        '
        'LblLargeAssetName
        '
        Me.LblLargeAssetName.AutoSize = True
        Me.LblLargeAssetName.Depth = 0
        Me.LblLargeAssetName.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.LblLargeAssetName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblLargeAssetName.Location = New System.Drawing.Point(10, 16)
        Me.LblLargeAssetName.MouseState = MaterialSkin.MouseState.HOVER
        Me.LblLargeAssetName.Name = "LblLargeAssetName"
        Me.LblLargeAssetName.Size = New System.Drawing.Size(102, 19)
        Me.LblLargeAssetName.TabIndex = 8
        Me.LblLargeAssetName.Text = "ASSET NAME"
        '
        'TxtLargeAssetTooltip
        '
        Me.TxtLargeAssetTooltip.BackColor = System.Drawing.Color.White
        Me.TxtLargeAssetTooltip.Depth = 0
        Me.TxtLargeAssetTooltip.Hint = ""
        Me.TxtLargeAssetTooltip.Location = New System.Drawing.Point(14, 101)
        Me.TxtLargeAssetTooltip.MouseState = MaterialSkin.MouseState.HOVER
        Me.TxtLargeAssetTooltip.Name = "TxtLargeAssetTooltip"
        Me.TxtLargeAssetTooltip.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtLargeAssetTooltip.SelectedText = ""
        Me.TxtLargeAssetTooltip.SelectionLength = 0
        Me.TxtLargeAssetTooltip.SelectionStart = 0
        Me.TxtLargeAssetTooltip.Size = New System.Drawing.Size(275, 23)
        Me.TxtLargeAssetTooltip.TabIndex = 11
        Me.TxtLargeAssetTooltip.UseSystemPasswordChar = False
        '
        'TxtLargeAssetName
        '
        Me.TxtLargeAssetName.BackColor = System.Drawing.Color.White
        Me.TxtLargeAssetName.Depth = 0
        Me.TxtLargeAssetName.Hint = ""
        Me.TxtLargeAssetName.Location = New System.Drawing.Point(14, 38)
        Me.TxtLargeAssetName.MouseState = MaterialSkin.MouseState.HOVER
        Me.TxtLargeAssetName.Name = "TxtLargeAssetName"
        Me.TxtLargeAssetName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtLargeAssetName.SelectedText = ""
        Me.TxtLargeAssetName.SelectionLength = 0
        Me.TxtLargeAssetName.SelectionStart = 0
        Me.TxtLargeAssetName.Size = New System.Drawing.Size(275, 23)
        Me.TxtLargeAssetName.TabIndex = 9
        Me.TxtLargeAssetName.UseSystemPasswordChar = False
        '
        'LblLargeAssetTooltip
        '
        Me.LblLargeAssetTooltip.AutoSize = True
        Me.LblLargeAssetTooltip.Depth = 0
        Me.LblLargeAssetTooltip.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.LblLargeAssetTooltip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblLargeAssetTooltip.Location = New System.Drawing.Point(10, 79)
        Me.LblLargeAssetTooltip.MouseState = MaterialSkin.MouseState.HOVER
        Me.LblLargeAssetTooltip.Name = "LblLargeAssetTooltip"
        Me.LblLargeAssetTooltip.Size = New System.Drawing.Size(68, 19)
        Me.LblLargeAssetTooltip.TabIndex = 10
        Me.LblLargeAssetTooltip.Text = "TOOLTIP"
        '
        'SmallImageTab
        '
        Me.SmallImageTab.BackColor = System.Drawing.Color.White
        Me.SmallImageTab.Controls.Add(Me.LblSmallAssetName)
        Me.SmallImageTab.Controls.Add(Me.TxtSmallAssetTooltip)
        Me.SmallImageTab.Controls.Add(Me.TxtSmallAssetName)
        Me.SmallImageTab.Controls.Add(Me.LblSmallAssetTooltip)
        Me.SmallImageTab.Location = New System.Drawing.Point(4, 22)
        Me.SmallImageTab.Name = "SmallImageTab"
        Me.SmallImageTab.Padding = New System.Windows.Forms.Padding(3)
        Me.SmallImageTab.Size = New System.Drawing.Size(346, 136)
        Me.SmallImageTab.TabIndex = 1
        Me.SmallImageTab.Text = "SMALL IMAGE"
        '
        'LblSmallAssetName
        '
        Me.LblSmallAssetName.AutoSize = True
        Me.LblSmallAssetName.Depth = 0
        Me.LblSmallAssetName.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.LblSmallAssetName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblSmallAssetName.Location = New System.Drawing.Point(10, 16)
        Me.LblSmallAssetName.MouseState = MaterialSkin.MouseState.HOVER
        Me.LblSmallAssetName.Name = "LblSmallAssetName"
        Me.LblSmallAssetName.Size = New System.Drawing.Size(102, 19)
        Me.LblSmallAssetName.TabIndex = 12
        Me.LblSmallAssetName.Text = "ASSET NAME"
        '
        'TxtSmallAssetTooltip
        '
        Me.TxtSmallAssetTooltip.BackColor = System.Drawing.Color.White
        Me.TxtSmallAssetTooltip.Depth = 0
        Me.TxtSmallAssetTooltip.Hint = ""
        Me.TxtSmallAssetTooltip.Location = New System.Drawing.Point(14, 101)
        Me.TxtSmallAssetTooltip.MouseState = MaterialSkin.MouseState.HOVER
        Me.TxtSmallAssetTooltip.Name = "TxtSmallAssetTooltip"
        Me.TxtSmallAssetTooltip.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSmallAssetTooltip.SelectedText = ""
        Me.TxtSmallAssetTooltip.SelectionLength = 0
        Me.TxtSmallAssetTooltip.SelectionStart = 0
        Me.TxtSmallAssetTooltip.Size = New System.Drawing.Size(275, 23)
        Me.TxtSmallAssetTooltip.TabIndex = 15
        Me.TxtSmallAssetTooltip.UseSystemPasswordChar = False
        '
        'TxtSmallAssetName
        '
        Me.TxtSmallAssetName.BackColor = System.Drawing.Color.White
        Me.TxtSmallAssetName.Depth = 0
        Me.TxtSmallAssetName.Hint = ""
        Me.TxtSmallAssetName.Location = New System.Drawing.Point(14, 38)
        Me.TxtSmallAssetName.MouseState = MaterialSkin.MouseState.HOVER
        Me.TxtSmallAssetName.Name = "TxtSmallAssetName"
        Me.TxtSmallAssetName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtSmallAssetName.SelectedText = ""
        Me.TxtSmallAssetName.SelectionLength = 0
        Me.TxtSmallAssetName.SelectionStart = 0
        Me.TxtSmallAssetName.Size = New System.Drawing.Size(275, 23)
        Me.TxtSmallAssetName.TabIndex = 13
        Me.TxtSmallAssetName.UseSystemPasswordChar = False
        '
        'LblSmallAssetTooltip
        '
        Me.LblSmallAssetTooltip.AutoSize = True
        Me.LblSmallAssetTooltip.Depth = 0
        Me.LblSmallAssetTooltip.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.LblSmallAssetTooltip.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblSmallAssetTooltip.Location = New System.Drawing.Point(10, 79)
        Me.LblSmallAssetTooltip.MouseState = MaterialSkin.MouseState.HOVER
        Me.LblSmallAssetTooltip.Name = "LblSmallAssetTooltip"
        Me.LblSmallAssetTooltip.Size = New System.Drawing.Size(68, 19)
        Me.LblSmallAssetTooltip.TabIndex = 14
        Me.LblSmallAssetTooltip.Text = "TOOLTIP"
        '
        'TabSelector
        '
        Me.TabSelector.BaseTabControl = Me.TabControl
        Me.TabSelector.Depth = 0
        Me.TabSelector.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TabSelector.Location = New System.Drawing.Point(12, 254)
        Me.TabSelector.MouseState = MaterialSkin.MouseState.HOVER
        Me.TabSelector.Name = "TabSelector"
        Me.TabSelector.Size = New System.Drawing.Size(368, 23)
        Me.TabSelector.TabIndex = 6
        Me.TabSelector.Text = "MaterialTabSelector1"
        '
        'BtnUpdateConfig
        '
        Me.BtnUpdateConfig.Depth = 0
        Me.BtnUpdateConfig.Location = New System.Drawing.Point(202, 78)
        Me.BtnUpdateConfig.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnUpdateConfig.Name = "BtnUpdateConfig"
        Me.BtnUpdateConfig.Primary = True
        Me.BtnUpdateConfig.Size = New System.Drawing.Size(178, 38)
        Me.BtnUpdateConfig.TabIndex = 7
        Me.BtnUpdateConfig.Text = "UPDATE CONFIGURATION"
        Me.BtnUpdateConfig.UseVisualStyleBackColor = True
        '
        'BtnGithub
        '
        Me.BtnGithub.AutoSize = True
        Me.BtnGithub.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnGithub.Depth = 0
        Me.BtnGithub.Location = New System.Drawing.Point(319, 33)
        Me.BtnGithub.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnGithub.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnGithub.Name = "BtnGithub"
        Me.BtnGithub.Primary = False
        Me.BtnGithub.Size = New System.Drawing.Size(61, 36)
        Me.BtnGithub.TabIndex = 8
        Me.BtnGithub.Text = "GITHUB"
        Me.BtnGithub.UseVisualStyleBackColor = True
        '
        'BtnLog
        '
        Me.BtnLog.AutoSize = True
        Me.BtnLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnLog.Depth = 0
        Me.BtnLog.Location = New System.Drawing.Point(273, 33)
        Me.BtnLog.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnLog.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnLog.Name = "BtnLog"
        Me.BtnLog.Primary = False
        Me.BtnLog.Size = New System.Drawing.Size(38, 36)
        Me.BtnLog.TabIndex = 9
        Me.BtnLog.Text = "LOG"
        Me.BtnLog.UseVisualStyleBackColor = True
        '
        'LblRequired
        '
        Me.LblRequired.AutoSize = True
        Me.LblRequired.Depth = 0
        Me.LblRequired.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.LblRequired.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblRequired.Location = New System.Drawing.Point(29, 217)
        Me.LblRequired.MouseState = MaterialSkin.MouseState.HOVER
        Me.LblRequired.Name = "LblRequired"
        Me.LblRequired.Size = New System.Drawing.Size(68, 19)
        Me.LblRequired.TabIndex = 12
        Me.LblRequired.Text = "Required"
        '
        'LblRequiredStar
        '
        Me.LblRequiredStar.AutoSize = True
        Me.LblRequiredStar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRequiredStar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblRequiredStar.Location = New System.Drawing.Point(12, 217)
        Me.LblRequiredStar.Name = "LblRequiredStar"
        Me.LblRequiredStar.Size = New System.Drawing.Size(17, 24)
        Me.LblRequiredStar.TabIndex = 13
        Me.LblRequiredStar.Text = "*"
        '
        'LblNote
        '
        Me.LblNote.AutoSize = True
        Me.LblNote.Depth = 0
        Me.LblNote.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.LblNote.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblNote.Location = New System.Drawing.Point(9, 142)
        Me.LblNote.MouseState = MaterialSkin.MouseState.HOVER
        Me.LblNote.Name = "LblNote"
        Me.LblNote.Size = New System.Drawing.Size(322, 19)
        Me.LblNote.TabIndex = 14
        Me.LblNote.Text = "Select EasyRP.exe as game in Discord, not GUI"
        '
        'ChxHideInTray
        '
        Me.ChxHideInTray.AutoSize = True
        Me.ChxHideInTray.Checked = True
        Me.ChxHideInTray.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChxHideInTray.Depth = 0
        Me.ChxHideInTray.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.ChxHideInTray.Location = New System.Drawing.Point(8, 175)
        Me.ChxHideInTray.Margin = New System.Windows.Forms.Padding(0)
        Me.ChxHideInTray.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.ChxHideInTray.MouseState = MaterialSkin.MouseState.HOVER
        Me.ChxHideInTray.Name = "ChxHideInTray"
        Me.ChxHideInTray.Ripple = True
        Me.ChxHideInTray.Size = New System.Drawing.Size(178, 30)
        Me.ChxHideInTray.TabIndex = 15
        Me.ChxHideInTray.Text = "Hide in tray on minimize"
        Me.ChxHideInTray.UseVisualStyleBackColor = True
        '
        'NotifyIcon
        '
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "EasyRP GUI"
        '
        'BtnRestart
        '
        Me.BtnRestart.AutoSize = True
        Me.BtnRestart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnRestart.Depth = 0
        Me.BtnRestart.Location = New System.Drawing.Point(194, 33)
        Me.BtnRestart.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnRestart.MouseState = MaterialSkin.MouseState.HOVER
        Me.BtnRestart.Name = "BtnRestart"
        Me.BtnRestart.Primary = False
        Me.BtnRestart.Size = New System.Drawing.Size(71, 36)
        Me.BtnRestart.TabIndex = 16
        Me.BtnRestart.Text = "RESTART"
        Me.BtnRestart.UseVisualStyleBackColor = True
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 582)
        Me.Controls.Add(Me.BtnRestart)
        Me.Controls.Add(Me.ChxHideInTray)
        Me.Controls.Add(Me.LblNote)
        Me.Controls.Add(Me.LblRequiredStar)
        Me.Controls.Add(Me.LblRequired)
        Me.Controls.Add(Me.BtnLog)
        Me.Controls.Add(Me.BtnGithub)
        Me.Controls.Add(Me.BtnUpdateConfig)
        Me.Controls.Add(Me.TabSelector)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Divider1)
        Me.Controls.Add(Me.BtnOpenMyApps)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(392, 503)
        Me.Name = "main"
        Me.Sizable = False
        Me.Text = "EasyRP GUI"
        Me.TabControl.ResumeLayout(False)
        Me.IdentifiersTab.ResumeLayout(False)
        Me.IdentifiersTab.PerformLayout()
        Me.StateTab.ResumeLayout(False)
        Me.StateTab.PerformLayout()
        Me.ImagesTab.ResumeLayout(False)
        Me.AssetsTabControl.ResumeLayout(False)
        Me.LargeImageTab.ResumeLayout(False)
        Me.LargeImageTab.PerformLayout()
        Me.SmallImageTab.ResumeLayout(False)
        Me.SmallImageTab.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnOpenMyApps As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents Divider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents LblClientId As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents IdentifiersTab As TabPage
    Friend WithEvents StateTab As TabPage
    Friend WithEvents TabSelector As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents ImagesTab As TabPage
    Friend WithEvents TxtDetails As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents LblDetails As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxtState As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents LblState As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents AssetsTabSelector As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents AssetsTabControl As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents LargeImageTab As TabPage
    Friend WithEvents LblLargeAssetName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxtLargeAssetTooltip As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TxtLargeAssetName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents LblLargeAssetTooltip As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents SmallImageTab As TabPage
    Friend WithEvents AssetsInfo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LblSmallAssetName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxtSmallAssetTooltip As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TxtSmallAssetName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents LblSmallAssetTooltip As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Divider2 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents BtnUpdateConfig As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents BtnGithub As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents BtnLog As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents LblRequired As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LblRequiredStar As Label
    Friend WithEvents ReqDetails As Label
    Friend WithEvents ReqState As Label
    Friend WithEvents ReqLargeAssetName As Label
    Friend WithEvents ReqClientId As Label
    Friend WithEvents LblNote As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TxtClientId As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ChxHideInTray As MaterialSkin.Controls.MaterialCheckBox
    Private WithEvents NotifyIcon As NotifyIcon
    Friend WithEvents BtnRestart As MaterialSkin.Controls.MaterialFlatButton
End Class
