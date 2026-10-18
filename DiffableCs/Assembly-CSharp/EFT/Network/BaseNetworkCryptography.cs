namespace EFT.Network;

public abstract class BaseNetworkCryptography
{
	public const int BUFFER_SIZE = 65535; //Field offset: 0x0
	public const int BUFFER_OVERHAND_SIZE = 16; //Field offset: 0x0
	private readonly byte[] _destinationArray; //Field offset: 0x10
	protected bool encryptionEnabled; //Field offset: 0x18
	protected bool decryptionEnabled; //Field offset: 0x19
	private readonly byte[] _defaultKey; //Field offset: 0x20

	protected BaseNetworkCryptography(bool encryptionEnabled, bool decryptionEnabled) { }

	public ArraySegment Decrypt(ArraySegment source) { }

	public ArraySegment Decrypt(byte[] sourceArray, int sourceIndex, int sourceLength) { }

	public ArraySegment Decrypt(ArraySegment source, byte[] destinationArray) { }

	public ArraySegment Decrypt(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray) { }

	public abstract void Decrypt(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray, int destinationIndex, out int destinationLength) { }

	protected void DefaultDecrypt(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray, int destinationIndex, out int destinationLength) { }

	protected void DefaultEncrypt(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray, int destinationIndex, out int destinationLength) { }

	public ArraySegment Encrypt(ArraySegment source) { }

	public ArraySegment Encrypt(byte[] sourceArray, int sourceIndex, int sourceLength) { }

	public ArraySegment Encrypt(ArraySegment source, byte[] destinationArray) { }

	public ArraySegment Encrypt(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray) { }

	public abstract void Encrypt(byte[] sourceArray, int sourceIndex, int sourceLength, byte[] destinationArray, int destinationIndex, out int destinationLength) { }

}

