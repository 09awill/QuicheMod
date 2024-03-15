Shader "UI Card" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] _Title ("Title", Vector) = (0.05882353,0.1568628,0.2627451,1)
		_BorderWidth ("Border Width", Range(0, 0.05)) = 0.01
		_BorderOffset ("Border Offset", Range(0, 1)) = 0.6235294
		_EdgeOffset ("Edge Offset", Range(0, 0.2)) = 0.075
		_TitleHeight ("Title Height", Range(0, 1.5)) = 0.075
		[ASEEnd] _TitleThickness ("Title Thickness", Range(0, 0.5)) = 0.075
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