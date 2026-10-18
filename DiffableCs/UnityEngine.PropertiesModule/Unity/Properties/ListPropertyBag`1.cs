namespace Unity.Properties;

public class ListPropertyBag`1 : IndexedCollectionPropertyBag
{

	protected virtual InstantiationKind InstantiationKind
	{
		 get { } //Length: 6
	}

	public ListPropertyBag`1() { }

	protected virtual InstantiationKind get_InstantiationKind() { }

	protected virtual List Instantiate() { }

	protected virtual List InstantiateWithCount(int count) { }

}

