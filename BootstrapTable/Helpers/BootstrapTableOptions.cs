using BootstrapTable.Support;

namespace System.Web.Mvc
{
    #region Table Options
    /// <summary>
    /// An enumeration representing all of the options that can be set against a table.
    /// </summary>
    public enum TableOption
    {
        /// <summary>
        /// Activate bootstrap table without writing JavaScript.
        /// </summary>
        /// <value>string = table</value>
        [ValueField(Name = "data-toggle", Value = "table")]
        toggle,

        /// <summary>
        /// The class name of table (default = table table-hover).
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-classes")]
        classes,

        /// <summary>
        /// The height of table.
        /// </summary>
        /// <value>int</value>
        [NameField(Name = "data-height")]
        height,

        /// <summary>
        /// Defines the default undefined text.
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-undefined-text")]
        undefined,

        /// <summary>
        /// True to stripe the rows (default = false)
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-striped")]
        striped,

        /// <summary>
        /// Defines which column can be sorted.
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-sort-name")]
        sortName,

        /// <summary>
        /// Defines the column sort order as assending.
        /// </summary>
        /// <value>bool</value>
        [ValueField(Name = "data-sort-order", Value = "asc")]
        sortOrder_asc,

        /// <summary>
        /// Defines the column sort order as decending.
        /// </summary>
        /// <value>bool</value>
        [ValueField(Name = "data-sort-order", Value = "desc")]
        sortOrder_desc,

        /// <summary>
        /// Defines icon set name.
        /// </summary>
        /// <value>string = 'glyphicon' (default) or 'fa' for FontAwesome</value>
        /// <remarks>1.6</remarks>
        [NameField(Name = "data-icons-prefix")]
        iconsPrefix,

        /// <summary>
        /// Defines icons that used for refresh, toggle and columns buttons.
        /// </summary>
        /// <value>object[] { refresh: 'glyphicon-refresh icon-refresh', toggle: 'glyphicon-list-alt icon-list-alt', columns: 'glyphicon-th icon-th' } </value>
        /// <example>
        /// .Apply(TableOption.iconsPrefix, "fa") //font-awesome
        /// .Apply(TableOption.icons, new { refresh = "fa fa-refresh" })
        /// </example>
        /// <remarks>1.6</remarks>
        [NameField(Name = "data-icons")]
        icons,

        /// <summary>
        /// The table columns config object, see column properties for more details.
        /// </summary>
        /// <value>string[]</value>
        [NameField(Name = "")]
        columns,

        /// <summary>
        /// The method type to request remote data (default = get).
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-method")]
        method,

        /// <summary>
        /// A URL to request data from remote site.
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-url")]
        url,

        /// <summary>
        /// False to disable caching of AJAX requests (default = true).
        /// </summary>
        /// <value>boolean</value>
        [ValueField(Name = "data-cache")]
        cache,

        /// <summary>
        /// The contentType of request remote data (default = application/json).
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-content-type")]
        contentType,

        /// <summary>
        /// The type of data that you are expecting back from the server (default = json).
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-data-type")]
        dataType,

        /// <summary>
        /// Additional options for submit ajax request. List of values: http://api.jquery.com/jQuery.ajax.
        /// </summary>
        /// <value>object[]</value>
        /// <remarks>1.6</remarks>
        [NameField(Name = "data-ajax-options")]
        ajaxOptions,

        /// <summary>
        /// When request remote data, sending additional parameters by format the queryParams,
        /// the parameters object contains: pageSize, pageNumber, searchText, sortName, sortOrder.
        /// Return false to stop request (default = function(params) { return params; }).
        /// </summary>
        /// <value>string</value>
        [ValueField(Name = "data-query-params")]
        queryParams,

        /// <summary>
        /// Set "limit" to send query params width RESTFul type (default = limit).
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-query-params-type")]
        queryParamsType,

        /// <summary>
        /// Before load remote data, handler the response data format, the parameters object 
        /// contains: res: the response data (default = function(res) { return res; }
        /// </summary>
        /// <value>string (function)</value>
        [NameField(Name = "data-response-handler")]
        responseHandler,

        /// <summary>
        /// True to show a pagination toolbar on table bottom (default = false).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-pagination")]
        pagination,

        /// <summary>
        /// Defines the side pagination of table, can only be "client" or "server" (default = client).
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-side-pagination")]
        sidePagination,

        /// <summary>
        /// When set pagination property, initialize the page number (default = 1).
        /// </summary>
        /// <value>int</value>
        [NameField(Name = "data-page-number")]
        pageNumber, 

        /// <summary>
        /// When set pagination property, initialize the page size (default = 10).
        /// </summary>
        /// <value>int</value>
        [NameField(Name = "data-page-size")]
        pageSize,

        /// <summary>
        /// When set pagination property, initialize the page size selecting list (default = [10, 25, 50, 100]).
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-page-list")]
        pageList,

        /// <summary>
        /// The name of radio or checkbox input (default = btSelectItem).
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-select-item-name")]
        selectItemName,

        /// <summary>
        /// True to display pagination or card view smartly.
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-smart-display")]
        smartDisplay,

        /// <summary>
        /// Enable the search input (default = false).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-search")]
        search,

        /// <summary>
        /// Set timeout for search fire.
        /// </summary>
        /// <value>int (default = 500)</value>
        /// <remarks>1.6</remarks>
        [NameField(Name = "data-search-time-out")]
        searchTimeOut,

        /// <summary>
        /// False to hide the table header (default = true)
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-show-header")]
        showHeader,

        /// <summary>
        /// True to show the columns drop down list (default = false).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-show-columns")]
        showColumns,

        /// <summary>
        /// True to show the refresh button (default = false).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-show-refresh")]
        showRefresh,

        /// <summary>
        /// True to show the toggle button to toggle table / card view (default = false).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-show-toggle")]
        showToggle,

        /// <summary>
        /// The minimum count columns to hide of the columns drop down list (default = 1).
        /// </summary>
        /// <value>int</value>
        [NameField(Name = "data-minimum-count-columns")]
        minimumCountColumns,

        /// <summary>
        /// Indicate which field is an identity field.
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-id-field")]
        idField,

        /// <summary>
        /// True to show card view table, for example mobile view (default = false).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-card-view")]
        cardView,

        /// <summary>
        /// Indicate how to align the search input (default = right).
        /// </summary>
        /// <value>bool</value>
        [ValueField(Name = "data-search-align", Value = "left")]
        searchAlign_left,

        /// <summary>
        /// Indicate how to align the search input (default = right).
        /// </summary>
        /// <value>bool</value>
        [ValueField(Name = "data-search-align", Value = "right")]
        searchAlign_right,

        /// <summary>
        /// Indicate how to align the toolbar buttons (default = right).
        /// </summary>
        /// <value>string = 'left', 'right'</value>
        /// <remarks>1.6.0</remarks>
        [NameField(Name = "data-buttons-align")]
        buttonsAlign,

        /// <summary>
        /// Indicate how to align the toolbar buttons on the left.
        /// </summary>
        /// <value>bool</value>
        [ValueField(Name = "data-toolbar-align", Value = "left")]
        toolbarAlign_left,

        /// <summary>
        /// Indicate how to align the toolbar buttons on the right.
        /// </summary>
        /// <value>bool</value>
        [ValueField(Name = "data-toolbar-align", Value = "right")]
        toolbarAlign_right,

        /// <summary>
        /// True to select checkbox or radiobox when click rows (default = false).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-click-to-select")]
        clickToSelect,

        /// <summary>
        /// True to allow checkbox selecting only one row (default = false).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-single-select")]
        singleSelect,

        /// <summary>
        /// jQuery selector that indicate the toolbar, for example: #toolbar, .toolbar.
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-toolbar")]
        toolbar,

        /// <summary>
        /// False to hide check-all checkbox in header row (default = true).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-checkbox-header")]
        checkboxHeader,

        /// <summary>
        /// True to maintain selected rows on change page and search (default = false).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-maintain-selected")]
        maintainSelected,

        /// <summary>
        /// False to disable sortable of all columns (default = true).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-sortable")]
        sortable,

        /// <summary>
        /// The row style formatter function, take two parameters: row: the row record data. 
        /// index: the row index. Support classes or css.
        /// </summary>
        /// <value>string (function)</value>
        [NameField(Name = "data-row-style")]
        rowStyle,

        /// <summary>
        /// Support all custom attributes.
        /// </summary>
        /// <value>Function	{} (parameters - row: the row record data, index: the row index)</value>
        /// <remarks>1.4.0</remarks>
        [NameField(Name = "data-row-attributes")]
        rowAttributes,

        /// <summary>
        /// Set the icons size.
        /// </summary>
        /// <value>?</value>
        /// <remarks>1.6.0</remarks>
        [NameField(Name = "data-icon-size")]
        iconSize,

        /// <summary>
        /// Toolbar button to show or hide the pagination.
        /// </summary>
        /// <remarks>1.6.0</remarks>
        [NameField(Name = "data-show-pagination-switch")]
        showPaginationSwitch,

        /// <summary>
        /// Show loading message when table is obtaining data.
        /// </summary>
        [NameField(Name = "data-show-loading")]
        showLoading,
    }

    ///<summary>
    ///Represents the options available for client or server side pagination.
    ///</summary>
    public enum TablePaginationOption
    {
        /// <summary></summary>
        [ValueField(Name = "data-side-pagination", Value = "")]
        none,
        /// <summary></summary>
        [ValueField(Name = "data-side-pagination", Value = "client")]
        client,
        /// <summary></summary>
        [ValueField(Name = "data-side-pagination", Value = "server")]
        server,
    }
    #endregion

    #region ColumnOptions
    /// <summary>
    /// An enumeration representing all of the options that can be set against a column.
    /// </summary>
    public enum ColumnOption
    {
        /// <summary>
        /// True to show a radio. The radio column has fixed width (default = false).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-radio")]
        radio,

        /// <summary>
        /// True to show a checkbox. The checkbox column has fixed width (defualt = false).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-checkbox")]
        checkbox,

        /// <summary>
        /// The column field name.
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-field")]
        field,

        /// <summary>
        /// The column title text.
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-title")]
        title,

        /// <summary>
        /// The column class name.
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-class")]
        @class,

        /// <summary>
        /// Indicate how to align the column data.
        /// </summary>
        /// <value>bool</value>
        [ValueField(Name = "data-align", Value = "left")]
        align_left,

        /// <summary>
        /// Indicate how to align the column data.
        /// </summary>
        /// <value>bool</value>
        [ValueField(Name = "data-align", Value = "right")]
        align_right,

        /// <summary>
        /// Indicate how to align the column data.
        /// </summary>
        /// <value>bool</value>        
        [ValueField(Name = "data-align", Value = "center")]
        align_center,

        /// <summary>
        /// Indicate how to align the table header.
        /// </summary>
        /// <value>bool</value>
        /// <remarks>1.4.0</remarks>
        [ValueField(Name = "data-halign", Value = "left")]
        halign_left,

        /// <summary>
        /// Indicate how to align the table header.
        /// </summary>
        /// <value>bool</value>
        /// <remarks>1.4.0</remarks>
        [ValueField(Name = "data-halign", Value = "right")]
        halign_right,

        /// <summary>
        /// Indicate how to align the table header.
        /// </summary>
        /// <value>bool</value>
        /// <remarks>1.4.0</remarks>
        [ValueField(Name = "data-halign", Value = "center")]
        halign_center,

        /// <summary>
        /// Indicate how to align the cell data.
        /// </summary>
        /// <value>bool</value>
        [ValueField(Name = "data-valign", Value = "top")]
        valign_top,

        /// <summary>
        /// Indicate how to align the cell data.
        /// </summary>
        /// <value>bool</value>
        [ValueField(Name = "data-valign", Value = "middle")]
        valign_middle,

        /// <summary>
        /// Indicate how to align the cell data.
        /// </summary>
        /// <value>bool</value>
        [ValueField(Name = "data-valign", Value = "bottom")]
        valign_bottom,

        /// <summary>
        /// The width of column. If not defined, the width will auto expand to fit its contents.
        /// </summary>
        /// <value>int</value>
        [NameField(Name = "data-width")]
        width,

        /// <summary>
        /// True to allow the column can be sorted (default = false).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-sortable")]
        sortable,

        /// <summary>
        /// The default sort order (default = asc).
        /// </summary>
        /// <value>string "asc" or "desc"</value>
        [NameField(Name = "data-order")]
        order,

        /// <summary>
        /// False to hide the columns item (default = true)
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-visible")]
        visible,

        /// <summary>
        /// False to disable the switchable of columns item (default = true).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-switchable")]
        switchable,

        /// <summary>
        /// True to select checkbox or radiobox when the column is clicked (default = true).
        /// </summary>
        /// <value>bool</value>
        [NameField(Name = "data-click-to-select")]
        clickToSelect,

        /// <summary>
        /// The cell formatter function, take three parameters: value: the field value. row: 
        /// the row record data. index: the row index (function).
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-formatter")]
        formatter,

        /// <summary>
        /// The cell events listener when you use formatter function, take three parameters: 
        /// event: the jQuery event. value: the field value. row: the row record data. index:
        /// the row index (function).
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-events")]
        events,

        /// <summary>
        /// The custom field sort function that used to do local sorting, take two parameters:
        /// a: the first field value. b: the second field value (function).
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-sorter")]
        sorter,

        /// <summary>
        /// The cell style formatter function, take three parameters: value: the field value.
        /// row: the row record data. index: the row index. Support classes or css (function).
        /// </summary>
        /// <value>string</value>
        [NameField(Name = "data-cell-style")]
        cellStyle,

        /// <summary>
        /// True to search data for this column.
        /// </summary>
        /// <value>bool</value>
        /// <remarks>1.5.0</remarks>
        [NameField(Name = "data-searchable")]
        searchable,
    }
    #endregion
}