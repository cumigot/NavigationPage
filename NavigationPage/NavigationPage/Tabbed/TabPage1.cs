using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace NavigationPage.Tabbed
{
   public class TabPage1 : ContentPage
   {
      public TabPage1()
      {
         Title = "Page 1"
;         Content = new StackLayout
         {
            Children = {
               new Label { Text = "Content Page 1" }
            }
         };
      }
   }
}
