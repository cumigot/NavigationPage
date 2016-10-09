using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace NavigationPage.Tabbed
{
   public class TabPage4 : ContentPage
   {
      public TabPage4()
      {
         Title = "Page 4";
         Content = new StackLayout
         {
            Children = {
               new Label { Text = "Content Page 4" }
            }
         };
      }
   }
}
