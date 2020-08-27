<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.2, Version=15.2.20.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<dx:ASPxCallbackPanel ClientInstanceName="cbp" ID="ASPxCallbackPanel1" runat="server" Width="200px" OnCallback="ASPxCallbackPanel1_Callback">
				<PanelCollection>
					<dx:PanelContent>
						<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings: NorthwindConnectionString %>"
							SelectCommand="SELECT * FROM [Employees]">
						</asp:SqlDataSource>
						<dx:ASPxGridView ID="ASPxGridView1" runat="server" DataSourceID="SqlDataSource1" ClientVisible="false" OnInit="ASPxGridView1_Init"
							OnRowUpdating="ASPxGridView1_RowUpdating" KeyFieldName="EmployeeID">
							<Columns>
								<dx:GridViewCommandColumn ShowSelectCheckbox="true" VisibleIndex="0" ShowEditButton="true">
								</dx:GridViewCommandColumn>
								<dx:GridViewDataTextColumn FieldName="EmployeeID" ReadOnly="True" VisibleIndex="1">
									<EditFormSettings Visible="False" />
								</dx:GridViewDataTextColumn>
								<dx:GridViewDataTextColumn FieldName="LastName" VisibleIndex="2">
								</dx:GridViewDataTextColumn>
								<dx:GridViewDataTextColumn FieldName="FirstName" VisibleIndex="3">
								</dx:GridViewDataTextColumn>
								<dx:GridViewDataBinaryImageColumn FieldName="Photo" VisibleIndex="100">
								</dx:GridViewDataBinaryImageColumn>
							</Columns>
						</dx:ASPxGridView>
					</dx:PanelContent>
				</PanelCollection>
			</dx:ASPxCallbackPanel>
			<dx:ASPxButton ID="ASPxButton1" runat="server" Text="ASPxButton" AutoPostBack="false">
				<ClientSideEvents Click="function(s,e) { cbp.PerformCallback(); }" />
			</dx:ASPxButton>
		</div>
	</form>
</body>
</html>
