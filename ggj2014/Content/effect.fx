uniform extern texture ScreenTexture;    

sampler ScreenS = sampler_state
{
    Texture = <ScreenTexture>;    
};

float4 PixelShader(float2 texCoord: TEXCOORD0) : COLOR
{
    ...
    // pick a pixel on the screen for this pixel, based on
    // the calculated offset and direction
    float4 color = tex2D(ScreenS, texCoord+(sinoffset*sinsign));    
            
    return color;
}