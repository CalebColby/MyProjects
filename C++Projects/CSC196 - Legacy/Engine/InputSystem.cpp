#include "InputSystem.h" 
#include <SDL.h> 

namespace neu
{
	KeyState InputSystem::GetKeyState(uint32_t key)
	{
		KeyState keyState = KeyState::Idle;

		bool keyDown = GetKeyDown(key);
		bool prevKeyDown = GetPreviousKeyDown(key);

		// set the keyState if keyDown (true) and prevKeyDown (true)
		if (keyDown && prevKeyDown) keyState = neu::KeyState::Idle;
		// set the keyState if keyDown (true) and prevKeyDown (false)
		if (keyDown && !prevKeyDown) keyState = neu::KeyState::Pressed;
		// set the keyState if keyDown (false) and prevKeyDown (true)
		if (!keyDown && prevKeyDown) keyState = neu::KeyState::Held;
		// set the keyState if keyDown (false) and prevKeyDown (false)
		if (!keyDown && !prevKeyDown) keyState = neu::KeyState::Released;

		return keyState;
	}

	void InputSystem::Intialize()
	{
		int numKeys;
		// get pointer to sdl keyboard states and number of keys 
		const uint8_t* keyboardState = SDL_GetKeyboardState(&numKeys);

		// resize of keyboard state using numKeys for size 
		m_keyboardState.resize(numKeys);

		// copy the sdl key states to keyboard state 
		std::copy(keyboardState, keyboardState + numKeys, m_keyboardState.begin());

		// set previous keyboard state to current keyboard state 
		m_prevKeyboardState = m_keyboardState;
	}

	void InputSystem::Shutdown()
	{
		// does nothing
	}

	void InputSystem::Update()
	{
		SDL_Event event;
		SDL_PollEvent(&event);

		// save previous keyboard state 
		m_prevKeyboardState = m_keyboardState;

		// get current keyboard state 
		const uint8_t* keyboardState = SDL_GetKeyboardState(nullptr);
		std::copy(keyboardState, keyboardState + m_keyboardState.size(), m_keyboardState.begin());
	}
}
