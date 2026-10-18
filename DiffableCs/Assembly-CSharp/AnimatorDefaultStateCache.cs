//Type is in global namespace

public class AnimatorDefaultStateCache : MonoBehaviour
{
	private struct AnimatorParameterDefaultValue
	{
		[SerializeField]
		private int _parameterNameHash; //Field offset: 0x0
		[SerializeField]
		private AnimatorControllerParameterType _type; //Field offset: 0x4
		[SerializeField]
		private int _defaultIntValue; //Field offset: 0x8
		[SerializeField]
		private float _defaultFloatValue; //Field offset: 0xC
		[SerializeField]
		private bool _defaultBoolValue; //Field offset: 0x10

		public AnimatorParameterDefaultValue(AnimatorControllerParameter parameter) { }

		public static void SetDefaultParameter(AnimatorParameterDefaultValue defaultValue, Animator animator) { }

	}

	private struct DefaultLayerState
	{
		[SerializeField]
		private int _layerIndex; //Field offset: 0x0
		[SerializeField]
		private float _weight; //Field offset: 0x4
		[SerializeField]
		private int _defaultStateHash; //Field offset: 0x8

		public DefaultLayerState(int layerIndex, float weight, int defaultStateHash) { }

		public static void SetDefaultState(DefaultLayerState layerState, Animator animator) { }

	}

	[SerializeField]
	private AnimatorParameterDefaultValue[] _parameters; //Field offset: 0x20
	[SerializeField]
	private DefaultLayerState[] _layersState; //Field offset: 0x28
	[SerializeField]
	private Animator _animator; //Field offset: 0x30

	public AnimatorDefaultStateCache() { }

	public void SetupDefaultParameter() { }

}

