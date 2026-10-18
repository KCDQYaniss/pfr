namespace Unity.Properties.Internal;

internal class BoundsPropertyBag : ContainerPropertyBag
{
	private class CenterProperty : Property
	{

		public virtual string Name
		{
			 get { } //Length: 49
		}

		public CenterProperty() { }

		public virtual string get_Name() { }

	}

	private class ExtentsProperty : Property
	{

		public virtual string Name
		{
			 get { } //Length: 49
		}

		public ExtentsProperty() { }

		public virtual string get_Name() { }

	}


	public BoundsPropertyBag() { }

}

