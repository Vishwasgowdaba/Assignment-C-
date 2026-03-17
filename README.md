# Employee Management System (C# Console Application)

## 📌 Overview

The **Employee Management System** is a simple C# console-based application that allows users to manage employee records. It supports both **Full-Time** and **Contract** employees and demonstrates core Object-Oriented Programming (OOP) concepts such as inheritance, polymorphism, and encapsulation.

---

## 🚀 Features

* ➕ Add Full-Time Employees
* ➕ Add Contract Employees
* 📋 View All Employees
* 🔍 Search Employees by Department
* 📊 Sort Employees by Salary (High to Low)
* ❌ Delete Employee by ID
* ⭐ Bonus Features:

  * Highest Paid Employee
  * Average Salary Calculation
  * Group Employees by Department

---

## 🧱 Technologies Used

* C#
* .NET (Console Application)
* LINQ (Language Integrated Query)

---

## 🧩 OOP Concepts Used

* **Inheritance**
  `FullTimeEmployee` and `ContractEmployee` inherit from `Employee`

* **Polymorphism**
  Method overriding of `CalculateSalary()` and `GetEmployeeType()`

* **Encapsulation**
  Use of properties (`get; set;`) instead of public fields

---

## 📂 Project Structure

```
EmployeeManagementSystem
│
├── Employee (Base Class)
├── FullTimeEmployee (Derived Class)
├── ContractEmployee (Derived Class)
└── Program (Main Application Logic)
```

---

## ▶️ How to Run

1. Open the project in Visual Studio or any C# IDE
2. Build the solution
3. Run the program
4. Use the menu options to interact with the system

---

## 📸 Sample Menu

```
===== Employee Management System =====
1. Add Full-Time Employee
2. Add Contract Employee
3. View All Employees
4. Search by Department
5. Sort by Salary (High → Low)
6. Delete Employee
7. Bonus Features
8. Exit
```

---

## 🧪 Example Operations

* Add employees with salary details
* View calculated salary based on employee type
* Search for employees in a specific department
* Analyze salary statistics

---

