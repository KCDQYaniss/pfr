namespace AnimationEventSystem;

public sealed class AnimationEvent : ICloneable, ISerializationCallbackReceiver
{
	public const float MAX_EVENT_TIME = 1; //Field offset: 0x0
	public const string FIRING_BULLET_EVENT_NAME = "FiringBullet"; //Field offset: 0x0
	public AnimationEventParameter Parameter; //Field offset: 0x10
	[CompilerGenerated]
	private bool <IsFiringBulletEvent>k__BackingField; //Field offset: 0x18
	[SerializeField]
	private string _functionName; //Field offset: 0x20
	[SerializeField]
	private int _functionNameHash; //Field offset: 0x28
	public bool Enabled; //Field offset: 0x2C
	[SerializeField]
	private float _time; //Field offset: 0x30
	public List EventConditions; //Field offset: 0x38

	public string FunctionName
	{
		 get { } //Length: 5
		 set { } //Length: 274
	}

	public int FunctionNameHash
	{
		 get { } //Length: 4
	}

	public private bool IsFiringBulletEvent
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public float Time
	{
		 get { } //Length: 6
		 set { } //Length: 33
	}

	public AnimationEvent() { }

	public override object Clone() { }

	public void Deserialize(BinaryReader reader) { }

	protected bool Equals(AnimationEvent other) { }

	public virtual bool Equals(object obj) { }

	public string get_FunctionName() { }

	public int get_FunctionNameHash() { }

	[CompilerGenerated]
	public bool get_IsFiringBulletEvent() { }

	public float get_Time() { }

	public bool IsConditionsSucceed(IAnimator animator) { }

	public bool IsTimeToFire(float previousNormalizedTime, float normalizedTime) { }

	public override void OnAfterDeserialize() { }

	public override void OnBeforeSerialize() { }

	public void Serialize(BinaryWriter writer) { }

	public void set_FunctionName(string value) { }

	[CompilerGenerated]
	private void set_IsFiringBulletEvent(bool value) { }

	public void set_Time(float value) { }

	public virtual string ToString() { }

}

