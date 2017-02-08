using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Digital_Clock
{
    public class get_font
    {
        public static void get(List<string>CB)
        {
            //InstalledFontCollectionオブジェクトの取得
            System.Drawing.Text.InstalledFontCollection InstalledFont =
                new System.Drawing.Text.InstalledFontCollection();

            //インストール済みフォントを取得
            FontFamily[] FontFamilies = InstalledFont.Families;

            foreach (FontFamily f in FontFamilies)
                CB.Add(f.Name);
        }
    }
}
