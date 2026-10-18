namespace EFT;

public struct Oid
{
	[JsonProperty("$oid")]
	public string Id; //Field offset: 0x0

	public static string op_Implicit(Oid oid) { }

	public virtual string ToString() { }

}

