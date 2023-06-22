using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.Profile;
using Windows.UI.Xaml;
using WinUIThemeTest;

namespace WinUIThemeTest
{
    internal partial class Theme:ResourceDictionary
    {
        public Theme()
        {
            this.InitializeComponent();
            if (Environment.OSVersion.Version.Build >= 22000)//判断系统是否为Win11
            {
                this.MergedDictionaries.Add(new XamlControlsResources { ControlsResourcesVersion = ControlsResourcesVersion.Version2 });//添加新版本控件样式
            }
            else
            {
                this.MergedDictionaries.Add(new XamlControlsResources { ControlsResourcesVersion = ControlsResourcesVersion.Version1 });//添加旧版本控件样式
            }
        }
    }
}
