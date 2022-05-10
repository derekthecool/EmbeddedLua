cmake_minimum_required(VERSION 3.19.2)

project(test)

find_package(Lua51 REQUIRED)

include_directories(/usr/local/include ${LUA_INCLUDE_DIR})

set(CMAKE_C_STANDARD 11)
set(SOURCE_FILES RunLua.c)

add_executable(test ${SOURCE_FILES})
target_link_libraries(test ${LUA_LIBRARIES})
