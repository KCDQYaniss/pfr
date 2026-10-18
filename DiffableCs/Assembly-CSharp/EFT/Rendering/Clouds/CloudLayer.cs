namespace EFT.Rendering.Clouds;

[CreateAssetMenu(menuName = "Settings/Clouds/Create CloudLayer Settings", fileName = "CloudLayerSettings", order = 0)]
public class CloudLayer : CloudSettings
{
	internal class CloudMap
	{
		internal static Texture2D DefaultTexture; //Field offset: 0x0
		[Tooltip("Specify the texture HDRP uses to render the clouds ( in LatLong layout).")]
		public Texture2D CloudTexture; //Field offset: 0x10
		[Range(0, 1)]
		[Tooltip("Opacity multiplier for the red channel.")]
		public float OpacityR; //Field offset: 0x18
		[Range(0, 1)]
		[Tooltip("Opacity multiplier for the green channel .")]
		public float OpacityG; //Field offset: 0x1C
		[Range(0, 1)]
		[Tooltip("Opacity multiplier for the  blue channel.")]
		public float OpacityB; //Field offset: 0x20
		[Range(0, 1)]
		[Tooltip("Opacity multiplier for the alpha channel.")]
		public float OpacityA; //Field offset: 0x24
		[Min(0)]
		[Tooltip("Altitude of the bottom of the cloud layer in meters.")]
		public float Altitude; //Field offset: 0x28
		[Range(0, 360)]
		[Tooltip("Sets the rotation of the clouds (in degrees).")]
		public float Rotation; //Field offset: 0x2C
		[Tooltip("Specifies the color HDRP uses to tint the clouds.")]
		public Color Tint; //Field offset: 0x30
		[InspectorName("Exposure Compensation")]
		[Tooltip("Sets the exposure compensation of the clouds in EV.")]
		public float Exposure; //Field offset: 0x40
		[InspectorName("Orientation")]
		[Range(0, 360)]
		[Tooltip("Controls the orientation of the wind relative  to the X world vector.\nThis value can be relative to the Global Wind Orientation defined in the Visual Environment.")]
		public float ScrollOrientation; //Field offset: 0x44
		[InspectorName("Min Speed")]
		[Tooltip("Sets the minimal wind speed in kilometers per hour.")]
		public float MinScrollSpeed; //Field offset: 0x48
		[InspectorName("Max Speed")]
		[Tooltip("Sets the maximal wind speed in kilometers per hour.")]
		public float MaxScrollSpeed; //Field offset: 0x4C
		[HideInInspector]
		public float ScrollSpeed; //Field offset: 0x50
		[InspectorName("Raymarching")]
		[Tooltip("Simulates cloud self-shadowing using raymarching.")]
		public bool Lighting; //Field offset: 0x54
		[Range(2, 32)]
		[Tooltip("Number of raymarching steps.")]
		public int Steps; //Field offset: 0x58
		[InspectorName("Density")]
		[Range(0, 1)]
		[Tooltip("Density of the cloud layer.")]
		public float Thickness; //Field offset: 0x5C
		[Range(0, 1)]
		[Tooltip("Controls the influence of the ambient probe on the cloud layer volume. A lower value will suppress the ambient light  and produce darker clouds overall.")]
		public float AmbientProbeDimmer; //Field offset: 0x60
		[Tooltip("Projects a portion of the clouds around the sun  light to simulate cloud shadows. This will override the cookie of your directional light.")]
		public bool CastShadows; //Field offset: 0x64
		public float ScrollFactor; //Field offset: 0x68

		internal Color Color
		{
			internal get { } //Length: 163
		}

		internal int NumSteps
		{
			internal get { } //Length: 13
		}

		internal Vector4 Opacities
		{
			internal get { } //Length: 27
		}

		public CloudMap() { }

		internal Color get_Color() { }

		internal int get_NumSteps() { }

		internal Vector4 get_Opacities() { }

		internal int GetBakingHashCode() { }

		internal ValueTuple GetBakingParameters() { }

		public virtual int GetHashCode() { }

		internal Vector4 GetRenderingParameters() { }

	}

	private const int ANGLE_TOLERANCE = 3; //Field offset: 0x0
	public const float DefaultPlanetRadius = 6378100; //Field offset: 0x0
	[Range(0, 1)]
	[Tooltip("Controls the global opacity of the cloud layer.")]
	public float Opacity; //Field offset: 0x18
	[Tooltip("Specifies the resolution of the texture HDRP  uses to represent the clouds.")]
	public CloudResolution Resolution; //Field offset: 0x1C
	[Header("Cloud Shadows")]
	[Tooltip("Controls the opacity of the cloud shadows.")]
	public float ShadowMultiplier; //Field offset: 0x20
	[Tooltip("Controls the tint of the cloud shadows.")]
	public Color ShadowTint; //Field offset: 0x24
	[Tooltip("Specifies the resolution of the texture HDRP uses to represent the cloud shadows.")]
	public CloudShadowsResolution ShadowResolution; //Field offset: 0x34
	[Tooltip("Specifies the size of the projected shadows.")]
	public float ShadowSize; //Field offset: 0x38
	[Tooltip("Specifies the position of the planet and its radius")]
	public Vector4 PlanetCenterRadius; //Field offset: 0x3C
	[Range(0, 0.5)]
	public float StretchDistance; //Field offset: 0x4C
	public CloudMap LayerA; //Field offset: 0x50

	internal bool CastShadows
	{
		internal get { } //Length: 27
	}

	public CloudLayer() { }

	private static Vector3Int CastToInt3(Vector3 vec, int tolerance) { }

	internal bool get_CastShadows() { }

	internal int GetBakingHashCode(Light sunLight) { }

	public virtual int GetHashCode() { }

	[RuntimeInitializeOnLoadMethod]
	private static void Init() { }

	private static int RoundWithTolerance(int value, int tolerance) { }

}

