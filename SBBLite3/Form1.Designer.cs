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
            this.lvConnections = new System.Windows.Forms.ListView();
            this.chDuration = new System.Windows.Forms.ColumnHeader();
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbStation = new System.Windows.Forms.TextBox();
            this.lbStation = new System.Windows.Forms.Label();
            this.tabLocation = new System.Windows.Forms.TabPage();
            this.connectionBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.stationBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.connectionBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.connectionBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.chFromStation = new System.Windows.Forms.ColumnHeader();
            this.chFromPlattform = new System.Windows.Forms.ColumnHeader();
            this.chToStation = new System.Windows.Forms.ColumnHeader();
            this.chDeparture = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.tabVerbindungen.SuspendLayout();
            this.tabAbfahrt.SuspendLayout();
            this.tabStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource5)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabVerbindungen);
            this.tabControl1.Controls.Add(this.tabAbfahrt);
            this.tabControl1.Controls.Add(this.tabStations);
            this.tabControl1.Controls.Add(this.tabLocation);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1817, 1130);
            this.tabControl1.TabIndex = 0;
            // 
            // tabVerbindungen
            // 
            this.tabVerbindungen.Controls.Add(this.lvConnections);
            this.tabVerbindungen.Controls.Add(this.dtpAbfahrtVon);
            this.tabVerbindungen.Controls.Add(this.lbAbfahrtVon);
            this.tabVerbindungen.Controls.Add(this.btnSearch);
            this.tabVerbindungen.Controls.Add(this.btnMail);
            this.tabVerbindungen.Controls.Add(this.tbStationTo);
            this.tabVerbindungen.Controls.Add(this.tbStationFrom);
            this.tabVerbindungen.Controls.Add(this.lbStationTo);
            this.tabVerbindungen.Controls.Add(this.lbStationFrom);
            this.tabVerbindungen.Location = new System.Drawing.Point(12, 69);
            this.tabVerbindungen.Margin = new System.Windows.Forms.Padding(6);
            this.tabVerbindungen.Name = "tabVerbindungen";
            this.tabVerbindungen.Padding = new System.Windows.Forms.Padding(6);
            this.tabVerbindungen.Size = new System.Drawing.Size(1793, 1049);
            this.tabVerbindungen.TabIndex = 0;
            this.tabVerbindungen.Text = "Verbindungen";
            this.tabVerbindungen.UseVisualStyleBackColor = true;
            // 
            // lvConnections
            // 
            this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDuration,
            this.chFromStation,
            this.chFromPlattform,
            this.chToStation,
            this.chDeparture});
            this.lvConnections.GridLines = true;
            this.lvConnections.Location = new System.Drawing.Point(69, 413);
            this.lvConnections.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(1621, 561);
            this.lvConnections.TabIndex = 9;
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.View = System.Windows.Forms.View.Details;
            // 
            // chDuration
            // 
            this.chDuration.Text = "Duration";
            // 
            // dtpAbfahrtVon
            // 
            this.dtpAbfahrtVon.Location = new System.Drawing.Point(303, 266);
            this.dtpAbfahrtVon.Margin = new System.Windows.Forms.Padding(6);
            this.dtpAbfahrtVon.Name = "dtpAbfahrtVon";
            this.dtpAbfahrtVon.Size = new System.Drawing.Size(595, 55);
            this.dtpAbfahrtVon.TabIndex = 8;
            // 
            // lbAbfahrtVon
            // 
            this.lbAbfahrtVon.AutoSize = true;
            this.lbAbfahrtVon.Location = new System.Drawing.Point(43, 266);
            this.lbAbfahrtVon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbAbfahrtVon.Name = "lbAbfahrtVon";
            this.lbAbfahrtVon.Size = new System.Drawing.Size(214, 48);
            this.lbAbfahrtVon.TabIndex = 6;
            this.lbAbfahrtVon.Text = "Abfahrt von:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(997, 266);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(394, 70);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Verbindung suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMail
            // 
            this.btnMail.Location = new System.Drawing.Point(1554, 13);
            this.btnMail.Margin = new System.Windows.Forms.Padding(6);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(223, 64);
            this.btnMail.TabIndex = 4;
            this.btnMail.Text = "Email";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // tbStationTo
            // 
            this.tbStationTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbStationTo.Location = new System.Drawing.Point(303, 144);
            this.tbStationTo.Margin = new System.Windows.Forms.Padding(6);
            this.tbStationTo.Name = "tbStationTo";
            this.tbStationTo.Size = new System.Drawing.Size(595, 55);
            this.tbStationTo.TabIndex = 3;
            this.tbStationTo.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // tbStationFrom
            // 
            this.tbStationFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbStationFrom.Location = new System.Drawing.Point(303, 64);
            this.tbStationFrom.Margin = new System.Windows.Forms.Padding(6);
            this.tbStationFrom.Name = "tbStationFrom";
            this.tbStationFrom.Size = new System.Drawing.Size(595, 55);
            this.tbStationFrom.TabIndex = 2;
            this.tbStationFrom.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lbStationTo
            // 
            this.lbStationTo.AutoSize = true;
            this.lbStationTo.Location = new System.Drawing.Point(43, 150);
            this.lbStationTo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbStationTo.Name = "lbStationTo";
            this.lbStationTo.Size = new System.Drawing.Size(193, 48);
            this.lbStationTo.TabIndex = 1;
            this.lbStationTo.Text = "Station bis:";
            // 
            // lbStationFrom
            // 
            this.lbStationFrom.AutoSize = true;
            this.lbStationFrom.Location = new System.Drawing.Point(43, 70);
            this.lbStationFrom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbStationFrom.Name = "lbStationFrom";
            this.lbStationFrom.Size = new System.Drawing.Size(206, 48);
            this.lbStationFrom.TabIndex = 0;
            this.lbStationFrom.Text = "Station von:";
            // 
            // tabAbfahrt
            // 
            this.tabAbfahrt.Controls.Add(this.btnMailTable);
            this.tabAbfahrt.Controls.Add(this.tbStationTable);
            this.tabAbfahrt.Controls.Add(this.lbStationTable);
            this.tabAbfahrt.Location = new System.Drawing.Point(12, 69);
            this.tabAbfahrt.Margin = new System.Windows.Forms.Padding(6);
            this.tabAbfahrt.Name = "tabAbfahrt";
            this.tabAbfahrt.Padding = new System.Windows.Forms.Padding(6);
            this.tabAbfahrt.Size = new System.Drawing.Size(1793, 1049);
            this.tabAbfahrt.TabIndex = 1;
            this.tabAbfahrt.Text = "Abfahrtstafel";
            this.tabAbfahrt.UseVisualStyleBackColor = true;
            // 
            // btnMailTable
            // 
            this.btnMailTable.Location = new System.Drawing.Point(1177, 48);
            this.btnMailTable.Margin = new System.Windows.Forms.Padding(6);
            this.btnMailTable.Name = "btnMailTable";
            this.btnMailTable.Size = new System.Drawing.Size(223, 64);
            this.btnMailTable.TabIndex = 2;
            this.btnMailTable.Text = "Email";
            this.btnMailTable.UseVisualStyleBackColor = true;
            // 
            // tbStationTable
            // 
            this.tbStationTable.Location = new System.Drawing.Point(274, 51);
            this.tbStationTable.Margin = new System.Windows.Forms.Padding(6);
            this.tbStationTable.Name = "tbStationTable";
            this.tbStationTable.Size = new System.Drawing.Size(295, 55);
            this.tbStationTable.TabIndex = 1;
            // 
            // lbStationTable
            // 
            this.lbStationTable.AutoSize = true;
            this.lbStationTable.Location = new System.Drawing.Point(51, 58);
            this.lbStationTable.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbStationTable.Name = "lbStationTable";
            this.lbStationTable.Size = new System.Drawing.Size(206, 48);
            this.lbStationTable.TabIndex = 0;
            this.lbStationTable.Text = "Station von:";
            // 
            // tabStations
            // 
            this.tabStations.Controls.Add(this.button1);
            this.tabStations.Controls.Add(this.tbStation);
            this.tabStations.Controls.Add(this.lbStation);
            this.tabStations.Location = new System.Drawing.Point(12, 69);
            this.tabStations.Margin = new System.Windows.Forms.Padding(6);
            this.tabStations.Name = "tabStations";
            this.tabStations.Size = new System.Drawing.Size(1793, 1049);
            this.tabStations.TabIndex = 2;
            this.tabStations.Text = "Stationssuche";
            this.tabStations.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1163, 64);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Email";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbStation
            // 
            this.tbStation.Location = new System.Drawing.Point(314, 70);
            this.tbStation.Margin = new System.Windows.Forms.Padding(6);
            this.tbStation.Name = "tbStation";
            this.tbStation.Size = new System.Drawing.Size(295, 55);
            this.tbStation.TabIndex = 4;
            this.tbStation.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbStation
            // 
            this.lbStation.AutoSize = true;
            this.lbStation.Location = new System.Drawing.Point(57, 74);
            this.lbStation.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbStation.Name = "lbStation";
            this.lbStation.Size = new System.Drawing.Size(243, 48);
            this.lbStation.TabIndex = 3;
            this.lbStation.Text = "Suche Station:";
            // 
            // tabLocation
            // 
            this.tabLocation.Location = new System.Drawing.Point(12, 69);
            this.tabLocation.Margin = new System.Windows.Forms.Padding(6);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Size = new System.Drawing.Size(1793, 1049);
            this.tabLocation.TabIndex = 3;
            this.tabLocation.Text = "Mein Standort";
            this.tabLocation.UseVisualStyleBackColor = true;
            // 
            // connectionBindingSource5
            // 
            this.connectionBindingSource5.DataSource = typeof(SwissTransport.Models.Connection);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1560, 1142);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(249, 64);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Schliessen";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // connectionBindingSource4
            // 
            this.connectionBindingSource4.DataSource = typeof(SwissTransport.Models.Connection);
            // 
            // connectionBindingSource6
            // 
            this.connectionBindingSource6.DataSource = typeof(SwissTransport.Models.Connection);
            // 
            // chFromStation
            // 
            this.chFromStation.Text = "From Station";
            // 
            // chFromPlattform
            // 
            this.chFromPlattform.Text = "Plattform";
            // 
            // chToStation
            // 
            this.chToStation.Text = "To Station";
            // 
            // chDeparture
            // 
            this.chDeparture.Text = "Departure";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1823, 1242);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
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
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource5)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource6)).EndInit();
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
        private BindingSource stationBindingSource;
        private BindingSource transportBindingSource1;
        private BindingSource stationsBindingSource2;
        private Button btnSearch;
        private BindingSource connectionBindingSource2;
        private DateTimePicker dtpAbfahrtVon;
        private Label lbAbfahrtVon;
        private BindingSource connectionBindingSource3;
        private Button btnClose;
        private BindingSource connectionBindingSource4;
        private BindingSource connectionBindingSource5;
        private ListView lvConnections;
        private BindingSource connectionBindingSource6;
        private ColumnHeader chDuration;
        private ColumnHeader chFromStation;
        private ColumnHeader chFromPlattform;
        private ColumnHeader chToStation;
        private ColumnHeader chDeparture;
    }
}