using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Group_Project_106._2
{
    /// <summary>
    /// Interaction logic for user_vac.xaml
    /// </summary>
    /// 

    public delegate void vacPageEvent();

    public partial class user_vac : UserControl
    {

        public event vacPageEvent Destoryed;
        public user_vac()
        {
            InitializeComponent();

            List<User> users;

            using (IDbConnection connection = new SQLiteConnection(globals.source))
            {
                connection.Open();
                var x = connection.Query<User>("select * from Users");
                users = x.ToList();
            }

            for (int i = 0; i < users.Count; i++)
            {
                User user = users[i];

                TextBlock numberText = new TextBlock
                {
                    Text = (i + 1).ToString(),
                    FontWeight = FontWeights.Bold,
                };

                TextBlock usernameText = new TextBlock
                {
                    Text = user.username,
                    FontWeight = FontWeights.Bold,
                };

                TextBlock cityText = new TextBlock
                {
                    Text = user.city,
                    FontWeight = FontWeights.Bold,
                };

                TextBlock statusText = new TextBlock
                {
                    FontWeight = FontWeights.Bold,
                };

                if(user.vaccinated == 1)
                {
                    statusText.Text = "Vaccinated";
                    statusText.Foreground = Brushes.Green;
                }
                else
                {
                    statusText.Text = "Unvaccinated";
                    statusText.Foreground = Brushes.Red;
                }



                Grid.SetRow(numberText, i+1);
                Grid.SetColumn(numberText, 0);

                Grid.SetRow(usernameText, i + 1);
                Grid.SetColumn(usernameText, 1);

                Grid.SetRow(cityText, i + 1);
                Grid.SetColumn(cityText, 2);

                Grid.SetRow(statusText, i + 1);
                Grid.SetColumn(statusText, 3);

                user_grid.Children.Add(numberText);
                user_grid.Children.Add(usernameText);
                user_grid.Children.Add(cityText);
                user_grid.Children.Add(statusText);
            }
        }

        private void backBtn(object sender, RoutedEventArgs e)
        {
            Destoryed?.Invoke();
        }
    }
}
