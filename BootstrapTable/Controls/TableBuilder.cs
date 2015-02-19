using BootstrapTable.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;

namespace BootstrapTable.Controls
{
    /// <summary>
    /// Build a BootstrapTable control.
    /// </summary>
    internal partial class TableBuilder : IColumnBuilder
    {
        ///<exclude/>
        private readonly TagBuilder _builder;
        ///<exclude/>
        private List<TagBuilder> _columns = new List<TagBuilder>();
        ///<exclude/>
        private TagBuilder _currentColumn = null;

        #region IHtmlString
        /// <inheritDoc/>
        public string ToHtmlString()
        {
            var thead = new TagBuilder("thead");
            _columns.ForEach(column => thead.InnerHtml += column);
            _builder.InnerHtml += thead;
            return _builder.ToString(TagRenderMode.Normal);
        }
        #endregion

        /// <inheritDoc/>
        public TableBuilder(string id = null, string url = null, TablePaginationOption? sidePagination = TablePaginationOption.none, object htmlAttributes = null)
        {
            _builder = new TagBuilder("table");
            if (!string.IsNullOrEmpty(id))
                _builder.Attributes.Add("id", id);

            if (sidePagination != TablePaginationOption.none)
            {
                Apply(TableOption.pagination);
                ApplyToTable(sidePagination.FieldName(), sidePagination.FieldValue());
            }

            if (!string.IsNullOrEmpty(url))
                Apply(TableOption.url, url);

            _builder.MergeAttributes(htmlAttributes.HtmlAttributesToDictionary());

            Apply(TableOption.toggle);
        }

        /// <inheritDoc/>
        public ITableBuilder ApplyToColumns(ColumnOption option)
        {
            _columns.ForEach(s => ApplyToColumn(s.InnerHtml, option.FieldName(), option.FieldValue() ?? true.ToStringLower()));
            return this;
        }

        /// <inheritDoc/>
        public ITableBuilder Columns(params string[] columns)
        {
            columns.ForEach(s => Column(s.SplitCamelCase(), s));
            return this;
        }

        /// <inheritDoc/>
        public IColumnBuilder Column(string title = "", bool sortable = false, string sorter = null)
        {
            return Column(title, title, sortable, sorter);
        }

        /// <inheritDoc/>
        public IColumnBuilder Column(string title, string field, bool sortable = false, string sorter = null)
        {
            TagBuilder findColumn = _columns.Find(c => c.InnerHtml == title);
            if (findColumn != null)
            {
                _currentColumn = findColumn;
                return this;
            }

            var column = new TagBuilder("th");
            column.Attributes.Add(ColumnOption.field.FieldName(), field);
            if (sortable)
            {
                column.Attributes.Add(ColumnOption.sortable.FieldName(), sortable.ToStringLower());
                column.Attributes.Add(ColumnOption.sorter.FieldName(), sorter);
            }
            column.InnerHtml = title;
            _columns.Add(column);
            _currentColumn = column;

            return this;
        }

        /// <exclude/>
        protected TagBuilder GetColumnByTitle(string column)
        {
            TagBuilder findColumn = _columns.Find(c => c.InnerHtml == column);
            if (findColumn == null)
                throw new ArgumentException("Column not found with that title.");
            return findColumn;
        }

        /// <exclude/>
        protected bool SetColumnByTitle(string column)
        {
            return (_currentColumn = GetColumnByTitle(column)) != null;
        }
    }
}
