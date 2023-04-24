<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGPTChat
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
        Me.btnSend = New System.Windows.Forms.Button()
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTemperature = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaxTokens = New System.Windows.Forms.TextBox()
        Me.cbModel = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbVoice = New System.Windows.Forms.ComboBox()
        Me.lblVoice = New System.Windows.Forms.Label()
        Me.chkListen = New System.Windows.Forms.CheckBox()
        Me.chkMute = New System.Windows.Forms.CheckBox()
        Me.lblSpeech = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnSend.Location = New System.Drawing.Point(3, 328)
        Me.btnSend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(109, 44)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'txtQuestion
        '
        Me.txtQuestion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuestion.Location = New System.Drawing.Point(3, 409)
        Me.txtQuestion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(1047, 105)
        Me.txtQuestion.TabIndex = 1
        '
        'txtAnswer
        '
        Me.txtAnswer.AcceptsReturn = True
        Me.txtAnswer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAnswer.Location = New System.Drawing.Point(3, 10)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAnswer.Multiline = True
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAnswer.Size = New System.Drawing.Size(1047, 314)
        Me.txtAnswer.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(206, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Randomness"
        '
        'txtTemperature
        '
        Me.txtTemperature.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTemperature.Location = New System.Drawing.Point(303, 337)
        Me.txtTemperature.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(89, 22)
        Me.txtTemperature.TabIndex = 5
        Me.txtTemperature.Text = "0.5"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 374)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Max tokens"
        '
        'txtMaxTokens
        '
        Me.txtMaxTokens.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMaxTokens.Location = New System.Drawing.Point(303, 373)
        Me.txtMaxTokens.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMaxTokens.Name = "txtMaxTokens"
        Me.txtMaxTokens.Size = New System.Drawing.Size(89, 22)
        Me.txtMaxTokens.TabIndex = 7
        Me.txtMaxTokens.Text = "2048"
        '
        'cbModel
        '
        Me.cbModel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbModel.FormattingEnabled = True
        Me.cbModel.Items.AddRange(New Object() {"text-davinci-003", "text-davinci-002", "code-davinci-002"})
        Me.cbModel.Location = New System.Drawing.Point(791, 340)
        Me.cbModel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbModel.Name = "cbModel"
        Me.cbModel.Size = New System.Drawing.Size(259, 24)
        Me.cbModel.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(740, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Model"
        '
        'cbVoice
        '
        Me.cbVoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbVoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVoice.FormattingEnabled = True
        Me.cbVoice.Location = New System.Drawing.Point(791, 374)
        Me.cbVoice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbVoice.Name = "cbVoice"
        Me.cbVoice.Size = New System.Drawing.Size(259, 24)
        Me.cbVoice.TabIndex = 11
        '
        'lblVoice
        '
        Me.lblVoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblVoice.AutoSize = True
        Me.lblVoice.Location = New System.Drawing.Point(740, 377)
        Me.lblVoice.Name = "lblVoice"
        Me.lblVoice.Size = New System.Drawing.Size(43, 17)
        Me.lblVoice.TabIndex = 12
        Me.lblVoice.Text = "Voice"
        '
        'chkListen
        '
        Me.chkListen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkListen.AutoSize = True
        Me.chkListen.Location = New System.Drawing.Point(419, 340)
        Me.chkListen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkListen.Name = "chkListen"
        Me.chkListen.Size = New System.Drawing.Size(68, 21)
        Me.chkListen.TabIndex = 13
        Me.chkListen.Text = "Listen"
        Me.chkListen.UseVisualStyleBackColor = True
        '
        'chkMute
        '
        Me.chkMute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkMute.AutoSize = True
        Me.chkMute.Location = New System.Drawing.Point(419, 376)
        Me.chkMute.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkMute.Name = "chkMute"
        Me.chkMute.Size = New System.Drawing.Size(61, 21)
        Me.chkMute.TabIndex = 14
        Me.chkMute.Text = "Mute"
        Me.chkMute.UseVisualStyleBackColor = True
        '
        'lblSpeech
        '
        Me.lblSpeech.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSpeech.AutoSize = True
        Me.lblSpeech.Location = New System.Drawing.Point(11, 382)
        Me.lblSpeech.Name = "lblSpeech"
        Me.lblSpeech.Size = New System.Drawing.Size(66, 17)
        Me.lblSpeech.TabIndex = 15
        Me.lblSpeech.Text = "speech..."
        Me.lblSpeech.Visible = False
        '
        'frmGPTChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 522)
        Me.Controls.Add(Me.lblSpeech)
        Me.Controls.Add(Me.chkMute)
        Me.Controls.Add(Me.chkListen)
        Me.Controls.Add(Me.lblVoice)
        Me.Controls.Add(Me.cbVoice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbModel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaxTokens)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.btnSend)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmGPTChat"
        Me.Text = "VB ChatGPT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSend As Button
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTemperature As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaxTokens As TextBox
    Friend WithEvents cbModel As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbVoice As ComboBox
    Friend WithEvents lblVoice As Label
    Friend WithEvents chkListen As CheckBox
    Friend WithEvents chkMute As CheckBox
    Friend WithEvents lblSpeech As Label
End Class
