# WindowsMailAgent
A Windows-native desktop application for running and interacting with local or remote Large Language Models that can safely control and automate Windows OS tasks through a structured tool system.


## Architecture
The system is composed of five core layers:
1. 🖥️ **UI Layer**  
   For chat interface and agent settings.

2. 🧠 **Agent Runtime**  
   Custom runtime following ubiquitous orchestration, execution flow, and logic for agents in 2026.

3. 🛠️ **Tools**  
   Provides external capabilities such as Mail, Notifications and Browser tool automation.

4. 🤖 **LLM Provider**  
   Currently only support local models through Ollama.

5. 💾 **Memory**  
   Persists application state.


## Phase 1

### Tools
- Mail
- Windows Desktop notifications
- Browser Tool Automation
- PowerShell operations
- File system operations
- Clipboard Tool

### LLM Provider
- Ollama (local models like Llama, Mistral, etc.)

### Memory/Storage
TODO
