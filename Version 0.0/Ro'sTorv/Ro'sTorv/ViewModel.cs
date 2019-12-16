using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ro_sTorv
{
    class ViewModel
    {
        public ObservableCollection<Model> Models { get; set; }
        public static string Name { get; set; }

        public ViewModel()
        {
            Models = new ObservableCollection<Model>()
            {
                new Model("Test1"),
                new Model("Test2"),
            };
            Models.Add(new Model("Test3"));

        }

        public void Add()
        {
            Models.Add(new Model(Name));

        }



        //public void LogIn(String Username, String Password)
        //{
        //    String username = Username;
        //    String password = Password;

        //    if()
        //}

    }
}
