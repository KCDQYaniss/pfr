namespace UnityEngine.UIElements;

internal struct StyleDataRef`1 : IEquatable
{
	private class RefCounted
	{
		private static uint m_NextId; //Field offset: 0x0
		private int m_RefCount; //Field offset: 0x0
		private readonly uint m_Id; //Field offset: 0x0
		public T value; //Field offset: 0x0

		public int refCount
		{
			 get { } //Length: 164
		}

		private static RefCounted() { }

		public RefCounted() { }

		public void Acquire() { }

		public RefCounted Copy() { }

		public int get_refCount() { }

		public void Release() { }

	}

	private RefCounted m_Ref; //Field offset: 0x0

	public StyleDataRef Acquire() { }

	public void CopyFrom(StyleDataRef other) { }

	public static StyleDataRef Create() { }

	public override bool Equals(StyleDataRef other) { }

	public virtual bool Equals(object obj) { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleDataRef lhs, StyleDataRef rhs) { }

	public T Read() { }

	public bool ReferenceEquals(StyleDataRef other) { }

	public void Release() { }

	public T Write() { }

}

