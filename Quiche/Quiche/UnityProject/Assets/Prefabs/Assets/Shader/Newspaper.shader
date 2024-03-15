Shader "Newspaper" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEBegin] _Photograph ("Photograph", 2D) = "white" {}
		_Alpha ("Alpha", Range(0, 1)) = 1
		_BlowoutScale ("Blowout Scale", Range(0, 1)) = 0
		_BlowoutOffset ("Blowout Offset", Range(0, 1)) = 0
		[ASEEnd] _Colour ("Colour", Range(0, 1)) = 0
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