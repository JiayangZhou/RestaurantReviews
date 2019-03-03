using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantReviews
{
    public partial class ShabbyBoard : Form
    {
        public ShabbyBoard()
        {
            InitializeComponent();
            trackLogTextBox.ReadOnly=true;
            trackLogTextBox.AppendText("Hi, I'm the manager of this restaurant that you just enjoyed your meal! I'd like to invite you to" 
                 + " leave your overall reivews to this restaurant so we will give you a free meal next time! Btw, you can pick up a nickname for yourself!"  + "\r\n");
            LoadReviewsToListView();

        }

        TextConnector connector = new TextConnector();
        public List<Review> avaliableReviews = new List<Review>();

        
        private void LoadReviewsToListView()
        {
            avaliableReviews = connector.GetAllReviews();
            reviewListView.Items.Clear();
            reviewListView.View = View.Details;

            foreach (Review review in avaliableReviews)
            {
                reviewListView.Items.Add(new ListViewItem(new[] { $"{review.Nickname}", $"{review.ReviewContext}" }));
            }
            reviewListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            reviewListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            reviewListView.GridLines = true;
            reviewListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            

        }

        private bool ValidateForm()
        {
            if (nicknameValue.Text.Length == 0)
            {
                return false;
            }
            if (yourReviewValue.Text.Length == 0)
            {
                return false;
            }
            trackLogTextBox.AppendText("-----------------------------------------------------\r\n"+"Excellent! You have filled up your name and review. Please press OK to see your review!" + "\r\n");
            return true;
        }


        private void postItButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                trackLogTextBox.AppendText("-----------------------------------------------------\r\n" + "Oh no, you either didn't pick your nickname or didn't leave review. Please press OK and redo it!" + "\r\n");
                MessageBox.Show("Invalid data");
                
            }
            else
            {
                Review reviews = new Review(nicknameValue.Text, yourReviewValue.Text);

                MessageBox.Show("Review posted");
                nicknameValue.Text = "";
                yourReviewValue.Text = "";
                connector.CreateReviews(reviews);
                LoadReviewsToListView();
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            trackLogTextBox.AppendText("-----------------------------------------------------\r\n" + "Sorry! You don't have the permession to delete the reviews. Please find a stuff to help!" + "\r\n");
        }
    }
}