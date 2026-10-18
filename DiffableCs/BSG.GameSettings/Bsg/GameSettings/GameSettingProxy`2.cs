namespace Bsg.GameSettings;

public sealed class GameSettingProxy`2 : GameSetting
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public GameSettingProxy <>4__this; //Field offset: 0x0
		public Action handler; //Field offset: 0x0

		public <>c__DisplayClass13_0() { }

		internal void <GetSubscriber>b__0(TBaseSetting baseValue) { }

	}

	private readonly Func _propertyGetter; //Field offset: 0x0
	private readonly Func _propertySetter; //Field offset: 0x0
	private readonly GameSetting _baseSetting; //Field offset: 0x0

	public GameSettingProxy`2(GameSetting baseSetting, Func propertyGetter, Func propertySetter) { }

	public virtual Action Bind(Action handler) { }

	public virtual Action BindWithoutValue(ICheckChanges handler) { }

	public virtual void ForceApply() { }

	private Action GetSubscriber(Action handler) { }

	public virtual TProperty GetValue() { }

	public virtual bool HasSameValue(GameSetting other) { }

	public virtual void ResetToDefault() { }

	public virtual Task SetValue(TProperty value) { }

	public virtual Action Subscribe(Action handler) { }

	public virtual void TakeValueFrom(GameSetting other) { }

}

