using System;
using System.Web;
using System.Web.Mvc;

namespace BootstrapTable.Controls
{
    /// <exclude/>
    public interface ITableApply<TResult>
    {
        /// <summary>
        /// Apply an option to the table.
        /// </summary>
        /// <param name="name">Name of the property to apply</param>
        /// <param name="value">Property value</param>
        TResult ApplyToTable(string name, object value);

        /// <summary>
        /// Apply an option to all of the columns already defined in the table.
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        TResult ApplyToColumns(ColumnOption option);

        /// <summary>
        /// Apply an option to either a table or a column.
        /// </summary>
        /// <param name="options">Enumeration option to apply</param>
        TResult Apply(params TableOption[] options);

        /// <summary>
        /// Apply an option value to the table or a column.
        /// </summary>
        /// <param name="option">Enumeration property to apply.</param>
        /// <param name="value">Property value.</param>
        TResult Apply(TableOption option, object value);

        /// <summary>
        /// Apply an option object array to the table or a column.
        /// </summary>
        /// <param name="option">Enumeration property to apply.</param>
        /// <param name="value">Property value.</param>
        TResult Apply(TableOption option, object[] value);

        /// <summary>
        /// Remove an option to either a table or a column.
        /// </summary>
        /// <param name="options">Enumeration option to remove.</param>
        TResult Cease(params TableOption[] options);

        /// <summary>
        /// Add one or more columns (fields) to the table.
        /// </summary>
        TResult Columns(params string[] columns);

        /// <summary>
        /// Add or retrieve a column to the table.
        /// </summary>
        /// <param name="title">Column title.</param>
        /// <param name="sortable">Is sortable.</param>
        /// <param name="sorter">Sorting function.</param>
        IColumnBuilder Column(string title = "", bool sortable = false, string sorter = null);
    }

    /// <exclude/>
    public interface IColumnApply<TResult>
    {
        /// <summary>
        /// Apply an option to a column
        /// </summary>
        /// <param name="option">Column option to apply</param>
        /// <param name="value">Object value</param>
        TResult Apply(ColumnOption option, object[] value);

        /// <summary>
        /// Apply an option to a column.
        /// </summary>
        /// <param name="option">Column option to apply.</param>
        /// <param name="value">Property value.</param>
        TResult Apply(ColumnOption option, object value);

        /// <summary>
        /// Apply a boolean true value to one or more column options.
        /// </summary>
        /// <param name="options">Column option(s) to apply.</param>
        TResult Apply(params ColumnOption[] options);

        /// <summary>
        /// Apply a boolean false value to one or more column options.
        /// </summary>
        /// <param name="options">Column option(s) to apply.</param>
        TResult Cease(params ColumnOption[] options);
    }

    /// <summary>
    /// Implementation to support bootstrap-table.
    /// </summary>
    public interface ITableBuilder : ITableApply<ITableBuilder>, IHtmlString
    {
        /// <summary>
        /// Add or retrieve a column.
        /// </summary>
        /// <param name="title">Column title.</param>
        /// <param name="field">Field name.</param>
        /// <param name="sortable">Is sortable.</param>
        /// <param name="sorter">Sorting function.</param>
        IColumnBuilder Column(string title, string field, bool sortable = false, string sorter = null);
    }

    /// <summary>
    /// Implementation to support bootstrap-table.
    /// </summary>
    public interface IColumnBuilder : ITableBuilder, IColumnApply<IColumnBuilder>
    {
        /// <summary>
        /// Apply an option to a column.
        /// </summary>
        /// <param name="name">Name of the property to apply</param>
        /// <param name="value">Property value</param>
        IColumnBuilder ApplyToColumn(string name, object value);
    }
}
