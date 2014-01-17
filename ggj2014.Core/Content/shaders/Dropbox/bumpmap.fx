MGFX   X  #ifdef GL_ES
precision mediump float;
precision mediump int;
#endif

const vec4 ps_c0 = vec4(0.5, 0.0, 0.0, 0.5);
vec4 ps_r0;
uniform sampler2D ps_s0;
varying vec4 vTexCoord0;
#define ps_t0 vTexCoord0
#define ps_oC0 gl_FragColor

void main()
{
	ps_r0 = texture2D(ps_s0, ps_t0.xy);
	ps_r0 = ps_r0 + ps_c0;
	ps_oC0 = ps_r0;
}

    ps_s0   Texture      
Technique1 Pass1 �    