namespace Diz.Resources;

public interface IEasyBundle : ILoadable
{

	[CanBeNull]
	public Object[] Assets
	{
		 get { } //Length: 0
	}

	[CanBeNull]
	public Object SameNameAsset
	{
		 get { } //Length: 0
	}

	public Object[] get_Assets() { }

	public Object get_SameNameAsset() { }

}

