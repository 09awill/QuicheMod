Shader "Lake Surface" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] _Color0 ("Color 0", Vector) = (0.5377715,0.7173741,0.8584906,1)
		_TimeScale ("Time Scale", Float) = 1
		_Color1 ("Color 1", Vector) = (0.7784977,0.8151122,0.8301887,1)
		[HDR] _DaySpec ("DaySpec", Vector) = (2.912527,3.044249,3.102792,1)
		[ASEEnd] [HDR] _NightSpec ("NightSpec", Vector) = (2.912527,3.044249,3.102792,1)
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