using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ApplicationWPFProject.Model;
using ApplicationWPFProject.Infrastructure;
using System.Windows;
namespace ApplicationWPFProject.ViewModel
{
    public class MainViewModel : NotifyViewModel
    {
        private ICommand m_sendCommand;
        private string m_customText;

        public ICommand CmdSend => m_sendCommand;


        public MainViewModel()
        {
            m_sendCommand = new DelegateCommand(Send);
        }

        private void Send()
        {
            CustomText = "1000";
        }
        public string CustomText
        {
            get
            {
                return m_customText;
            }
            set
            {
                m_customText = value;
                OnPropertyChanged("CustomText");

            }
        }

    }
}
