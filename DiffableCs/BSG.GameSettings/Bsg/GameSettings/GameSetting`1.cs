namespace Bsg.GameSettings;

public abstract class GameSetting`1 : IGameSetting, IBindable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public Func preProcessor; //Field offset: 0x0

		public <>c__DisplayClass22_0() { }

		internal Task <.ctor>b__0(T value) { }

	}

	protected static readonly Type SettingType; //Field offset: 0x0
	protected static readonly bool IsNullable; //Field offset: 0x0
	[CompilerGenerated]
	private readonly string <Key>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsAvailableToEdit>k__BackingField; //Field offset: 0x0
	private readonly Func _asyncPreProcessor; //Field offset: 0x0

	private override Type Bsg.GameSettings.IGameSetting.ObjectType
	{
		private get { } //Length: 119
	}

	private override object Bsg.GameSettings.IGameSetting.ObjectValue
	{
		private get { } //Length: 64
		private set { } //Length: 206
	}

	public override bool IsAvailableToEdit
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public override string Key
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override T Value
	{
		 get { } //Length: 20
		 set { } //Length: 200
	}

	private static GameSetting`1() { }

	protected GameSetting`1(string key, Func asyncPreProcessor) { }

	protected GameSetting`1(string key, Func preProcessor) { }

	public abstract Action Bind(Action handler) { }

	public abstract Action BindWithoutValue(ICheckChanges handler) { }

	private override Type Bsg.GameSettings.IGameSetting.get_ObjectType() { }

	private override object Bsg.GameSettings.IGameSetting.get_ObjectValue() { }

	private override bool Bsg.GameSettings.IGameSetting.HasSameValue(IGameSetting other) { }

	private override void Bsg.GameSettings.IGameSetting.set_ObjectValue(object value) { }

	private override void Bsg.GameSettings.IGameSetting.TakeValueFrom(IGameSetting other) { }

	public abstract void ForceApply() { }

	[CompilerGenerated]
	public override bool get_IsAvailableToEdit() { }

	[CompilerGenerated]
	public override string get_Key() { }

	public override T get_Value() { }

	public abstract T GetValue() { }

	public abstract bool HasSameValue(GameSetting other) { }

	public static T op_Implicit(GameSetting setting) { }

	protected Task PreProcessValue(T value) { }

	public abstract void ResetToDefault() { }

	[CompilerGenerated]
	public override void set_IsAvailableToEdit(bool value) { }

	public void set_Value(T value) { }

	public abstract Task SetValue(T value) { }

	public abstract Action Subscribe(Action handler) { }

	public abstract void TakeValueFrom(GameSetting other) { }

	public virtual string ToString() { }

}

