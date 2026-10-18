namespace Bsg.GameSettings;

[JsonConverter(typeof(GameSettingsJsonConverter))]
public interface IGameSetting
{

	public bool IsAvailableToEdit
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public string Key
	{
		 get { } //Length: 0
	}

	public Type ObjectType
	{
		 get { } //Length: 0
	}

	public object ObjectValue
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public void ForceApply() { }

	public bool get_IsAvailableToEdit() { }

	public string get_Key() { }

	public Type get_ObjectType() { }

	public object get_ObjectValue() { }

	public bool HasSameValue(IGameSetting other) { }

	public void set_IsAvailableToEdit(bool value) { }

	public void set_ObjectValue(object value) { }

	public void TakeValueFrom(IGameSetting other) { }

}

