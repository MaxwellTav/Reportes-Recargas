
namespace Reportes_Recargas
{
    partial class LoginForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Password_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.User_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.PanelForm_Control = new System.Windows.Forms.FlowLayoutPanel();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Minimize_Button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Rezise_Button = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.Title_Label = new System.Windows.Forms.Label();
            this.PanelForm_Control.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.TargetControl = this;
            // 
            // Password_Textbox
            // 
            this.Password_Textbox.Animated = true;
            this.Password_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_Textbox.DefaultText = "";
            this.Password_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_Textbox.DisabledState.Parent = this.Password_Textbox;
            this.Password_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_Textbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Password_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_Textbox.FocusedState.Parent = this.Password_Textbox;
            this.Password_Textbox.ForeColor = System.Drawing.Color.White;
            this.Password_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_Textbox.HoverState.Parent = this.Password_Textbox;
            this.Password_Textbox.Location = new System.Drawing.Point(72, 257);
            this.Password_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password_Textbox.Name = "Password_Textbox";
            this.Password_Textbox.PasswordChar = '\0';
            this.Password_Textbox.PlaceholderText = "Contraseña";
            this.Password_Textbox.SelectedText = "";
            this.Password_Textbox.ShadowDecoration.Parent = this.Password_Textbox;
            this.Password_Textbox.Size = new System.Drawing.Size(276, 36);
            this.Password_Textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Password_Textbox.TabIndex = 0;
            this.Password_Textbox.UseSystemPasswordChar = true;
            // 
            // User_Textbox
            // 
            this.User_Textbox.Animated = true;
            this.User_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_Textbox.DefaultText = "";
            this.User_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.User_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.User_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User_Textbox.DisabledState.Parent = this.User_Textbox;
            this.User_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User_Textbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.User_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User_Textbox.FocusedState.Parent = this.User_Textbox;
            this.User_Textbox.ForeColor = System.Drawing.Color.White;
            this.User_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User_Textbox.HoverState.Parent = this.User_Textbox;
            this.User_Textbox.Location = new System.Drawing.Point(72, 193);
            this.User_Textbox.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.User_Textbox.Name = "User_Textbox";
            this.User_Textbox.PasswordChar = '\0';
            this.User_Textbox.PlaceholderText = "Usuario";
            this.User_Textbox.SelectedText = "";
            this.User_Textbox.ShadowDecoration.Parent = this.User_Textbox;
            this.User_Textbox.Size = new System.Drawing.Size(276, 36);
            this.User_Textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.User_Textbox.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(0, 394);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(420, 96);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Iniciar Sesión";
            // 
            // PanelForm_Control
            // 
            this.PanelForm_Control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelForm_Control.Controls.Add(this.Exit_Button);
            this.PanelForm_Control.Controls.Add(this.Minimize_Button);
            this.PanelForm_Control.Controls.Add(this.Rezise_Button);
            this.PanelForm_Control.Location = new System.Drawing.Point(320, 4);
            this.PanelForm_Control.Name = "PanelForm_Control";
            this.PanelForm_Control.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PanelForm_Control.Size = new System.Drawing.Size(95, 28);
            this.PanelForm_Control.TabIndex = 5;
            // 
            // Exit_Button
            // 
            this.Exit_Button.CheckedState.Parent = this.Exit_Button;
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.No;
            this.Exit_Button.CustomImages.Parent = this.Exit_Button;
            this.Exit_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.HoverState.Parent = this.Exit_Button;
            this.Exit_Button.Location = new System.Drawing.Point(70, 3);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(20, 20);
            this.Exit_Button.TabIndex = 0;
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.CheckedState.Parent = this.Minimize_Button;
            this.Minimize_Button.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.Minimize_Button.CustomImages.Parent = this.Minimize_Button;
            this.Minimize_Button.FillColor = System.Drawing.Color.DimGray;
            this.Minimize_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Minimize_Button.ForeColor = System.Drawing.Color.White;
            this.Minimize_Button.HoverState.Parent = this.Minimize_Button;
            this.Minimize_Button.Location = new System.Drawing.Point(44, 3);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Minimize_Button.ShadowDecoration.Parent = this.Minimize_Button;
            this.Minimize_Button.Size = new System.Drawing.Size(20, 20);
            this.Minimize_Button.TabIndex = 3;
            // 
            // Rezise_Button
            // 
            this.Rezise_Button.Animated = true;
            this.Rezise_Button.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rezise_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Rezise_Button.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Rezise_Button.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Rezise_Button.CheckedState.Parent = this.Rezise_Button;
            this.Rezise_Button.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.Rezise_Button.Location = new System.Drawing.Point(3, 3);
            this.Rezise_Button.Name = "Rezise_Button";
            this.Rezise_Button.ShadowDecoration.Parent = this.Rezise_Button;
            this.Rezise_Button.Size = new System.Drawing.Size(35, 20);
            this.Rezise_Button.TabIndex = 2;
            this.Rezise_Button.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rezise_Button.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Rezise_Button.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.Rezise_Button.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.Rezise_Button.UncheckedState.Parent = this.Rezise_Button;
            // 
            // Title_Label
            // 
            this.Title_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_Label.Location = new System.Drawing.Point(3, 78);
            this.Title_Label.Name = "Title_Label";
            this.Title_Label.Size = new System.Drawing.Size(415, 48);
            this.Title_Label.TabIndex = 4;
            this.Title_Label.Text = "Login";
            this.Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(420, 490);
            this.Controls.Add(this.PanelForm_Control);
            this.Controls.Add(this.Title_Label);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.User_Textbox);
            this.Controls.Add(this.Password_Textbox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.PanelForm_Control.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2TextBox Password_Textbox;
        private System.Windows.Forms.FlowLayoutPanel PanelForm_Control;
        private Guna.UI2.WinForms.Guna2CircleButton Exit_Button;
        private Guna.UI2.WinForms.Guna2CircleButton Minimize_Button;
        private Guna.UI2.WinForms.Guna2ToggleSwitch Rezise_Button;
        private System.Windows.Forms.Label Title_Label;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox User_Textbox;
    }
}

