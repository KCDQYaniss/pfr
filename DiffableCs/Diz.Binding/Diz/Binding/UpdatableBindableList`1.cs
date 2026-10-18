namespace Diz.Binding;

public class UpdatableBindableList`1 : BindableList, IUpdatableList
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public T newItem; //Field offset: 0x0

		public <>c__DisplayClass2_0() { }

		internal bool <UpdateItems>b__0(T x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_1
	{
		public T existingItem; //Field offset: 0x0

		public <>c__DisplayClass2_1() { }

		internal bool <UpdateItems>b__1(T x) { }

	}


	public UpdatableBindableList`1() { }

	public UpdatableBindableList`1(IEnumerable items) { }

	public override void UpdateItems(ICollection newItems) { }

}

