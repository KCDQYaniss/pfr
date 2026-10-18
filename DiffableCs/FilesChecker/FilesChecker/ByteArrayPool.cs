namespace FilesChecker;

internal class ByteArrayPool
{
	private readonly int _arraySize; //Field offset: 0x10
	private readonly Stack _pool; //Field offset: 0x18

	public ByteArrayPool(int arraySize) { }

	public byte[] Rent() { }

	public void Return(byte[] array) { }

}

