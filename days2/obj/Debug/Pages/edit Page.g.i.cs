// Updated by XamlIntelliSenseFileGenerator 25.03.2021 8:37:03
#pragma checksum "..\..\..\Pages\edit Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E7BCB07317AE5429AE61CB323E8548581B0951D87D081B7572805C860B7EB2B0"
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


namespace days2.Pages
{


    /// <summary>
    /// edit_Page
    /// </summary>
    public partial class edit_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector
    {


#line 21 "..\..\..\Pages\edit Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bage;

#line default
#line hidden


#line 25 "..\..\..\Pages\edit Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbimage;

#line default
#line hidden


#line 27 "..\..\..\Pages\edit Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbname;

#line default
#line hidden


#line 29 "..\..\..\Pages\edit Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbtime;

#line default
#line hidden


#line 31 "..\..\..\Pages\edit Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbcount;

#line default
#line hidden


#line 33 "..\..\..\Pages\edit Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Tbdiscont;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/days2;component/pages/edit%20page.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Pages\edit Page.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.bage = ((System.Windows.Controls.Button)(target));

#line 21 "..\..\..\Pages\edit Page.xaml"
                    this.bage.Click += new System.Windows.RoutedEventHandler(this.bage_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.tbimage = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.tbname = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 4:
                    this.tbtime = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 5:
                    this.tbcount = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.Tbdiscont = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:

#line 34 "..\..\..\Pages\edit Page.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.ComboBox cbimage;
    }
}
