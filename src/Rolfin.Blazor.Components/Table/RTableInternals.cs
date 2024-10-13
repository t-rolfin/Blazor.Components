using Microsoft.AspNetCore.Components;

namespace Rolfin.Blazor.Components.Table
{
    internal class Column<TItem>
    {
        public Column(string columnName, string width, Func<TItem, object> value)
        {
            ColumnName = columnName;
            Value = value;
            DataType = DataType.Value;
            Width = width;
        }

        public Column(string columnName, string width, RenderFragment fragment)
        {
            ColumnName = columnName;
            Fragment = fragment;
            DataType = DataType.Fragment;
            Width = width;
        }

        public string ColumnName { get; init; }
        public string Width { get; set; }
        public DataType DataType { get; init; }
        public Func<TItem, object> Value { get; init; }
        public RenderFragment Fragment { get; init; }
    }

    internal class Row
    {
        public string Id { get; set; }
        public List<Cell> Cells { get; set; }
    }

    internal class Cell
    {
        public Cell(object value, DataType dataType)
        {
            Value = value;
            DataType = dataType;
        }

        public object Value { get; set; }
        public DataType DataType { get; set; }
    }

    internal enum DataType
    {
        Value,
        Fragment
    }

}
