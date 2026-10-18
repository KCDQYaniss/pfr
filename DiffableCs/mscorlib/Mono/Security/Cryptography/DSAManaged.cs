namespace Mono.Security.Cryptography;

internal class DSAManaged : DSA
{
	internal sealed class KeyGeneratedEventHandler : MulticastDelegate
	{

		public KeyGeneratedEventHandler(object object, IntPtr method) { }

		public override void Invoke(object sender, EventArgs e) { }

	}

	private bool keypairGenerated; //Field offset: 0x20
	private bool m_disposed; //Field offset: 0x21
	private BigInteger p; //Field offset: 0x28
	private BigInteger q; //Field offset: 0x30
	private BigInteger g; //Field offset: 0x38
	private BigInteger x; //Field offset: 0x40
	private BigInteger y; //Field offset: 0x48
	private BigInteger j; //Field offset: 0x50
	private BigInteger seed; //Field offset: 0x58
	private int counter; //Field offset: 0x60
	private bool j_missing; //Field offset: 0x64
	private RandomNumberGenerator rng; //Field offset: 0x68
	[CompilerGenerated]
	private KeyGeneratedEventHandler KeyGenerated; //Field offset: 0x70

	public event KeyGeneratedEventHandler KeyGenerated
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public virtual int KeySize
	{
		 get { } //Length: 43
	}

	public bool PublicOnly
	{
		 get { } //Length: 99
	}

	private RandomNumberGenerator Random
	{
		private get { } //Length: 117
	}

	public DSAManaged(int dwKeySize) { }

	private void add(byte[] a, byte[] b, int value) { }

	[CompilerGenerated]
	public void add_KeyGenerated(KeyGeneratedEventHandler value) { }

	protected virtual void Dispose(bool disposing) { }

	public virtual DSAParameters ExportParameters(bool includePrivateParameters) { }

	protected virtual void Finalize() { }

	private void Generate() { }

	private void GenerateKeyPair() { }

	private void GenerateParams(int keyLength) { }

	public virtual int get_KeySize() { }

	public bool get_PublicOnly() { }

	private RandomNumberGenerator get_Random() { }

	public virtual void ImportParameters(DSAParameters parameters) { }

	private byte[] NormalizeArray(byte[] array) { }

	[CompilerGenerated]
	public void remove_KeyGenerated(KeyGeneratedEventHandler value) { }

	public virtual bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

}

