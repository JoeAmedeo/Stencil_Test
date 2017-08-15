#version 330 core

in vec2 TexCoords;

out vec4 FragColor;

uniform sampler2D FrameBufferTexture;

void main(){
    FragColor = texture(FrameBufferTexture, TexCoords);
}