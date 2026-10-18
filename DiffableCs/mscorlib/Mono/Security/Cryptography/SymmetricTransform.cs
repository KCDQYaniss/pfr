namespace Mono.Security.Cryptography;

internal abstract class SymmetricTransform : ICryptoTransform, IDisposable
{
	protected SymmetricAlgorithm algo; //Field offset: 0x10
	protected bool encrypt; //Field offset: 0x18
	protected int BlockSizeByte; //Field offset: 0x1C
	protected byte[] temp; //Field offset: 0x20
	protected byte[] temp2; //Field offset: 0x28
	private byte[] workBuff; //Field offset: 0x30
	private byte[] workout; //Field offset: 0x38
	protected PaddingMode padmode; //Field offset: 0x40
	protected int FeedBackByte; //Field offset: 0x44
	private bool m_disposed; //Field offset: 0x48
	protected bool lastBlock; //Field offset: 0x49
	private RandomNumberGenerator _rng; //Field offset: 0x50

	public override bool CanTransformMultipleBlocks
	{
		 get { } //Length: 3
	}

	public override int InputBlockSize
	{
		 get { } //Length: 4
	}

	private bool KeepLastBlock
	{
		private get { } //Length: 23
	}

	public override int OutputBlockSize
	{
		 get { } //Length: 4
	}

	public SymmetricTransform(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	protected override void CBC(byte[] input, byte[] output) { }

	protected override void CFB(byte[] input, byte[] output) { }

	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	protected override void CTS(byte[] input, byte[] output) { }

	protected override void Dispose(bool disposing) { }

	protected abstract void ECB(byte[] input, byte[] output) { }

	protected override byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	protected override byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	protected virtual void Finalize() { }

	public override bool get_CanTransformMultipleBlocks() { }

	public override int get_InputBlockSize() { }

	private bool get_KeepLastBlock() { }

	public override int get_OutputBlockSize() { }

	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	protected override void OFB(byte[] input, byte[] output) { }

	private void Random(byte[] buffer, int start, int length) { }

	private override void System.IDisposable.Dispose() { }

	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	protected override void Transform(byte[] input, byte[] output) { }

	public override int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public override byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

