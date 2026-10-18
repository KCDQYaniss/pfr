namespace System.Security.Cryptography;

internal class AesTransform : SymmetricTransform
{
	private static readonly uint[] Rcon; //Field offset: 0x0
	private static readonly byte[] SBox; //Field offset: 0x8
	private static readonly byte[] iSBox; //Field offset: 0x10
	private static readonly uint[] T0; //Field offset: 0x18
	private static readonly uint[] T1; //Field offset: 0x20
	private static readonly uint[] T2; //Field offset: 0x28
	private static readonly uint[] T3; //Field offset: 0x30
	private static readonly uint[] iT0; //Field offset: 0x38
	private static readonly uint[] iT1; //Field offset: 0x40
	private static readonly uint[] iT2; //Field offset: 0x48
	private static readonly uint[] iT3; //Field offset: 0x50
	private uint[] expandedKey; //Field offset: 0x58
	private int Nk; //Field offset: 0x60
	private int Nr; //Field offset: 0x64

	private static AesTransform() { }

	public AesTransform(Aes algo, bool encryption, byte[] key, byte[] iv) { }

	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	protected virtual void ECB(byte[] input, byte[] output) { }

	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	private uint SubByte(uint a) { }

}

