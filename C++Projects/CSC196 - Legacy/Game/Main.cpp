#include "Math/MathUtils.h"
#include "Renderer.h"
#include "Math/Random.h"
#include "Core/File.h"
#include <iostream>
#include <vector>


using namespace std;
int main()
{
	neu::SetFilePath("../Assets");
	cout << neu::GetFilePath();


	neu::Renderer ren;

	ren.Intialize();

	ren.CreateWindow("Neumont", 800, 600);


	bool quit = false;
	while(!quit)
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
