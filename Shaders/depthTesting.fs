#version 330 core
out vec4 FragColor;

float near = 0.01;//Info que está en el main 
float far = 100.0;//Info que está en el main 
//Linealiza la profuncidad a una 

float linearDepth(float depth){
    float z = depth * 2.0 - 1.0;
    return (2.0 * near * far) / (far + near - z * (far - near));
}

void main()
{             
    //FragColor = vec4(1.0, 1.0, 1.0, 1.0);
    //FragColor = vec4(vec3(gl_FragCoord.z), 1.0);//Pregunta de examen
    float z = linearDepth(gl_FragCoord.z) / far;
    FragColor = vec4(vec3(z), 1.0);
}
