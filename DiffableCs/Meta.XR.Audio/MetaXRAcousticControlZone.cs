//Type is in global namespace

public sealed class MetaXRAcousticControlZone : MonoBehaviour
{
	public class State
	{
		[SerializeField]
		internal Color color; //Field offset: 0x10
		[SerializeField]
		internal Spectrum rt60; //Field offset: 0x20
		[SerializeField]
		internal Spectrum reverbLevel; //Field offset: 0x28
		[SerializeField]
		internal float fadeDistance; //Field offset: 0x30

		public State() { }

		internal void Clone(State other) { }

	}

	[SerializeField]
	private State _state; //Field offset: 0x20
	private IntPtr _controlHandle; //Field offset: 0x28

	internal float FadeDistance
	{
		internal get { } //Length: 28
		internal set { } //Length: 34
	}

	private Vector3 NativeBoxSize
	{
		private get { } //Length: 143
	}

	private Vector3 NativeFadeDistance
	{
		private get { } //Length: 665
	}

	internal Spectrum ReverbLevel
	{
		internal get { } //Length: 27
		internal set { } //Length: 107
	}

	internal Spectrum Rt60
	{
		internal get { } //Length: 27
		internal set { } //Length: 107
	}

	internal State state
	{
		internal get { } //Length: 5
	}

	internal Color ZoneColor
	{
		internal get { } //Length: 33
		internal set { } //Length: 30
	}

	internal MetaXRAcousticControlZone() { }

	internal void ApplyProperties() { }

	private void ApplyTransform() { }

	internal void Clone(State other) { }

	internal void DestroyInternal() { }

	internal float get_FadeDistance() { }

	private Vector3 get_NativeBoxSize() { }

	private Vector3 get_NativeFadeDistance() { }

	internal Spectrum get_ReverbLevel() { }

	internal Spectrum get_Rt60() { }

	internal State get_state() { }

	internal Color get_ZoneColor() { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	internal void set_FadeDistance(float value) { }

	internal void set_ReverbLevel(Spectrum value) { }

	internal void set_Rt60(Spectrum value) { }

	internal void set_ZoneColor(Color value) { }

	private void Start() { }

	internal void StartInternal() { }

}

