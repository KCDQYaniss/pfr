namespace EFT.UI.Ragfair;

public sealed class CancellableFilter
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public Action onCancel; //Field offset: 0x10
		public CancellableFilter <>4__this; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		internal void <.ctor>b__0(bool arg) { }

	}

	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly EFilterType <Type>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly bool <CanCancel>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private readonly Action <OnCancel>k__BackingField; //Field offset: 0x20

	public bool CanCancel
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public Action OnCancel
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public EFilterType Type
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public CancellableFilter(string name, EFilterType type, Action onCancel, bool canCancel = true) { }

	[CompilerGenerated]
	public bool get_CanCancel() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public Action get_OnCancel() { }

	[CompilerGenerated]
	public EFilterType get_Type() { }

}

