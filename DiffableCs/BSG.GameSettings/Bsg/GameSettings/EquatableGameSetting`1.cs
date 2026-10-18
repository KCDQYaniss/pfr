namespace Bsg.GameSettings;

public class EquatableGameSetting`1 : StateGameSetting
{

	internal EquatableGameSetting`1(string key, T defaultValue, Func asyncPreProcessor) { }

	internal EquatableGameSetting`1(string key, T defaultValue, Func preProcessor) { }

	public virtual bool HasSameValue(GameSetting other) { }

}

