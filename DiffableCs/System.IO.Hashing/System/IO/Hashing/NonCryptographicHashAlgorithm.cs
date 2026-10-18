namespace System.IO.Hashing;

public abstract class NonCryptographicHashAlgorithm
{
	[CompilerGenerated]
	private readonly int <HashLengthInBytes>k__BackingField; //Field offset: 0x10

	protected NonCryptographicHashAlgorithm(int hashLengthInBytes) { }

	public abstract void Append(ReadOnlySpan source) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("Use GetCurrentHash() to retrieve the computed hash code.", True)]
	public virtual int GetHashCode() { }

	public abstract void Reset() { }

}

