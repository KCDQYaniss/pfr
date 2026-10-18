namespace EFT.Hideout;

public class HideoutProductionEnvironmentReaction : SerializedMonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <OnProduceStatusChanged>b__14_0(ItemsProducerBase p) { }

	}

	[SerializeField]
	private EAreaType _areaType; //Field offset: 0x60
	[SerializeField]
	private HideoutArea _hideoutArea; //Field offset: 0x68
	[SerializeField]
	private AreaLevelAudio _audio; //Field offset: 0x70
	[SerializeField]
	private ILightSwitcher[] _lights; //Field offset: 0x78
	[SerializeField]
	private GameObject[] _objects; //Field offset: 0x80
	[SerializeField]
	private AudioClip[] _audioClipsOnEnable; //Field offset: 0x88
	[SerializeField]
	private AudioClip[] _audioClipsOnDisable; //Field offset: 0x90
	[SerializeField]
	private Animator _animator; //Field offset: 0x98
	private AreaData _areaData; //Field offset: 0xA0
	private List _itemsProducers; //Field offset: 0xA8
	private bool _isEnabled; //Field offset: 0xB0

	public HideoutProductionEnvironmentReaction() { }

	[CompilerGenerated]
	private bool <OnEnable>b__11_0(AreaData d) { }

	private void EnableAnimations(bool enable) { }

	private void EnableLight(bool enable) { }

	private void EnableObjects(bool enable) { }

	private void EnableReactions(bool enable) { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnLightLevelChanged() { }

	private void OnProduceStatusChanged() { }

	private void PlayAudio(bool enable) { }

}

