namespace Unity.Properties;

public sealed class ArrayPropertyBag`1 : IndexedCollectionPropertyBag
{

	protected virtual InstantiationKind InstantiationKind
	{
		 get { } //Length: 6
	}

	public ArrayPropertyBag`1() { }

	protected virtual InstantiationKind get_InstantiationKind() { }

	protected virtual TElement[] Instantiate() { }

	protected virtual TElement[] InstantiateWithCount(int count) { }

}

