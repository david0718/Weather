﻿#pragma checksum "..\..\RestHolidaySetting.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B05055FD95280FD13F50BC4F7A66E4C9"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
using WeatherCalendar;
using YUI.Controls;


namespace WeatherCalendar {
    
    
    /// <summary>
    /// RestHolidaySetting
    /// </summary>
    public partial class RestHolidaySetting : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 69 "..\..\RestHolidaySetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox yearComboBox;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\RestHolidaySetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox mouthComboBox;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\RestHolidaySetting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal WeatherCalendar.Calendar calendar;
        
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
            System.Uri resourceLocater = new System.Uri("/WeatherCalendar;component/restholidaysetting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\RestHolidaySetting.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 11 "..\..\RestHolidaySetting.xaml"
            ((WeatherCalendar.RestHolidaySetting)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.GetCityWindow_OnMouseLeftButtonDown);
            
            #line default
            #line hidden
            
            #line 12 "..\..\RestHolidaySetting.xaml"
            ((WeatherCalendar.RestHolidaySetting)(target)).Loaded += new System.Windows.RoutedEventHandler(this.RestHolidaySetting_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\RestHolidaySetting.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.CloseWindowCommand_CanExecute);
            
            #line default
            #line hidden
            
            #line 15 "..\..\RestHolidaySetting.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.CloseWindowCommand_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.yearComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 71 "..\..\RestHolidaySetting.xaml"
            this.yearComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.YearComboBox_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 75 "..\..\RestHolidaySetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LastButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.mouthComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 82 "..\..\RestHolidaySetting.xaml"
            this.mouthComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.MouthComboBox_OnSelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 85 "..\..\RestHolidaySetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.NextButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 7:
            this.calendar = ((WeatherCalendar.Calendar)(target));
            return;
            case 8:
            
            #line 113 "..\..\RestHolidaySetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ChangeCityButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 142 "..\..\RestHolidaySetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.UpdateWeatherButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 172 "..\..\RestHolidaySetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StopWatchButton_OnClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 189 "..\..\RestHolidaySetting.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.TodayButton_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

