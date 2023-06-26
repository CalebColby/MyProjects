#include "File.h"
#include <filesystem>

void SetFilePath(const std::string& pathName)
{
	std::filesystem::current_path(pathName);
}

std::string neu::GetFilePath()
{
	return std::filesystem::current_path().string();
}
