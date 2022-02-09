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
            this.dtpFromTime = new System.Windows.Forms.DateTimePicker();
            this.lvConnections = new System.Windows.Forms.ListView();
            this.chDeparture = new System.Windows.Forms.ColumnHeader();
            this.chFromStation = new System.Windows.Forms.ColumnHeader();
            this.chFromPlattform = new System.Windows.Forms.ColumnHeader();
            this.chToStation = new System.Windows.Forms.ColumnHeader();
            this.chDuration = new System.Windows.Forms.ColumnHeader();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lbAbfahrtVon = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.tbStationTo = new System.Windows.Forms.TextBox();
            this.tbStationFrom = new System.Windows.Forms.TextBox();
            this.lbStationTo = new System.Windows.Forms.Label();
            this.lbStationFrom = new System.Windows.Forms.Label();
            this.tabAbfahrt = new System.Windows.Forms.TabPage();
            this.btnAbfahrt = new System.Windows.Forms.Button();
            this.lvConnectionTab = new System.Windows.Forms.ListView();
            this.chDepartureTab = new System.Windows.Forms.ColumnHeader();
            this.chToStationTab = new System.Windows.Forms.ColumnHeader();
            this.btnMailTable = new System.Windows.Forms.Button();
            this.tbStationTable = new System.Windows.Forms.TextBox();
            this.lbStationTable = new System.Windows.Forms.Label();
            this.tabStations = new System.Windows.Forms.TabPage();
            this.btnSearchStations = new System.Windows.Forms.Button();
            this.lvSearchStations = new System.Windows.Forms.ListView();
            this.chpossStations = new System.Windows.Forms.ColumnHeader();
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
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
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabVerbindungen);
            this.tabControl1.Controls.Add(this.tabAbfahrt);
            this.tabControl1.Controls.Add(this.tabStations);
            this.tabControl1.Controls.Add(this.tabLocation);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 588);
            this.tabControl1.TabIndex = 0;
            // 
            // tabVerbindungen
            // 
            this.tabVerbindungen.Controls.Add(this.dtpFromTime);
            this.tabVerbindungen.Controls.Add(this.lvConnections);
            this.tabVerbindungen.Controls.Add(this.dtpFromDate);
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
            this.tabVerbindungen.Size = new System.Drawing.Size(901, 550);
            this.tabVerbindungen.TabIndex = 0;
            this.tabVerbindungen.Text = "Verbindungen";
            this.tabVerbindungen.UseVisualStyleBackColor = true;
            // 
            // dtpFromTime
            // 
            this.dtpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFromTime.Location = new System.Drawing.Point(465, 135);
            this.dtpFromTime.Name = "dtpFromTime";
            this.dtpFromTime.Size = new System.Drawing.Size(110, 31);
            this.dtpFromTime.TabIndex = 10;
            // 
            // lvConnections
            // 
            this.lvConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDeparture,
            this.chFromStation,
            this.chFromPlattform,
            this.chToStation,
            this.chDuration});
            this.lvConnections.GridLines = true;
            this.lvConnections.Location = new System.Drawing.Point(0, 177);
            this.lvConnections.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvConnections.Name = "lvConnections";
            this.lvConnections.Size = new System.Drawing.Size(901, 345);
            this.lvConnections.TabIndex = 9;
            this.lvConnections.UseCompatibleStateImageBehavior = false;
            this.lvConnections.View = System.Windows.Forms.View.Details;
            // 
            // chDeparture
            // 
            this.chDeparture.Text = "Departure";
            this.chDeparture.Width = 180;
            // 
            // chFromStation
            // 
            this.chFromStation.Text = "From Station";
            this.chFromStation.Width = 220;
            // 
            // chFromPlattform
            // 
            this.chFromPlattform.Text = "Plattform";
            this.chFromPlattform.Width = 80;
            // 
            // chToStation
            // 
            this.chToStation.Text = "To Station";
            this.chToStation.Width = 220;
            // 
            // chDuration
            // 
            this.chDuration.Text = "Duration";
            this.chDuration.Width = 180;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(151, 136);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(300, 31);
            this.dtpFromDate.TabIndex = 8;
            // 
            // lbAbfahrtVon
            // 
            this.lbAbfahrtVon.AutoSize = true;
            this.lbAbfahrtVon.Location = new System.Drawing.Point(21, 136);
            this.lbAbfahrtVon.Name = "lbAbfahrtVon";
            this.lbAbfahrtVon.Size = new System.Drawing.Size(111, 25);
            this.lbAbfahrtVon.TabIndex = 6;
            this.lbAbfahrtVon.Text = "Abfahrt von:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(498, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(197, 37);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Verbindung suchen";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnMail
            // 
            this.btnMail.Location = new System.Drawing.Point(777, 7);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(111, 33);
            this.btnMail.TabIndex = 4;
            this.btnMail.Text = "Email";
            this.btnMail.UseVisualStyleBackColor = true;
            // 
            // tbStationTo
            // 
            this.tbStationTo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbStationTo.Location = new System.Drawing.Point(151, 75);
            this.tbStationTo.Name = "tbStationTo";
            this.tbStationTo.Size = new System.Drawing.Size(300, 31);
            this.tbStationTo.TabIndex = 3;
            this.tbStationTo.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // tbStationFrom
            // 
            this.tbStationFrom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbStationFrom.Location = new System.Drawing.Point(151, 33);
            this.tbStationFrom.Name = "tbStationFrom";
            this.tbStationFrom.Size = new System.Drawing.Size(300, 31);
            this.tbStationFrom.TabIndex = 2;
            this.tbStationFrom.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lbStationTo
            // 
            this.lbStationTo.AutoSize = true;
            this.lbStationTo.Location = new System.Drawing.Point(21, 78);
            this.lbStationTo.Name = "lbStationTo";
            this.lbStationTo.Size = new System.Drawing.Size(99, 25);
            this.lbStationTo.TabIndex = 1;
            this.lbStationTo.Text = "Station bis:";
            // 
            // lbStationFrom
            // 
            this.lbStationFrom.AutoSize = true;
            this.lbStationFrom.Location = new System.Drawing.Point(21, 37);
            this.lbStationFrom.Name = "lbStationFrom";
            this.lbStationFrom.Size = new System.Drawing.Size(106, 25);
            this.lbStationFrom.TabIndex = 0;
            this.lbStationFrom.Text = "Station von:";
            // 
            // tabAbfahrt
            // 
            this.tabAbfahrt.Controls.Add(this.btnAbfahrt);
            this.tabAbfahrt.Controls.Add(this.lvConnectionTab);
            this.tabAbfahrt.Controls.Add(this.btnMailTable);
            this.tabAbfahrt.Controls.Add(this.tbStationTable);
            this.tabAbfahrt.Controls.Add(this.lbStationTable);
            this.tabAbfahrt.Location = new System.Drawing.Point(4, 34);
            this.tabAbfahrt.Name = "tabAbfahrt";
            this.tabAbfahrt.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbfahrt.Size = new System.Drawing.Size(901, 550);
            this.tabAbfahrt.TabIndex = 1;
            this.tabAbfahrt.Text = "Abfahrtstafel";
            this.tabAbfahrt.UseVisualStyleBackColor = true;
            // 
            // btnAbfahrt
            // 
            this.btnAbfahrt.Location = new System.Drawing.Point(502, 25);
            this.btnAbfahrt.Name = "btnAbfahrt";
            this.btnAbfahrt.Size = new System.Drawing.Size(195, 34);
            this.btnAbfahrt.TabIndex = 11;
            this.btnAbfahrt.Text = "Abfahrten suchen";
            this.btnAbfahrt.UseVisualStyleBackColor = true;
            this.btnAbfahrt.Click += new System.EventHandler(this.btnAbfahrt_Click);
            // 
            // lvConnectionTab
            // 
            this.lvConnectionTab.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDepartureTab,
            this.chToStationTab});
            this.lvConnectionTab.GridLines = true;
            this.lvConnectionTab.Location = new System.Drawing.Point(0, 103);
            this.lvConnectionTab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvConnectionTab.Name = "lvConnectionTab";
            this.lvConnectionTab.Size = new System.Drawing.Size(905, 345);
            this.lvConnectionTab.TabIndex = 10;
            this.lvConnectionTab.UseCompatibleStateImageBehavior = false;
            this.lvConnectionTab.View = System.Windows.Forms.View.Details;
            // 
            // chDepartureTab
            // 
            this.chDepartureTab.Text = "Departure";
            this.chDepartureTab.Width = 180;
            // 
            // chToStationTab
            // 
            this.chToStationTab.Text = "To Station";
            this.chToStationTab.Width = 720;
            // 
            // btnMailTable
            // 
            this.btnMailTable.Location = new System.Drawing.Point(780, 9);
            this.btnMailTable.Name = "btnMailTable";
            this.btnMailTable.Size = new System.Drawing.Size(111, 33);
            this.btnMailTable.TabIndex = 2;
            this.btnMailTable.Text = "Email";
            this.btnMailTable.UseVisualStyleBackColor = true;
            // 
            // tbStationTable
            // 
            this.tbStationTable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbStationTable.Location = new System.Drawing.Point(137, 27);
            this.tbStationTable.Name = "tbStationTable";
            this.tbStationTable.Size = new System.Drawing.Size(328, 31);
            this.tbStationTable.TabIndex = 1;
            this.tbStationTable.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // lbStationTable
            // 
            this.lbStationTable.AutoSize = true;
            this.lbStationTable.Location = new System.Drawing.Point(26, 30);
            this.lbStationTable.Name = "lbStationTable";
            this.lbStationTable.Size = new System.Drawing.Size(106, 25);
            this.lbStationTable.TabIndex = 0;
            this.lbStationTable.Text = "Station von:";
            // 
            // tabStations
            // 
            this.tabStations.Controls.Add(this.btnSearchStations);
            this.tabStations.Controls.Add(this.lvSearchStations);
            this.tabStations.Controls.Add(this.button1);
            this.tabStations.Controls.Add(this.tbStation);
            this.tabStations.Controls.Add(this.lbStation);
            this.tabStations.Location = new System.Drawing.Point(4, 34);
            this.tabStations.Name = "tabStations";
            this.tabStations.Size = new System.Drawing.Size(901, 550);
            this.tabStations.TabIndex = 2;
            this.tabStations.Text = "Stationssuche";
            this.tabStations.UseVisualStyleBackColor = true;
            // 
            // btnSearchStations
            // 
            this.btnSearchStations.Location = new System.Drawing.Point(505, 35);
            this.btnSearchStations.Name = "btnSearchStations";
            this.btnSearchStations.Size = new System.Drawing.Size(195, 34);
            this.btnSearchStations.TabIndex = 12;
            this.btnSearchStations.Text = "Stationen suchen";
            this.btnSearchStations.UseVisualStyleBackColor = true;
            this.btnSearchStations.Click += new System.EventHandler(this.btnSearchStations_Click);
            // 
            // lvSearchStations
            // 
            this.lvSearchStations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chpossStations});
            this.lvSearchStations.GridLines = true;
            this.lvSearchStations.Location = new System.Drawing.Point(0, 103);
            this.lvSearchStations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvSearchStations.Name = "lvSearchStations";
            this.lvSearchStations.Size = new System.Drawing.Size(901, 345);
            this.lvSearchStations.TabIndex = 11;
            this.lvSearchStations.UseCompatibleStateImageBehavior = false;
            this.lvSearchStations.View = System.Windows.Forms.View.Details;
            // 
            // chpossStations
            // 
            this.chpossStations.Text = "Station";
            this.chpossStations.Width = 890;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(780, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "Email";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbStation
            // 
            this.tbStation.Location = new System.Drawing.Point(157, 37);
            this.tbStation.Name = "tbStation";
            this.tbStation.Size = new System.Drawing.Size(294, 31);
            this.tbStation.TabIndex = 4;
            // 
            // lbStation
            // 
            this.lbStation.AutoSize = true;
            this.lbStation.Location = new System.Drawing.Point(29, 38);
            this.lbStation.Name = "lbStation";
            this.lbStation.Size = new System.Drawing.Size(123, 25);
            this.lbStation.TabIndex = 3;
            this.lbStation.Text = "Suche Station:";
            // 
            // tabLocation
            // 
            this.tabLocation.Location = new System.Drawing.Point(4, 34);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.Size = new System.Drawing.Size(901, 550);
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
            this.btnClose.Location = new System.Drawing.Point(780, 595);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 33);
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
            // Form1
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(937, 642);
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
        private DateTimePicker dtpFromDate;
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
        private ListView lvConnectionTab;
        private ColumnHeader chToStationTab;
        private ColumnHeader chDepartureTab;
        private Button btnAbfahrt;
        private ListView lvSearchStations;
        private ColumnHeader chpossStations;
        private Button btnSearchStations;
        private DateTimePicker dtpFromTime;
        private FontDialog fontDialog1;
    }
}