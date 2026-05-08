# WindowsDesktopApp
A Windows-native desktop application for running and interacting with local or remote Large Language Models that can safely control and automate Windows OS tasks through a structured tool system.


## Architecture
The system is composed of five core layers:
1. 🖥️ **UI Layer**  
   Handles user interaction and presentation.

2. 🧠 **Agent Runtime**  
   Manages orchestration, execution flow, and agent logic.

3. 🛠️ **Tools**  
   Provides external capabilities such as APIs, search, and function execution.

4. 🤖 **LLM Provider**  
   Interfaces with the underlying language model provider.

5. 💾 **Memory / Storage**  
   Persists conversation history, embeddings, and application state.


## Phase 1

### Tools
- PowerShell
- File system operations
- Clipboard Tool
- Notifications
- Keyboard/mouse
- App launching

### LLM Provider
- Ollama (local models like Llama, Mistral, etc.)
- OpenAI API

### Memory/Storage
TODO
