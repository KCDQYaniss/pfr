namespace EFT.Interactive;

public class LampLights
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__25_0; //Field offset: 0x8
		public static Action <>9__25_1; //Field offset: 0x10
		public static Action <>9__25_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <Initialize>b__25_0(MaterialEmission mat) { }

		internal void <Initialize>b__25_1(MaterialEmission property) { }

		internal void <Initialize>b__25_2(MaterialColor property) { }

	}

	private readonly LampController _lampController; //Field offset: 0x10
	private readonly Light[] _lights; //Field offset: 0x18
	private readonly BaseLight[] _areaAndTubeLights; //Field offset: 0x20
	private readonly AdvancedLight[] _customLights; //Field offset: 0x28
	private readonly Flicker[] _flickers; //Field offset: 0x30
	private readonly GameObject[] _onObjects; //Field offset: 0x38
	private readonly GameObject[] _offObjects; //Field offset: 0x40
	private readonly GameObject[] _destroyedObjects; //Field offset: 0x48
	private readonly FlareLight[] _multiFlareLights; //Field offset: 0x50
	private MaterialEmission[] _materialsWithEmission; //Field offset: 0x58
	private readonly MaterialColor[] _legacyMaterialsWithEmission; //Field offset: 0x60
	private float[] _lightsIntensities; //Field offset: 0x68
	private float[] _baseLightsIntensities; //Field offset: 0x70
	private Color[] _customLightsColors; //Field offset: 0x78
	private List _volumetricLights; //Field offset: 0x80
	private List _cullingLightObjects; //Field offset: 0x88
	private List _cullingAdvancedLightObjects; //Field offset: 0x90
	private float _lastIntensity; //Field offset: 0x98

	public LampLights(LampController lampController) { }

	private static void ActivateComponents(IReadOnlyList components, bool value) { }

	private static void ActivateGameObjects(IReadOnlyList gameObjects, bool value) { }

	public void Destroy() { }

	private static void DestroyObjects(IReadOnlyList objects) { }

	public void GrabCullingIntensities() { }

	private void Initialize() { }

	public bool IntensityChanged(float intensity) { }

	private static bool IsVolumetricEnabled() { }

	public void SetIntensity(float intensity) { }

	public void ToggleFlareLights(bool value) { }

	public void TurnLights(bool value) { }

}

