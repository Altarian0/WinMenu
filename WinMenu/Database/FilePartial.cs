using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WinMenu.Database
{
    partial class File
    {
        public BitmapImage IconSource
        {
            get
            {
                if (Icon == null || Icon == "" || new FileInfo(Icon).Extension != ".png")
                    return null;

                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(Icon, UriKind.RelativeOrAbsolute);
                bitmap.EndInit();

                return bitmap;

            }
        }


    }
}
