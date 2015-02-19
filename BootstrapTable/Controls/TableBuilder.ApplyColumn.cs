using BootstrapTable.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BootstrapTable.Controls
{
    internal partial class TableBuilder
    {
        /// <inheritDoc/>
        public IColumnBuilder ApplyToColumn(string name, object value)
        {
            ApplyToColumn(_currentColumn, name, value);
            return this;
        }

        /// <inheritDoc/>
        public ITableBuilder ApplyToColumn(string title, string name, object value)
        {
            return ApplyToColumn(GetColumnByTitle(title), name, value);
        }

        /// <exclude/>
        public IColumnBuilder Apply(ColumnOption option, object value)
        {
            return ApplyToColumn(option.FieldName(), value);
        }

        /// <exclude/>
        public IColumnBuilder Apply(ColumnOption option, object[] value)
        {
            return ApplyToColumn(option.FieldName(), string.Format("[{0}]", string.Join(",", value)));
        }

        /// <exclude/>
        public IColumnBuilder Apply(params ColumnOption[] options)
        {
            options.ForEach(option =>
            {
                ApplyToColumn(option.FieldName(), option.FieldValue() ?? true.ToStringLower());
            });
            return this;
        }

        /// <exclude/>
        public IColumnBuilder Cease(params ColumnOption[] options)
        {
            options.ForEach(option =>
            {
                ApplyToColumn(option.FieldName(), option.FieldValue() ?? false.ToStringLower());
            });
            return this;
        }

        /// <inheritDoc/>
        protected ITableBuilder ApplyToColumn(TagBuilder column, string name, object value)
        {
            if (value.GetType().IsAnonymousType())
                column.Attributes.Add(name, value.ToSerializedString().ToString());
            else if (value.GetType() == typeof(bool))
                column.Attributes.Add(name, value.ToStringLower());
            else
                column.Attributes.Add(name, value.ToString());
            return this;
        }
    }
}
