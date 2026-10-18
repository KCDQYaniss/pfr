namespace System.Security.Cryptography;

public abstract class HashAlgorithm : IDisposable, ICryptoTransform
{
	private bool _disposed; //Field offset: 0x10
	protected int HashSizeValue; //Field offset: 0x14
	protected private byte[] HashValue; //Field offset: 0x18
	protected int State; //Field offset: 0x20

	public override bool CanTransformMultipleBlocks
	{
		 get { } //Length: 3
	}

	public override byte[] Hash
	{
		 get { } //Length: 267
	}

	public override int HashSize
	{
		 get { } //Length: 4
	}

	public override int InputBlockSize
	{
		 get { } //Length: 6
	}

	public override int OutputBlockSize
	{
		 get { } //Length: 6
	}

	protected HashAlgorithm() { }

	private byte[] CaptureHashCodeAndReinitialize() { }

	public void Clear() { }

	public byte[] ComputeHash(byte[] buffer) { }

	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	public byte[] ComputeHash(Stream inputStream) { }

	public static HashAlgorithm Create(string hashName) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public override bool get_CanTransformMultipleBlocks() { }

	public override byte[] get_Hash() { }

	public override int get_HashSize() { }

	public override int get_InputBlockSize() { }

	public override int get_OutputBlockSize() { }

	protected abstract void HashCore(byte[] array, int ibStart, int cbSize) { }

	protected abstract byte[] HashFinal() { }

	public abstract void Initialize() { }

	public override int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public override byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

