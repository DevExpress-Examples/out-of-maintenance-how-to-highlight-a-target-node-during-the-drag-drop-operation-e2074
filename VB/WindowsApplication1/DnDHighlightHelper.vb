Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.Utils

Namespace WindowsApplication1
	Public Class DnDHighlightHelper
		Inherits Component
		Private _AppearanceHighlight As New AppearanceObject()
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Property AppearanceHighlight() As AppearanceObject
			Get
				Return If(_AppearanceHighlight, AppearanceObject.EmptyAppearance)
			End Get
			Set(ByVal value As AppearanceObject)
				_AppearanceHighlight = value
			End Set
		End Property
		Private _SelectedTreeList As TreeList
		Public Property SelectedTreeList() As TreeList
			Get
				Return _SelectedTreeList
			End Get
			Set(ByVal value As TreeList)
				UnsubsribeEvents()
				_SelectedTreeList = value
				SubsribeEvents()
			End Set
		End Property

		Private Sub SubsribeEvents()
			If SelectedTreeList Is Nothing Then
				Return
			End If
			AddHandler SelectedTreeList.NodeCellStyle, AddressOf TreeList_NodeCellStyle
			AddHandler SelectedTreeList.DragOver, AddressOf TreeList_DragOver
			AddHandler SelectedTreeList.AfterDragNode, AddressOf TreeList_AfterDragNode
		End Sub

		Private Sub UnsubsribeEvents()
			If SelectedTreeList Is Nothing Then
				Return
			End If
			RemoveHandler SelectedTreeList.NodeCellStyle, AddressOf TreeList_NodeCellStyle
			RemoveHandler SelectedTreeList.DragOver, AddressOf TreeList_DragOver
			RemoveHandler SelectedTreeList.AfterDragNode, AddressOf TreeList_AfterDragNode
		End Sub

		Private hotTrackNode_Renamed As TreeListNode
		Private Property HotTrackNode() As TreeListNode
			Get
				Return hotTrackNode_Renamed
			End Get
			Set(ByVal value As TreeListNode)
				If hotTrackNode_Renamed IsNot value Then
					Dim prevNode As TreeListNode = hotTrackNode_Renamed
					hotTrackNode_Renamed = value
					SelectedTreeList.RefreshNode(prevNode)
					SelectedTreeList.RefreshNode(HotTrackNode)
				End If
			End Set
		End Property


		Private Sub TreeList_NodeCellStyle(ByVal sender As Object, ByVal e As GetCustomNodeCellStyleEventArgs)
			If e.Node Is HotTrackNode Then
				e.Appearance.Assign(AppearanceHighlight)
			End If
		End Sub

		Private Sub TreeList_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
			Dim treeList As TreeList = TryCast(sender, TreeList)
			Dim p As Point = treeList.PointToClient(New Point(e.X, e.Y))
			Dim hitInfo As TreeListHitInfo = SelectedTreeList.CalcHitInfo(p)
			If hitInfo.Node Is Nothing Then
				p.X = 2
				hitInfo = SelectedTreeList.CalcHitInfo(p)
			End If
			HotTrackNode = hitInfo.Node
		End Sub

		Private Sub TreeList_AfterDragNode(ByVal sender As Object, ByVal e As NodeEventArgs)
			HotTrackNode = Nothing
		End Sub
	End Class
End Namespace
