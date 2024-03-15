Shader "Unlit/Outline Shader" {
	Properties {
		_Sigma ("Sigma", Range(1E-05, 4)) = 0.05
		_InnerStrength ("Inner Strength", Range(0, 100)) = 10
		_OuterStrength ("Outer Strength", Range(0, 100)) = 100
		_TransparencyBase ("Transparency Base", Range(0, 2)) = 0.5
		_TransparencyVariance ("Transparency Variance", Range(0, 1)) = 0.5
		_TransparencyThreshold ("Transparency Threshold", Range(0, 2)) = 0.5
		_TransparencySmoothness ("Transparency Smoothness", Range(0, 1)) = 0.05
		_BorderColour ("Border Colour", Vector) = (0,0,0,0.5)
		_BorderColourBaseMultiplier ("Border Colour Base Multiplier", Range(0, 1)) = 0.75
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
}