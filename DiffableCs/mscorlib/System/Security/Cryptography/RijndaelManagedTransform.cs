namespace System.Security.Cryptography;

[ComVisible(True)]
public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable
{
	private static readonly byte[] s_Sbox; //Field offset: 0x0
	private static readonly int[] s_Rcon; //Field offset: 0x8
	private static readonly int[] s_T; //Field offset: 0x10
	private static readonly int[] s_TF; //Field offset: 0x18
	private static readonly int[] s_iT; //Field offset: 0x20
	private static readonly int[] s_iTF; //Field offset: 0x28
	private CipherMode m_cipherMode; //Field offset: 0x10
	private PaddingMode m_paddingValue; //Field offset: 0x14
	private RijndaelManagedTransformMode m_transformMode; //Field offset: 0x18
	private int m_blockSizeBits; //Field offset: 0x1C
	private int m_blockSizeBytes; //Field offset: 0x20
	private int m_inputBlockSize; //Field offset: 0x24
	private int m_outputBlockSize; //Field offset: 0x28
	private int[] m_encryptKeyExpansion; //Field offset: 0x30
	private int[] m_decryptKeyExpansion; //Field offset: 0x38
	private int m_Nr; //Field offset: 0x40
	private int m_Nb; //Field offset: 0x44
	private int m_Nk; //Field offset: 0x48
	private int[] m_encryptindex; //Field offset: 0x50
	private int[] m_decryptindex; //Field offset: 0x58
	private int[] m_IV; //Field offset: 0x60
	private int[] m_lastBlockBuffer; //Field offset: 0x68
	private byte[] m_depadBuffer; //Field offset: 0x70
	private byte[] m_shiftRegister; //Field offset: 0x78

	public override bool CanTransformMultipleBlocks
	{
		 get { } //Length: 3
	}

	public override int InputBlockSize
	{
		 get { } //Length: 4
	}

	public override int OutputBlockSize
	{
		 get { } //Length: 4
	}

	private static RijndaelManagedTransform() { }

	internal RijndaelManagedTransform(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

	private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	public override void Dispose() { }

	private void Dispose(bool disposing) { }

	private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

	private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	private void GenerateKeyExpansion(byte[] rgbKey) { }

	public override bool get_CanTransformMultipleBlocks() { }

	public override int get_InputBlockSize() { }

	public override int get_OutputBlockSize() { }

	private static int MulX(int x) { }

	public void Reset() { }

	private static int rot1(int val) { }

	private static int rot2(int val) { }

	private static int rot3(int val) { }

	private static int SubWord(int a) { }

	public override int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	public override byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

