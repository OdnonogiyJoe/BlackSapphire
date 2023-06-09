﻿using BlackSapphire.Tools;
using BlackSapphire.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSapphire.ViewModels
{
    public class StartWindowViewModel : BaseViewModel
    {
        private object _currentPage;
        public object CurrentPage
        {
            get { return _currentPage; }
            set
            {
                _currentPage = value;
                SignalChanged("CurrentPage");
            }
        }

        #region commands
        //public CustomCommand HomePage { get; set; }
        public CustomCommand AnnouncementPage { get; set; }
        public CustomCommand ProfilePage { get; set; }

        #endregion

        public StartWindowViewModel()
        {
            //CurrentPage = new HomePage();

            //HomePage = new CustomCommand(() =>
            //{
            //    CurrentPage = new HomePage();
            //    SignalChanged("CurrentPage");
            //});

            AnnouncementPage = new CustomCommand(() =>
            {
                CurrentPage = new AnnouncementPage();
                SignalChanged("CurrentPage");
            });

            ProfilePage = new CustomCommand(() =>
            {
                CurrentPage = new ProfilePage();
                SignalChanged("CurrentPage");
            });
        }
    }
}
