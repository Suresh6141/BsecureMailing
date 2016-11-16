using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace BsecureMailing
{
    public static class Initialisation
    {
        public static WebEditor ViewMail;

        public static void RibbonComboboxFontsInitialisation()
        {
            ViewMail.RibbonComboboxFonts.ItemsSource = Fonts.SystemFontFamilies;
            ViewMail.RibbonComboboxFonts.Text = "Times New Roman";
        }

        public static void RibbonComboboxFormatInitionalisation()
        {
            ViewMail.RibbonComboboxFormat.ItemsSource = Gui.RibbonComboboxFormatInitionalisation();
            ViewMail.RibbonComboboxFormat.SelectedIndex = 0;
        }

        public static void RibbonComboboxFontSizeInitialisation()
        {
            ViewMail.RibbonComboboxFontHeight.ItemsSource = Gui.RibbonComboboxFontSizeInitialisation();
            ViewMail.RibbonComboboxFontHeight.Text = "3";
        }
    }
}
