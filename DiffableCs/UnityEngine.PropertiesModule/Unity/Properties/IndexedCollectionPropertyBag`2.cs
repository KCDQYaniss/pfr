namespace Unity.Properties;

public class IndexedCollectionPropertyBag`2 : PropertyBag, IPropertyBag, IPropertyBag, IConstructorWithCount, IConstructor
{
	private class ListElementProperty : Property
	{
		internal int m_Index; //Field offset: 0x0

		public override int Index
		{
			 get { } //Length: 4
		}

		public virtual string Name
		{
			 get { } //Length: 171
		}

		public ListElementProperty() { }

		public override int get_Index() { }

		public virtual string get_Name() { }

	}

	private readonly ListElementProperty m_Property; //Field offset: 0x0

	public IndexedCollectionPropertyBag`2() { }

	protected override TList InstantiateWithCount(int count) { }

	private override TList Unity.Properties.IConstructorWithCount<TList>.InstantiateWithCount(int count) { }

}

