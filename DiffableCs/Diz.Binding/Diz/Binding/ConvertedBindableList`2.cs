namespace Diz.Binding;

public sealed class ConvertedBindableList`2 : BindableList, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public ConvertedBindableList <>4__this; //Field offset: 0x0
		public IBindableList source; //Field offset: 0x0

		public <>c__DisplayClass6_0() { }

		internal void <AddSource>g__OnItemAddedHandler|2(TSource item) { }

		internal void <AddSource>g__OnItemsAddedHandler|1(IEnumerable items) { }

		internal void <AddSource>g__OnItemsRemovedHandler|0() { }

		internal void <AddSource>g__OnItemUpdatedHandler|3(TSource item) { }

		internal void <AddSource>g__Unsubscriber|4() { }

	}

	internal sealed class Converter : MulticastDelegate
	{

		public Converter(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(TSource sourceItem, out TResult resultItem, AsyncCallback callback, object object) { }

		public override bool EndInvoke(out TResult resultItem, IAsyncResult result) { }

		public override bool Invoke(TSource sourceItem, out TResult resultItem) { }

	}

	private sealed class IndexItem
	{
		public TResult ResultItem; //Field offset: 0x0
		public IBindableList Source; //Field offset: 0x0

		public IndexItem() { }

	}

	private readonly Dictionary _sources; //Field offset: 0x0
	private readonly Converter _converter; //Field offset: 0x0
	private readonly Dictionary _index; //Field offset: 0x0

	public ConvertedBindableList`2(IBindableList source, Converter converter, Comparison comparer) { }

	private void AddItem(IBindableList source, TSource item) { }

	private void AddItems(IBindableList source, IEnumerable items) { }

	public void AddSource(IBindableList source) { }

	public virtual void Clear() { }

	public override void Dispose() { }

	private bool GetOrCreateResultItem(IBindableList source, TSource item, out TResult resultItem) { }

	private void OnItemRemovedHandler(TSource item) { }

	private void RemoveItems(IBindableList source) { }

	public void RemoveSource(BindableList source) { }

	private void UpdateItem(IBindableList source, TSource item) { }

}

