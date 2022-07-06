#pragma once
namespace neu
{
	struct Vector2
	{
		float x, y;

		Vector2 operator + (const Vector2& v) { return Vector2{ v.x + this->x, v.y + this->y }; }
		Vector2 operator - (const Vector2& v) { return Vector2{ v.x - this->x, v.y - this->y }; }
		Vector2 operator * (const Vector2& v) { return Vector2{ v.x * this->x, v.y * this->y }; }
		Vector2 operator / (const Vector2& v) { return Vector2{ v.x / this->x, v.y / this->y }; }
	};
}
