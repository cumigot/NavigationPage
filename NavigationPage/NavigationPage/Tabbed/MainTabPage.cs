using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace NavigationPage.Tabbed
{
   public class MainTabPage : TabbedPage
   {
      public MainTabPage()
      {
         Children.Add(new TabPage1());
         Children.Add(new TabPage2());
         Children.Add(new TabPage3());
         Children.Add(new TabPage4());
         Children.Add(new TabPage5());
      }
   }
}
