﻿#pragma checksum "..\..\..\View\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FD5F589707535336BD1CACC67E399BA4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using FundMaster;
using FundMaster.Entity;
using FundMaster.EntityDAL;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace FundMaster {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TabControl tabControl;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Copy;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FundName_txt;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGrid_Fund;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Deleted;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Deleted_checkbox;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button refresh_button;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SecurityInfo_label;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SecurityName_label;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PriceName_label;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label QuantityName_label;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SecurityAdd_btn;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox security_textBox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox secprice_textBox;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SecFundMappingGrid;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid securities_dataGrid;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label QuantityName_label_Copy;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox secQty_textBox;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SecurityRefresh_btn;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SecType_comboBox;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label SecurityInfo_label_Copy;
        
        #line default
        #line hidden
        
        
        #line 107 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label QuantityName_label_Copy1;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox security_checkBox;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FM_sec_list_dataGrid;
        
        #line default
        #line hidden
        
        
        #line 142 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2;
        
        #line default
        #line hidden
        
        
        #line 143 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid FM_sec_fund_list_dataGrid;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2_Copy;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox funds_comboBox;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 170 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GroupBox groupBox;
        
        #line default
        #line hidden
        
        
        #line 171 "..\..\..\View\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid fundSummary_dataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FundMaster;component/view/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tabControl = ((System.Windows.Controls.TabControl)(target));
            return;
            case 2:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.label_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.FundName_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.dataGrid_Fund = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.label_Deleted = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Deleted_checkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 8:
            this.refresh_button = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\View\MainWindow.xaml"
            this.refresh_button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SecurityInfo_label = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.SecurityName_label = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.PriceName_label = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.QuantityName_label = ((System.Windows.Controls.Label)(target));
            return;
            case 13:
            this.SecurityAdd_btn = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.security_textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            this.secprice_textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 16:
            this.SecFundMappingGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 17:
            this.securities_dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 18:
            this.QuantityName_label_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 19:
            this.secQty_textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 20:
            this.SecurityRefresh_btn = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\View\MainWindow.xaml"
            this.SecurityRefresh_btn.Click += new System.Windows.RoutedEventHandler(this.SecurityRefresh_btn_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.SecType_comboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 22:
            this.SecurityInfo_label_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 23:
            this.QuantityName_label_Copy1 = ((System.Windows.Controls.Label)(target));
            return;
            case 24:
            this.security_checkBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 25:
            this.FM_sec_list_dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 122 "..\..\..\View\MainWindow.xaml"
            this.FM_sec_list_dataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.FM_sec_list_dataGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 26:
            this.label2 = ((System.Windows.Controls.Label)(target));
            return;
            case 27:
            this.FM_sec_fund_list_dataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 143 "..\..\..\View\MainWindow.xaml"
            this.FM_sec_fund_list_dataGrid.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.FM_sec_fund_list_dataGrid_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 28:
            this.label2_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 29:
            this.funds_comboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 168 "..\..\..\View\MainWindow.xaml"
            this.funds_comboBox.DropDownOpened += new System.EventHandler(this.funds_comboBox_DropDownOpened);
            
            #line default
            #line hidden
            
            #line 168 "..\..\..\View\MainWindow.xaml"
            this.funds_comboBox.DropDownClosed += new System.EventHandler(this.funds_comboBox_DropDownClosed);
            
            #line default
            #line hidden
            return;
            case 30:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 31:
            this.groupBox = ((System.Windows.Controls.GroupBox)(target));
            return;
            case 32:
            this.fundSummary_dataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

