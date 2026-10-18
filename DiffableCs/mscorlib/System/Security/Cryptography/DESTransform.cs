namespace System.Security.Cryptography;

internal class DESTransform : SymmetricTransform
{
	internal static readonly int KEY_BIT_SIZE; //Field offset: 0x0
	internal static readonly int KEY_BYTE_SIZE; //Field offset: 0x4
	internal static readonly int BLOCK_BIT_SIZE; //Field offset: 0x8
	internal static readonly int BLOCK_BYTE_SIZE; //Field offset: 0xC
	private static readonly uint[] spBoxes; //Field offset: 0x10
	private static readonly byte[] PC1; //Field offset: 0x18
	private static readonly byte[] leftRotTotal; //Field offset: 0x20
	private static readonly byte[] PC2; //Field offset: 0x28
	internal static readonly uint[] ipTab; //Field offset: 0x30
	internal static readonly uint[] fpTab; //Field offset: 0x38
	private byte[] keySchedule; //Field offset: 0x58
	private byte[] byteBuff; //Field offset: 0x60
	private uint[] dwordBuff; //Field offset: 0x68

	private static DESTransform() { }

	internal DESTransform(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	private static void BSwap(byte[] byteBuff) { }

	private uint CipherFunct(uint r, int n) { }

	protected virtual void ECB(byte[] input, byte[] output) { }

	internal static byte[] GetStrongKey() { }

	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	public void ProcessBlock(byte[] input, byte[] output) { }

	internal void SetKey(byte[] key) { }

}

