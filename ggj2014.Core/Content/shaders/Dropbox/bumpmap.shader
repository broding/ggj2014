texture Texture;
sampler TextureSampler = sampler_state
{
    Texture = <Texture>;
};

struct VertexShaderOutput
{
    float4 Position : TEXCOORD0;
    float4 Color : COLOR0;
    float2 TextureCoordinate : TEXCOORD0;
};
 
float4 PixelShaderFunction(VertexShaderOutput input) : COLOR0
{
 	float4 colorplus = float4(0.5, 0, 0, 0.5);
    float4 color = tex2D(TextureSampler, input.TextureCoordinate);
    return color + colorplus;
}
 
technique Technique1
{
    pass Pass1
    {
        PixelShader = compile ps_2_0 PixelShaderFunction();
    }
}