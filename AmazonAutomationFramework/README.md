# Amazon India Data-Driven Automation Framework

This project contains a functional data-driven web automation framework designed using **C# Playwright** and **NUnit** for Amazon India. It focuses on object repositories separation and clean data injection pipelines to handle multi-row retail workflows natively.

## 🛠️ Key Technical Features
* **Page Object Model (POM):** Decent structural isolation separating web element locators and synchronous page click actions.
* **Dynamic Data Extraction:** Built-in JSON reader utility mapping search keys, dynamic execution timeouts, and categories from external configuration profiles sheet using `System.Text.Json`.
* **Dynamic Dropdown Automation:** Custom dual-parameter signatures utilizing Playwright's native selection mechanisms to automate native select-box departments before executing search commands.
* **Parallel Execution Engine:** Global assembly optimization tags allowing NUnit to manage simultaneous test workflows over multiple threads efficiently.
* **CI/CD Integration Pipeline:** Contains a structured execution pipeline file (`azure-pipelines.yaml`) pre-configured for automated remote cloud agent test triggers.

## 📁 Framework Structure Quick View
* `Data/` - Contains external JSON sheets and template validation data models.
* `Pages/` - UI elements identification logic and reusable action methods.
* `Tests/` - NUnit execution suites parameterizing dynamic dataset streams securely via yield returns.
* `Utils/` - Shared file system infrastructure path combiners and directory monitors.

## 🏃‍♂️ How to Run Locally
1. Clone this framework repository to your local workspace workspace directory.
2. Open the command terminal inside the root directory and compile the solutions project build:
   ```bash
   dotnet build
   ```
3. Run the automated data-driven suite using the specialized filter tag:
   ```bash
   dotnet test --filter "AmazonSearchTest"
   ```
