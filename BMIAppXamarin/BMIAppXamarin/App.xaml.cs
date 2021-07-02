﻿using BMIAppXamarin.Data;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMIAppXamarin
{
    public partial class App : Application
    {
        static UserDatabase userDB;
        static BmiDatabase bmiDB;

        public static UserDatabase UserDB
        {
            get
            {
                if (userDB == null)
                {
                    userDB = new UserDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Users.db3"));
                }
                return userDB;
            }
        }

        public static BmiDatabase BmiDB
        {
            get
            {
                if (bmiDB == null)
                {
                    bmiDB = new BmiDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "BMIs.db3"));
                }
                return bmiDB;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new Views.StartingPage();
        }

    }
}
