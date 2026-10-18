namespace Unity.Properties.Internal;

internal class Vector2IntPropertyBag : ContainerPropertyBag
{
	private class XProperty : Property
	{

		public virtual string Name
		{
			 get { } //Length: 49
		}

		public XProperty() { }

		public virtual string get_Name() { }

	}

	private class YProperty : Property
	{

		public virtual string Name
		{
			 get { } //Length: 49
		}

		public YProperty() { }

		public virtual string get_Name() { }

	}


	public Vector2IntPropertyBag() { }

}

