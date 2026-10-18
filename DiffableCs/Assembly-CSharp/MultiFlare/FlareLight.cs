namespace MultiFlare;

[ExecuteInEditMode]
[HelpURL("https://eodproject.atlassian.net/wiki/spaces/FRONT/pages/1254981646/Unity.#Flare")]
public class FlareLight : MonoBehaviour
{
	private bool _destroyed; //Field offset: 0x20
	[FormerlySerializedAs("_scale")]
	[FormerlySerializedAs("Scale")]
	[Min(0.01)]
	[SerializeField]
	[Tooltip("Общий множитель размера всех флар для этого FlareLight")]
	private float _totalScale; //Field offset: 0x24
	[FormerlySerializedAs("_alpha")]
	[FormerlySerializedAs("Alpha")]
	[Range(0.01, 1)]
	[SerializeField]
	[Tooltip("Общий множитель прозрачности всех флар для этого FlareLight")]
	private float _totalAlpha; //Field offset: 0x28
	[Min(0.01)]
	[SerializeField]
	[Tooltip("Если дистанция до камеры превышает это значение все флары внутри этого источника будут откулены")]
	private float _cullDistance; //Field offset: 0x2C
	[FormerlySerializedAs("Flares")]
	[SerializeField]
	private Flare[] _flares; //Field offset: 0x30

	public float Alpha
	{
		 get { } //Length: 6
	}

	public static string AlphaPropertyName
	{
		 get { } //Length: 49
	}

	public float CullDistance
	{
		 get { } //Length: 6
	}

	public static string CullDistancePropertyName
	{
		 get { } //Length: 49
	}

	public bool Enabled
	{
		 get { } //Length: 78
	}

	public IReadOnlyList Flares
	{
		 get { } //Length: 76
	}

	public static string FlaresPropertyName
	{
		 get { } //Length: 49
	}

	public float Scale
	{
		 get { } //Length: 6
	}

	public static string ScalePropertyName
	{
		 get { } //Length: 49
	}

	public FlareLight() { }

	public float get_Alpha() { }

	public static string get_AlphaPropertyName() { }

	public float get_CullDistance() { }

	public static string get_CullDistancePropertyName() { }

	public bool get_Enabled() { }

	public IReadOnlyList get_Flares() { }

	public static string get_FlaresPropertyName() { }

	public float get_Scale() { }

	public static string get_ScalePropertyName() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnDrawGizmos() { }

	private void OnEnable() { }

	public void SetAlpha(float value) { }

	public void SetScale(float value) { }

}

