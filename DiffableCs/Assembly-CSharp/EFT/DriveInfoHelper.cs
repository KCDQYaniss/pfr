namespace EFT;

internal static class DriveInfoHelper
{
	internal class DriveInfo
	{
		[CompilerGenerated]
		private string <DriveName>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private string <RootDirectory>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private DriveType <DriveType>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private bool <IsReady>k__BackingField; //Field offset: 0x24

		public private string DriveName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private DriveType DriveType
		{
			[CompilerGenerated]
			 get { } //Length: 4
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private bool IsReady
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public private string RootDirectory
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public DriveInfo() { }

		[CompilerGenerated]
		public string get_DriveName() { }

		[CompilerGenerated]
		public DriveType get_DriveType() { }

		[CompilerGenerated]
		public bool get_IsReady() { }

		[CompilerGenerated]
		public string get_RootDirectory() { }

		public static DriveInfo GetDriverInfo(string driveName) { }

		[CompilerGenerated]
		private void set_DriveName(string value) { }

		[CompilerGenerated]
		private void set_DriveType(DriveType value) { }

		[CompilerGenerated]
		private void set_IsReady(bool value) { }

		[CompilerGenerated]
		private void set_RootDirectory(string value) { }

		public bool SetUp(string driveName) { }

	}


	internal static List GetDrives() { }

	private static uint GetDriveType(string lpRootPathName) { }

	private static uint GetLogicalDrives() { }

	private static string[] GetLogicalDrivesList() { }

}

