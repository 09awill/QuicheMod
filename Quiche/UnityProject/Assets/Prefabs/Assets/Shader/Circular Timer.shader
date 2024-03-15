Shader "Circular Timer" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] _Value ("Value", Range(0, 1)) = 0
		_Colour ("Colour", Vector) = (0.6914378,0.9433962,0.3239587,0)
		_BackingColour ("BackingColour", Vector) = (0.2924528,0.2687255,0.2687255,0)
		_Color0 ("Color 0", Vector) = (0.2924528,0.2687255,0.2687255,0)
		_InnerRadius ("Inner Radius", Range(0, 1)) = 0.3
		_FadeInner ("Fade Inner", Range(0, 0.1)) = 0.03058824
		_BorderWidth ("Border Width", Range(0, 0.2)) = 0.02
		_OuterRadius ("Outer Radius", Range(0, 0.5)) = 0.5
		[ASEEnd] [Toggle] _IsWaitingPeriod ("IsWaitingPeriod", Range(0, 1)) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	Fallback "Hidden/InternalErrorShader"
	//CustomEditor "UnityEditor.ShaderGraph.PBRMasterGUI"
}