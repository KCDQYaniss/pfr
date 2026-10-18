namespace DriveAnalyzing;

public static class DriveAnalyzer
{
	private struct DeviceSeekPenaltyDescriptor
	{
		public int Version; //Field offset: 0x0
		public int Size; //Field offset: 0x4
		public bool IncursSeekPenalty; //Field offset: 0x8

	}

	private enum StoragePropertyId
	{
		StorageDeviceProperty = 0,
		StorageAdapterProperty = 1,
		StorageDeviceIdProperty = 2,
		StorageDeviceUniqueIdProperty = 3,
		StorageDeviceWriteCacheProperty = 4,
		StorageMiniportProperty = 5,
		StorageAccessAlignmentProperty = 6,
		StorageDeviceSeekPenaltyProperty = 7,
		StorageDeviceTrimProperty = 8,
		StorageDeviceWriteAggregationProperty = 9,
		StorageDeviceDeviceTelemetryProperty = 10,
		StorageDeviceLBProvisioningProperty = 11,
		StorageDevicePowerProperty = 12,
		StorageDeviceCopyOffloadProperty = 13,
		StorageDeviceResiliencyProperty = 14,
		StorageDeviceMediumProductType = 15,
		StorageAdapterRpmbProperty = 16,
		StorageAdapterCryptoProperty = 17,
		StorageDeviceIoCapabilityProperty = 18,
		StorageAdapterProtocolSpecificProperty = 19,
		StorageDeviceProtocolSpecificProperty = 20,
		StorageAdapterTemperatureProperty = 21,
		StorageDeviceTemperatureProperty = 22,
		StorageAdapterPhysicalTopologyProperty = 23,
		StorageDevicePhysicalTopologyProperty = 24,
		StorageDeviceAttributesProperty = 25,
		StorageDeviceManagementStatus = 26,
		StorageAdapterSerialNumberProperty = 27,
		StorageDeviceLocationProperty = 28,
		StorageDeviceNumaProperty = 29,
		StorageDeviceZonedDeviceProperty = 30,
		StorageDeviceUnsafeShutdownCount = 31,
	}

	private struct StoragePropertyQuery
	{
		public StoragePropertyId PropertyId; //Field offset: 0x0
		public StorageQueryType QueryType; //Field offset: 0x4
		public byte AdditionalParameters; //Field offset: 0x8

	}

	private enum StorageQueryType
	{
		PropertyStandardQuery = 0,
		PropertyExistsQuery = 1,
		PropertyMaskQuery = 2,
		PropertyQueryMaxDefined = 3,
	}

	private const int IOCtlStorageQueryProperty = 2954240; //Field offset: 0x0
	private const uint FileShareRead = 1; //Field offset: 0x0
	private const uint FileShareWrite = 2; //Field offset: 0x0
	private const uint OpenExisting = 3; //Field offset: 0x0
	private const uint FileAttributeNormal = 128; //Field offset: 0x0

	private static SafeFileHandle CreateFileW(string lpFileName, uint dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, IntPtr hTemplateFile) { }

	private static bool DeviceIoControl(in SafeFileHandle hDevice, in int dwIoControlCode, in void* lpInBuffer, in int nInBufferSize, out void* lpOutBuffer, in int nOutBufferSize, out int lpBytesReturned, in IntPtr lpOverlapped) { }

	public static bool IsSsd(string driveLetter) { }

}

