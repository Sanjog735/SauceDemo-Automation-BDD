# SauceDemo Automation Framework (BDD)

End-to-end UI automation framework for the SauceDemo application built using **Selenium WebDriver with C#**, **BDD with Reqnroll**, and **NUnit**.
The framework follows industry best practices such as **Page Object Model (POM)**, **BDD structure**, and **CI/CD integration using GitHub Actions**.

---

## 🚀 Tech Stack

* C#
* Selenium WebDriver
* Reqnroll (BDD)
* NUnit Test Framework
* .NET 8
* GitHub Actions (CI/CD)
* ExtentReports (Test Reporting)

---

## 📂 Project Structure

```
SauceDemo-Automation-BDD
│
├── SauceDemoAutomation
│   ├── Features              # BDD feature files
│   ├── StepDefinitions       # Step definition implementations
│   ├── Pages                 # Page Object Model classes
│   ├── Hooks                 # Setup and teardown logic
│   ├── Drivers               # WebDriver factory / driver management
│   ├── Config                # Configuration files
│   ├── Utilities             # Helper methods
│   ├── TestData              # Test data files
│   └── Reports               # Extent test reports
│
├── .github/workflows         # CI/CD pipeline configuration
│   └── dotnet-ci.yml
│
├── SauceDemoAutomation.sln
└── README.md
```


## ▶️ Running Tests Locally

1. Clone the repository

```
git clone https://github.com/Sanjog735/SauceDemo-Automation-BDD.git
```

2. Open the solution in Visual Studio

```
SauceDemoAutomation.sln
```

3. Restore dependencies

```
dotnet restore
```

4. Run tests

```
dotnet test
```

---

## ⚙️ CI/CD Integration

This project uses **GitHub Actions** for continuous integration.

Pipeline stages:

1. Checkout repository
2. Restore NuGet dependencies
3. Build project
4. Execute tests
5. Upload test reports

Workflow file location:

```
.github/workflows/dotnet-ci.yml
```

Whenever code is pushed to the **main branch**, the CI pipeline automatically runs.

---

## 📊 Test Reporting

The framework integrates **ExtentReports** for detailed test execution reports.

Reports are generated under:

```
SauceDemoAutomation/Reports/
```

In CI, reports are uploaded as **pipeline artifacts** for download.

---

## 🌐 Test Application

Tests are executed against the demo e-commerce application:

https://www.saucedemo.com

---

## 📌 Best Practices Used

* Page Object Model (POM)
* BDD with Gherkin syntax
* Config-driven framework
* Reusable WebDriver management
* CI/CD automation
* Clean project structure

---

## 👨‍💻 Author

**Sanjog Patel**
QA Automation Engineer

GitHub: https://github.com/Sanjog735

---
