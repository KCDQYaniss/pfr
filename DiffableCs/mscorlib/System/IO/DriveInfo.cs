namespace System.IO;

[ComVisible(True)]
public sealed class DriveInfo : ISerializable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison <>9__3_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__3_0(DriveInfo di1, DriveInfo di2) { }

	}

	private string drive_format; //Field offset: 0x10
	private string path; //Field offset: 0x18

	public DriveType DriveType
	{
		 get { } //Length: 15
	}

	public string Name
	{
		 get { } //Length: 5
	}

	private DriveInfo(string path, string fstype) { }

	public DriveInfo(string driveName) { }

	public DriveType get_DriveType() { }

	public string get_Name() { }

	private static string GetDriveFormat(string rootPathName) { }

	private static string GetDriveFormatInternal(char* rootPathName, int rootPathName_length) { }

	[MonoTODO("In windows, alldrives are 'Fixed'")]
	public static DriveInfo[] GetDrives() { }

	private static uint GetDriveTypeInternal(char* rootPathName, int rootPathName_length) { }

	private static uint GetDriveTypeInternal(string rootPathName) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	public virtual string ToString() { }

}

