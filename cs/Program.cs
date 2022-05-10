using NLua;

// https://github.com/NLua/NLua
Console.WriteLine("Starting Nlua test application");

Lua state = new Lua(openLibs: false);
state.DoFile("test.lua");
