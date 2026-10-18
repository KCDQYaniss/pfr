namespace MultiFlare;

public class Flare
{
	public const float MinValue = 0.01; //Field offset: 0x0
	[FormerlySerializedAs("Scale")]
	[Min(0.01)]
	[SerializeField]
	[Tooltip("Размер выбранной флары - ширина и высота")]
	private Vector2 _scale; //Field offset: 0x10
	[FormerlySerializedAs("Alpha")]
	[Range(0.01, 1)]
	[SerializeField]
	[Tooltip("Прозрачность выбранной флары")]
	private float _alpha; //Field offset: 0x18
	[FormerlySerializedAs("Color")]
	[SerializeField]
	[Tooltip("Цвет выбранной флары")]
	private Color _color; //Field offset: 0x1C
	[FormerlySerializedAs("Type")]
	[SerializeField]
	[Tooltip("Тип выбранной флары. В зависимости от типа, флары могут иметь специфическую логику отображения или материал. Общие настройки каждого типа можно найти в FlareSceneSettings внутри скриптовой сцены. Более опдробно о типах флар можно узнать из документации")]
	private FlareType _flareType; //Field offset: 0x2C
	[FormerlySerializedAs("MinDist")]
	[SerializeField]
	[Tooltip("Расстояние, которое определяет размер и прозрачность флары. Когда расстояние от камеры до флары больше или равно End, ее размер(Scale) будет умножен на MaxScale. Когда расстояние от камеры до флары меньше или равно Start, ее размер(Scale) будет умножен на MinScale. Промежуточные значения будут линейно интерполированные между этими граничными значениями. Аналогично будет вычислена прозрачность.")]
	private float _minDist; //Field offset: 0x30
	[FormerlySerializedAs("MaxDist")]
	[SerializeField]
	private float _maxDist; //Field offset: 0x34
	[FormerlySerializedAs("MinScale")]
	[SerializeField]
	[Tooltip("Диапазон изменения размера флары в зависимости от знвчения DistanceRange")]
	private float _minScale; //Field offset: 0x38
	[FormerlySerializedAs("MaxScale")]
	[SerializeField]
	private float _maxScale; //Field offset: 0x3C
	[FormerlySerializedAs("MinAlpha")]
	[SerializeField]
	[Tooltip("Диапазон изменения прозрачности флары в зависимости от знвчения DistanceRange")]
	private float _minAlpha; //Field offset: 0x40
	[FormerlySerializedAs("MaxAlpha")]
	[SerializeField]
	private float _maxAlpha; //Field offset: 0x44
	[FormerlySerializedAs("TextureId")]
	[SerializeField]
	[Tooltip("Текстура флары. Все текстуры собранны в атлас. Значения атласа можно найти в FlareSceneSettings")]
	private int _texId; //Field offset: 0x48

	public float Alpha
	{
		 get { } //Length: 6
	}

	public static string AlphaPropertyName
	{
		 get { } //Length: 49
	}

	public Color Color
	{
		 get { } //Length: 11
	}

	public static string ColorPropertyName
	{
		 get { } //Length: 49
	}

	public FlareType FlareType
	{
		 get { } //Length: 4
	}

	public static string FlareTypePropertyName
	{
		 get { } //Length: 49
	}

	public float MaxAlpha
	{
		 get { } //Length: 6
	}

	public static string MaxAlphaPropertyName
	{
		 get { } //Length: 49
	}

	public float MaxDist
	{
		 get { } //Length: 6
	}

	public static string MaxDistPropertyName
	{
		 get { } //Length: 49
	}

	public float MaxScale
	{
		 get { } //Length: 6
	}

	public static string MaxScalePropertyName
	{
		 get { } //Length: 49
	}

	public float MinAlpha
	{
		 get { } //Length: 6
	}

	public static string MinAlphaPropertyName
	{
		 get { } //Length: 49
	}

	public float MinDist
	{
		 get { } //Length: 6
	}

	public static string MinDistPropertyName
	{
		 get { } //Length: 49
	}

	public float MinScale
	{
		 get { } //Length: 6
	}

	public static string MinScalePropertyName
	{
		 get { } //Length: 49
	}

	public Vector2 Scale
	{
		 get { } //Length: 19
	}

	public static string ScalePropertyName
	{
		 get { } //Length: 49
	}

	public int TexId
	{
		 get { } //Length: 4
	}

	public static string TexIdPropertyName
	{
		 get { } //Length: 49
	}

	public Flare() { }

	public float get_Alpha() { }

	public static string get_AlphaPropertyName() { }

	public Color get_Color() { }

	public static string get_ColorPropertyName() { }

	public FlareType get_FlareType() { }

	public static string get_FlareTypePropertyName() { }

	public float get_MaxAlpha() { }

	public static string get_MaxAlphaPropertyName() { }

	public float get_MaxDist() { }

	public static string get_MaxDistPropertyName() { }

	public float get_MaxScale() { }

	public static string get_MaxScalePropertyName() { }

	public float get_MinAlpha() { }

	public static string get_MinAlphaPropertyName() { }

	public float get_MinDist() { }

	public static string get_MinDistPropertyName() { }

	public float get_MinScale() { }

	public static string get_MinScalePropertyName() { }

	public Vector2 get_Scale() { }

	public static string get_ScalePropertyName() { }

	public int get_TexId() { }

	public static string get_TexIdPropertyName() { }

}

