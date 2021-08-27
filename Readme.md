<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128537844/15.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T352835)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[ColumnUpdater.cs](./CS/App_Code/ColumnUpdater.cs) (VB: [ColumnUpdater.vb](./VB/App_Code/ColumnUpdater.vb))**
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to bind ASPxGridView to a data source with various number of data fields
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t352835/)**
<!-- run online end -->


<p>This example shows how to use <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxGridViewtopic"><strong>ASPxGridView</strong></a> with several predefined columns and automatically add the rest of them. The current implementation uses a custom <strong>ColumnUpdater</strong> class for saving and updating a column collection of the <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxGridViewtopic"><strong>ASPxGridView</strong></a>. For this purpose, the grid was subscribed in the <strong>ASPxGridView.Init</strong> event with the <strong>ColumnUpdater</strong> class.<br>In this example, the grid is loaded in the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxCallbackPanel_Callbacktopic"><strong>ASPxCallbackPanel.Callback</strong></a> event. To show the grid, please click the button.</p>

<br/>


