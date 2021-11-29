using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.PointOfService;

namespace WinFormsDrawer
{
    public partial class Form1 : Form
    {

        public PosExplorer PosExplorer { get; set; }

        public PosCommon Device { get; set; }

        public PosCommon Device2 { get; set; }

        public CashDrawer Drawer => Device as CashDrawer;

        public PosPrinter Printer => Device2 as PosPrinter;
        public Form1()
        {
            InitializeComponent();

            PosExplorer = new PosExplorer(this);
            handler = new StatusUpdateEventHandler(OnStatusUpdateEvent);
            handler2 = new StatusUpdateEventHandler(OnStatusUpdateEvent2);
        }

        private void EnsureDevice()
        {
            if (Device != null)
                return;
            
            var drawerName = ConfigurationManager.AppSettings["DrawerName"];
            //"DN_CashDrawer_POSPrinter_TH250-II_USB_UDM";

            var devices = PosExplorer.GetDevices().Cast<DeviceInfo>().ToList();
            var info = devices.First(d => d.ServiceObjectName.Equals(drawerName));

            Device = PosExplorer.CreateInstance(info) as PosCommon;
        }

        private void EnsureDevice2()
        {
            if (Device2 != null)
                return;

            var printerName = ConfigurationManager.AppSettings["PrinterName"];
           // "DN_POSPrinter_TH250-II_USB_UDM";

            var devices = PosExplorer.GetDevices().Cast<DeviceInfo>().ToList();
            var info = devices.First(d => d.ServiceObjectName.Equals(printerName));

            Device2 = PosExplorer.CreateInstance(info) as PosCommon;
        }

        private void Log(Exception ex)
        {
            Log($"{ex.Message}");
        }

        private void Log(string text)
        {
            logBox.AppendText($"{DateTime.Now:HH:mm:ss} - {text}\r\n");

            logBox.Select(logBox.TextLength,0);
            logBox.ScrollToCaret();
        }

        private void btnOpen_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Log("Open Drawer!");
                Drawer?.OpenDrawer();
            }
            catch (Exception ex)
            {
                Log(ex);
            }
        }

        private void btnOposOpen_MouseClick(object sender, MouseEventArgs e)
        {
            EnsureDevice();
            if (Device == null)
            {
                Log("Device not found!");
                return;
            }

            try
            {
                Device.Open();

                Thread.Sleep(500);

                btnOposOpen.Enabled = false;
                btnOposClose.Enabled = true;
                btnOposClaim.Enabled = true;


                Device.StatusUpdateEvent += handler;
            }
            catch (Exception ex)
            {
                Log(ex);//.Dump("Error in Open"));
                return;
            }
        }

        private StatusUpdateEventHandler handler;
        private StatusUpdateEventHandler handler2;

        private void OnStatusUpdateEvent(object sender, StatusUpdateEventArgs e)
        {
            Log($"Status: {e.Status} ID: {e.EventId}");
        }

        private void OnStatusUpdateEvent2(object sender, StatusUpdateEventArgs e)
        {
            Log($"Status2: {e.Status} ID: {e.EventId}");
        }

        private void btnOposClose_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Device.StatusUpdateEvent -= handler;
                Device.Close();

                btnOposOpen.Enabled = true;
                btnOposClose.Enabled = false;
                btnOposClaim.Enabled = false;
            }
            catch (Exception ex)
            {
                Log(ex);//.Dump("Error in Open"));
                return;
            }
        }

        private void btnOposClaim_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Device.Claim(1000);
                
                btnOposClaim.Enabled = false;
                btnOposRelease.Enabled = true;
                btnOposClose.Enabled = false;
                checkDeviceEnabled.Enabled = true;
            }
            catch (Exception ex)
            {
                Log(ex);//.Dump("Error in Open"));
                return;
            }
        }

        private void btnOposRelease_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Device.Release();
            }
            catch (Exception ex)
            {
                Log(ex);//.Dump("Error in Open"));
            }

            btnOposClaim.Enabled = true;
            btnOposRelease.Enabled = false;
            btnOposClose.Enabled = true;
            checkDeviceEnabled.Enabled = false;
        }

        private void checkDeviceEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Device.DeviceEnabled = checkDeviceEnabled.Checked;

            if (checkDeviceEnabled.Checked)
            {
                btnOpen.Enabled = true;
                btnOposRelease.Enabled = false;
            }
            else
            {
                btnOpen.Enabled = false;
                btnOposRelease.Enabled = true;
            }
        }

        private void btnPrtOpen_MouseClick(object sender, MouseEventArgs e)
        {
            EnsureDevice2();
            if (Device2 == null)
            {
                Log("Device2 not found!");
                return;
            }

            try
            {
                Device2.Open();

                Thread.Sleep(500);

                btnPrtOpen.Enabled = false;
                btnPrtClose.Enabled = true;
                btnPrtClaim.Enabled = true;


                Device2.StatusUpdateEvent += handler2;
            }
            catch (Exception ex)
            {
                Log(ex);//.Dump("Error in Open"));
                return;
            }
        }

        private void btnPrtClose_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Device2.StatusUpdateEvent -= handler2;
                Device2.Close();

                btnPrtOpen.Enabled = true;
                btnPrtClose.Enabled = false;
                btnPrtClaim.Enabled = false;
            }
            catch (Exception ex)
            {
                Log(ex);//.Dump("Error in Open"));
                return;
            }
        }

        private void btnPrtClaim_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Device2.Claim(1000);

                btnPrtClaim.Enabled = false;
                btnPrtRelease.Enabled = true;
                btnPrtClose.Enabled = false;
                checkPrtEnabled.Enabled = true;
            }
            catch (Exception ex)
            {
                Log(ex);//.Dump("Error in Open"));
                return;
            }
        }

        private void btnPrtRelease_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Device2.Release();
            }
            catch (Exception ex)
            {
                Log(ex);//.Dump("Error in Open"));
            }

            btnPrtClaim.Enabled = true;
            btnPrtRelease.Enabled = false;
            btnPrtClose.Enabled = true;
            checkPrtEnabled.Enabled = false;
        }

        private void checkPrtEnabled_CheckedChanged(object sender, EventArgs e)
        {
            Device2.DeviceEnabled = checkPrtEnabled.Checked;

            if (checkPrtEnabled.Checked)
            {
                btnPrtRelease.Enabled = false;
            }
            else
            {
                btnPrtRelease.Enabled = true;
            }
        }
    }
}
