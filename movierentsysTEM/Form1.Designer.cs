namespace movierentsys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Maintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allAvailableMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRentedMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Maintenance,
            this.searchByToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Maintenance
            // 
            this.Maintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.rentsToolStripMenuItem});
            this.Maintenance.Name = "Maintenance";
            this.Maintenance.Size = new System.Drawing.Size(50, 20);
            this.Maintenance.Text = "Maint";
            this.Maintenance.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // rentsToolStripMenuItem
            // 
            this.rentsToolStripMenuItem.Name = "rentsToolStripMenuItem";
            this.rentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rentsToolStripMenuItem.Text = "Rents";
            this.rentsToolStripMenuItem.Click += new System.EventHandler(this.rentsToolStripMenuItem_Click);
            // 
            // searchByToolStripMenuItem
            // 
            this.searchByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleToolStripMenuItem,
            this.titleToolStripMenuItem1,
            this.genreToolStripMenuItem});
            this.searchByToolStripMenuItem.Name = "searchByToolStripMenuItem";
            this.searchByToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.searchByToolStripMenuItem.Text = "Search By";
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.titleToolStripMenuItem.Text = "Title";
            this.titleToolStripMenuItem.Click += new System.EventHandler(this.titleToolStripMenuItem_Click);
            // 
            // titleToolStripMenuItem1
            // 
            this.titleToolStripMenuItem1.Name = "titleToolStripMenuItem1";
            this.titleToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.titleToolStripMenuItem1.Text = "Director";
            this.titleToolStripMenuItem1.Click += new System.EventHandler(this.titleToolStripMenuItem1_Click);
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            this.genreToolStripMenuItem.Click += new System.EventHandler(this.genreToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfUsersToolStripMenuItem,
            this.listOfMoviesToolStripMenuItem,
            this.allAvailableMoviesToolStripMenuItem,
            this.allRentedMoviesToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // listOfUsersToolStripMenuItem
            // 
            this.listOfUsersToolStripMenuItem.Name = "listOfUsersToolStripMenuItem";
            this.listOfUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOfUsersToolStripMenuItem.Text = "List of Users";
            this.listOfUsersToolStripMenuItem.Click += new System.EventHandler(this.listOfUsersToolStripMenuItem_Click);
            // 
            // listOfMoviesToolStripMenuItem
            // 
            this.listOfMoviesToolStripMenuItem.Name = "listOfMoviesToolStripMenuItem";
            this.listOfMoviesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOfMoviesToolStripMenuItem.Text = "List of Movies";
            this.listOfMoviesToolStripMenuItem.Click += new System.EventHandler(this.listOfMoviesToolStripMenuItem_Click);
            // 
            // allAvailableMoviesToolStripMenuItem
            // 
            this.allAvailableMoviesToolStripMenuItem.Name = "allAvailableMoviesToolStripMenuItem";
            this.allAvailableMoviesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allAvailableMoviesToolStripMenuItem.Text = "All Available Movies";
            this.allAvailableMoviesToolStripMenuItem.Click += new System.EventHandler(this.allAvailableMoviesToolStripMenuItem_Click);
            // 
            // allRentedMoviesToolStripMenuItem
            // 
            this.allRentedMoviesToolStripMenuItem.Name = "allRentedMoviesToolStripMenuItem";
            this.allRentedMoviesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allRentedMoviesToolStripMenuItem.Text = "All Rented Movies";
            this.allRentedMoviesToolStripMenuItem.Click += new System.EventHandler(this.allRentedMoviesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Video Club System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Maintenance;
        private ToolStripMenuItem moviesToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem rentsToolStripMenuItem;
        private ToolStripMenuItem searchByToolStripMenuItem;
        private ToolStripMenuItem titleToolStripMenuItem;
        private ToolStripMenuItem titleToolStripMenuItem1;
        private ToolStripMenuItem genreToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem listOfUsersToolStripMenuItem;
        private ToolStripMenuItem listOfMoviesToolStripMenuItem;
        private ToolStripMenuItem allAvailableMoviesToolStripMenuItem;
        private ToolStripMenuItem allRentedMoviesToolStripMenuItem;
    }
}