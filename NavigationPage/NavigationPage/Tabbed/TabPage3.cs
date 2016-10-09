using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace NavigationPage.Tabbed
{
   public class TabPage3 : ContentPage
   {
      public TabPage3()
      {
         Title = "Page 3";
         Content = new StackLayout
         {
            Children = {
               new Label { Text = "Content Page 3" }
            }
         };
      }
   }
}
