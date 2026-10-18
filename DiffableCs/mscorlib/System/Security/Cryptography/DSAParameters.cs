namespace System.Security.Cryptography;

[ComVisible(True)]
public struct DSAParameters
{
	public byte[] P; //Field offset: 0x0
	public byte[] Q; //Field offset: 0x8
	public byte[] G; //Field offset: 0x10
	public byte[] Y; //Field offset: 0x18
	public byte[] J; //Field offset: 0x20
	public byte[] X; //Field offset: 0x28
	public byte[] Seed; //Field offset: 0x30
	public int Counter; //Field offset: 0x38

}

