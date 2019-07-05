using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace week3
{
    //InitializeComponent();
    //rbkgs.IsChecked == true;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            rbkgs.IsChecked = true;
        }
        private void DoIt_Click (object sender, RoutedEventArgs e)
        {
            double myMass;
            double myWeight;
            if (double.TryParse(Mass_inputBox.Text, out myMass))
            {
                if (rbgms.IsChecked == true)
                {
                    myMass = myMass / 1000;
                }

                myWeight = myMass * 9.8;
                lblResult.Content = "The weight is " + myWeight + " Newtons.";

                if (myWeight >= 1000)
                {
                    lblComplain.Content = "Too heavy!";
                }
                else if (myWeight <= 10)
                {
                    lblComplain.Content = "Too light!";
                }

                else
                {
                    lblComplain.Content = "";
                }
        
            }
            else
                lblResult.Content = "That's not a number! Try again";
                lblComplain.Content = "";
        }

        private void Clear_Click (object sender, RoutedEventArgs e)
        {
            rbkgs.IsChecked = true;
            lblResult.Content = "";
            lblComplain.Content = "";
            Mass_inputBox.Text = "";
        }

    }
}
