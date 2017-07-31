#version 330 core

out vec4 FragColor;

uniform float time;

void main(){
    FragColor = vec4(vec3(time), 1.0);
}