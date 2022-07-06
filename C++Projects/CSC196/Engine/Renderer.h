#pragma once
//#include <SDL.h>
#include "Vector2.h"
#include "Color.h"

struct SDL_Renderer;
struct SDL_Window;

namespace neu
{
	class Renderer
	{
	public:
		Renderer() = default;
		~Renderer() = default;

		void Intialize();
		void Shutdown();

		void CreateWindow(const char* name, int width, int height);
		void BeginFrame();
		void EndFrame();

		void DrawLine(float x1, float y1, float x2, float y2);
		void DrawLine(const Vector2& v1, const Vector2& v2, const Color& color);
		void DrawPoint(float x, float y);
		void DrawPoint(const Vector2& v, const Color& color);

	private:
		SDL_Renderer* m_renderer{ nullptr };
		SDL_Window* m_window{ nullptr };
		Color clearColor;
	};
}