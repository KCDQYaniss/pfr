namespace EFT.Communications;

public sealed class NotificationBackendMessagePopup : Notification
{
	[JsonProperty("message")]
	public string Message; //Field offset: 0x30
	[JsonProperty("image")]
	public string ImageUrl; //Field offset: 0x38

	public virtual string Description
	{
		 get { } //Length: 76
	}

	[JsonIgnore]
	public string DescriptionLocalized
	{
		 get { } //Length: 171
	}

	[JsonIgnore]
	public string HeaderLocalized
	{
		 get { } //Length: 171
	}

	public virtual bool ShowNotification
	{
		 get { } //Length: 3
	}

	public NotificationBackendMessagePopup() { }

	public virtual string get_Description() { }

	public string get_DescriptionLocalized() { }

	public string get_HeaderLocalized() { }

	public virtual bool get_ShowNotification() { }

}

