﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Label4 = New Label()
        btnEvaluate = New Button()
        Label3 = New Label()
        txtgrade = New TextBox()
        Label2 = New Label()
        EnterMarks = New TextBox()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.FlatStyle = FlatStyle.Flat
        Label4.Font = New Font("Times New Roman", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Blue
        Label4.Location = New Point(100, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(460, 32)
        Label4.TabIndex = 12
        Label4.Text = "GRADING SCALE CALCULATOR"
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Font = New Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEvaluate.Location = New Point(233, 313)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(171, 83)
        btnEvaluate.TabIndex = 11
        btnEvaluate.Text = "EVALUATE"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.FlatStyle = FlatStyle.Flat
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label3.Location = New Point(119, 251)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 19)
        Label3.TabIndex = 10
        Label3.Text = "Grade"
        ' 
        ' txtgrade
        ' 
        txtgrade.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtgrade.Location = New Point(276, 247)
        txtgrade.Name = "txtgrade"
        txtgrade.Size = New Size(256, 27)
        txtgrade.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.FlatStyle = FlatStyle.Flat
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold)
        Label2.Location = New Point(109, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 19)
        Label2.TabIndex = 8
        Label2.Text = "Enter Marks"
        ' 
        ' EnterMarks
        ' 
        EnterMarks.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EnterMarks.Location = New Point(276, 190)
        EnterMarks.Name = "EnterMarks"
        EnterMarks.Size = New Size(256, 27)
        EnterMarks.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ClientSize = New Size(661, 488)
        Controls.Add(Label4)
        Controls.Add(btnEvaluate)
        Controls.Add(Label3)
        Controls.Add(txtgrade)
        Controls.Add(Label2)
        Controls.Add(EnterMarks)
        Name = "Form1"
        Text = "NUWAGABA SHAWN"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btnEvaluate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtgrade As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EnterMarks As TextBox

End Class