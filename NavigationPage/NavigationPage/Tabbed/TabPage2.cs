using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace NavigationPage.Tabbed
{
   public class TabPage2 : ContentPage
   {
      public TabPage2()
      {
         Title = "Page 2";
         Content = new StackLayout
         {
            Children = {
               new Label { Text = "Content Page 2" }
            }
         };
      }
   }
}
