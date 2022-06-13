using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Hardware.Info;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace monitor__ {

	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainWindow : Window {

		public MainWindow() {
			this.InitializeComponent();
		}

		private void myButton_Click(object sender, RoutedEventArgs e) {
			myButton.Content = "Clicked";
		}
	}

	class hiMom {
		static readonly IHardwareInfo hardwareInfo = new HardwareInfo();

		public static void mom(string[] args) {
			//hardwareInfo.RefreshMemoryStatus();
			//hardwareInfo.RefreshBatteryList();
			//hardwareInfo.RefreshBIOSList();
			//hardwareInfo.RefreshCPUList();
			//hardwareInfo.RefreshDriveList();
			//hardwareInfo.RefreshKeyboardList();
			//hardwareInfo.RefreshMemoryList();
			//hardwareInfo.RefreshMonitorList();
			//hardwareInfo.RefreshMotherboardList();
			//hardwareInfo.RefreshMouseList();
			//hardwareInfo.RefreshNetworkAdapterList();
			//hardwareInfo.RefreshPrinterList();
			//hardwareInfo.RefreshSoundDeviceList();
			//hardwareInfo.RefreshVideoControllerList();

			hardwareInfo.RefreshAll();

			Console.WriteLine(hardwareInfo.MemoryStatus);

			foreach (var hardware in hardwareInfo.BatteryList)
				Console.WriteLine(hardware);

			foreach (var hardware in hardwareInfo.BiosList)
				Console.WriteLine(hardware);

			foreach (var cpu in hardwareInfo.CpuList) {
				Console.WriteLine(cpu);

				foreach (var cpuCore in cpu.CpuCoreList)
					Console.WriteLine(cpuCore);
			}

			Console.ReadLine();

			foreach (var drive in hardwareInfo.DriveList) {
				Console.WriteLine(drive);

				foreach (var partition in drive.PartitionList) {
					Console.WriteLine(partition);

					foreach (var volume in partition.VolumeList)
						Console.WriteLine(volume);
				}
			}

			Console.ReadLine();

			foreach (var hardware in hardwareInfo.KeyboardList)
				Console.WriteLine(hardware);

			foreach (var hardware in hardwareInfo.MemoryList)
				Console.WriteLine(hardware);

			foreach (var hardware in hardwareInfo.MonitorList)
				Console.WriteLine(hardware);

			foreach (var hardware in hardwareInfo.MotherboardList)
				Console.WriteLine(hardware);

			foreach (var hardware in hardwareInfo.MouseList)
				Console.WriteLine(hardware);

			foreach (var hardware in hardwareInfo.NetworkAdapterList)
				Console.WriteLine(hardware);

			foreach (var hardware in hardwareInfo.PrinterList)
				Console.WriteLine(hardware);

			foreach (var hardware in hardwareInfo.SoundDeviceList)
				Console.WriteLine(hardware);

			foreach (var hardware in hardwareInfo.VideoControllerList)
				Console.WriteLine(hardware);

			Console.ReadLine();

			foreach (var address in HardwareInfo.GetLocalIPv4Addresses())
				Console.WriteLine(address);

			Console.ReadLine();
		}
	}
}
