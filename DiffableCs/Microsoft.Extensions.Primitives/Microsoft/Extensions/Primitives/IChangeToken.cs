namespace Microsoft.Extensions.Primitives;

[NullableContext(1)]
public interface IChangeToken
{

	public bool ActiveChangeCallbacks
	{
		 get { } //Length: 0
	}

	public bool HasChanged
	{
		 get { } //Length: 0
	}

	public bool get_ActiveChangeCallbacks() { }

	public bool get_HasChanged() { }

	public IDisposable RegisterChangeCallback(Action callback, object state) { }

}

