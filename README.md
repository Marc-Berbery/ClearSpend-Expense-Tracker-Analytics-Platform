🎯 ClearSpend – Expense Tracker (ASP.NET Core MVC 8)

A modern, full-stack expense tracking web application built with ASP.NET Core MVC 8, Entity Framework Core, ASP.NET Identity, SendGrid email verification, Chart.js, and real-time currency conversion using the OpenExchangeRates API.

This project demonstrates clean architecture, secure authentication, role-based features, a functional dashboard, and premium extensions — ideal for real-world financial apps.

⭐ Features
🔐 Authentication & Security

Full ASP.NET Identity integration

Email verification using SendGrid

Secure login, logout, and registration

Password recovery & reset

User roles: StandardUser and PremiumUser

Role-based routing for premium features

💰 Expense Tracking

Add, edit, delete, and view transactions

Categorize expenses & income

Monthly & yearly summaries

Recent transactions table

Sorting and grouping

📊 Interactive Dashboard

Built with Chart.js and dynamic EF Core data:

Income vs Expenses bar chart

Spending by Category pie chart

Savings calculation

Time range filter (This Month, This Year)

Currency selector (USD, EUR, GBP, JPY, LBP)

🌍 Currency Conversion

Integrated with OpenExchangeRates API:

Converts each transaction dynamically

Dashboard updates instantly when switching currencies

Supports multi-currency operations

⭐ Premium Features

Accessible only to PremiumUser role.

📈 Advanced Analytics

Top spending categories per month

Monthly breakdown

Financial behavior insights

🧮 Budget Planner

Set a monthly budget

Track expenses against your target

Color-coded progress bar (green = under, red = over)

📥 Excel Export

Export all transactions to .xlsx using EPPlus

Includes category, type, date, and amount

🧱 Tech Stack
Backend

ASP.NET Core MVC 8

Entity Framework Core

ASP.NET Identity

Dependency Injection

OpenExchangeRates API

SendGrid Email Service

SQL Server

Frontend

Bootstrap 5

Chart.js

Razor Views


