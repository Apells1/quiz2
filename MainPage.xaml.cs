using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwiperNoSwiping
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        IList<string> strList = new List<string>();
        IList<string> imageList = new List<string>();
        IList<string> answers = new List<string>();
        int index;
        string correct;
        int answer;
        public MainPage()
        {
            InitializeComponent();
            strList.Add("is this a Flower Box?");
            strList.Add("is this a cookie?");
            strList.Add("is this a Lettuce Lattice?");
            strList.Add("is this a truck?");
            imageList.Add("flower_box.jpg");
            imageList.Add("img_1.jpg");
            imageList.Add("img_2.jpg");
            imageList.Add("img_3.jpg");
            answers.Add("True");
            answers.Add("False");
            answers.Add("True");
            answers.Add("False");
            index = 0;
            answer = 0;
            correct = "";
            
        }

        void OnSwiped(object sender, SwipedEventArgs e)
        {
            theLabel.Text = e.Direction.ToString() + " " + index;
            if (e.Direction == SwipeDirection.Right)
            {
                correct = "True";
                if (correct == answers[index])
                {
                    answer += 1;
                }
                index += 1;
                // if (index >= strList.Count-1)
                // {
                //     index = -1;
                // }
                 theLabel.Text = strList[index];
                 theImage.Source = imageList[index];
            }
            else if (e.Direction == SwipeDirection.Left)
            {
                correct = "False";
                if (correct == answers[index])
                {
                    answer += 1;
                }
                
                index += 1;
                // if (index >= strList.Count-1)
                // {
                //     index = -1;
                // }
                theLabel.Text = strList[index];
                theImage.Source = imageList[index];
            }

            if (index > answers.Count)
            {
                theLabel.Text = "you got " + answer + " right!";
            }
        }

    }
}
