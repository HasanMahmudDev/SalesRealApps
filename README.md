# 🚀 Sales Real App

<p align="center">
  <img src="https://raw.githubusercontent.com/HasanMahmudDev/SalesRealApps/main/SalesRealApp/wwwroot/image/ProjectImage.png" alt="Project Preview" width="800"/>
</p>

# 🚀 Sales Real-Time App (.NET + SignalR)

## 📌 Overview
This project is a **real-time Sales Management System** built with:
- ASP.NET Core MVC
- Entity Framework Core
- SignalR (for live updates)
- Bootstrap 5 (UI)

It allows multiple users to:
- Add Sales
- Update Sales
- Delete Sales
- See changes instantly (real-time)

---

## 🎯 Why This Project?

### ✅ Real-time Experience
No page reload required. Data updates instantly using SignalR.

### ✅ Clean & Simple Architecture
Easy to understand for learning and scalable for real-world use.

### ✅ Beginner to Advanced Friendly
Perfect for:
- Learning .NET Core
- Understanding SignalR
- Building modern web apps

---

## ⚙️ Technologies Used

- .NET Core MVC
- Entity Framework Core
- SignalR
- SQL Server
- Bootstrap 5
- JavaScript (Fetch API)

---

## 📂 Project Structure

```
SalesRealApp/
│
├── Controllers/
│   └── SalesController.cs
│
├── Hubs/
│   └── SalesHub.cs
│
├── Models/
│   └── Sale.cs
│
├── Views/
│   └── Sales/
│       └── Index.cshtml
│
├── Data/
│   └── AppDbContext.cs
```

---

## 🛠️ How to Run the Project

### 1️⃣ Clone Project
```
git clone https://github.com/your-repo/sales-realtime-app.git
```

### 2️⃣ Open in Visual Studio

### 3️⃣ Configure Database
Update connection string in:
```
appsettings.json
```

### 4️⃣ Run Migration
```
Add-Migration InitialCreate
Update-Database
```

### 5️⃣ Run Project
Press **F5** or:
```
dotnet run
```

---

## 🔥 Features

- ➕ Add Sales
- ✏️ Edit Sales
- ❌ Delete Sales
- 📡 Real-time sync with SignalR
- 📱 Responsive UI

---

## 🧠 How It Works

1. User adds data from UI
2. Controller saves data in database
3. SignalR broadcasts event
4. All clients update instantly

---

## 💡 Future Improvements

- Authentication System
- Dashboard Analytics
- Pagination
- Search & Filter
- Export to Excel/PDF

---

## 🤝 Contribution

Feel free to fork and improve!

---

## 📧 Contact

Developed by: [Hasan Mahmud
](https://www.linkedin.com/in/hasanmahmuddev/)
