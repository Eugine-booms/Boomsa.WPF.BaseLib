using Boomsa.WPF.BaseLib.Services.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Boomsa.WPF.BaseLib.Services
{
    class UserDialog : IUserDialog
    {
        public bool ConfirmInformation_YesNo(string information, string title)
        {
            var message = MessageBox.Show(information, title, MessageBoxButton.YesNo, MessageBoxImage.Information);
            return message == MessageBoxResult.Yes;
        }
        public bool Warninng_YesNo(string information, string title)
        {
            var message = MessageBox.Show(information, title, MessageBoxButton.YesNo, MessageBoxImage.Warning);
            return message == MessageBoxResult.Yes;
        }
        public bool Error_YesNo(string information, string title)
        {
            var message = MessageBox.Show(information, title, MessageBoxButton.YesNo, MessageBoxImage.Error);
            return message == MessageBoxResult.Yes;
        }
        public void Warning_OK(string title, string message) => MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Warning);
        public void Error_OK(string title, string message) => MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Error);
        public void Information_OK(string title, string message) => MessageBox.Show(message, title, MessageBoxButton.OK, MessageBoxImage.Information);
    }
}
