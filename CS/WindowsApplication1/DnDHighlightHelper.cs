using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.Utils;

namespace WindowsApplication1
{
    public class DnDHighlightHelper:Component
    {
        private AppearanceObject _AppearanceHighlight = new AppearanceObject();
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public AppearanceObject AppearanceHighlight
        {
            get { return _AppearanceHighlight ?? AppearanceObject.EmptyAppearance; }
            set { _AppearanceHighlight = value; }
        }
        private TreeList _SelectedTreeList;
        public TreeList SelectedTreeList
        {
            get { return _SelectedTreeList; }
            set { UnsubsribeEvents(); _SelectedTreeList = value; SubsribeEvents(); }
        }

        private void SubsribeEvents()
        {
            if (SelectedTreeList == null) return;
            SelectedTreeList.NodeCellStyle += TreeList_NodeCellStyle;
            SelectedTreeList.DragOver += TreeList_DragOver;
            SelectedTreeList.AfterDragNode += TreeList_AfterDragNode;
        }

        private void UnsubsribeEvents()
        {
            if (SelectedTreeList == null) return;
            SelectedTreeList.NodeCellStyle -= TreeList_NodeCellStyle;
            SelectedTreeList.DragOver -= TreeList_DragOver;
            SelectedTreeList.AfterDragNode -= TreeList_AfterDragNode;
        }

        private TreeListNode hotTrackNode;
        private TreeListNode HotTrackNode
        {
            get
            {
                return hotTrackNode;
            }
            set
            {
                if (hotTrackNode != value)
                {
                    SelectedTreeList.InvalidateNode(HotTrackNode);
                    hotTrackNode = value;
                    SelectedTreeList.InvalidateNode(HotTrackNode);
                }
            }
        }


        private void TreeList_NodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e)
        {
            if (e.Node == HotTrackNode)
                e.Appearance.Assign(AppearanceHighlight);
        }

        private void TreeList_DragOver(object sender, DragEventArgs e)
        {
            TreeList treeList = sender as TreeList;
            Point p = treeList.PointToClient(new Point(e.X, e.Y));
            TreeListHitInfo hitInfo = SelectedTreeList.CalcHitInfo(p);
            if (hitInfo.Node == null)
            {
                p.X = 2;
                hitInfo = SelectedTreeList.CalcHitInfo(p);
            }
            HotTrackNode = hitInfo.Node;
        }

        private void TreeList_AfterDragNode(object sender, NodeEventArgs e)
        {
            HotTrackNode = null;
        }
    }
}
