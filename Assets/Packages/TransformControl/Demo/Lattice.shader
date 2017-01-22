Shader "mattatz/Lattice" {

	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_Color ("Color", Color) = (1, 1, 1, 1)
		_Unit ("Unit", Float) = 1.0
		_Width ("Line Width", Range(0.0, 1.0)) = 0.1
	}

	SubShader {
		CGINCLUDE

		#include "UnityCG.cginc"

		struct appdata {
			float4 vertex : POSITION;
			float2 uv : TEXCOORD0;
		};

		struct v2f {
			float4 vertex : SV_POSITION;
			float3 world : NORMAL;
			float2 uv : TEXCOORD0;
		};

		sampler2D _MainTex;
		float4 _MainTex_TexelSize;

		fixed4 _Color;
		fixed _Width, _Ratio;
		float _Unit;

		v2f vert(appdata v) {
			v2f o;

			float4 world = mul(unity_ObjectToWorld, v.vertex);
			o.vertex = mul(UNITY_MATRIX_VP, world);
			o.world = world.xyz;
			o.uv = v.uv;
			return o;
		}

		fixed4 lattice(sampler2D tex, float2 uv) {
			float dx = 1.0 / _Unit;
			float dy = 1.0 / _Unit;
			float x = fmod(abs(uv.x), dx) / dx;
			float y = fmod(abs(uv.y), dy) / dy;
			float hw = _Width * 0.5;
			if (x < hw || y < hw || x > 1.0 - hw || y > 1.0 - hw) {
				return _Color;
			}
			return tex2D(tex, uv);
		}

		ENDCG

		Pass {
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			fixed4 frag(v2f i) : SV_Target {
				float3 world = i.world;
				return lattice(_MainTex, world.xz);
			}
			ENDCG
		}
	}
}
