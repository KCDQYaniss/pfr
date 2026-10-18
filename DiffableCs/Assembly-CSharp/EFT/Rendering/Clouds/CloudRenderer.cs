namespace EFT.Rendering.Clouds;

public abstract class CloudRenderer
{
	public bool SupportDynamicSunLight; //Field offset: 0x10

	protected CloudRenderer() { }

	public abstract void Build() { }

	public abstract void Cleanup() { }

	internal abstract bool DoUpdate(BuiltinSkyParameters builtinParams) { }

	public override bool GetSunLightCookieParameters(CloudSettings settings, BuiltinSkyParameters parameters, out CookieParameters cookieParams) { }

	public override void PreRenderClouds(BuiltinSkyParameters builtinParams, bool renderForCubemap) { }

	public abstract void RenderClouds(BuiltinSkyParameters builtinParams, bool renderForCubemap) { }

	public override void RenderSunLightCookie(BuiltinSunCookieParameters builtinParams) { }

	public override bool RequiresPreRenderClouds(BuiltinSkyParameters builtinParams) { }

}

