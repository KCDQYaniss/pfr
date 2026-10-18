namespace System.Globalization;

[ComVisible(True)]
public class SortKey
{
	private readonly string source; //Field offset: 0x10
	private readonly byte[] key; //Field offset: 0x18
	private readonly CompareOptions options; //Field offset: 0x20
	private readonly int lcid; //Field offset: 0x24

	public override byte[] KeyData
	{
		 get { } //Length: 5
	}

	public override string OriginalString
	{
		 get { } //Length: 5
	}

	internal SortKey(int lcid, string source, CompareOptions opt) { }

	internal SortKey(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	internal SortKey(string localeName, string str, CompareOptions options, byte[] keyData) { }

	internal SortKey() { }

	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	public virtual bool Equals(object value) { }

	public override byte[] get_KeyData() { }

	public override string get_OriginalString() { }

	public virtual int GetHashCode() { }

	public virtual string ToString() { }

}

