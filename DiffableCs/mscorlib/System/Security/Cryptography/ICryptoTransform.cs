namespace System.Security.Cryptography;

[ComVisible(True)]
public interface ICryptoTransform : IDisposable
{

	public bool CanTransformMultipleBlocks
	{
		 get { } //Length: 0
	}

	public int InputBlockSize
	{
		 get { } //Length: 0
	}

	public int OutputBlockSize
	{
		 get { } //Length: 0
	}

	public bool get_CanTransformMultipleBlocks() { }

	public int get_InputBlockSize() { }

	public int get_OutputBlockSize() { }

	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

