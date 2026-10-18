namespace EFT.Hideout;

public sealed class RelatedRequirements : RelatedData, IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__9_0; //Field offset: 0x8
		public static Func <>9__9_1; //Field offset: 0x10
		public static Func <>9__9_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <GetFilteredTypeList>b__9_0(Type x) { }

		internal bool <GetFilteredTypeList>b__9_1(Type x) { }

		internal bool <GetFilteredTypeList>b__9_2(Type x) { }

	}

	public List Data; //Field offset: 0x10

	public virtual bool IsActive
	{
		 get { } //Length: 74
	}

	public virtual EPanelType Type
	{
		 get { } //Length: 6
	}

	public virtual object Value
	{
		 get { } //Length: 5
	}

	public RelatedRequirements() { }

	public virtual bool get_IsActive() { }

	public virtual EPanelType get_Type() { }

	public virtual object get_Value() { }

	public override IEnumerator GetEnumerator() { }

	public IEnumerable GetFilteredTypeList() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

