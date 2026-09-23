# SauceDemo Data-Driven Automation Framework

This project contains a data-driven web automation framework built from scratch using **C#** **Playwright** and **NUnit**. It implements structural configurations to handle multiple user profiles natively via configuration layers.

## 🛠️ Key Technical Features
* **Page Object Model (POM):** Decent structural isolation between web locators and test workflows.
* **Dynamic Data Parsing:** Core JSON utilities (`System.Text.Json`) to load user authentication data cleanly from external sheets.
* **Custom Execution Hooks:** Inherited base framework architecture (`BaseTest`) managing isolated browser tabs, screenshot lifecycles, and Trace Viewer reporting.
* **Parallel Execution Engine:** Global assembly configuration running multi-threaded test scenarios simultaneously to save execution time.
* **CI/CD Configuration Ready:** Custom pipeline setup (`azure-pipelines.yaml`) ready to execute tests smoothly on cloud environments.

## 📁 Framework Structure Quick View
* `Data/` - Dynamic database parameters (.json profiles) and tracking model classes.
* `Utils/` - Custom directory path readers and synchronous file stream converters.
* `Pages/` - UI web elements mapping logic.
* `Tests/` - Execution test classes inherited securely from BaseTest configuration.

## 🏃‍♂️ How to Run Locally
1. Clone the project repository to your workspace.
2. Open the terminal inside the root directory and build the workspace:
   ```bash
   dotnet build
   ```
3. Run the automated regression test suite using the NUnit filter tag:
   ```bash
   dotnet test --filter "SauceDemoTests"
   ```
