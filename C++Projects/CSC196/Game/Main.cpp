#include "Math/MathUtils.h"
#include "Renderer.h"
#include "Math/Random.h"
#include <iostream>


using namespace std;
int main()
{
	
	neu::Renderer ren;

	ren.Intialize();

	ren.CreateWindow("Neumont", 800, 600);

	while(1)
	{
		ren.BeginFrame();
		//draw
		ren.DrawLine(neu::RandomF(800), neu::RandomF(600), neu::RandomF(800), neu::RandomF(600));
		ren.DrawPoint(neu::RandomF(800), neu::RandomF(600));
		ren.EndFrame();
	}

	getchar();

	ren.Shutdown();

	return 0;
}
