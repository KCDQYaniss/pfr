namespace EFT;

public sealed class ClientHardwareDescription
{
	public string deviceUniqueIdentifier; //Field offset: 0x10
	public int systemMemorySize; //Field offset: 0x18
	public int graphicsDeviceID; //Field offset: 0x1C
	public string graphicsDeviceName; //Field offset: 0x20
	public string graphicsDeviceType; //Field offset: 0x28
	public string graphicsDeviceVendor; //Field offset: 0x30
	public int graphicsDeviceVendorID; //Field offset: 0x38
	public string graphicsDeviceVersion; //Field offset: 0x40
	public int graphicsMemorySize; //Field offset: 0x48
	public bool graphicsMultiThreaded; //Field offset: 0x4C
	public int graphicsShaderLevel; //Field offset: 0x50
	public string operatingSystem; //Field offset: 0x58
	public int processorCount; //Field offset: 0x60
	public int processorFrequency; //Field offset: 0x64
	public string processorType; //Field offset: 0x68
	public EDriveType driveType; //Field offset: 0x70
	public EDriveType swapDriveType; //Field offset: 0x74

	public ClientHardwareDescription() { }

}

