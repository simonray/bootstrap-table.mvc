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
        public ITableBuilder ApplyToTable(string name, object value)
        {
            if (value.GetType().IsAnonymousType())
                _builder.Attributes.Add(name, value.ToSerializedString().ToString());
            else if (value.GetType() == typeof(bool))
                _builder.Attributes.Add(name, value.ToStringLower());
            else
                _builder.Attributes.Add(name, value.ToString());
            return this;
        }

		/// <exclude/>
        public ITableBuilder Apply(TableOption option, object value)
        {
            return ApplyToTable(option.FieldName(), value);
        }

        /// <exclude/>
        public ITableBuilder Apply(TableOption option, object[] value)
        {
            if (option.GetType() == typeof(TableOption) && ((TableOption)option) == TableOption.columns)
                return Columns(value.Select(o => o.ToString()).ToArray());
            else
                return ApplyToTable(option.FieldName(), string.Format("[{0}]", string.Join(",", value)));
        }

        /// <exclude/>
        public ITableBuilder Apply(params TableOption[] options)
        {
            options.ForEach(option =>
            {
                ApplyToTable(option.FieldName(), option.FieldValue() ?? true.ToStringLower());
            });
            return this;
        }

        /// <exclude/>
        public ITableBuilder Cease(params TableOption[] options)
        {
            options.ForEach(option =>
            {
                ApplyToTable(option.FieldName(), option.FieldValue() ?? false.ToStringLower());
            });
            return this;
        }
    }
}
