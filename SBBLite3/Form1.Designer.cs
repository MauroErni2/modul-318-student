namespace SBBLite3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVerbindungen = new System.Windows.Forms.TabPage();
            this.dtpAbfahrtVon = new System.Windows.Forms.DateTimePicker();
            this.lbAbfahrtVon = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.tbStationTo = new System.Windows.Forms.TextBox();
            this.tbStationFrom = new System.Windows.Forms.TextBox();
            this.lbStationTo = new System.Windows.Forms.Label();
            this.lbStationFrom = new System.Windows.Forms.Label();
            this.tabAbfahrt = new System.Windows.Forms.TabPage();
            this.btnMailTable = new System.Windows.Forms.Button();
            this.tbStationTable = new System.Windows.Forms.TextBox();
            this.lbStationTable = new System.Windows.Forms.Label();
            this.tabStations = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coordinateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tbStation = new System.Windows.Forms.TextBox();
            this.lbStation = new System.Windows.Forms.Label();
            this.tabLocation = new System.Windows.Forms.TabPage();
            this.connectionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.connectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.connectionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stationsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stationsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.connectionBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabVerbindungen.SuspendLayout();
            this.tabAbfahrt.SuspendLayout();
            this.tabStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVerbindungen);
            this.tabControl1.Controls.Add(this.tabAbfahrt);
            this.tabControl1.Controls.Add(this.tabStations);
            this.tabControl1.Controls.Add(this.tabLocation);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabVerbindungen
            // 
            this.tabVerbindungen.Controls.Add(this.dtpAbfahrtVon);
            this.tabVerbindungen.Controls.Add(this.lbAbfahrtVon);
            this.tabVerbindungen.Controls.Add(this.btnSearch);
            this.tabVerbindungen.Controls.Add(this.btnMail);
            this.tabVerbindungen.Controls.Add(this.tbStationTo);
            this.tabVerbindungen.Controls.Add(this.tbStationFrom);
            this.tabVerbindungen.Controls.Add(this.lbStationTo);
            this.tabVerbindungen.Controls.Add(this.lbStationFrom);
            this.tabVerbindungen.Location = new System.Drawing.Point(4, 34);
            this.tabVerbindungen.Name = "tabVerbindungen";
            this.tabVerbindungen.Padding = new System.Windows.Forms.Padding(3);
            this.tabVerbindungen.Size = new System.Drawing.Size(792, 411);
            this.tabVerbindungen.TabIndex = 0;
            this.tabVerbindungen.Text = "Verbindungen";
            this.tabVerbindungen.UseVisualStyleBackColor = true;
            // 
            // dtpAbfahrtVon
            // 
            this.dtpAbfahrtVon.Location = new System.Drawing.Point(151, 138);
            this.dtpAbfahrtVon.Name = "dtpAbfahrtVon";
            this.dtpAbfahrtVon.Size = new System.Drawing.Size(300, 31);
            this.dtpAbfahrtVon.TabIndex = 8;
            // 
            // lbAbfahrtVon
            // 
            this.lbAbfahrtVon.AutoSize = true;
            this.lbAbfahrtVon.Location = new System.Drawing.Point(21, 138);
            this.lbAbfahrtVon.Name = "lbAbfahrtVon";
            this.lbAbfahrtVon.Size = new System.Drawing.Size(111, 25);
            this.lbAbfahrtVon.TabIndex = 6;
            this.lbAbfahrtVon.Text = "Abfahrt von:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(499, 138);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(197, 36);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Verbindung suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnMail
            // 
            this.btnMail.Location = new System.Drawing.Point(660, 18);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(112, 34);
            this.btnMail.TabIndex = 4;
            this.btnMail.Text = "Email";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // tbStationTo
            // 
            this.tbStationTo.Location = new System.Drawing.Point(151, 70);
            this.tbStationTo.Name = "tbStationTo";
            this.tbStationTo.Size = new System.Drawing.Size(300, 31);
            this.tbStationTo.TabIndex = 3;
            // 
            // tbStationFrom
            // 
            this.tbStationFrom.Location = new System.Drawing.Point(151, 33);
            this.tbStationFrom.Name = "tbStationFrom";
            this.tbStationFrom.Size = new System.Drawing.Size(300, 31);
            this.tbStationFrom.TabIndex = 2;
            // 
            // lbStationTo
            // 
            this.lbStationTo.AutoSize = true;
            this.lbStationTo.Location = new System.Drawing.Point(21, 73);
            this.lbStationTo.Name = "lbStationTo";
            this.lbStationTo.Size = new System.Drawing.Size(99, 25);
            this.lbStationTo.TabIndex = 1;
            this.lbStationTo.Text = "Station bis:";
            // 
            // lbStationFrom
            // 
            this.lbStationFrom.AutoSize = true;
            this.lbStationFrom.Location = new System.Drawing.Point(21, 36);
            this.lbStationFrom.Name = "lbStationFrom";
            this.lbStationFrom.Size = new System.Drawing.Size(106, 25);
            this.lbStationFrom.TabIndex = 0;
            this.lbStationFrom.Text = "Station von:";
            // 
            // tabAbfahrt
            // 
            this.tabAbfahrt.Controls.Add(this.btnMailTable);
            this.tabAbfahrt.Controls.Add(this.tbStationTable);
            this.tabAbfahrt.Controls.Add(this.lbStationTable);
            this.tabAbfahrt.Location = new System.Drawing.Point(4, 34);
            this.tabAbfahrt.Name = "tabAbfahrt";
            this.tabAbfahrt.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbfahrt.Size = new System.Drawing.Size(792, 411);
            this.tabAbfahrt.TabIndex = 1;
            this.tabAbfahrt.Text = "Abfahrtstafel";
            this.tabAbfahrt.UseVisualStyleBackColor = true;
            // 
            // btnMailTable
            // 
            this.btnMailTable.Location = new System.Drawing.Point(588, 25);
            this.btnMailTable.Name = "btnMailTable";
            this.btnMailTable.Size = new System.Drawing.Size(112, 34);
            this.btnMailTable.TabIndex = 2;
            this.btnMailTable.Text = "Email";
            this.btnMailTable.UseVisualStyleBackColor = true;
            // 
            // tbStationTable
            // 
            this.tbStationTable.Location = new System.Drawing.Point(137, 27);
            this.tbStationTable.Name = "tbStationTable";
            this.tbStationTable.Size = new System.Drawing.Size(150, 31);
            this.tbStationTable.TabIndex = 1;
            // 
            // lbStationTable
            // 
            this.lbStationTable.AutoSize = true;
            this.lbStationTable.Location = new System.Drawing.Point(25, 30);
            this.lbStationTable.Name = "lbStationTable";
            this.lbStationTable.Size = new System.Drawing.Size(106, 25);
            this.lbStationTable.TabIndex = 0;
            this.lbStationTable.Text = "Station von:";
            // 
            // tabStations
            // 
            this.tabStations.Controls.Add(this.dataGridView1);
            this.tabStations.Controls.Add(this.button1);
            this.tabStations.Controls.Add(this.tbStation);
            this.tabStations.Controls.Add(this.lbStation);
            this.tabStations.Location = new System.Drawing.Point(4, 34);
            this.tabStations.Name = "tabStations";
            this.tabStations.Size = new System.Drawing.Size(792, 411);
            this.tabStations.TabIndex = 2;
            this.tabStations.Text = "Stationssuche";
            this.tabStations.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.coordinateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(663, 225);
            this.dataGridView1.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.Width = 150;
            // 
            // coordinateDataGridViewTextBoxColumn
            // 
            this.coordinateDataGridViewTextBoxColumn.DataPropertyName = "Coordinate";
            this.coordinateDataGridViewTextBoxColumn.HeaderText = "Coordinate";
            this.coordinateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.coordinateDataGridViewTextBoxColumn.Name = "coordinateDataGridViewTextBoxColumn";
            this.coordinateDataGridViewTextBoxColumn.Width = 150;
            // 
            // stationBindingSource
            // 
            this.stationBindingSource.DataSource = typeof(SwissTransport.Models.Station);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Email";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbStation
            // 
            this.tbStation.Location = new System.Drawing.Point(157, 36);
            this.tbStation.Name = "tbStation";
            this.tbStation.Size = new System.Drawing.Size(150, 31);
            this.tbStation.TabIndex = 4;
            this.tbStation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbStation
            // 
            this.lbStation.AutoSize = true;
            this.lbStation.Location = new System.Drawing.Point(28, 38);
            this.lbStation.Name = "lbStation";
            this.lbStation.Size = new System.Drawing.Size(123, 25);
            this.lbStation.TabIndex = 3;
            this.lbStation.Text = "Suche Station:";
            // 
            // tabLocation
            // 
            this.tabLocation.Location = new System.Drawing.Point(4, 34);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Size = new System.Drawing.Size(792, 411);
            this.tabLocation.TabIndex = 3;
            this.tabLocation.Text = "Mein Standort";
            this.tabLocation.UseVisualStyleBackColor = true;
            // 
            // connectionBindingSource2
            // 
            this.connectionBindingSource2.DataSource = typeof(SwissTransport.Models.Connection);
            // 
            // connectionBindingSource
            // 
            this.connectionBindingSource.DataSource = typeof(SwissTransport.Models.Connection);
            // 
            // connectionBindingSource1
            // 
            this.connectionBindingSource1.DataSource = typeof(SwissTransport.Models.Connection);
            // 
            // stationsBindingSource
            // 
            this.stationsBindingSource.DataSource = typeof(SwissTransport.Models.Stations);
            // 
            // stationsBindingSource1
            // 
            this.stationsBindingSource1.DataSource = typeof(SwissTransport.Models.Stations);
            // 
            // transportBindingSource
            // 
            this.transportBindingSource.DataSource = typeof(SwissTransport.Core.Transport);
            // 
            // transportBindingSource1
            // 
            this.transportBindingSource1.DataSource = typeof(SwissTransport.Core.Transport);
            // 
            // stationsBindingSource2
            // 
            this.stationsBindingSource2.DataSource = typeof(SwissTransport.Models.Stations);
            // 
            // connectionBindingSource3
            // 
            this.connectionBindingSource3.DataSource = typeof(SwissTransport.Models.Connection);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(654, 464);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(799, 514);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SwissTransport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabVerbindungen.ResumeLayout(false);
            this.tabVerbindungen.PerformLayout();
            this.tabAbfahrt.ResumeLayout(false);
            this.tabAbfahrt.PerformLayout();
            this.tabStations.ResumeLayout(false);
            this.tabStations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transportBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stationsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabVerbindungen;
        private Button btnMail;
        private TextBox tbStationTo;
        private TextBox tbStationFrom;
        private Label lbStationTo;
        private Label lbStationFrom;
        private TabPage tabAbfahrt;
        private Label lbStationTable;
        private TabPage tabStations;
        private Button btnMailTable;
        private TextBox tbStationTable;
        private Button button1;
        private TextBox tbStation;
        private Label lbStation;
        private TabPage tabLocation;
        private BindingSource connectionBindingSource;
        private BindingSource connectionBindingSource1;
        private BindingSource stationsBindingSource;
        private BindingSource stationsBindingSource1;
        private BindingSource transportBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn coordinateDataGridViewTextBoxColumn;
        private BindingSource stationBindingSource;
        private BindingSource transportBindingSource1;
        private BindingSource stationsBindingSource2;
        private Button btnSearch;
        private BindingSource connectionBindingSource2;
        private DateTimePicker dtpAbfahrtVon;
        private Label lbAbfahrtVon;
        private BindingSource connectionBindingSource3;
        private Button btnClose;
    }
}