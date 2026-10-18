namespace EFT.Communications;

public class HideoutAreaNotification : HideoutNotification
{
	private readonly string _areaName; //Field offset: 0x50

	public virtual string Description
	{
		 get { } //Length: 208
	}

	public HideoutAreaNotification(EHideoutNotificationType eventType, AreaTemplate areaTemplate, Action onClick) { }

	public virtual string get_Description() { }

}

