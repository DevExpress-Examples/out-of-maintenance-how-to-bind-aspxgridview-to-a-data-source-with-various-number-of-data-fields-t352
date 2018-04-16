using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Web.UI;

public class ColumnUpdater {
	List<GridViewColumn> columns;
	ASPxGridView _grid;
	Page page;
	ColumnUpdater(ASPxGridView currentGrid) {
		_grid = currentGrid;
		page = _grid.Page;
		if(page.IsPostBack)
			return;		
		_grid.DataBinding += ASPxGridView1_DataBinding;
		_grid.DataBound += ASPxGridView1_DataBound;
	}
	public static void Initialize(ASPxGridView currentGrid) {
		new ColumnUpdater(currentGrid);
	}
	void ASPxGridView1_DataBinding(object sender, EventArgs e) {		
		SaveColumns();
	}
	void ASPxGridView1_DataBound(object sender, EventArgs e) {
		UpdateColumns();
	}
	void SaveColumns() {
		columns = new List<GridViewColumn>();
		for(int i = 0; i < _grid.Columns.Count; i++) {
			columns.Add(_grid.Columns[i]);
		}
		_grid.Columns.Clear();
		_grid.AutoGenerateColumns = true;
	}
	void UpdateColumns() {
		foreach(GridViewColumn col in columns) {
			if(!(col is GridViewDataColumn)) {
				_grid.Columns.Add(col);
				continue;
			}
			for(int j = 0; j < _grid.Columns.Count; j++) {
				if(((GridViewDataColumn)col).FieldName != ((GridViewDataColumn)_grid.Columns[j]).FieldName)
					continue;
				_grid.Columns.RemoveAt(j);
				_grid.Columns.Add(col);
				break;
			}
		}
	}
}