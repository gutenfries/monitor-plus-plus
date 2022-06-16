using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hardware.Info;

// yeah this is a joke for now...

namespace monitor__.CLI {
	internal class Program {
		static readonly IHardwareInfo hardwareInfo = new HardwareInfo();
		static void Main(string[] args) {

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

			foreach (var hardware in hardwareInfo.BatteryList) {
				Console.WriteLine(hardware);
			};
			foreach (var hardware in hardwareInfo.BiosList) {
				Console.WriteLine(hardware);
			};
			foreach (var cpu in hardwareInfo.CpuList) {
				Console.WriteLine(cpu);
				foreach (var cpuCore in cpu.CpuCoreList) {
					Console.WriteLine(cpuCore);
				};
			};
			foreach (var drive in hardwareInfo.DriveList) {
				Console.WriteLine(drive);
				foreach (var partition in drive.PartitionList) {
					Console.WriteLine(partition);
					foreach (var volume in partition.VolumeList) {
						Console.WriteLine(volume);
					};
				};
			};
			foreach (var hardware in hardwareInfo.KeyboardList) {
				Console.WriteLine(hardware);
			};
			foreach (var hardware in hardwareInfo.MemoryList) {
				Console.WriteLine(hardware);
			};
			foreach (var hardware in hardwareInfo.MonitorList) {
				Console.WriteLine(hardware);
			};
			foreach (var hardware in hardwareInfo.MotherboardList) {
				Console.WriteLine(hardware);
			};
			foreach (var hardware in hardwareInfo.MouseList) {
				Console.WriteLine(hardware);
			};
			foreach (var hardware in hardwareInfo.NetworkAdapterList) {
				Console.WriteLine(hardware);
			};
			// foreach (var hardware in hardwareInfo.PrinterList) {
			// 	Console.WriteLine(hardware);
			// };
			foreach (var hardware in hardwareInfo.SoundDeviceList) {
				Console.WriteLine(hardware);
			};
			foreach (var hardware in hardwareInfo.VideoControllerList) {
				Console.WriteLine(hardware);
			};
			//foreach (var address in HardwareInfo.GetLocalIPv4Addresses(NetworkInterfaceType.Ethernet, OperationalStatus.Up))
			//	Console.WriteLine(address);

			//Console.WriteLine();

			//foreach (var address in HardwareInfo.GetLocalIPv4Addresses(NetworkInterfaceType.Wireless80211))
			//	Console.WriteLine(address);

			//Console.WriteLine();

			//foreach (var address in HardwareInfo.GetLocalIPv4Addresses(OperationalStatus.Up))
			//	Console.WriteLine(address);

			//Console.WriteLine();
			foreach (var address in HardwareInfo.GetLocalIPv4Addresses()) {
				Console.WriteLine(address);
			};
		}
	};
};
