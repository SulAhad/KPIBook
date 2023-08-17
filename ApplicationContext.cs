using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPIBook
{
    class DataBaseContext : DbContext
    {
        public DbSet<DataBase> DataBases => Set<DataBase>();
        public DataBaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlite("Data Source=\\\\rusarstup01.lab-industries.pro\\RUSAR-DATA\\RUSAR_UW_All\\PLS_programms\\KPIBook\\bin\\Debug\\net7.0-windows\\DataBase.db");
            }
            catch(Exception ex)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.downTray.Content = ex.Message;
            }
        }
    }
}
