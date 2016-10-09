using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace NavigationPage.Tabbed
{
   public class TabPage5 : ContentPage
   {
     
      public TabPage5()
      {
         Title = "Page 5";
         Content = new StackLayout
         {
            Children = {
               new Label { Text = "Content Page 5" }
            }
         };
      }
   }
}
