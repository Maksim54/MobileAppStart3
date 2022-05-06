using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elemendide_App;
using Xamarin.Forms;

namespace MobileAppStart
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();
            StackLayout st = new StackLayout();
            Button b = new Button() 
            {
                TextColor = Color.Black,
                Text = "Open",
                BackgroundColor = Color.White
            };
            Button timer_b = new Button()
            {
                TextColor = Color.Black,
                Text = "Time",
                BackgroundColor = Color.White
            };
            timer_b.Clicked += timer_b_Clicked;
            Button box_b = new Button()
            {
                TextColor = Color.Black,
                Text = "Clicker",
                BackgroundColor = Color.White
            };
            box_b.Clicked += box_b_Clicked;
            Button box_date = new Button()
            {
                TextColor = Color.Black,
                Text = "Date/Time",
                BackgroundColor = Color.White
            };
            box_date.Clicked += box_date_Clicked;
            Button box_ss = new Button()
            {
                TextColor = Color.Black,
                Text = "Stepper/slider",
                BackgroundColor = Color.White
            };
            box_ss.Clicked += box_ss_Clicked;
            Button framebtn = new Button()
            {
                TextColor = Color.Black,
                Text = "Frame",
                BackgroundColor = Color.White
            };
            framebtn.Clicked += framebtn_Clicked;
            Button imgbtn = new Button()
            {
                TextColor = Color.Black,
                Text = "Image",
                BackgroundColor = Color.White
            };
            imgbtn.Clicked += imgbtn_Clicked;
            Button trafficbtn = new Button()
            {
                TextColor = Color.Black,
                Text = "Valgusfoor",
                BackgroundColor = Color.White
            };
            trafficbtn.Clicked += trafficbtn_Clicked;
            Button rgbbtn = new Button()
            {
                TextColor = Color.Black,
                Text = "RGB",
                BackgroundColor = Color.White
            };
            rgbbtn.Clicked += Rgbbtn_Clicked;
            Button ttt = new Button()
            {
                TextColor = Color.Black,
                Text = "Trips traps trull",
                BackgroundColor = Color.White
            };
            ttt.Clicked += Ttt_Clicked;
            Button horos = new Button()
            {
                Text = "Horoskop Page",
                BackgroundColor = Color.LightGreen,
            };

            //st = {b,timer}
            st.Children.Add(b);
            st.Children.Add(timer_b);
            st.Children.Add(box_b);
            st.Children.Add(box_date);
            st.Children.Add(box_ss);
            st.Children.Add(framebtn);
            st.Children.Add(imgbtn);
            st.Children.Add(trafficbtn);
            st.Children.Add(rgbbtn);
            st.Children.Add(ttt);
            st.Children.Add(horos);
            st.BackgroundColor = Color.Purple;
            Content = st;
            b.Clicked += B_Clicked;
            horos.Clicked += Horos_Clicked;
        }

        private async void Horos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Horoskop());
        }
        private async void Ttt_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Blank_ttt());
        }

        private async void Rgbbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RGB_View());
        }

        private async void trafficbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Svetofor());
        }
        private async void imgbtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Image_page());
        }

        private async void framebtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FramePage());
        } 
        private async void box_ss_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SliderPage());
        }

        private async void box_date_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Date());
        }

        private async void box_b_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Box_View_Page());
        }

        private async void timer_b_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Timer());
        }

        private async void B_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Entry_Page());
        }
    }
}
