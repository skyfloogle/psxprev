﻿#version 150
in vec3 in_Position;
in vec3 in_Color; 
in vec3 in_Normal;
in vec3 in_Uv;

out vec2 pass_Uv;
out vec4 pass_Ambient;
out vec4 pass_Color;
out float pass_NormalDotLight;
out float pass_NormalLength;
out float discardPixel;

uniform mat4 mvpMatrix;
uniform vec3 lightDirection;
uniform vec3 maskColor;
uniform vec3 ambientColor;
uniform int renderMode;
uniform float lightIntensity;
uniform sampler2D mainTex;

const float discardValue = 100000000;

void main(void) {	
    gl_Position = mvpMatrix * vec4(in_Position, 1.0);
	discardPixel = step(discardValue, in_Position.x);
	pass_NormalDotLight = clamp(dot(in_Normal, lightDirection), 0.0, 1.0) * lightIntensity;
	pass_NormalLength = length(in_Normal);
	pass_Uv = in_Uv.st;
	pass_Ambient = vec4(ambientColor, 1.0);
	pass_Color = vec4(in_Color, 1.0);
}