# 📌 OOP Concepts Demo (.NET 10 Console App)

## 🚀 Overview
A console application demonstrating core OOP concepts: Inheritance, Polymorphism, and Abstraction using simple real-world examples.

## 🎯 Objective
- Understand OOP principles in C#
- Learn inheritance and access modifiers
- Observe polymorphism behavior
- Practice abstraction using encapsulation

## 🛠️ Tech Stack
- Language: C#
- Framework: .NET 10
- Type: Console Application

## 🧠 Concepts Covered
- Inheritance
- Method Overriding (Polymorphism)
- Encapsulation (Abstraction)
- Access Modifiers (private, protected)

---

## 🔷 Inheritance

### ⚙️ How It Works
1. `Sponsor` class contains protected field `owner`
2. `Team` inherits from `Sponsor`
3. Child class accesses protected member
4. `printInfo()` returns combined string

### 📌 Sample Output
<img width="1119" height="630" alt="image" src="https://github.com/user-attachments/assets/a7a2ee72-53a1-4cc7-8f50-6058765b15ec" />

---

## 🔷 Polymorphism

### ⚙️ How It Works
1. Base class `Bird` has method `Voice()`
2. Derived class `Duck` overrides `Voice()`
3. Method call depends on object type

### 📌 Sample Output
<img width="1113" height="626" alt="image" src="https://github.com/user-attachments/assets/b8b9da6e-07fc-40ad-ab49-a775b3e783a5" />

---

## 🔷 Abstraction

### ⚙️ How It Works
1. Private fields `brand` and `model`
2. Public properties to access them
3. Public method `LaptopDetails()` accessible
4. Private method `MotherBoardInfo()` not accessible outside class

### 📌 Sample Output
<img width="1113" height="624" alt="image" src="https://github.com/user-attachments/assets/fba936b1-8698-426d-98f2-d2cda9c387bc" />

---

## ▶️ How to Run
1. Clone the repository
2. Navigate to project folder
3. Run:
   ```bash
   dotnet run
