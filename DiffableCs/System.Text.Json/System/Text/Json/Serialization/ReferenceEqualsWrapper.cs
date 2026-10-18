namespace System.Text.Json.Serialization;

[IsReadOnly]
internal struct ReferenceEqualsWrapper : IEquatable
{
	private readonly object _object; //Field offset: 0x0

	public ReferenceEqualsWrapper(object obj) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(ReferenceEqualsWrapper obj) { }

	public virtual int GetHashCode() { }

}

