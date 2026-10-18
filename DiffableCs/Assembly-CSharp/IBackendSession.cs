//Type is in global namespace

public interface IBackendSession
{

	public bool Destroyed
	{
		 get { } //Length: 0
	}

	public void AddNotificationToHandle(string notificationType, Action action) { }

	public bool get_Destroyed() { }

	public Task GetAllCustomizations(Dictionary returnInCaseOfCache = null) { }

	public Task GetTemplates(ItemTemplates returnInCaseOfCache) { }

}

