namespace EFT.Utilities;

public static class GetDriveTypeUtility
{
	private struct ATA_PASS_THROUGH_EX
	{
		public ushort Length; //Field offset: 0x0
		public ushort AtaFlags; //Field offset: 0x2
		public byte PathId; //Field offset: 0x4
		public byte TargetId; //Field offset: 0x5
		public byte Lun; //Field offset: 0x6
		public byte ReservedAsUchar; //Field offset: 0x7
		public uint DataTransferLength; //Field offset: 0x8
		public uint TimeOutValue; //Field offset: 0xC
		public uint ReservedAsUlong; //Field offset: 0x10
		public IntPtr DataBufferOffset; //Field offset: 0x18
		public byte[] PreviousTaskFile; //Field offset: 0x20
		public byte[] CurrentTaskFile; //Field offset: 0x28

	}

	private struct ATAIdentifyDeviceQuery
	{
		public ATA_PASS_THROUGH_EX header; //Field offset: 0x0
		public ushort[] data; //Field offset: 0x30

	}

	private struct DEVICE_SEEK_PENALTY_DESCRIPTOR
	{
		public uint Version; //Field offset: 0x0
		public uint Size; //Field offset: 0x4
		public bool IncursSeekPenalty; //Field offset: 0x8

	}

	private struct DISK_EXTENT
	{
		public uint DiskNumber; //Field offset: 0x0
		public long StartingOffset; //Field offset: 0x8
		public long ExtentLength; //Field offset: 0x10

	}

	private struct STORAGE_PROPERTY_QUERY
	{
		public uint PropertyId; //Field offset: 0x0
		public uint QueryType; //Field offset: 0x4
		public byte[] AdditionalParameters; //Field offset: 0x8

	}

	private struct VOLUME_DISK_EXTENTS
	{
		public uint NumberOfDiskExtents; //Field offset: 0x0
		public DISK_EXTENT[] Extents; //Field offset: 0x8

	}

	private const uint GENERIC_READ = 2147483648; //Field offset: 0x0
	private const uint PropertyStandardQuery = 0; //Field offset: 0x0
	private const uint StorageDeviceSeekPenaltyProperty = 7; //Field offset: 0x0
	private const uint IOCTL_VOLUME_BASE = 86; //Field offset: 0x0
	private const uint FILE_WRITE_ACCESS = 2; //Field offset: 0x0
	private const uint FILE_READ_ACCESS = 1; //Field offset: 0x0
	private const uint FILE_ANY_ACCESS = 0; //Field offset: 0x0
	private const uint METHOD_BUFFERED = 0; //Field offset: 0x0
	private const uint ATA_FLAGS_DATA_IN = 2; //Field offset: 0x0
	private const uint IOCTL_SCSI_BASE = 4; //Field offset: 0x0
	private const uint IOCTL_STORAGE_BASE = 45; //Field offset: 0x0
	private const uint FILE_DEVICE_MASS_STORAGE = 45; //Field offset: 0x0
	private const uint FILE_ATTRIBUTE_NORMAL = 128; //Field offset: 0x0
	private const uint OPEN_EXISTING = 3; //Field offset: 0x0
	private const uint FILE_SHARE_WRITE = 2; //Field offset: 0x0
	private const uint FILE_SHARE_READ = 1; //Field offset: 0x0
	private const uint GENERIC_WRITE = 1073741824; //Field offset: 0x0
	private const uint FILE_DEVICE_CONTROLLER = 4; //Field offset: 0x0
	private const uint FORMAT_MESSAGE_FROM_SYSTEM = 4096; //Field offset: 0x0

	private static SafeFileHandle CreateFileW(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile) { }

	private static uint CTL_CODE(uint DeviceType, uint Function, uint Method, uint Access) { }

	private static bool DeviceIoControl(SafeFileHandle hDevice, uint dwIoControlCode, ref STORAGE_PROPERTY_QUERY lpInBuffer, uint nInBufferSize, ref DEVICE_SEEK_PENALTY_DESCRIPTOR lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped) { }

	private static bool DeviceIoControl(SafeFileHandle hDevice, uint dwIoControlCode, ref ATAIdentifyDeviceQuery lpInBuffer, uint nInBufferSize, ref ATAIdentifyDeviceQuery lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped) { }

	private static bool DeviceIoControl(SafeFileHandle hDevice, uint dwIoControlCode, IntPtr lpInBuffer, uint nInBufferSize, ref VOLUME_DISK_EXTENTS lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped) { }

	private static uint FormatMessage(uint dwFlags, IntPtr lpSource, uint dwMessageId, uint dwLanguageId, StringBuilder lpBuffer, uint nSize, IntPtr Arguments) { }

	private static uint GetDiskExtents(string cDrive) { }

	public static string GetDriveTypeName(string directoryPath) { }

	private static string GetErrorMessage(int code) { }

	private static bool HasNominalMediaRotationRate(string sDrive) { }

	private static bool HasSeekPenalty(string sDrive) { }

}

