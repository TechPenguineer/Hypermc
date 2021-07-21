using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hypermc.Utility;

namespace Hypermc.UI.Components
{
	public class DraggablePanel : Panel
	{
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool IsDragging { get; private set; }

		[Category("Behavior")]
		[DisplayName("Drag Control")]
		[Description("The control which's location will be updated (i.e. dragged)")]
		public Control? DragControl { get; set; }

		private Point _dragCursorOrigin;
		private Point _dragFormOrigin;

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			IsDragging = true;
			_dragCursorOrigin = Cursor.Position;
			_dragFormOrigin = Location;
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			if (IsDragging && DragControl is not null)
			{
				DragControl.Location = Utils.PointAdd(_dragFormOrigin, Utils.PointSub(Cursor.Position, _dragCursorOrigin));
			}
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);

			IsDragging = false;
		}
	}
}
