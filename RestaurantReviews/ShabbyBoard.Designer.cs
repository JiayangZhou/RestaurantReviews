namespace RestaurantReviews
{
    partial class ShabbyBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.addNewPostGroupBox = new System.Windows.Forms.GroupBox();
            this.yourReview = new System.Windows.Forms.Label();
            this.postItButton = new System.Windows.Forms.Button();
            this.yourReviewValue = new System.Windows.Forms.TextBox();
            this.nicknameValue = new System.Windows.Forms.TextBox();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.trackLogTextBox = new System.Windows.Forms.TextBox();
            this.trackLogLabel = new System.Windows.Forms.Label();
            this.reviewsLabel = new System.Windows.Forms.Label();
            this.reviewListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addNewPostGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addNewPostGroupBox
            // 
            this.addNewPostGroupBox.Controls.Add(this.yourReview);
            this.addNewPostGroupBox.Controls.Add(this.postItButton);
            this.addNewPostGroupBox.Controls.Add(this.yourReviewValue);
            this.addNewPostGroupBox.Controls.Add(this.nicknameValue);
            this.addNewPostGroupBox.Controls.Add(this.nicknameLabel);
            this.addNewPostGroupBox.Location = new System.Drawing.Point(236, 24);
            this.addNewPostGroupBox.Name = "addNewPostGroupBox";
            this.addNewPostGroupBox.Size = new System.Drawing.Size(404, 298);
            this.addNewPostGroupBox.TabIndex = 25;
            this.addNewPostGroupBox.TabStop = false;
            this.addNewPostGroupBox.Text = "Add New Post";
            // 
            // yourReview
            // 
            this.yourReview.AutoSize = true;
            this.yourReview.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.yourReview.Location = new System.Drawing.Point(16, 112);
            this.yourReview.Name = "yourReview";
            this.yourReview.Size = new System.Drawing.Size(113, 25);
            this.yourReview.TabIndex = 35;
            this.yourReview.Text = "Your Review";
            // 
            // postItButton
            // 
            this.postItButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.postItButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.postItButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.postItButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postItButton.Location = new System.Drawing.Point(99, 248);
            this.postItButton.Name = "postItButton";
            this.postItButton.Size = new System.Drawing.Size(214, 44);
            this.postItButton.TabIndex = 27;
            this.postItButton.Text = "Post It";
            this.postItButton.UseVisualStyleBackColor = true;
            this.postItButton.Click += new System.EventHandler(this.postItButton_Click);
            // 
            // yourReviewValue
            // 
            this.yourReviewValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourReviewValue.Location = new System.Drawing.Point(139, 112);
            this.yourReviewValue.Multiline = true;
            this.yourReviewValue.Name = "yourReviewValue";
            this.yourReviewValue.Size = new System.Drawing.Size(202, 91);
            this.yourReviewValue.TabIndex = 34;
            // 
            // nicknameValue
            // 
            this.nicknameValue.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.nicknameValue.Location = new System.Drawing.Point(139, 49);
            this.nicknameValue.Name = "nicknameValue";
            this.nicknameValue.Size = new System.Drawing.Size(113, 31);
            this.nicknameValue.TabIndex = 28;
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicknameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nicknameLabel.Location = new System.Drawing.Point(16, 44);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(99, 25);
            this.nicknameLabel.TabIndex = 27;
            this.nicknameLabel.Text = "NickName";
            // 
            // deleteButton
            // 
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.deleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(918, 560);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 44);
            this.deleteButton.TabIndex = 37;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // trackLogTextBox
            // 
            this.trackLogTextBox.Location = new System.Drawing.Point(12, 68);
            this.trackLogTextBox.Multiline = true;
            this.trackLogTextBox.Name = "trackLogTextBox";
            this.trackLogTextBox.Size = new System.Drawing.Size(173, 396);
            this.trackLogTextBox.TabIndex = 36;
            // 
            // trackLogLabel
            // 
            this.trackLogLabel.AutoSize = true;
            this.trackLogLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackLogLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.trackLogLabel.Location = new System.Drawing.Point(12, 24);
            this.trackLogLabel.Name = "trackLogLabel";
            this.trackLogLabel.Size = new System.Drawing.Size(91, 25);
            this.trackLogLabel.TabIndex = 36;
            this.trackLogLabel.Text = "Track Log";
            // 
            // reviewsLabel
            // 
            this.reviewsLabel.AutoSize = true;
            this.reviewsLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.reviewsLabel.Location = new System.Drawing.Point(676, 24);
            this.reviewsLabel.Name = "reviewsLabel";
            this.reviewsLabel.Size = new System.Drawing.Size(78, 25);
            this.reviewsLabel.TabIndex = 38;
            this.reviewsLabel.Text = "Reviews";
            // 
            // reviewListView
            // 
            this.reviewListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.reviewListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.reviewListView.Location = new System.Drawing.Point(681, 73);
            this.reviewListView.Name = "reviewListView";
            this.reviewListView.Size = new System.Drawing.Size(311, 391);
            this.reviewListView.TabIndex = 39;
            this.reviewListView.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nickname";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Review";
            this.columnHeader2.Width = 100;
            // 
            // ShabbyBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 607);
            this.Controls.Add(this.reviewListView);
            this.Controls.Add(this.reviewsLabel);
            this.Controls.Add(this.trackLogLabel);
            this.Controls.Add(this.trackLogTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addNewPostGroupBox);
            this.Name = "ShabbyBoard";
            this.Text = "ShabbyBoard";
            this.addNewPostGroupBox.ResumeLayout(false);
            this.addNewPostGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox addNewPostGroupBox;
        private System.Windows.Forms.Label yourReview;
        private System.Windows.Forms.Button postItButton;
        private System.Windows.Forms.TextBox yourReviewValue;
        private System.Windows.Forms.TextBox nicknameValue;
        private System.Windows.Forms.Label nicknameLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox trackLogTextBox;
        private System.Windows.Forms.Label trackLogLabel;
        private System.Windows.Forms.Label reviewsLabel;
        private System.Windows.Forms.ListView reviewListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

