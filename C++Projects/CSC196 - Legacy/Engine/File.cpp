#include "Core/File.h"
#include "Core/File.h"
#include <filesystem>
#include <fstream>

void SetFilePath(const std::string& pathName)
{
	std::filesystem::current_path(pathName);
}

std::string neu::GetFilePath()
{
	return std::filesystem::current_path().string();

}

bool neu::FileExists(const std::string& pathName)
{
	return std::filesystem::exists(pathName);
}

bool neu::GetFileSize(const std::string& pathName, size_t& size)
{
	if (!FileExists(pathName)) return false;
	size = std::filesystem::file_size(pathName);
	return true;
}

bool neu::ReadFile(const std::string& pathName, std::string& buffer)
{
	if (!FileExists(pathName)) return false;
	
	size_t size;
	GetFileSize(pathName, size);
	buffer.resize(size);

	std::ifstream fstream(pathName);
	fstream.read(buffer.data(), size);
	fstream.close();

	return true;
}
