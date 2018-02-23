namespace Cookie_Clicker
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.biscotti = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.potenziamentiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.potenziamento1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.potenziamento2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrimoTimer = new System.Windows.Forms.Timer(this.components);
            this.debug = new System.Windows.Forms.Label();
            this.aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaddddddddddddddddddddffffffffffffffffffffgggggggggggggggggghhhhhhhhhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SecondoTimer = new System.Windows.Forms.Timer(this.components);
            this.cheatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biscottiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biscottiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.biscottiToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.kBsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TerzoTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(178, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 167);
            this.button1.TabIndex = 0;
            this.button1.Text = "CLICCA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Biscotti:";
            // 
            // biscotti
            // 
            this.biscotti.AutoSize = true;
            this.biscotti.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biscotti.Location = new System.Drawing.Point(334, 96);
            this.biscotti.Name = "biscotti";
            this.biscotti.Size = new System.Drawing.Size(39, 33);
            this.biscotti.TabIndex = 2;
            this.biscotti.Text = "...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.potenziamentiToolStripMenuItem1,
            this.cheatsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // potenziamentiToolStripMenuItem1
            // 
            this.potenziamentiToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.potenziamento1ToolStripMenuItem2,
            this.potenziamento2ToolStripMenuItem,
            this.aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaddddddddddddddddddddffffffffffffffffffffgggggggggggggggggghhhhhhhhhToolStripMenuItem,
            this.kBsToolStripMenuItem});
            this.potenziamentiToolStripMenuItem1.Name = "potenziamentiToolStripMenuItem1";
            this.potenziamentiToolStripMenuItem1.Size = new System.Drawing.Size(95, 20);
            this.potenziamentiToolStripMenuItem1.Text = "potenziamenti";
            // 
            // potenziamento1ToolStripMenuItem2
            // 
            this.potenziamento1ToolStripMenuItem2.Name = "potenziamento1ToolStripMenuItem2";
            this.potenziamento1ToolStripMenuItem2.Size = new System.Drawing.Size(420, 22);
            this.potenziamento1ToolStripMenuItem2.Text = "Aiuto click (200 Bs): aggiunge 5 biscotti ogni secondo";
            this.potenziamento1ToolStripMenuItem2.Click += new System.EventHandler(this.potenziamento1ToolStripMenuItem2_Click);
            // 
            // potenziamento2ToolStripMenuItem
            // 
            this.potenziamento2ToolStripMenuItem.Name = "potenziamento2ToolStripMenuItem";
            this.potenziamento2ToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.potenziamento2ToolStripMenuItem.Text = "Scarica di click(750 Bs): Aggiunge 30 Bs ogni 10 secondi";
            this.potenziamento2ToolStripMenuItem.Click += new System.EventHandler(this.potenziamento2ToolStripMenuItem_Click);
            // 
            // PrimoTimer
            // 
            this.PrimoTimer.Interval = 1000;
            this.PrimoTimer.Tick += new System.EventHandler(this.PrimoTimer_Tick);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debug.Location = new System.Drawing.Point(259, 368);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(39, 33);
            this.debug.TabIndex = 6;
            this.debug.Text = "...";
            // 
            // aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaddddddddddddddddddddffffffffffffffffffffgggggggggggggggggghhhhhhhhhToolStripMenuItem
            // 
            this.aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaddddddddddddddddddddffffffffffffffffffffgggggggggggggggggghhhhhhhhhToolStripMenuItem.Name = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaddddddddddddddddddddffffffffffffffffffffggggggggg" +
    "ggggggggghhhhhhhhhToolStripMenuItem";
            this.aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaddddddddddddddddddddffffffffffffffffffffgggggggggggggggggghhhhhhhhhToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaddddddddddddddddddddffffffffffffffffffffgggggggggggggggggghhhhhhhhhToolStripMenuItem.Text = "Moltiplicatore Biscotti(1200 Bs): Raddoppia i biscotti ogni miinuto";
            this.aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaddddddddddddddddddddffffffffffffffffffffgggggggggggggggggghhhhhhhhhToolStripMenuItem.Click += new System.EventHandler(this.aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaddddddddddddddddddddffffffffffffffffffffgggggggggggggggggghhhhhhhhhToolStripMenuItem_Click);
            // 
            // SecondoTimer
            // 
            this.SecondoTimer.Interval = 10000;
            this.SecondoTimer.Tick += new System.EventHandler(this.SecondoTimer_Tick);
            // 
            // cheatsToolStripMenuItem
            // 
            this.cheatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biscottiToolStripMenuItem,
            this.biscottiToolStripMenuItem1,
            this.biscottiToolStripMenuItem2});
            this.cheatsToolStripMenuItem.Name = "cheatsToolStripMenuItem";
            this.cheatsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cheatsToolStripMenuItem.Text = "Cheats";
            // 
            // biscottiToolStripMenuItem
            // 
            this.biscottiToolStripMenuItem.Name = "biscottiToolStripMenuItem";
            this.biscottiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.biscottiToolStripMenuItem.Text = "200 Biscotti";
            this.biscottiToolStripMenuItem.Click += new System.EventHandler(this.biscottiToolStripMenuItem_Click);
            // 
            // biscottiToolStripMenuItem1
            // 
            this.biscottiToolStripMenuItem1.Name = "biscottiToolStripMenuItem1";
            this.biscottiToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.biscottiToolStripMenuItem1.Text = "750 Biscotti";
            this.biscottiToolStripMenuItem1.Click += new System.EventHandler(this.biscottiToolStripMenuItem1_Click);
            // 
            // biscottiToolStripMenuItem2
            // 
            this.biscottiToolStripMenuItem2.Name = "biscottiToolStripMenuItem2";
            this.biscottiToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.biscottiToolStripMenuItem2.Text = "1200 Biscotti";
            this.biscottiToolStripMenuItem2.Click += new System.EventHandler(this.biscottiToolStripMenuItem2_Click);
            // 
            // kBsToolStripMenuItem
            // 
            this.kBsToolStripMenuItem.Name = "kBsToolStripMenuItem";
            this.kBsToolStripMenuItem.Size = new System.Drawing.Size(420, 22);
            this.kBsToolStripMenuItem.Text = "10k Bs";
            // 
            // TerzoTimer
            // 
            this.TerzoTimer.Interval = 60000;
            this.TerzoTimer.Tick += new System.EventHandler(this.TerzoTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 444);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.biscotti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label biscotti;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem potenziamentiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem potenziamento1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem potenziamento2ToolStripMenuItem;
        private System.Windows.Forms.Timer PrimoTimer;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.ToolStripMenuItem aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaddddddddddddddddddddffffffffffffffffffffgggggggggggggggggghhhhhhhhhToolStripMenuItem;
        private System.Windows.Forms.Timer SecondoTimer;
        private System.Windows.Forms.ToolStripMenuItem cheatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biscottiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biscottiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem biscottiToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem kBsToolStripMenuItem;
        private System.Windows.Forms.Timer TerzoTimer;
    }
}

