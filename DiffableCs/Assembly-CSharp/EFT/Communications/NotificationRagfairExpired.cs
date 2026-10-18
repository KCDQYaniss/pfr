namespace EFT.Communications;

public sealed class NotificationRagfairExpired : NotificationRagFair
{
	private static readonly Color _failColor; //Field offset: 0x0
	private readonly Offer _offer; //Field offset: 0x30

	public virtual string Description
	{
		 get { } //Length: 612
	}

	public virtual Nullable TextColor
	{
		 get { } //Length: 125
	}

	private static NotificationRagfairExpired() { }

	public NotificationRagfairExpired(Offer offer) { }

	public virtual string get_Description() { }

	public virtual Nullable get_TextColor() { }

}

