#pragma once

#include "Renderer.h"
#include <vector>


namespace neu
{
	class Model
	{
	public:
		Model(const std::vector<neu::Vector2>& points,const neu::Color& color)
		{
			m_points = points;
			m_color = color;
		}

		void Draw(Renderer& ren, const Vector2& position, float scale);
	private:
		Color m_color;
		std::vector<Vector2> m_points;
	};
}
