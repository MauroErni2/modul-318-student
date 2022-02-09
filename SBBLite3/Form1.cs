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

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvConnections.Items.Clear();
            string fromStation = tbStationFrom.Text;
            string toStation = tbStationTo.Text;
            DateTime FromDate = dtpFromDate.Value;
            DateTime FromTime = dtpFromTime.Value;

            if (fromStation != "" && toStation != "")
            {
                Connections possibleConnections;
                possibleConnections = _transport.GetConnections(fromStation,toStation, FromDate, FromTime);
                foreach (Connection connection in possibleConnections.ConnectionList)
                {
                    var lvi = new ListViewItem(new string[] { connection.From.Departure.ToString(), connection.From.Station.Name, connection.From.Platform, connection.To.Station.Name, connection.Duration});
                    lvConnections.Items.Add(lvi);
                }
            }
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;

            if (txtBox.TextLength % 3 == 0)
            {
                //Ich weiss, AutoComplete ist nicht die beste Lösung...hatte aber keine Zeit mehr. 
                txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                var stations = _transport.GetStations(txtBox.Text);

                if (stations != null)
                {
                    if (stations.StationList.Count > 0)
                    {
                        string[] stationNames = stations.StationList.Select(station => station.Name).ToArray();

                        if (_currentStationNamesCollection != stationNames)
                        {
                            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
                            collection.AddRange(stationNames);
                            txtBox.AutoCompleteCustomSource = collection;
                        }

                        _currentStationNamesCollection = stationNames;
                    }
                }
            }

            string fromStation = tbStationFrom.Text;
            string toStation = tbStationTo.Text;
            if (fromStation != "" && toStation != "")
            {
                btnSearch.Enabled = true;
            }
            else btnSearch.Enabled = false;
        }


        private void btnAbfahrt_Click(object sender, EventArgs e)
        {
            
            lvConnectionTab.Items.Clear();
            string fromStation = tbStationTable.Text;

            if (fromStation != "")
            {


                StationBoardRoot possibleStations;
                possibleStations = _transport.GetStationBoard(fromStation, "");
                    foreach (StationBoard station in possibleStations.Entries)
                {
                    var lvi = new ListViewItem(new string[] { station.Stop.Departure.TimeOfDay.ToString(), station.To  });
                    lvConnectionTab.Items.Add(lvi);
                }
            }
        }

        private void btnSearchStations_Click(object sender, EventArgs e)
        {
            lvSearchStations.Items.Clear();
            var stations = _transport.GetStations(tbStation.Text);

            if (stations != null)
            {
                if (stations.StationList.Count > 0)
                {
                    string[] stationNames = stations.StationList.Select(station => station.Name).ToArray();
                    foreach(string stationName in stationNames)
                    {
                        lvSearchStations.Items.Add(new ListViewItem(stationName));
                    }

                }
                

            }


        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Die App ist noch im Aufbau ;)");
        }
    }
}