using AminaOneProect.PartialClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace AminaOneProect.Base
{
    internal class Navigation
    {
        private static List<PartialClassComponent> components = new List<PartialClassComponent>();
        public static MainWindow mainWindow;

        public static void ClearHistory()
        {
            App.IsAdmin = false;
            components.Clear();
        }

        public static void Update(PartialClassComponent partialClassComponent)
        {
            mainWindow.TitleTb.Text = partialClassComponent.Title;
            mainWindow.BackBTN.Visibility = components.Count() > 1 ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
            mainWindow.ExitBTN.Visibility = App.IsAdmin ? System.Windows.Visibility.Visible : System.Windows.Visibility.Hidden;
            mainWindow.MyFrame.Navigate(partialClassComponent.Page);
        }
        public static void NextPage(PartialClassComponent partialClassComponent)
        {
            components.Add(partialClassComponent);
            Update(partialClassComponent);

        }

        public static void BackPage()
        {
            if (components.Count > 1)
            {
                components.RemoveAt(components.Count - 1);
                Update(components[components.Count - 1]);
            }
        }

    }


    public class PartialClassComponent
    {
        public string Title { get; set; }
        public Page Page { get; set; }

        public PartialClassComponent(string title, Page page)
        {
           Page = page;
           Title = title;
        }
    }
}
