﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GixxerAdvSettings
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.G_misc = New System.Windows.Forms.GroupBox()
        Me.C_HOX = New System.Windows.Forms.CheckBox()
        Me.C_EXC = New System.Windows.Forms.CheckBox()
        Me.C_PAIR = New System.Windows.Forms.CheckBox()
        Me.C_FAN = New System.Windows.Forms.CheckBox()
        Me.C_coil_fi_disable = New System.Windows.Forms.CheckBox()
        Me.C_msmode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.G_misc.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(258, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "STP map"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "View and edit STP map"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(291, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 88)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Misc maps"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(258, 46)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Inj balance"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "View and edit injector balance map"
        '
        'G_misc
        '
        Me.G_misc.Controls.Add(Me.C_HOX)
        Me.G_misc.Controls.Add(Me.C_EXC)
        Me.G_misc.Controls.Add(Me.C_PAIR)
        Me.G_misc.Controls.Add(Me.C_FAN)
        Me.G_misc.Controls.Add(Me.C_coil_fi_disable)
        Me.G_misc.Controls.Add(Me.C_msmode)
        Me.G_misc.Controls.Add(Me.Label2)
        Me.G_misc.Location = New System.Drawing.Point(12, 106)
        Me.G_misc.Name = "G_misc"
        Me.G_misc.Size = New System.Drawing.Size(354, 123)
        Me.G_misc.TabIndex = 11
        Me.G_misc.TabStop = False
        Me.G_misc.Text = "Misc settings"
        '
        'C_HOX
        '
        Me.C_HOX.AutoSize = True
        Me.C_HOX.Location = New System.Drawing.Point(179, 48)
        Me.C_HOX.Name = "C_HOX"
        Me.C_HOX.Size = New System.Drawing.Size(115, 17)
        Me.C_HOX.TabIndex = 12
        Me.C_HOX.Text = "HOX sensor on/off"
        Me.C_HOX.UseVisualStyleBackColor = True
        '
        'C_EXC
        '
        Me.C_EXC.AutoSize = True
        Me.C_EXC.Location = New System.Drawing.Point(179, 71)
        Me.C_EXC.Name = "C_EXC"
        Me.C_EXC.Size = New System.Drawing.Size(79, 17)
        Me.C_EXC.TabIndex = 47
        Me.C_EXC.Text = "EXC on/off"
        Me.C_EXC.UseVisualStyleBackColor = True
        '
        'C_PAIR
        '
        Me.C_PAIR.AutoSize = True
        Me.C_PAIR.Location = New System.Drawing.Point(12, 94)
        Me.C_PAIR.Name = "C_PAIR"
        Me.C_PAIR.Size = New System.Drawing.Size(83, 17)
        Me.C_PAIR.TabIndex = 11
        Me.C_PAIR.Text = "PAIR on/off"
        Me.C_PAIR.UseVisualStyleBackColor = True
        '
        'C_FAN
        '
        Me.C_FAN.AutoSize = True
        Me.C_FAN.Location = New System.Drawing.Point(12, 71)
        Me.C_FAN.Name = "C_FAN"
        Me.C_FAN.Size = New System.Drawing.Size(88, 17)
        Me.C_FAN.TabIndex = 10
        Me.C_FAN.Text = "Fan ON/OFF"
        Me.C_FAN.UseVisualStyleBackColor = True
        '
        'C_coil_fi_disable
        '
        Me.C_coil_fi_disable.AutoSize = True
        Me.C_coil_fi_disable.Location = New System.Drawing.Point(12, 48)
        Me.C_coil_fi_disable.Name = "C_coil_fi_disable"
        Me.C_coil_fi_disable.Size = New System.Drawing.Size(100, 17)
        Me.C_coil_fi_disable.TabIndex = 9
        Me.C_coil_fi_disable.Text = "Coil FI disabled "
        Me.C_coil_fi_disable.UseVisualStyleBackColor = True
        '
        'C_msmode
        '
        Me.C_msmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.C_msmode.FormattingEnabled = True
        Me.C_msmode.Location = New System.Drawing.Point(258, 18)
        Me.C_msmode.Name = "C_msmode"
        Me.C_msmode.Size = New System.Drawing.Size(75, 21)
        Me.C_msmode.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Set dualmap mode MS0/MS1 ( switching pin 66 )"
        '
        'GixxerAdvSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 285)
        Me.Controls.Add(Me.G_misc)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "GixxerAdvSettings"
        Me.Text = "ecueditor.com - gixxer K7- advanced settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.G_misc.ResumeLayout(False)
        Me.G_misc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents G_misc As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents C_msmode As System.Windows.Forms.ComboBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents C_coil_fi_disable As System.Windows.Forms.CheckBox
    Friend WithEvents C_FAN As System.Windows.Forms.CheckBox
    Friend WithEvents C_PAIR As System.Windows.Forms.CheckBox
    Friend WithEvents C_EXC As System.Windows.Forms.CheckBox
    Friend WithEvents C_HOX As System.Windows.Forms.CheckBox
End Class
