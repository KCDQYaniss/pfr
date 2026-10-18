namespace Unity.Properties;

public class KeyValueCollectionPropertyBag`3 : PropertyBag, IPropertyBag, IPropertyBag
{
	private class KeyValuePairProperty : Property
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private TKey <Key>k__BackingField; //Field offset: 0x0

		public override TKey Key
		{
			[CompilerGenerated]
			 get { } //Length: 173
		}

		public virtual string Name
		{
			 get { } //Length: 354
		}

		public KeyValuePairProperty() { }

		[CompilerGenerated]
		public override TKey get_Key() { }

		public virtual string get_Name() { }

	}

	private readonly KeyValuePairProperty m_KeyValuePairProperty; //Field offset: 0x0

	public KeyValueCollectionPropertyBag`3() { }

}

