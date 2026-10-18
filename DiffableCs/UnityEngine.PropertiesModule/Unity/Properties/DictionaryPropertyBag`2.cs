namespace Unity.Properties;

public class DictionaryPropertyBag`2 : KeyValueCollectionPropertyBag
{

	protected virtual InstantiationKind InstantiationKind
	{
		 get { } //Length: 6
	}

	public DictionaryPropertyBag`2() { }

	protected virtual InstantiationKind get_InstantiationKind() { }

	protected virtual Dictionary Instantiate() { }

}

