namespace System.Security.Cryptography;

[ComVisible(True)]
public struct RSAParameters
{
	public byte[] Exponent; //Field offset: 0x0
	public byte[] Modulus; //Field offset: 0x8
	public byte[] P; //Field offset: 0x10
	public byte[] Q; //Field offset: 0x18
	public byte[] DP; //Field offset: 0x20
	public byte[] DQ; //Field offset: 0x28
	public byte[] InverseQ; //Field offset: 0x30
	public byte[] D; //Field offset: 0x38

}

