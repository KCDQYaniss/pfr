namespace Unity.Properties.Internal;

internal class BoundsIntPropertyBag : ContainerPropertyBag
{
	private class PositionProperty : Property
	{

		public virtual string Name
		{
			 get { } //Length: 49
		}

		public PositionProperty() { }

		public virtual string get_Name() { }

	}

	private class SizeProperty : Property
	{

		public virtual string Name
		{
			 get { } //Length: 49
		}

		public SizeProperty() { }

		public virtual string get_Name() { }

	}


	public BoundsIntPropertyBag() { }

}

