# Summaries in MAUI DataGrid

This sample demonstrates how to add summaries to the .NET MAUI DataGrid control in a .NET MAUI application.

## Sample

```xaml
    <datagrid:SfDataGrid x:Name="dataGrid" ItemsSource="{Binding OrdersInfo}"
                         ColumnWidthMode="{OnPlatform Android=Auto, WinUI=Fill, MacCatalyst=Fill, iOS=Auto}" 
                         AllowGroupExpandCollapse="True" AutoGenerateColumnsMode="None" 
                         GridLinesVisibility="Both" HeaderGridLinesVisibility="Both">

        <datagrid:SfDataGrid.CaptionSummaryTemplate>
            <DataTemplate>
                <StackLayout Orientation="Horizontal" Spacing="8" >
                    <Image Source="icon.png" WidthRequest="24" HeightRequest="24"/>
                    <Label Text="{Binding Converter={StaticResource SummaryConverter}, ConverterParameter = {x:Reference dataGrid}}" VerticalTextAlignment="Center"/>
                </StackLayout>
            </DataTemplate>
        </datagrid:SfDataGrid.CaptionSummaryTemplate>

        <datagrid:SfDataGrid.GroupColumnDescriptions>
            <datagrid:GroupColumnDescription ColumnName="FirstName"/>
        </datagrid:SfDataGrid.GroupColumnDescriptions>

        <datagrid:SfDataGrid.CaptionSummaryRow>
            <datagrid:DataGridSummaryRow ShowSummaryInRow="True" Title="Total Price :{Price} for {ProductCount} members">
                <datagrid:DataGridSummaryRow.SummaryColumns>
                    <datagrid:DataGridSummaryColumn Name="Price"
                                                    MappingName="Price" Format="{}{Sum:C0}"
                                                    SummaryType="Int32Aggregate" />
                    <datagrid:DataGridSummaryColumn Name="ProductCount"
                                                    Format="{}{Count}"
                                                    MappingName="Price"
                                                    SummaryType="CountAggregate" />
                </datagrid:DataGridSummaryRow.SummaryColumns>
            </datagrid:DataGridSummaryRow>
        </datagrid:SfDataGrid.CaptionSummaryRow>

        <datagrid:SfDataGrid.GroupSummaryRows>
            <datagrid:DataGridSummaryRow ShowSummaryInRow="True"
                                         Title="Total Price: {Price} for {customerID} members">
                <datagrid:DataGridSummaryRow.SummaryColumns>
                    <datagrid:DataGridSummaryColumn Name="Price"
                                                    MappingName="Price"
                                                    Format="{}{Sum:C0}"
                                                    SummaryType="DoubleAggregate">
                    </datagrid:DataGridSummaryColumn>
                    <datagrid:DataGridSummaryColumn Name="customerID"
                                                    MappingName="CustomerID"
                                                    Format="{}{Count}"
                                                    SummaryType="CountAggregate">
                    </datagrid:DataGridSummaryColumn>
                </datagrid:DataGridSummaryRow.SummaryColumns>
            </datagrid:DataGridSummaryRow>
        </datagrid:SfDataGrid.GroupSummaryRows>

        <datagrid:SfDataGrid.TableSummaryRows>
            <datagrid:DataGridTableSummaryRow ShowSummaryInRow="True" Title="Total Price: {Price} for {ID} items" TitleColumnCount="2" Position="Bottom" >
                <datagrid:DataGridTableSummaryRow.SummaryColumns>
                    <datagrid:DataGridSummaryColumn Name="Price"
                                                    Format="{}{Sum:C0}"
                                                    MappingName="Price"
                                                    SummaryType="DoubleAggregate" />
                    <datagrid:DataGridSummaryColumn Name="ID"
                                                    Format="{}{Count}"
                                                    MappingName="CustomerID"
                                                    SummaryType="CountAggregate" />
                </datagrid:DataGridTableSummaryRow.SummaryColumns>
            </datagrid:DataGridTableSummaryRow>
        </datagrid:SfDataGrid.TableSummaryRows>

        <datagrid:SfDataGrid.Columns>
            <datagrid:DataGridNumericColumn Format="D" MappingName="OrderID" HeaderText="Order ID" 
                                            CellTextAlignment="Start" HeaderTextAlignment="Start"/>
            <datagrid:DataGridNumericColumn Format="D" MappingName="EmployeeID" HeaderText="Customer ID"/>
            <datagrid:DataGridTextColumn MappingName="FirstName" HeaderText="Name"/>
            <datagrid:DataGridNumericColumn Format="C" MappingName="Freight" HeaderText="Freight"/>
            <datagrid:DataGridTextColumn MappingName="ShipCity" HeaderText="City"/>
            <datagrid:DataGridNumericColumn Format="C" MappingName="Price" HeaderText="Price"/>
        </datagrid:SfDataGrid.Columns>
    </datagrid:SfDataGrid>
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements)

## Troubleshooting:

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise from using or viewing the samples. The samples are for demonstrative purposes. If you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion's samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion's samples.
