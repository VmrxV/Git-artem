﻿#pragma checksum "..\..\..\Pages\Client.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "67EFC2E019E49451C7457060EA6AA0677F7758E8C147004B6EF94F115BD93B17"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using days2.Pages;


namespace days2.Pages {
    
    
    /// <summary>
    /// Client
    /// </summary>
    public partial class Client : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\Pages\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView list;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Pages\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Up;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button down;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Pages\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox discount;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Pages\Client.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bage;
        
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
            System.Uri resourceLocater = new System.Uri("/days2;component/pages/client.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Client.xaml"
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
            this.list = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.Up = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\Pages\Client.xaml"
            this.Up.Click += new System.Windows.RoutedEventHandler(this.Up_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.down = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Pages\Client.xaml"
            this.down.Click += new System.Windows.RoutedEventHandler(this.down_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.discount = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Bage = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\Pages\Client.xaml"
            this.Bage.Click += new System.Windows.RoutedEventHandler(this.Bage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

