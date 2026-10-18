namespace Bsg.GameSettings.Json;

public sealed class VersionJsonSerializer : IJsonSerializer
{
	internal interface IVersion
	{

		public void Upgrade(JObject data) { }

	}

	public const string VERSION_KEY = "Version"; //Field offset: 0x0
	private readonly uint _currentVersion; //Field offset: 0x10
	private readonly IVersion[] _versions; //Field offset: 0x18
	private readonly JProperty _versionProperty; //Field offset: 0x20
	private readonly JsonSerializer _jsonSerializer; //Field offset: 0x28

	public VersionJsonSerializer(JsonSerializerSettings serializerSettings, IVersion[] versions) { }

	public override T Populate(JObject json, T item, out bool needReSave) { }

	public override JObject PrepareToSave(T item) { }

	private bool TryToUpgradeJson(JObject json) { }

}

