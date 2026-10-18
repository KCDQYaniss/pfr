namespace EFT;

[GenerateBinarySerialization]
public class ResourceKey
{
	public static readonly ResourceKey EmptyResourceKey; //Field offset: 0x0
	[Nullable]
	public string path; //Field offset: 0x10
	[Nullable]
	public string rcid; //Field offset: 0x18

	public string FileName
	{
		 get { } //Length: 149
	}

	private static ResourceKey() { }

	public ResourceKey() { }

	protected bool Equals(ResourceKey other) { }

	public virtual bool Equals(object obj) { }

	public string get_FileName() { }

	public virtual int GetHashCode() { }

	public bool IsEmpty() { }

	public static bool op_Equality(ResourceKey left, ResourceKey right) { }

	public static bool op_Inequality(ResourceKey left, ResourceKey right) { }

	[CanBeNull]
	public string ToAssetName() { }

	public virtual string ToString() { }

}

