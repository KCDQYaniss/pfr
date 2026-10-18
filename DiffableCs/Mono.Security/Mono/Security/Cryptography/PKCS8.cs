namespace Mono.Security.Cryptography;

public sealed class PKCS8
{
	internal class EncryptedPrivateKeyInfo
	{
		private string _algorithm; //Field offset: 0x10
		private byte[] _salt; //Field offset: 0x18
		private int _iterations; //Field offset: 0x20
		private byte[] _data; //Field offset: 0x28

		public string Algorithm
		{
			 get { } //Length: 5
			 set { } //Length: 82
		}

		public byte[] EncryptedData
		{
			 get { } //Length: 124
			 set { } //Length: 210
		}

		public int IterationCount
		{
			 get { } //Length: 4
			 set { } //Length: 126
		}

		public byte[] Salt
		{
			 get { } //Length: 267
		}

		public EncryptedPrivateKeyInfo() { }

		public EncryptedPrivateKeyInfo(byte[] data) { }

		private void Decode(byte[] data) { }

		public string get_Algorithm() { }

		public byte[] get_EncryptedData() { }

		public int get_IterationCount() { }

		public byte[] get_Salt() { }

		public byte[] GetBytes() { }

		public void set_Algorithm(string value) { }

		public void set_EncryptedData(byte[] value) { }

		public void set_IterationCount(int value) { }

	}

	internal class PrivateKeyInfo
	{
		private int _version; //Field offset: 0x10
		private string _algorithm; //Field offset: 0x18
		private byte[] _key; //Field offset: 0x20
		private ArrayList _list; //Field offset: 0x28

		public string Algorithm
		{
			 get { } //Length: 5
			 set { } //Length: 82
		}

		public byte[] PrivateKey
		{
			 get { } //Length: 126
			 set { } //Length: 318
		}

		public PrivateKeyInfo() { }

		public PrivateKeyInfo(byte[] data) { }

		private void Decode(byte[] data) { }

		public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

		public static RSA DecodeRSA(byte[] keypair) { }

		public static byte[] Encode(RSA rsa) { }

		public static byte[] Encode(DSA dsa) { }

		public static byte[] Encode(AsymmetricAlgorithm aa) { }

		public string get_Algorithm() { }

		public byte[] get_PrivateKey() { }

		public byte[] GetBytes() { }

		private static byte[] Normalize(byte[] bigInt, int length) { }

		private static byte[] RemoveLeadingZero(byte[] bigInt) { }

		public void set_Algorithm(string value) { }

		public void set_PrivateKey(byte[] value) { }

	}


}

