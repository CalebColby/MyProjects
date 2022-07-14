#pragma once
#include <string>

namespace neu
{
	void SetFilePath(const std::string& pathName);
	std::string GetFilePath();

	bool FileExists(const std::string& pathName);
	bool GetFileSize(const std::string& pathName, size_t& size);
	bool ReadFile(const std::string& pathName, std::string& buffer);
}

