using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ajaplaan
{
    public partial class Ajaplaan : ContentPage
    {
        Label l;
        TimePicker timePicker;
        Image img;
        

        public Ajaplaan()
        {
            Grid grd = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
                    new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}

                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }

            };
            l = new Label { Text = "", TextColor = Color.Gold, BackgroundColor = Color.Red , FontSize = 50 };
            grd.Children.Add(l, 0, 0);
            Grid.SetColumnSpan(l, 3);

            timePicker = new TimePicker() { Time = new TimeSpan(18, 1, 1) };
            grd.Children.Add(timePicker, 2, 1);
            timePicker.PropertyChanged += TimePicker_PropertyChanged;
            img = new Image {  };
            grd.Children.Add(img, 0, 1);
            Grid.SetColumnSpan(l, 2);
            Grid.SetColumnSpan(img, 2);
            Content = grd;
        }

        private void TimePicker_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                var time = timePicker.Time.Hours;
                if (time == 0)
                {
                    l.Text = "я сплю";
                    img.Source = "nn.jpg";
                }
                else if (time == 1)
                {
                    l.Text = "всё ещё сплю";
                    img.Source = FileImageSource.FromFile("n.jpg");
                }
                else if (time == 2)
                {
                    l.Text = "2 часа ночи, ещё время на сон";
                    img.Source = FileImageSource.FromFile("nm.jpg");
                }
                else if (time == 3)
                {
                    l.Text = "ну ещё сплю";
                    img.Source = FileImageSource.FromFile("nnn.jpg");
                }
                else if (time == 4)
                {
                    l.Text = "сон продолжается";
                    img.Source = FileImageSource.FromFile("nnnn.jpg");
                }
                else if (time == 5)
                {
                    l.Text = "эх, сладкий сон";
                    img.Source = FileImageSource.FromFile("nn.jpg");
                }
                else if (time == 6)
                {
                    l.Text = "обажаю спать";
                    img.Source = FileImageSource.FromFile("nn.jpg");
                }
                else if (time == 7)
                {
                    l.Text = "ни что не может быть лучше сна";
                    img.Source = FileImageSource.FromFile("nnnn.jpg");
                }
                else if (time == 8)
                {
                    l.Text = "сегондя выходной, а я забыл выключить будильник :(( ";
                    img.Source = FileImageSource.FromFile("nmmm.jpg");
                }
                else if (time == 9)
                {
                    l.Text = "не смог заснуть после будильника и встаю";
                    img.Source = FileImageSource.FromFile("gg.jpg");
                }
                else if (time == 10)
                {
                    l.Text = "Делаю зарядку(Кого я обманываю, я смотрю телевизор)";
                    img.Source = FileImageSource.FromFile("ш.jpg");
                }
                else if (time == 11)
                {
                    l.Text = "Вот тут честно, я играю в компьютер";
                    img.Source = FileImageSource.FromFile("tut.jpg");
                }
                else if (time == 12)
                {
                    l.Text = "Играю много";
                    img.Source = FileImageSource.FromFile("tut.jpg");
                }
                else if (time == 13)
                {
                    l.Text = "Ну очень много";
                    img.Source = FileImageSource.FromFile("tut.jpg");
                }
                else if (time == 14)
                {
                    l.Text = "Прямо максимально много";
                    img.Source = FileImageSource.FromFile("tut.jpg");
                }
                else if (time == 15)
                {
                    l.Text = "Люблю играть в компьютер";
                    img.Source = FileImageSource.FromFile("tut.jpg");
                }
                else if (time == 16)
                {
                    l.Text = "Узнаю что-то новое";
                    img.Source = FileImageSource.FromFile("op.jpg");
                }
                else if (time == 17)
                {
                    l.Text = "Смотрю видео на ютубе";
                    img.Source = FileImageSource.FromFile("op.jpg");
                }
                else if (time == 18)
                {
                    l.Text = "Работаю в визуальной студии как честный человек";
                    img.Source = FileImageSource.FromFile("op.jpg");
                }
                else if (time == 19)
                {
                    l.Text = "Гуляю";
                    img.Source = FileImageSource.FromFile("ll.jpg");
                }
                else if (time == 20)
                {
                    l.Text = "Всё ещё Гуляю";
                    img.Source = FileImageSource.FromFile("ll.jpg");
                }
                else if (time == 21)
                {
                    l.Text = "ммм...Гуляю";
                    img.Source = FileImageSource.FromFile("ll.jpg");
                }
                else if (time == 22)
                {
                    l.Text = "Весело Гулять";
                    img.Source = FileImageSource.FromFile("ll.jpg");
                }
                else if (time == 23)
                {
                    l.Text = "ложусь спать";
                    img.Source = FileImageSource.FromFile("gg.jpg");
                }
            }
        }

    }
}
