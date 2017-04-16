using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Core
{
    public class FileDialogs
    {
        public static SaveFileDialog saveFileDialog(string fileName, string filters)
        {
            SaveFileDialog save = new SaveFileDialog();

            if (fileName != null)
                save.FileName = fileName;

            if (filters != null)
                save.Filter = filters;

            return save;
        }
    }
}
