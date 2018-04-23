Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.dnDHighlightHelper1 = New WindowsApplication1.DnDHighlightHelper()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.treeList1.Location = New System.Drawing.Point(0, 0)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.DragNodes = True
			Me.treeList1.OptionsBehavior.Editable = False
			Me.treeList1.Size = New System.Drawing.Size(572, 482)
			Me.treeList1.TabIndex = 0
			' 
			' dnDHighlightHelper1
			' 
			Me.dnDHighlightHelper1.AppearanceHighlight.BackColor = System.Drawing.Color.Gold
			Me.dnDHighlightHelper1.AppearanceHighlight.BackColor2 = System.Drawing.Color.DarkOrange
			Me.dnDHighlightHelper1.AppearanceHighlight.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
			Me.dnDHighlightHelper1.AppearanceHighlight.Options.UseBackColor = True
			Me.dnDHighlightHelper1.SelectedTreeList = Me.treeList1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(572, 482)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private treeList1 As DevExpress.XtraTreeList.TreeList
		Private dnDHighlightHelper1 As DnDHighlightHelper
	End Class
End Namespace

