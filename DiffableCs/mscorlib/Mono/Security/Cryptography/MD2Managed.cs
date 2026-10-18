namespace Mono.Security.Cryptography;

internal class MD2Managed : MD2
{
	private static readonly byte[] PI_SUBST; //Field offset: 0x0
	private byte[] state; //Field offset: 0x28
	private byte[] checksum; //Field offset: 0x30
	private byte[] buffer; //Field offset: 0x38
	private int count; //Field offset: 0x40
	private byte[] x; //Field offset: 0x48

	private static MD2Managed() { }

	public MD2Managed() { }

	protected virtual void HashCore(byte[] array, int ibStart, int cbSize) { }

	protected virtual byte[] HashFinal() { }

	public virtual void Initialize() { }

	private void MD2Transform(byte[] state, byte[] checksum, byte[] block, int index) { }

	private byte[] Padding(int nLength) { }

}

