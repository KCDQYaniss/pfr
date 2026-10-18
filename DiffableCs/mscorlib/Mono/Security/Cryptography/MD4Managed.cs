namespace Mono.Security.Cryptography;

internal class MD4Managed : MD4
{
	private uint[] state; //Field offset: 0x28
	private byte[] buffer; //Field offset: 0x30
	private uint[] count; //Field offset: 0x38
	private uint[] x; //Field offset: 0x40
	private byte[] digest; //Field offset: 0x48

	public MD4Managed() { }

	private void Decode(uint[] output, byte[] input, int index) { }

	private void Encode(byte[] output, uint[] input) { }

	private uint F(uint x, uint y, uint z) { }

	private void FF(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	private uint G(uint x, uint y, uint z) { }

	private void GG(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	private uint H(uint x, uint y, uint z) { }

	protected virtual void HashCore(byte[] array, int ibStart, int cbSize) { }

	protected virtual byte[] HashFinal() { }

	private void HH(ref uint a, uint b, uint c, uint d, uint x, byte s) { }

	public virtual void Initialize() { }

	private void MD4Transform(uint[] state, byte[] block, int index) { }

	private byte[] Padding(int nLength) { }

	private uint ROL(uint x, byte n) { }

}

