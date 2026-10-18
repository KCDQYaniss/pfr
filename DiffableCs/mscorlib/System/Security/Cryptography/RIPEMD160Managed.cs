namespace System.Security.Cryptography;

[ComVisible(True)]
public class RIPEMD160Managed : RIPEMD160
{
	private byte[] _buffer; //Field offset: 0x28
	private long _count; //Field offset: 0x30
	private uint[] _stateMD160; //Field offset: 0x38
	private uint[] _blockDWords; //Field offset: 0x40

	private byte[] _EndHash() { }

	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	public RIPEMD160Managed() { }

	private static uint F(uint x, uint y, uint z) { }

	private static uint G(uint x, uint y, uint z) { }

	private static uint H(uint x, uint y, uint z) { }

	protected virtual void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	protected virtual byte[] HashFinal() { }

	private static uint I(uint x, uint y, uint z) { }

	public virtual void Initialize() { }

	private void InitializeState() { }

	private static uint J(uint x, uint y, uint z) { }

	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

}

