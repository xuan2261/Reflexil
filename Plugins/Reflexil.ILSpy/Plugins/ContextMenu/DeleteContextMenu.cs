﻿using System;
using ICSharpCode.ILSpy;
using ICSharpCode.TreeView;

namespace Reflexil.Plugins.ILSpy.ContextMenu
{
	[ExportContextMenuEntry(Icon = "resources/delete.png", Header = "Delete", Category = "ReflexilMember")]
	internal class DeleteContextMenu : BaseMemberContextMenu
    {
		protected override void Execute(SharpTreeNode node)
        {
			ILSpyPackage.DeleteItem(node, EventArgs.Empty);
        }
    }
}

