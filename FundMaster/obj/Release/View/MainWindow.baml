   M S B A M L   `   `   `  ���� E  AFundMaster, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:FundMaster
FundMaster  O KFundMaster.EntityDAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY@clr-namespace:FundMaster.EntityDAL;assembly=FundMaster.EntityDALFundMaster.EntityDAL L HFundMaster.Entity, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullP:clr-namespace:FundMaster.Entity;assembly=FundMaster.EntityFundMaster.Entity     FundMaster.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:FundMaster     V	EntityDAL@clr-namespace:FundMaster.EntityDAL;assembly=FundMaster.EntityDAL     MEntity:clr-namespace:FundMaster.Entity;assembly=FundMaster.Entity       � Title$  
FundMaster��$	��462��$	��969��.��� $��0,0,2,6q� J� RenderTransformOrigin$ 	0.5,0.521&�.+��� -    ��Name$ 
tabControl��$
��10,0q�.@��� $
��Fund��.��� ���	#FFE5E5E5$��0,3,9,2q� � ColumnDefinitions �� $	��31* ��� $
��366* �.+��� -    ��Name$ label��$��Create new Fund��$
��Left=�$��	10,10,0,0q�$	��Top=�$��2���� -   $ 
label_Copy��$
��Name��$
��Left=�$��	10,41,0,0q�$	��Top=��� -    ��Name$ FundName_txt��$
��Left=�$��23��$��	70,44,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��240��$��1������ *
FundName+�� $	��Add��$
��Left=�$��145,117,0,0q�$	��Top=�$��75��$��1������ *AddFundItem+&   System.Windows.Controls.DataGrid  -     Name$ dataGrid_Fund��   AutoGenerateColumns .  $
��Left=�$��
580,44,0,0q�$	��Top=�$��1������ *	FundsList+	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Name+  $
 
CreatedUTC�� �� *
CreatedUTC+4  .System.Windows.Controls.DataGridCheckBoxColumn  $
 	isDeleted�� �� *	isDeleted+�� -   $ label_Deleted��$��Mark as deleted��$
��Left=�$��	10,82,0,0q�$	��Top=�$��2��$	��117���� -    ��Name$ Deleted_checkbox��$��1��$
��Left=�$��	70,88,0,0q�$	��Top=� d� 	IsChecked �� *isDeletedFund+�� -    ��Name$ refresh_button��$��Refresh��$��1��$
��Left=�$��235,117,0,0q�$	��Top=�$��75���� $��Security��.��� ���	#FFE5E5E5$��
-9,-7,-3,2q�$ 	0.5,0.519&�.+��� -	   $ SecurityInfo_label��$��Create new security��$
��Left=�$��	10,25,0,0q�$	��Top=��� -
   $ SecurityName_label��$��Security Name��$
��Left=�$��	10,56,0,0q�$	��Top=��� -   $ PriceName_label��$��Security Type��$
��Left=�$��	10,89,0,0q�$	��Top=��� -   $ QuantityName_label��$��Price��$
��Left=�$��
10,122,0,0q�$	��Top=��� -   $ SecurityAdd_btn��$	��Add��$
��Left=�$��216,222,0,0q�$	��Top=�$��75������ *AddSecurityItem+�� -   $ security_textBox��$
��Left=�$��23��$��
122,59,0,0q�$
 Wrap=�$	��Top=�$	��169������ *	SecName+�� -   $ secprice_textBox��$
��Left=�$��23��$��122,122,0,0q�$
 Wrap=�$	��Top=�$	��120������ *
SecPrice+� -    �Name$ SecFundMappingGrid��$
��Left=�$	��292��$��
372,25,0,0q�$	��Top=�$	��375�� � 
InputScope ��  �� Mode$ OneWay=� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect   � DataContext ,  &FundMaster.EntityDAL.FundMasterContext    -   $ securities_dataGrid�� .  $
��Left=�$��
485,58,0,0q�$	��Top=����� *	SecList+	   $

 Name�� �� *Name+  $
 	SecTypeId�� �� *SecurityTypeId+  $
 Price�� �� *Price+  $
 Quantity�� �� *Qty+  $
 
CreatedUTC�� �� *
CreatedUTC+  $
 	isDeleted�� �� *	isDeleted+�� -   $ QuantityName_label_Copy��$��Quantity��$
��Left=�$��
10,150,0,0q�$	��Top=��� -   $ secQty_textBox��$
��Left=�$��23��$��122,154,0,0q�$
 Wrap=�$	��Top=�$	��120������ *SecQty+�� -   $ SecurityRefresh_btn��$��Refresh��$
��Left=�$��
741,31,0,0q�$	��Top=�$��75���� -    ��Name$ SecType_comboBox��$
��Left=�$��
122,89,0,0q�$	��Top=�$	��169�� �� SelectedValue �� *	SecType+�� -   $ SecurityInfo_label_Copy��$��Securities List��$
��Left=�$��
488,25,0,0q�$	��Top=��� -   $ QuantityName_label_Copy1��$��Mark as Deleted��$
��Left=�$��
10,181,0,0q�$	��Top=�$	��113���� -   $ security_checkBox��$�� ��$
��Left=�$��122,187,0,0q�$	��Top=� �� *isDeletedSec+�� $��Fund Manager��.��� ���	#FFE5E5E5.+�� $
��Left=�$	��340��$��10,47,-40,0q�$	��Top=�$	��774�� �� $
��647* ��� $
��127* �.+�  -   $ FM_sec_list_dataGrid�� .  $
��Left=�$��	6,140,0,0q�$	��Top=�$	��321��   RowStyle ��  �� 
TargetType)  #System.Windows.Controls.DataGridRow"  .���  �� Property � �� �� Value
 ���� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  � ��
 � � ���  � ��
 �����	   $
 Id�� �� *Id+  $

 Name�� �� *Name+  $
 	SecTypeId�� �� *SecurityTypeId+  $
 Price�� �� *Price+  $
 Quantity�� �� *Qty+�� -   $ label2��$*��$Choose Securities from the list List��$
��Left=�$��	6,109,0,0q�$	��Top=�  -   $ FM_sec_fund_list_dataGrid�� %� IsVirtualizing .   .  $
��Left=�$��342,140,-103,0q�$	��Top=�$	��535��$��2�� �� "  .���  � ��
 ���� P�  �@J�IsMouseOver . . ���  � ��
 � � ���  � ��
 �����	   $
 Id�� �� *Id+  $

 Name�� �� *Name+  $
 	SecTypeId�� �� *SecurityTypeId+  $
 Price�� �� *Price+  $
 Quantity�� �� *Qty+  $
 MarketValue�� �� *
MktValue+  $
 TransactionCost�� �� *TransactionCost+  $
 SecWeight %�� �� *	SecWeight+�� -   $ label2_Copy��$"��Added Securities to the Fund��$
��Left=�$��340,111,0,0q�$	��Top=��� -   $ funds_comboBox��$
��Left=�$��	97,29,0,0q�$	��Top=�$	��165���� -   $ label1��$��Select Fund��$
��Left=�$��	10,25,0,0q�$	��Top=�$ -0.132,1.154&��� -    ��Name$ groupBox��$��Fund Summary��$
��Left=�$��
352,10,0,0q�$	��Top=�$	��145��$	��535��.��  -    $ fundSummary_dataGrid�� .   .  $
��Left=�$��59,5,0,0q�$	��Top=�$ 0.333,-1&�$	��405��$	��115��	   $
 TypeName�� �� *Name+  $
 TotalNumber�� �� *TotalNumber+  $
 TotalStockWeight�� �� *TotalStockWeight+  $
 TotalMktValue�� �� *TotalMktValue+