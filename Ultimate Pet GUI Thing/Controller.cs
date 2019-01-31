using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate_Pet_GUI_Thing
{
    public class Controller
    {
        
        //InsertPetPage insertPetPage = new InsertPetPage();
        
        MainWindow start;
        MainPage mainPage;

        public void OpenMainWindow()
        {
            
            start.Content = mainPage;
        }

        public void OpenIPP()
        {
            Page1 page1 = new Page1(this);
            start.Content = page1;
        }

        public Controller(MainWindow v)
        {
            start = v;
            mainPage= new MainPage(this);
        }
    }
}
