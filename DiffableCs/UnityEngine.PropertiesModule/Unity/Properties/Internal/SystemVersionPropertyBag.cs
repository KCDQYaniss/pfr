namespace Unity.Properties.Internal;

internal class SystemVersionPropertyBag : ContainerPropertyBag
{
	private class BuildProperty : Property
	{

		public virtual string Name
		{
			 get { } //Length: 49
		}

		public BuildProperty() { }

		public virtual string get_Name() { }

	}

	private class MajorProperty : Property
	{

		public virtual string Name
		{
			 get { } //Length: 49
		}

		public MajorProperty() { }

		public virtual string get_Name() { }

	}

	private class MinorProperty : Property
	{

		public virtual string Name
		{
			 get { } //Length: 49
		}

		public MinorProperty() { }

		public virtual string get_Name() { }

	}

	private class RevisionProperty : Property
	{

		public virtual string Name
		{
			 get { } //Length: 49
		}

		public RevisionProperty() { }

		public virtual string get_Name() { }

	}


	public SystemVersionPropertyBag() { }

}

