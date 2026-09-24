# Playwright & NUnit Test Automation Portfolio

This repository contains functional automated web testing projects built from scratch using **C# Playwright** and **NUnit**. The main objective is to design clean page element maps and load test data dynamically from external configuration files.

## 📁 Repository Structure & Projects

### 1. Web Portal Automation (SauceDemo Project)
* **Design Pattern:** Built using the Page Object Model (POM) to keep web elements and test scenarios separate and clean.
* **Trace Viewer & Logs:** Automatically captures runtime screenshots, page snapshots, and zip logs using custom setup and teardown lifecycle hooks.
* **Cloud Execution File:** Contains a structured `azure-pipelines.yaml` configuration to trigger and execute tests on Azure DevOps cloud agents.

### 2. E-Commerce Filter Automation (Amazon India Project)
* **Data-Driven Processing:** Completely removed hardcoded strings from the code by reading search keys, product categories, and timeouts dynamically from external JSON sheets using `System.Text.Json`.
* **Dropdown Selection Automation:** Utilizes custom dual-parameter methods to select specific product departments from native select-boxes before triggering search keys.
* **Test Verification:** Validated live user search scenarios with 100% stable execution metrics.

## ⚡ Global Execution Optimization
* **Parallel Execution Engine:** Configured NUnit global assembly attributes to execute multiple test classes simultaneously over parallel worker threads to minimize local and cloud execution time.

## 🏃‍♂️ How to Run the Projects Locally
1. Clone this master repository to your local computer workspace.
2. Build the visual solution project files using the terminal:
   ```bash
   dotnet build
   ```
3. Execute the respective test suites using standard NUnit specialized filter tags:
   * For SauceDemo portal tests: `dotnet test --filter "SauceDemoTests"`
   * For Amazon filter tests: `dotnet test --filter "AmazonSearchTest"`
