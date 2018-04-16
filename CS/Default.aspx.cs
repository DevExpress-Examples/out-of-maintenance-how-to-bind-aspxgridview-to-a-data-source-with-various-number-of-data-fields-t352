using DevExpress.Web;
using System;

public partial class _Default : System.Web.UI.Page {			
	protected void ASPxCallbackPanel1_Callback(object sender, CallbackEventArgsBase e) {
		ASPxGridView1.ClientVisible = true;
	}
	protected void ASPxGridView1_Init(object sender, EventArgs e) {
		ColumnUpdater.Initialize((ASPxGridView)sender);
	}
	protected void ASPxGridView1_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e) {
		e.Cancel = true;
		((ASPxGridView)sender).CancelEdit();		
		//update is not allowed in online demos
	}
}