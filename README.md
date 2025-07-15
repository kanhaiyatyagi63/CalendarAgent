# 📅 CalendarAgent

A .NET 8 tool to automate Google Calendar scheduling and inspection, integrated with MCP and GitHub Copilot.

---

## 📌 Objective

Automate calendar tasks like scheduling meetings via prompts, inspect metadata, and build extensible agent‑based workflows.

---

## ✅ Prerequisites

Before you begin, install and set up the following:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Node.js (v14.x or higher)](https://nodejs.org/)
- **npm** (comes with Node.js)
- [MCP Inspector](https://www.npmjs.com/package/mcp-inspector):
  ```bash
  
  npm install -g mcp-inspector

- **Google Cloud Credentials**:
  - Create a project in [Google Cloud Console](https://console.cloud.google.com/).
  - Enable the **Google Calendar API**.
  - Download the `credentials.json` file.
  - Place it in the **root directory** of the project.

📦 **Project structure & configuration**
- Uses [Central Package Management (CPM)](https://learn.microsoft.com/en-us/nuget/consume-packages/Central-Package-Management) for NuGet dependencies.
- Code style enforced with StyleCop.
- Includes `mcp.json` file for MCP configuration in the project root.
---

## ✨ Setup & build instructions (VS Code)

1. **Clone the repository:**

   ```bash
   git clone https://github.com/kanhaiyatyagi63/CalendarAgent.git
   cd CalendarAgent
2. **Install .NET dependencies:**

   ```bash
   dotnet restore
3. **Create VS Code workspace folder:**

   - In the root of your project, create a folder named:
     ```bash
     .vs
   - Change or set your solution path inside .vs as needed.
4. **Open project in VS Code:**

   ```bash
     Code .
5. **Build the solution:**

   ```bash
     dotnet build
6. **Configure MCP:**
   - Copy or move ```mcp.json``` into the ```.vs``` folder if you want to keep configs separate.
   - Open ```mcp.json``` inside the ```.vs``` folder.
   - Start the MCP server:
     ```bash
     mcp-inspector
     
✏️ **Use with GitHub Copilot (example)**

After opening the project in VS Code and running the MCP server:

1. In VS Code, open the Copilot sidebar.
2. Select the agent you configured from your MCP server.
3. Enter a prompt, for example:
   > 💭 **Prompt:**  
   > `Schedule a meeting with xyz@gmail.com, abc@gmail.com for Generative AI from tomorrow 4 PM to 6 PM`
4. Ask for a login to generate the ```token.json``` for the first time only.

Copilot will use your agent and the MCP server to process the request and schedule the meeting.

---
