namespace UnityEngine;

[NativeHeader("Runtime/Camera/Light.h")]
[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(Transform))]
public sealed class Light : Behaviour
{
	private int m_BakedIndex; //Field offset: 0x18

	public LightBakingOutput bakingOutput
	{
		 get { } //Length: 107
	}

	public float bounceIntensity
	{
		 get { } //Length: 78
	}

	public Color color
	{
		 get { } //Length: 102
		 set { } //Length: 93
	}

	public float colorTemperature
	{
		 get { } //Length: 78
	}

	public Texture cookie
	{
		 get { } //Length: 78
		 set { } //Length: 93
	}

	public float cookieSize
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public int cullingMask
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public float intensity
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public float[] layerShadowCullDistances
	{
		[FreeFunction("Light_Bindings::SetLayerShadowCullDistances", HasExplicitThis = True, ThrowsException = True)]
		 set { } //Length: 93
	}

	public float range
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	public LightRenderMode renderMode
	{
		[FreeFunction("Light_Bindings::SetRenderMode", HasExplicitThis = True, ThrowsException = True)]
		 set { } //Length: 91
	}

	public float shadowBias
	{
		 get { } //Length: 78
	}

	public float shadowNearPlane
	{
		 get { } //Length: 78
	}

	public LightShadows shadows
	{
		[NativeMethod("GetShadowType")]
		 get { } //Length: 78
		[FreeFunction("Light_Bindings::SetShadowType", HasExplicitThis = True, ThrowsException = True)]
		 set { } //Length: 91
	}

	public float shadowStrength
	{
		 get { } //Length: 78
		[FreeFunction("Light_Bindings::SetShadowStrength", HasExplicitThis = True)]
		 set { } //Length: 94
	}

	public float spotAngle
	{
		 get { } //Length: 78
		 set { } //Length: 94
	}

	[NativeProperty("LightType")]
	public LightType type
	{
		 get { } //Length: 78
		 set { } //Length: 91
	}

	public bool useColorTemperature
	{
		 get { } //Length: 78
	}

	[FreeFunction("Light_Bindings::AddCommandBuffer", HasExplicitThis = True)]
	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask) { }

	public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	public LightBakingOutput get_bakingOutput() { }

	private void get_bakingOutput_Injected(out LightBakingOutput ret) { }

	public float get_bounceIntensity() { }

	public Color get_color() { }

	private void get_color_Injected(out Color ret) { }

	public float get_colorTemperature() { }

	public Texture get_cookie() { }

	public float get_cookieSize() { }

	public int get_cullingMask() { }

	public float get_intensity() { }

	public float get_range() { }

	public float get_shadowBias() { }

	public float get_shadowNearPlane() { }

	[NativeMethod("GetShadowType")]
	public LightShadows get_shadows() { }

	public float get_shadowStrength() { }

	public float get_spotAngle() { }

	public LightType get_type() { }

	public bool get_useColorTemperature() { }

	public void RemoveAllCommandBuffers() { }

	public void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer) { }

	public void set_color(Color value) { }

	private void set_color_Injected(ref Color value) { }

	public void set_cookie(Texture value) { }

	public void set_cookieSize(float value) { }

	public void set_cullingMask(int value) { }

	public void set_intensity(float value) { }

	[FreeFunction("Light_Bindings::SetLayerShadowCullDistances", HasExplicitThis = True, ThrowsException = True)]
	public void set_layerShadowCullDistances(float[] value) { }

	public void set_range(float value) { }

	[FreeFunction("Light_Bindings::SetRenderMode", HasExplicitThis = True, ThrowsException = True)]
	public void set_renderMode(LightRenderMode value) { }

	[FreeFunction("Light_Bindings::SetShadowType", HasExplicitThis = True, ThrowsException = True)]
	public void set_shadows(LightShadows value) { }

	[FreeFunction("Light_Bindings::SetShadowStrength", HasExplicitThis = True)]
	public void set_shadowStrength(float value) { }

	public void set_spotAngle(float value) { }

	public void set_type(LightType value) { }

}

