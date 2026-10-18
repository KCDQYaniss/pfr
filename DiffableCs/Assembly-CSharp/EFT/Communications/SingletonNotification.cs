namespace EFT.Communications;

public abstract class SingletonNotification : Notification, IEquatable
{

	protected SingletonNotification() { }

	public override bool Equals(SingletonNotification other) { }

	public virtual bool Equals(object obj) { }

}

