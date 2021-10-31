namespace ProjectGIS2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.btnload = new System.Windows.Forms.Button();
            this.loadmap = new System.Windows.Forms.TextBox();
            this.listmaps = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listlayer = new System.Windows.Forms.ListBox();
            this.loadlayer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.featlist2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.featlist1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.attributebtn = new System.Windows.Forms.Button();
            this.textquery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.wheretxt = new System.Windows.Forms.TextBox();
            this.layercmb = new System.Windows.Forms.ComboBox();
            this.mapcmb = new System.Windows.Forms.ComboBox();
            this.spatialquery = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.featurelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(12, 22);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(516, 609);
            this.axMapControl1.TabIndex = 0;
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(147, 46);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(96, 39);
            this.btnload.TabIndex = 1;
            this.btnload.Text = "Load Map";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.loadmap_Click);
            // 
            // loadmap
            // 
            this.loadmap.Location = new System.Drawing.Point(6, 19);
            this.loadmap.Name = "loadmap";
            this.loadmap.Size = new System.Drawing.Size(237, 20);
            this.loadmap.TabIndex = 2;
            // 
            // listmaps
            // 
            this.listmaps.FormattingEnabled = true;
            this.listmaps.Location = new System.Drawing.Point(6, 62);
            this.listmaps.Name = "listmaps";
            this.listmaps.Size = new System.Drawing.Size(122, 121);
            this.listmaps.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listlayer);
            this.groupBox1.Controls.Add(this.loadlayer);
            this.groupBox1.Controls.Add(this.listmaps);
            this.groupBox1.Controls.Add(this.btnload);
            this.groupBox1.Controls.Add(this.loadmap);
            this.groupBox1.Location = new System.Drawing.Point(550, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 323);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "load map";
            // 
            // listlayer
            // 
            this.listlayer.FormattingEnabled = true;
            this.listlayer.Location = new System.Drawing.Point(6, 189);
            this.listlayer.Name = "listlayer";
            this.listlayer.Size = new System.Drawing.Size(122, 121);
            this.listlayer.TabIndex = 5;
            this.listlayer.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // loadlayer
            // 
            this.loadlayer.Location = new System.Drawing.Point(152, 144);
            this.loadlayer.Name = "loadlayer";
            this.loadlayer.Size = new System.Drawing.Size(96, 39);
            this.loadlayer.TabIndex = 4;
            this.loadlayer.Text = "Load Layers";
            this.loadlayer.UseVisualStyleBackColor = true;
            this.loadlayer.Click += new System.EventHandler(this.loadlayer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.featurelbl);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.add);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.featlist2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.featlist1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.attributebtn);
            this.groupBox2.Controls.Add(this.textquery);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(853, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 627);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selectd by Attribute";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Methods";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(169, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(268, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Show Uniqe values";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 243);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Show Fields";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(173, 271);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 12;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Uniqe Values";
            // 
            // featlist2
            // 
            this.featlist2.FormattingEnabled = true;
            this.featlist2.Location = new System.Drawing.Point(223, 103);
            this.featlist2.Name = "featlist2";
            this.featlist2.Size = new System.Drawing.Size(152, 134);
            this.featlist2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fields of Selected layer";
            // 
            // featlist1
            // 
            this.featlist1.FormattingEnabled = true;
            this.featlist1.Location = new System.Drawing.Point(35, 104);
            this.featlist1.Name = "featlist1";
            this.featlist1.Size = new System.Drawing.Size(152, 134);
            this.featlist1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(381, 194);
            this.dataGridView1.TabIndex = 7;
            // 
            // attributebtn
            // 
            this.attributebtn.Location = new System.Drawing.Point(265, 317);
            this.attributebtn.Name = "attributebtn";
            this.attributebtn.Size = new System.Drawing.Size(110, 42);
            this.attributebtn.TabIndex = 2;
            this.attributebtn.Text = "Query";
            this.attributebtn.UseVisualStyleBackColor = true;
            this.attributebtn.Click += new System.EventHandler(this.attributebtn_Click);
            // 
            // textquery
            // 
            this.textquery.Location = new System.Drawing.Point(20, 320);
            this.textquery.Multiline = true;
            this.textquery.Name = "textquery";
            this.textquery.Size = new System.Drawing.Size(204, 39);
            this.textquery.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "where clause";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.wheretxt);
            this.groupBox3.Controls.Add(this.layercmb);
            this.groupBox3.Controls.Add(this.mapcmb);
            this.groupBox3.Controls.Add(this.spatialquery);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(556, 351);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 303);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selected by Location";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(100, 26);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(145, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Methods";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wheretxt
            // 
            this.wheretxt.Location = new System.Drawing.Point(100, 147);
            this.wheretxt.Name = "wheretxt";
            this.wheretxt.Size = new System.Drawing.Size(152, 20);
            this.wheretxt.TabIndex = 3;
            // 
            // layercmb
            // 
            this.layercmb.FormattingEnabled = true;
            this.layercmb.Location = new System.Drawing.Point(100, 108);
            this.layercmb.Name = "layercmb";
            this.layercmb.Size = new System.Drawing.Size(145, 21);
            this.layercmb.TabIndex = 5;
            this.layercmb.SelectedIndexChanged += new System.EventHandler(this.layercmb_SelectedIndexChanged);
            // 
            // mapcmb
            // 
            this.mapcmb.FormattingEnabled = true;
            this.mapcmb.Location = new System.Drawing.Point(100, 68);
            this.mapcmb.Name = "mapcmb";
            this.mapcmb.Size = new System.Drawing.Size(145, 21);
            this.mapcmb.TabIndex = 4;
            // 
            // spatialquery
            // 
            this.spatialquery.Location = new System.Drawing.Point(67, 196);
            this.spatialquery.Name = "spatialquery";
            this.spatialquery.Size = new System.Drawing.Size(110, 42);
            this.spatialquery.TabIndex = 3;
            this.spatialquery.Text = "Spatial Query";
            this.spatialquery.UseVisualStyleBackColor = true;
            this.spatialquery.Click += new System.EventHandler(this.spatialquery_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Where Clause";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "that are inside";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select * from";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 591);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Number of Selected Features:";
            // 
            // featurelbl
            // 
            this.featurelbl.AutoSize = true;
            this.featurelbl.Location = new System.Drawing.Point(200, 591);
            this.featurelbl.Name = "featurelbl";
            this.featurelbl.Size = new System.Drawing.Size(32, 13);
            this.featurelbl.TabIndex = 20;
            this.featurelbl.Text = "?????";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 645);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.axMapControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.TextBox loadmap;
        private System.Windows.Forms.ListBox listmaps;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loadlayer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button attributebtn;
        private System.Windows.Forms.TextBox textquery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox wheretxt;
        private System.Windows.Forms.ComboBox layercmb;
        private System.Windows.Forms.ComboBox mapcmb;
        private System.Windows.Forms.Button spatialquery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox featlist2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox featlist1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listlayer;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label featurelbl;
        private System.Windows.Forms.Label label9;
    }
}

