using Boomsa.WPF.BaseLib.Services.Interfaces;

using Microsoft.Win32;

using System.Collections.Generic;
using System.Linq;

namespace Boomsa.WPF.BaseLib.Services
{
    internal class UserFileDialog : IUserFileDialog
    {
        public bool OpenFiles(string title, out IEnumerable<string> selectdFiles, string filter = "Все файлы (*.*)|*.*")
        {
            var file_dialog = new OpenFileDialog()
            {
                Title = title,
                Filter = filter
            };
            if (file_dialog.ShowDialog() != true)
            {
                selectdFiles = Enumerable.Empty<string>();
                return false;
            }
            selectdFiles = file_dialog.FileNames;
            return true;
        }
        public bool OpenFile(string title, out string selectdFile, string filter = "Все файлы (*.*)|*.*")
        {
            var file_dialog = new OpenFileDialog()
            {
                Title = title,
                Filter = filter
            };
            if (file_dialog.ShowDialog() != true)
            {
                selectdFile = null;
                return false;
            }
            selectdFile = file_dialog.FileName;
            return true;
        }
        public bool SaveFile(string title, out string selectdFile, string defaultFileName = null, string filter = "Все файлы (*.*)|*.*")
        {


            var file_dialog = new SaveFileDialog()
            {
                Title = title,
                Filter = filter
            };
            if (defaultFileName != null)
                file_dialog.FileName = defaultFileName;
            if (file_dialog.ShowDialog() != true)
            {
                selectdFile = null;
                return false;
            }
            selectdFile = file_dialog.FileName;
            return true;
        }
    }
}
