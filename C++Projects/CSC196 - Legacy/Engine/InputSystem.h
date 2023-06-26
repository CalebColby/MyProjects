#pragma once
#include <SDL_stdinc.h>
#include <vector>

namespace neu
{
	enum class KeyState
	{
		Idle,
		Pressed,
		Held,
		Released
	};

	class InputSystem
	{
	public:
		KeyState GetKeyState(uint32_t key);
		bool GetKeyDown(uint32_t key) { return m_keyboardState[key]; }
		bool GetPreviousKeyDown(uint32_t key) { return m_prevKeyboardState[key]; }

		void Intialize();
		void Shutdown();
		void Update();

	private:
		std::vector<Uint8> m_keyboardState;
		std::vector<Uint8> m_prevKeyboardState;

	};
}
