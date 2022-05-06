using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppStart
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Blank_ttt : ContentPage
    {
        Label[,] tic = new Label[3, 3];
        string l;
        Label lbl;
        Button change, restart, man;
        public Blank_ttt()
        {
            Grid();
            stps = 0;
            man.IsEnabled = true;
        }
        //InitializeComponent();
        void Grid()
        {
            stps = 0;
            Grid grid = new Grid();
            for (int h = 0; h < 3; h++)
            {
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
                grid.BackgroundColor = Color.FromRgb(255, 255, 255);
            }
            for (int w = 0; w < 3; w++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }
            change = new Button
            {
                Text = "Juhuslik mängija"
            };
            change.Clicked += Change_Clicked;
            grid.Children.Add(change, 0, 3);
            grid.BackgroundColor = Color.FromRgb(120, 120, 120);

            restart = new Button
            {
                Text = "Alusta uuesti"
            };
            restart.Clicked += Restart_Clicked;
            grid.Children.Add(restart, 1, 3);
            grid.BackgroundColor = Color.FromRgb(120, 120, 120);

            man = new Button
            {
                Text = "Märgi valik"
            };
            man.Clicked += Man_Clicked;
            grid.Children.Add(man, 2, 3);
            grid.BackgroundColor = Color.FromRgb(120, 120, 120);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    lbl = new Label
                    {
                        BackgroundColor = Color.FromRgb(255, 255, 255),
                        FontSize = 100,
                        Text = "",
                        HorizontalTextAlignment = TextAlignment.Center,
                        TextColor = Color.FromRgb(0, 255, 96),
                        VerticalTextAlignment = TextAlignment.Center,
                    };
                    tic[i, j] = lbl;
                    l = "X";
                    var tap = new TapGestureRecognizer();
                    tap.Tapped += Tap_Tapped;
                    grid.Children.Add(lbl, i, j);
                    lbl.GestureRecognizers.Add(tap);
                }
            }

            Content = grid;
        }

        private void Restart_Clicked(object sender, EventArgs e)
        {
            Grid();
            chck = 0;
            stps = 0;
        }

        private async void Man_Clicked(object sender, EventArgs e)
        {
            string choice = await DisplayActionSheet("Kes alustab?", "X", "O", "Valige märk");

            if (choice == "X")
            {
                chck = 2;
                change.Text = "X";
                man.IsEnabled = false;

            }
            else if (choice == "O")
            {

                chck = 1;
                change.Text = "O";
                man.IsEnabled = false;

            }

            else
            {
                man.IsEnabled = true;
            }
        }
        private void Tap_Tapped(object sender, EventArgs e)

        {
            Label label = sender as Label;
            if (chck % 2 == 0)
            {
                change.Text = "O";
                label.Text = l;
                chck++;
                stps++;
            }
            else if (chck % 2 != 0)
            {
                change.Text = "X";
                chck++;
                stps++;
                label.Text = "O";
            }
            if (check() == true)
            {
                DisplayAlert("Mäng läbi!", "Viik", "Uus mäng");
                Grid();
                stps = 0;
            }

            else if (checkY() == true)
            {
                DisplayAlert("Mäng läbi!", win, "Uus mäng");
                Grid();
            }
            else if (checkX() == true)
            {
                DisplayAlert("Mäng läbi!", win, "Uus mäng");
                Grid();
            }
            else if (checkXY() == true)
            {
                DisplayAlert("Mäng läbi!", win, "Uus mäng");
                Grid();
            }
        }
        bool check() //Ничья
        {
            if (stps == 9)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        string win = "";
        bool checkY() //Победа по вертикали
        {

            if (tic[0, 0].Text == "X" && tic[0, 1].Text == "X" && tic[0, 2].Text == "X")
            {
                win = "Võitis X";
                return true;
            }

            else if (tic[1, 0].Text == "X" && tic[1, 1].Text == "X" && tic[1, 2].Text == "X")
            {
                win = "Võitis X";
                return true;
            }

            else if (tic[2, 0].Text == "O" && tic[2, 1].Text == "O" && tic[2, 2].Text == "X")
            {
                win = "Võitis X";
                return true;
            }

            else if (tic[0, 0].Text == "O" && tic[0, 1].Text == "O" && tic[0, 2].Text == "O")
            {
                win = "Võitis O";
                return true;
            }

            else if (tic[1, 0].Text == "O" && tic[1, 1].Text == "0" && tic[1, 2].Text == "O")
            {
                win = "Võitis O";
                return true;
            }

            else if (tic[2, 0].Text == "O" && tic[2, 1].Text == "X" && tic[2, 2].Text == "O")
            {
                win = "Võitis O";
                return true;
            }
            else
            {
                return false;
            }
        }
        bool checkX() //Победа по горизонтали
        {
            if (tic[0, 0].Text == "X" && tic[1, 0].Text == "X" && tic[2, 0].Text == "X")
            {
                win = "Võitis X";
                return true;
            }
            else if (tic[0, 1].Text == "X" && tic[1, 1].Text == "X" && tic[2, 1].Text == "X")
            {
                win = "Võitis X";
                return true;
            }
            else if (tic[0, 2].Text == "X" && tic[1, 2].Text == "X" && tic[2, 2].Text == "X")
            {
                win = "Võitis X";
                return true;
            }
            else if (tic[0, 0].Text == "O" && tic[1, 0].Text == "O" && tic[2, 0].Text == "O")
            {
                win = "Võitis O";
                return true;
            }
            else if (tic[0, 1].Text == "O" && tic[1, 1].Text == "O" && tic[2, 1].Text == "O")
            {
                win = "Võitis O";
                return true;
            }
            else if (tic[0, 2].Text == "O" && tic[1, 2].Text == "O" && tic[2, 2].Text == "O")
            {
                win = "Võitis O";
                return true;
            }
            else
            {
                return false;
            }
        }
        bool checkXY() //Победа по диагонали
        {
            if (tic[0, 0].Text == "X" && tic[1, 1].Text == "X" && tic[2, 2].Text == "X")
            {
                win = "Võitis X";
                return true; ;
            }
            else if (tic[2, 0].Text == "X" && tic[1, 1].Text == "X" && tic[0, 2].Text == "X")
            {
                win = "Võitis X";
                return true;
            }
            else if (tic[0, 0].Text == "O" && tic[1, 1].Text == "O" && tic[2, 2].Text == "O")
            {
                win = "Võitis O";
                return true; ;
            }
            else if (tic[2, 0].Text == "O" && tic[1, 1].Text == "O" && tic[0, 2].Text == "O")
            {
                win = "Võitis O";
                return true;
            }
            else
            {
                return false;
            }
        }
        int stps = 0;
        Random rnd = new Random();
        int chck = 0;
        private void Change_Clicked(object sender, EventArgs e)
        {
            chck = rnd.Next(0, 2);
            if (chck % 2 == 0)
            {
                change.Text = "X";
            }
            else if (chck % 2 != 0)
            {
                change.Text = "O";
            }

        }
    }
}