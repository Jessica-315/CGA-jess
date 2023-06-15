#version 330 core
out vec4 Color;

in vec2 our_uv;

uniform sampler2D depthMap;

void main()
{             
    vec4 textureColor = texture(depthMap, our_uv);
	if(textureColor.a < 0.1){
		discard;
	}
	Color = textureColor;
}