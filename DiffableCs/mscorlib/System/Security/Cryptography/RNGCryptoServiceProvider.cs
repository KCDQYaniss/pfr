namespace System.Security.Cryptography;

public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
{
	private static object _lock; //Field offset: 0x0
	private IntPtr _handle; //Field offset: 0x10

	private static RNGCryptoServiceProvider() { }

	public RNGCryptoServiceProvider() { }

	private void Check() { }

	protected virtual void Dispose(bool disposing) { }

	protected virtual void Finalize() { }

	public virtual void GetBytes(byte[] data) { }

	private static void RngClose(IntPtr handle) { }

	private static IntPtr RngGetBytes(IntPtr handle, byte* data, IntPtr data_length) { }

	private static IntPtr RngInitialize(byte* seed, IntPtr seed_length) { }

	private static bool RngOpen() { }

}

