namespace UnityEngine.Build.Pipeline;

public struct BundleDetails : IEquatable
{
	[SerializeField]
	private string m_FileName; //Field offset: 0x0
	[SerializeField]
	private uint m_Crc; //Field offset: 0x8
	[SerializeField]
	private string m_Hash; //Field offset: 0x10
	[SerializeField]
	private string[] m_Dependencies; //Field offset: 0x18

	public uint Crc
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public string[] Dependencies
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public string FileName
	{
		 get { } //Length: 4
		 set { } //Length: 82
	}

	public Hash128 Hash
	{
		 get { } //Length: 115
		 set { } //Length: 158
	}

	public virtual bool Equals(object obj) { }

	public override bool Equals(BundleDetails other) { }

	public uint get_Crc() { }

	public string[] get_Dependencies() { }

	public string get_FileName() { }

	public Hash128 get_Hash() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(BundleDetails a, BundleDetails b) { }

	public static bool op_Inequality(BundleDetails a, BundleDetails b) { }

	public void set_Crc(uint value) { }

	public void set_Dependencies(string[] value) { }

	public void set_FileName(string value) { }

	public void set_Hash(Hash128 value) { }

}

