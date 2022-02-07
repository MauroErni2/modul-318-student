using SwissTransport.Core;
using SwissTransport.Models;
using SwissTransport;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SBBLite3
{
    public partial class Form1 : Form
    {
        private readonly Transport _transport = new Transport();
        private string[] _currentStationNamesCollection = default;
        private const string _CurrentPositionText = "⌖ Aktueller Standort";
        private Size _formsize;
        private ListViewItem _focusedItem;
        private ListView _selectedListView;
        private string _emailText;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnMail_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string fromStation = tbStationFrom.Text;
            string toStation = tbStationTo.Text;

            if (fromStation != "" && toStation != "")
            {
                Connections possibleConnections;
                possibleConnections = _transport.GetConnections(fromStation, toStation);
                foreach (Connection connection in possibleConnections.ConnectionList)
                {
                    var lvi = new ListViewItem(new string[] { connection.Duration, connection.From.Station.Name, connection.From.Platform, connection.To.Station.Name, connection.From.Departure.ToString()});
                    lvConnections.Items.Add(lvi);
                    //string[] lineValue = { connection.From.ToString(), connection.To.ToString() };
                    //var listviewitem = new ListViewItem(lineValue);
                    //lvConnections.Items.Add(listviewitem);
                }
            }
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;

            //Nur bei jedem dritten Zeichen, um die API - Abfragerate zu reduzieren
            if (txtBox.TextLength % 3 == 0)
            {
                txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                var stations = _transport.GetStations(txtBox.Text);

                if (stations != null)
                {
                    if (stations.StationList.Count > 0)
                    {
                        // Die Namen der verfügbaren Stationen speichern
                        string[] stationNames = stations.StationList.Select(station => station.Name).ToArray();

                        if (_currentStationNamesCollection != stationNames)
                        {
                            // AutoComplete aktualisieren
                            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                            collection.AddRange(stationNames);
                            txtBox.AutoCompleteCustomSource = collection;
                        }

                        // Aktuellen Stand zwischenspeichern, damit nur bei einer Änderung eine neue Abfrage gestartet wird
                        _currentStationNamesCollection = stationNames;
                    }
                }
            }
        }
    }
}