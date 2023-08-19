using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace SimpleLogin
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       //Simplifying this method with databasefacade

        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade dbFac = new DatabaseFacade(new UserData());
            dbFac.EnsureCreated();
        }
    }
}
