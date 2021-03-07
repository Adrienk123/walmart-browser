namespace Custom_browser
{
    partial class Main
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
            this.bpanel = new System.Windows.Forms.Panel();
            this.dragbar = new Siticone.UI.WinForms.SiticonePanel();
            this.toptext = new Siticone.UI.WinForms.SiticoneLabel();
            this.minimizebutton = new Siticone.UI.WinForms.SiticoneButton();
            this.ExitButton = new Siticone.UI.WinForms.SiticoneButton();
            this.url = new Siticone.UI.WinForms.SiticoneTextBox();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.search = new Siticone.UI.WinForms.SiticoneButton();
            this.bpanel.SuspendLayout();
            this.dragbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bpanel
            // 
            this.bpanel.Controls.Add(this.browser);
            this.bpanel.Location = new System.Drawing.Point(-1, 56);
            this.bpanel.Name = "bpanel";
            this.bpanel.Size = new System.Drawing.Size(1558, 797);
            this.bpanel.TabIndex = 0;
            // 
            // dragbar
            // 
            this.dragbar.Controls.Add(this.search);
            this.dragbar.Controls.Add(this.url);
            this.dragbar.Controls.Add(this.toptext);
            this.dragbar.Controls.Add(this.minimizebutton);
            this.dragbar.Controls.Add(this.ExitButton);
            this.dragbar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.dragbar.Location = new System.Drawing.Point(-1, -2);
            this.dragbar.Name = "dragbar";
            this.dragbar.ShadowDecoration.Parent = this.dragbar;
            this.dragbar.Size = new System.Drawing.Size(1558, 57);
            this.dragbar.TabIndex = 1;
            this.dragbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragbar_MouseDown);
            this.dragbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragbar_MouseMove);
            // 
            // toptext
            // 
            this.toptext.BackColor = System.Drawing.Color.Transparent;
            this.toptext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toptext.ForeColor = System.Drawing.Color.White;
            this.toptext.Location = new System.Drawing.Point(706, 7);
            this.toptext.Name = "toptext";
            this.toptext.Size = new System.Drawing.Size(156, 23);
            this.toptext.TabIndex = 0;
            this.toptext.Text = "An walmart browser";
            // 
            // minimizebutton
            // 
            this.minimizebutton.CheckedState.Parent = this.minimizebutton;
            this.minimizebutton.CustomImages.Parent = this.minimizebutton;
            this.minimizebutton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.minimizebutton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizebutton.ForeColor = System.Drawing.Color.White;
            this.minimizebutton.HoveredState.Parent = this.minimizebutton;
            this.minimizebutton.Location = new System.Drawing.Point(1505, 7);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.ShadowDecoration.Parent = this.minimizebutton;
            this.minimizebutton.Size = new System.Drawing.Size(20, 20);
            this.minimizebutton.TabIndex = 1;
            this.minimizebutton.Text = "-";
            this.minimizebutton.Click += new System.EventHandler(this.minimizebutton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.CheckedState.Parent = this.ExitButton;
            this.ExitButton.CustomImages.Parent = this.ExitButton;
            this.ExitButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.HoveredState.Parent = this.ExitButton;
            this.ExitButton.Location = new System.Drawing.Point(1531, 7);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(20, 20);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // url
            // 
            this.url.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.url.DefaultText = "";
            this.url.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.url.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.url.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.url.DisabledState.Parent = this.url;
            this.url.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.url.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.url.FocusedState.Parent = this.url;
            this.url.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.url.HoveredState.Parent = this.url;
            this.url.Location = new System.Drawing.Point(72, 31);
            this.url.Name = "url";
            this.url.PasswordChar = '\0';
            this.url.PlaceholderText = "";
            this.url.SelectedText = "";
            this.url.ShadowDecoration.Parent = this.url;
            this.url.Size = new System.Drawing.Size(1483, 21);
            this.url.TabIndex = 0;
            this.url.TextChanged += new System.EventHandler(this.url_TextChanged);
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 0);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(1558, 797);
            this.browser.TabIndex = 0;
            this.browser.Url = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            // 
            // search
            // 
            this.search.CheckedState.Parent = this.search;
            this.search.CustomImages.Parent = this.search;
            this.search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(54)))));
            this.search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.HoveredState.Parent = this.search;
            this.search.Location = new System.Drawing.Point(3, 32);
            this.search.Name = "search";
            this.search.ShadowDecoration.Parent = this.search;
            this.search.Size = new System.Drawing.Size(63, 20);
            this.search.TabIndex = 4;
            this.search.Text = "Search";
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1557, 851);
            this.Controls.Add(this.dragbar);
            this.Controls.Add(this.bpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Custom Browser";
            this.bpanel.ResumeLayout(false);
            this.dragbar.ResumeLayout(false);
            this.dragbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bpanel;
        private Siticone.UI.WinForms.SiticonePanel dragbar;
        private Siticone.UI.WinForms.SiticoneButton ExitButton;
        private Siticone.UI.WinForms.SiticoneButton minimizebutton;
        private Siticone.UI.WinForms.SiticoneLabel toptext;
        private Siticone.UI.WinForms.SiticoneTextBox url;
        private System.Windows.Forms.WebBrowser browser;
        private Siticone.UI.WinForms.SiticoneButton search;
    }
}

