namespace LeerXmlEstructura
{
    partial class Frm_Principal
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
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objTreeView = new System.Windows.Forms.TreeView();
            this.objListView = new System.Windows.Forms.ListView();
            this.objTextBox = new System.Windows.Forms.TextBox();
            this.objDataGridView = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Menu;
            this.panel.Controls.Add(this.objDataGridView);
            this.panel.Controls.Add(this.objTextBox);
            this.panel.Controls.Add(this.objListView);
            this.panel.Controls.Add(this.objTreeView);
            this.panel.Controls.Add(this.menuStrip1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1055, 530);
            this.panel.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MintCream;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.opcionesXmlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesXmlToolStripMenuItem
            // 
            this.opcionesXmlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.opcionesXmlToolStripMenuItem.Name = "opcionesXmlToolStripMenuItem";
            this.opcionesXmlToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.opcionesXmlToolStripMenuItem.Text = "Opciones Xml";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // objTreeView
            // 
            this.objTreeView.Location = new System.Drawing.Point(12, 27);
            this.objTreeView.Name = "objTreeView";
            this.objTreeView.Size = new System.Drawing.Size(431, 252);
            this.objTreeView.TabIndex = 1;
            // 
            // objListView
            // 
            this.objListView.HideSelection = false;
            this.objListView.Location = new System.Drawing.Point(12, 286);
            this.objListView.Name = "objListView";
            this.objListView.Size = new System.Drawing.Size(431, 218);
            this.objListView.TabIndex = 2;
            this.objListView.UseCompatibleStateImageBehavior = false;
            // 
            // objTextBox
            // 
            this.objTextBox.Location = new System.Drawing.Point(449, 28);
            this.objTextBox.Multiline = true;
            this.objTextBox.Name = "objTextBox";
            this.objTextBox.Size = new System.Drawing.Size(594, 252);
            this.objTextBox.TabIndex = 3;
            // 
            // objDataGridView
            // 
            this.objDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.objDataGridView.Location = new System.Drawing.Point(449, 286);
            this.objDataGridView.Name = "objDataGridView";
            this.objDataGridView.Size = new System.Drawing.Size(594, 218);
            this.objDataGridView.TabIndex = 4;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 530);
            this.Controls.Add(this.panel);
            this.Name = "Frm_Principal";
            this.Text = "Desglozando un Xml";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesXmlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ListView objListView;
        private System.Windows.Forms.TreeView objTreeView;
        private System.Windows.Forms.DataGridView objDataGridView;
        private System.Windows.Forms.TextBox objTextBox;
    }
}