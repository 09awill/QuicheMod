Shader "Mirror Backing" {
	Properties {
		[HideInInspector] _AlphaCutoff ("Alpha Cutoff ", Range(0, 1)) = 0.5
		[HideInInspector] _EmissionColor ("Emission Color", Vector) = (1,1,1,1)
		[ASEEnd] [ASEBegin] _Color0 ("Color 0", Vector) = (0,0,0,0)
		_TessPhongStrength ("Phong Tess Strength", Range(0, 1)) = 0.5
		_TessValue ("Max Tessellation", Range(1, 32)) = 16
		_TessMin ("Tess Min Distance", Float) = 10
		_TessMax ("Tess Max Distance", Float) = 25
		_TessEdgeLength ("Edge length", Range(2, 50)) = 16
		_TessMaxDisp ("Max Displacement", Float) = 25
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