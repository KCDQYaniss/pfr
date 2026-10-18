namespace Bsg.GameSettings.Json;

public sealed class JsonDirectSettingsProvider : BaseJsonSettingsProvider
{
	private JObject _json; //Field offset: 0x20

	public JsonDirectSettingsProvider(JObject json, IJsonSerializer serializer, BaseJsonSettingsProvider[] fallbackProviders) { }

	public JsonDirectSettingsProvider(string json, IJsonSerializer serializer, BaseJsonSettingsProvider[] fallbackProviders) { }

	protected virtual Task LoadJson() { }

	protected virtual Task SaveJson(JObject json) { }

	public virtual string ToString() { }

}

