﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System.Diagnostics.CodeAnalysis;

#if MIGRATION
namespace System.Windows.Controls
#else
namespace Windows.UI.Xaml.Controls
#endif
{
/// <summary>
/// Defines modes that indicates how DataGrid content is copied to the Clipboard. 
/// </summary>
public enum DataGridClipboardCopyMode
    {
        /// <summary>
        /// Disable the DataGrid's ability to copy selected items as text.
        /// </summary>
        None,

        /// <summary>
        /// Enable the DataGrid's ability to copy selected items as text, but do not include
        /// the column header content as the first line in the text that gets copied to the Clipboard.
        /// </summary>
        ExcludeHeader,

        /// <summary>
        /// Enable the DataGrid's ability to copy selected items as text, and include
        /// the column header content as the first line in the text that gets copied to the Clipboard.
        /// </summary>
        IncludeHeader
    }

    /// <summary>
    /// Used to specify action to take out of edit mode.
    /// </summary>
    /// <QualityBand>Mature</QualityBand>
    public enum DataGridEditAction
    {
        /// <summary>
        /// Cancel the changes.
        /// </summary>
        Cancel,

        /// <summary>
        /// Commit edited value.
        /// </summary>
        Commit
    }

    // Determines the location and visibility of the editing row.
    internal enum DataGridEditingRowLocation
    {
        Bottom = 0, // The editing row is collapsed below the displayed rows
        Inline = 1, // The editing row is visible and displayed
        Top = 2     // The editing row is collapsed above the displayed rows
    }

    /// <summary>
    /// Determines whether the inner cells' vertical/horizontal gridlines are shown or not.
    /// </summary>
    /// <QualityBand>Mature</QualityBand>
#if MIGRATION
    [Flags]
    [SuppressMessage("Microsoft.Naming", "CA1714:FlagsEnumsShouldHavePluralNames")]
#endif
    public enum DataGridGridLinesVisibility
    {
        None = 0,
        Horizontal = 1,
        Vertical = 2,
        All = 3,
    }

    /// <QualityBand>Mature</QualityBand>
    public enum DataGridEditingUnit
    {
        Cell = 0,
        Row = 1,
    }

    /// <summary>
    /// Determines whether the row/column headers are shown or not.
    /// </summary>
    /// <QualityBand>Mature</QualityBand>
#if MIGRATION
    [Flags]
#endif
    [SuppressMessage("Microsoft.Naming", "CA1714:FlagsEnumsShouldHavePluralNames")]
    public enum DataGridHeadersVisibility
    {
        /// <summary>
        /// Show Row, Column, and Corner Headers
        /// </summary>
        All = Row | Column,

        /// <summary>
        /// Show only Column Headers with top-right corner Header
        /// </summary>
        Column = 0x01,
        
        /// <summary>
        /// Show only Row Headers with bottom-left corner
        /// </summary>
        Row = 0x02,

        /// <summary>
        /// Don’t show any Headers
        /// </summary>
        None = 0x00
    }

    /// <QualityBand>Mature</QualityBand>
    public enum DataGridRowDetailsVisibilityMode
    {
        Collapsed = 2,          // Show no details.  Developer is in charge of toggling visibility.
        Visible = 1,	        // Show the details section for all rows.
        VisibleWhenSelected = 0	// Show the details section only for the selected row(s).
    }

    /// <summary>
    /// Determines the type of action to take when selecting items
    /// </summary>
    internal enum DataGridSelectionAction
    {
        AddCurrentToSelection,
        None,
        RemoveCurrentFromSelection,
        SelectCurrent,
        SelectFromAnchorToCurrent
    }

    /// <summary>
    /// Determines the selection model
    /// </summary>
    /// <QualityBand>Mature</QualityBand>
    public enum DataGridSelectionMode
    {
        Extended = 0,
        Single = 1
    }
}
