namespace System.Collections.Generic;

internal class EnumEqualityComparer`1 : EqualityComparer, ISerializable
{

	public EnumEqualityComparer`1() { }

	protected EnumEqualityComparer`1(SerializationInfo information, StreamingContext context) { }

	public virtual bool Equals(T x, T y) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode(T obj) { }

	public virtual int GetHashCode() { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

