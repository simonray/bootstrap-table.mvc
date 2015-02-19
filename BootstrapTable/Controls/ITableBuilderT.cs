using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace BootstrapTable.Controls
{
    /// <exclude/>
    public interface ITableBuilderT<TModel> : ITableApply<ITableBuilderT<TModel>>
    {
        /// <summary>
        /// Apply an option to a column.
        /// </summary>
        /// <param name="expression">An expression that identifies the column property</param>
        /// <param name="option">Column option to apply</param>
        /// <param name="value">Property value</param>
        /// <returns></returns>
        IColumnBuilderT<TModel> Apply<TProperty>(Expression<Func<TModel, TProperty>> expression, ColumnOption option, object[] value);
        
        /// <summary>
        /// Apply an option to the column.
        /// </summary>
        /// <param name="expression">An expression that identifies the column property</param>
        /// <param name="option">Column option to apply</param>
        /// <param name="value">Property value</param>
        /// <returns></returns>
        IColumnBuilderT<TModel> Apply<TProperty>(Expression<Func<TModel, TProperty>> expression, ColumnOption option, object value);

        /// <summary>
        /// Apply a boolean true value to one or more column options.
        /// </summary>
        /// <param name="expression">An expression that identifies the column property</param>
        /// <param name="options">Column option(s) to apply</param>
        /// <returns></returns>
        IColumnBuilderT<TModel> Apply<TProperty>(Expression<Func<TModel, TProperty>> expression, params ColumnOption[] options);

        /// <summary>
        /// Apply a boolean false value to one or more column options.
        /// </summary>
        /// <param name="expression">An expression that identifies the column property</param>
        /// <param name="options">Column option(s) to apply</param>
        /// <returns></returns>
        IColumnBuilderT<TModel> Cease<TProperty>(Expression<Func<TModel, TProperty>> expression, params ColumnOption[] options);

        /// <summary>
        /// Get a column for a specific property.
        /// </summary>
        IColumnBuilderT<TModel> Column<TProperty>(Expression<Func<TModel, TProperty>> expression);
    }

    /// <exclude/>
    public interface IColumnBuilderT<TModel> : ITableBuilderT<TModel>, IColumnApply<IColumnBuilderT<TModel>>
    {

    }
}
