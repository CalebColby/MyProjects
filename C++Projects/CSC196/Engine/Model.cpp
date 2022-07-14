#include "model.h"
namespace neu
{
	void Model::Draw(Renderer& ren, const Vector2& position, float scale)
	{
		for(int i = 0; i < m_points.size(); i++)
		{
			neu::Vector2 p1 = (m_points[i] * scale);
			neu::Vector2 p2 = m_points[i + scale];
		}
	}
}
