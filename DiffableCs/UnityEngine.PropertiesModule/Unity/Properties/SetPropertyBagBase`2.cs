namespace Unity.Properties;

public class SetPropertyBagBase`2 : PropertyBag, IPropertyBag, IPropertyBag
{
	private class SetElementProperty : Property
	{
		internal TElement m_Value; //Field offset: 0x0

		public virtual string Name
		{
			 get { } //Length: 242
		}

		public SetElementProperty() { }

		public virtual string get_Name() { }

	}

	private readonly SetElementProperty m_Property; //Field offset: 0x0

	public SetPropertyBagBase`2() { }

}

